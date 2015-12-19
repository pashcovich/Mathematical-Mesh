﻿using System;
using System.Collections.Generic;
using Goedel.Registry;
using Goedel.Persistence;
using Goedel.LibCrypto;
using Goedel.LibCrypto.PKIX;

namespace Goedel.Mesh {



    /// <summary>
    /// The Mesh Mail Profile
    /// </summary>
    public partial class MailProfile : ApplicationProfile {

        private MailProfilePrivate _Private;

        /// <summary>
        /// The portion of the profile that is encrypted in the mesh.
        /// </summary>

        public MailProfilePrivate Private {
            get {
                if (_Private == null) {
                    _Private = MailProfilePrivate.FromTagged(DecryptPrivate());
                    }
                return _Private;
                }
            }

        /// <summary>
        /// Returns the private profile as a block of JSON encoded bytes ready for
        /// encryption.
        /// </summary>
        protected override byte[] GetPrivateData {
            get { return Private.GetBytes(); }
            }


        /// <summary>
        /// Construct a MailProfile from the specified account information.
        /// </summary>
        /// <param name="UserProfile">The personal profile to attach this profile to.</param>
        /// <param name="MailAccountInfo">Description of the mail account.</param>
        public MailProfile(PersonalProfile UserProfile, MailAccountInfo MailAccountInfo)
            : base(UserProfile, "MailProfile", MailAccountInfo.AccountName) {
            _Private = new MailProfilePrivate(MailAccountInfo);
            }


        /// <summary>
        /// Construct an empty MailProfile for the specified account.
        /// </summary>
        /// <param name="UserProfile">The Personal Profile to link the MailProfile to.</param>
        /// <param name="Account">The mail account name.</param>
        public MailProfile(PersonalProfile UserProfile, string Account)
            : base(UserProfile, "MailProfile", Account) {
            //_Private = new MailProfilePrivate(Account);
            }

        /// <summary>
        /// Get the default mail profile from the specified personal profile.
        /// </summary>
        /// <param name="UserProfile">The user profile</param>
        /// <returns>The default mail profile.</returns>
        public static MailProfile Get(PersonalProfile UserProfile) {
            //return UserProfile.GetApplication(typeof(MailProfile)) as MailProfile;
            return null;
            }

        /// <summary>
        /// Export the profile parameters to the specified MailAccountInfo
        /// structure. 
        /// </summary>
        /// <param name="MailAccountInfo">The object to copy parameters to. 
        /// This object must already exist. Any prepopulated elements that 
        /// are present will be overwritten.</param>
        /// <example>
        /// The typical way the Export method is used is to create a MailAccountInfo
        /// entry for a specific client by creating an object of the class for the 
        /// application in question and passing it to the Export method.
        /// </example>
        public void Export (MailAccountInfo MailAccountInfo) {
            MailAccountInfo.EmailAddress = Private.EmailAddress;
            MailAccountInfo.ReplyToAddress = Private.ReplyToAddress;
            MailAccountInfo.DisplayName = Private.DisplayName;
            MailAccountInfo.AccountName = Private.AccountName;
            MailAccountInfo.Inbound = Private.Inbound;
            MailAccountInfo.Outbound = Private.Outbound;
            MailAccountInfo.Sign = Private.Sign;
            MailAccountInfo.Encrypt = Private.Encrypt;
            }


        }

    public partial class MailProfilePrivate {

        /// <summary>
        /// Construct a MailProfile object from a MailAccountInfo object.
        /// </summary>
        /// <param name="MailAccountInfo"></param>
        public MailProfilePrivate(MailAccountInfo MailAccountInfo) {
            EmailAddress = MailAccountInfo.EmailAddress;
            ReplyToAddress = MailAccountInfo.ReplyToAddress;
            DisplayName = MailAccountInfo.DisplayName;
            AccountName = MailAccountInfo.AccountName;
            Inbound = MailAccountInfo.Inbound;
            Outbound = MailAccountInfo.Outbound;
            Sign = MailAccountInfo.Sign;
            foreach (var Key in Sign) {
                Key.ExportPrivateParameters();
                }
            Encrypt = MailAccountInfo.Encrypt;
            foreach (var Key in Encrypt) {
                Key.ExportPrivateParameters();
                }
            }



        }

    }
