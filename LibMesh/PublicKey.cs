﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Goedel.Registry;
using Goedel.LibCrypto;
using Goedel.LibCrypto.PKIX;
using Goedel.Debug;
using Goedel.Cryptography.Jose;

namespace Goedel.Mesh {

    /// <summary>
    /// Mesh Key types
    /// </summary>
    public enum KeyType {
        /// <summary>
        /// Personal Master Key
        /// </summary>
        PMSK,

        /// <summary>
        /// Personal Master Escrow Key
        /// </summary>
        PMEK,

        /// <summary>
        /// Personal Master Online Signing Key
        /// </summary>
        POSK,

        /// <summary>
        /// Device Signing Key 
        /// </summary>
        DSK,

        /// <summary>
        /// Device authentication key 
        /// </summary>
        DAK,

        /// <summary>
        /// Device Encryption Key
        /// </summary>
        DEK,

        /// <summary>
        /// Application Signing Key
        /// </summary>
        ASK,

        /// <summary>
        /// Application Authentication Key
        /// </summary>
        AAK,

        /// <summary>
        /// Application Encryption Key
        /// </summary>
        AEK,

        /// <summary>
        /// Unspecified.
        /// </summary>
        Unknown
        }


    public partial class PublicKey {
        /// <summary>
        /// Return the initial key security level for a key type
        /// </summary>
        /// <param name="KeyType">Type of key</param>
        /// <returns>Initial security level</returns>
        public static KeySecurity GetKeySecurity(KeyType KeyType) {
            switch (KeyType) {
                case KeyType.DSK:
                case KeyType.DEK:
                case KeyType.DAK: {
                    return KeySecurity.Device;
                    }
                case KeyType.ASK:
                case KeyType.AEK:
                case KeyType.AAK:
                    {
                    return KeySecurity.Exportable;
                    }
                case KeyType.PMSK:
                case KeyType.POSK:
                case KeyType.PMEK: {
                    return KeySecurity.Master;
                    }
                }
            return KeySecurity.Ephemeral;
            }

        //public List<Certificate> Chain;

        /// <summary>
        /// The cryptolib representation of the Key Pair. This is the point of access
        /// for all cryptolib operations. 
        /// </summary>
        protected KeyPair _KeyPair;

        /// <summary>
        /// The cryptolib representation of the Key Pair. This is the point of access
        /// for all cryptolib operations. 
        /// </summary>
        public virtual KeyPair KeyPair {
            get {
                if (_KeyPair == null) {
                    _KeyPair = GetKeyPair();
                    }

                return _KeyPair;
                }
            set {
                _KeyPair = value;
                UDF = KeyPair.UDF;
                }
            }



        /// <summary>
        /// Accessor mechanism for the private key portion
        /// </summary>
        public virtual KeyPair PrivateKey {
            get {
                _KeyPair.GetPrivate();
                return _KeyPair;
                }
            }


        private KeyType _KeyType = KeyType.Unknown;

        /// <summary>
        /// The type of key
        /// </summary>
        public KeyType KeyType {
            get { return _KeyType; }
            set { _KeyType = value; }
            }

        private Certificate _Certificate;

        /// <summary>
        /// The PKIC Certificate for the key (if it exists)
        /// </summary>
        public Certificate Certificate {
            get { return _Certificate; }
            set {
                _Certificate = value;
                if (_Certificate.Data != null) {
                    X509Certificate = _Certificate.Data;
                    }
                KeyPair = Certificate.KeyPair;
                }
            }

        /// <summary>
        /// Unpack that the public key parameters match the UDF fingerprint.
        /// </summary>
        /// <returns>true if the verification succeeds, false otherwise.</returns>

        public bool Verify() {
            return Verify(UDF);
            }

        /// <summary>
        /// Verify the keypair parameters match the fingerprint.
        /// </summary>
        /// <param name="TestUDF">The fingerprint value.</param>
        /// <returns>true if the verification succeeds, false otherwise.</returns>
        public bool Verify (string TestUDF) { 
            var KeyPair = GetKeyPair();
            if (KeyPair.UDF == TestUDF) {
                _KeyPair = KeyPair;
                return true;
                }

            return false;
            }


        private KeyPair GetKeyPair () {
            if (PublicParameters != null) {
                return PublicParameters.GetKeyPair();
                }


            return null;
            }
 


        /// <summary>
        /// Generate a new key pair and return a PublicKey object for the public 
        /// parameters.
        /// </summary>
        /// <param name="KeyType">The mest key type.</param>
        /// <param name="CryptoAlgorithmID">The algorithm to generate keys for.</param>
        /// <returns></returns>
        public static PublicKey Generate(KeyType KeyType, CryptoAlgorithmID CryptoAlgorithmID) {

            var CryptoProvider = CryptoCatalog.Default.GetAsymmetric(CryptoAlgorithmID);
            CryptoProvider.Generate(GetKeySecurity(KeyType));
            var KeyPair = CryptoProvider.KeyPair;

            var PublicKey = new PublicKey();
            PublicKey.KeyPair = KeyPair;
            

            if (KeyPair.GetType() == typeof(RSAKeyPair)) {
                PublicKey.PublicParameters = new PublicKeyRSA(KeyPair as RSAKeyPair);
                return PublicKey;
               }

            throw new Exception("Not found");
            }

        /// <summary>
        /// Create a self signed root certificate
        /// </summary>
        /// <param name="PKIXUse">Bit mask specifying certificate uses.</param>
        public void SelfSignCertificate(Application PKIXUse) {
            Certificate = new Certificate(_KeyPair, PKIXUse, null);
            }

        /// <summary>
        /// Create an application or intermediary certificate
        /// </summary>
        /// <param name="PKIXUse">Bit mask specifying certificate uses.</param>
        /// <param name="Signer">The signing key (which must have an attached certificate).</param>
        public void SignCertificate(Application PKIXUse, PublicKey Signer) {
            Certificate = new Certificate(_KeyPair, PKIXUse, Signer.Certificate);
            }

        /// <summary>
        /// Create an application certificate with the specified SubjectAltName.
        /// </summary>
        /// <param name="PKIXUse">Bit mask specifying certificate uses.</param>
        /// <param name="SubjectAltName">The subjectAltName. Must be a DNS domain name
        /// or a RFC822 email address.</param>
        /// <param name="Signer">The signing key (which must have an attached certificate).</param>
        public void SignCertificate(Application PKIXUse, string SubjectAltName, PublicKey Signer) {
            Certificate = new Certificate(_KeyPair, PKIXUse, SubjectAltName, SubjectAltName);
            Certificate.Sign(Signer.Certificate);
            }


        }

    }
