﻿using System;
using System.Collections.Generic;
using System.Text;
using Goedel.Protocol;

namespace Goedel.Cryptography.Jose {

    public partial class Jose {

        // Algorithm parameters

        //"HS256",	"http://www.w3.org/2001/04/xmldsig-more#hmac-sha256",	    "HmacSHA256",	        "1.2.840.113549.2.9"
        //"HS384",	"http://www.w3.org/2001/04/xmldsig-more#hmac-sha384",	    "HmacSHA384",	        "1.2.840.113549.2.10"
        //"HS512",	"http://www.w3.org/2001/04/xmldsig-more#hmac-sha512",	    "HmacSHA512",	        "1.2.840.113549.2.11"
        //"RS256",	"http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",	    "SHA256withRSA",	    "1.2.840.113549.1.1.11"
        //"RS384",	"http://www.w3.org/2001/04/xmldsig-more#rsa-sha384",	    "SHA384withRSA",	    "1.2.840.113549.1.1.12"
        //"RS512",	"http://www.w3.org/2001/04/xmldsig-more#rsa-sha512",	    "SHA512withRSA",	    "1.2.840.113549.1.1.13"
        //"ES256",	"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256",	    "SHA256withECDSA",	    "1.2.840.10045.4.3.2"
        //"ES384",	"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384",	    "SHA384withECDSA",	    "1.2.840.10045.4.3.3"
        //"ES512",	"http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512",	    "SHA512withECDSA",	    "1.2.840.10045.4.3.4"
        //"PS256",	"http://www.w3.org/2007/05/xmldsig-more#sha256-rsa-MGF1",	"SHA256withRSAandMGF1",	"1.2.840.113549.1.1.10"
        //"PS384",	"http://www.w3.org/2007/05/xmldsig-more#sha384-rsa-MGF1",	"SHA384withRSAandMGF1",	"1.2.840.113549.1.1.10"
        //"PS512",	"http://www.w3.org/2007/05/xmldsig-more#sha512-rsa-MGF1",	"SHA512withRSAandMGF1",	"1.2.840.113549.1.1.10"

        // Content encryption modes

        //"A128CBC-HS256",	"	http://www.w3.org/2001/04/xmlenc#aes128-cbc",	"	AES/CBC/PKCS5Padding",	"	2.16.840.1.101.3.4.1.2
        //"A192CBC-HS384",	"	http://www.w3.org/2001/04/xmlenc#aes192-cbc",	"	AES/CBC/PKCS5Padding",	"	2.16.840.1.101.3.4.1.22
        //"A256CBC-HS512",	"	http://www.w3.org/2001/04/xmlenc#aes256-cbc",	"	AES/CBC/PKCS5Padding",	"	2.16.840.1.101.3.4.1.42
        //"A128GCM",	"	http://www.w3.org/2009/xmlenc11#aes128-gcm",	"	AES/GCM/NoPadding",	"	2.16.840.1.101.3.4.1.6
        //"A192GCM",	"	http://www.w3.org/2009/xmlenc11#aes192-gcm",	"	AES/GCM/NoPadding",	"	2.16.840.1.101.3.4.1.26
        //"A256GCM",	"	http://www.w3.org/2009/xmlenc11#aes256-gcm",	"	AES/GCM/NoPadding",	"	2.16.840.1.101.3.4.1.46


        // Key wrapping modes


        public byte[] ToJson() {
            var JSONWriter = new JSONWriter();
            Serialize(JSONWriter);
            return JSONWriter.GetBytes;
            }

        public byte[] ToJsonB() {
            var JSONWriter = new JSONBWriter();
            Serialize(JSONWriter);
            return JSONWriter.GetBytes;
            }

        public byte[] ToJsonC(Dictionary<string, int> Dict) {
            var JSONWriter = new JSONCWriter(Dict);
            Serialize(JSONWriter);
            return JSONWriter.GetBytes;
            }
        }

    }