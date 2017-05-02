﻿using Goedel.Utilities;
using Goedel.Mesh;
using Goedel.Mesh.Platform;

namespace Goedel.Mesh.MeshMan {

    public partial class Shell {
        /// Create a new web application profile.
        /// </summary>
        /// <param name="Options">Command line parameters</param>
        public override void Password(Password Options) {
            //SetReporting(Options.Report, Options.Verbose);
            //GetProfile(Options.Portal, Options.UDF);
            //GetMeshClient();

            //var SignedDeviceProfile = GetDevice(SignedPersonalProfile);
            //Assert.NotNull(SignedDeviceProfile, NoDeviceProfile.Throw);

            //var PersonalProfile = SignedPersonalProfile.PersonalProfile;

            //var PasswordProfile = new PasswordProfile(true);

            //var ApplicationProfileEntry = PersonalProfile.Add(PasswordProfile);
            //ApplicationProfileEntry.AddDevice(SignedDeviceProfile.DeviceProfile);

            //PasswordProfile.Link(PersonalProfile, ApplicationProfileEntry);

            //var SignedPasswordProfile = PasswordProfile.SignedApplicationProfile;

            //Machine.Add(SignedPasswordProfile);
            //RegistrationPersonal.WriteToPortal();

            //MeshClient.Publish(SignedPasswordProfile);
            //MeshClient.Publish(RegistrationPersonal.SignedPersonalProfile);

            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Options">Command line parameters</param>
        public override void DumpPassword(DumpPassword Options) {
            SetReporting(Options.Report, Options.Verbose);
            GetProfile(Options.Portal, Options.UDF);
            GetMeshClient();

            GetPasswordProfile();

            if (PasswordProfilePrivate.Entries == null) {
                Report("Empty");
                }
            else {
                foreach (var Entry in PasswordProfilePrivate.Entries) {
                    Report("Sites: ", Entry.Sites);
                    Report("    Username: {0} Password {1}", Entry.Username, Entry.Password);
                    }
                }

            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Options">Command line parameters</param>
        public override void AddPassword(AddPassword Options) {
            SetReporting(Options.Report, Options.Verbose);
            GetProfile(Options.Portal, Options.UDF);
            GetMeshClient();
            GetPasswordProfile();

            PasswordProfile.Add(Options.Site.Value, Options.Username.Value,
                Options.Password.Value);

            UpdatePasswordProfile();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Options">Command line parameters</param>
        public override void GetPassword(GetPassword Options) {
            SetReporting(Options.Report, Options.Verbose);
            GetProfile(Options.Portal, Options.UDF);
            GetMeshClient();
            GetPasswordProfile();

            var Entry = PasswordProfile.Get(Options.Site.Value);

            Report("Username {0} Password {1}", Entry.Username, Entry.Password);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Options">Command line parameters</param>
        public override void DeletePassword(DeletePassword Options) {
            SetReporting(Options.Report, Options.Verbose);
            GetProfile(Options.Portal, Options.UDF);
            GetMeshClient();
            GetPasswordProfile();

            PasswordProfile.Delete(Options.Site.Value);

            UpdatePasswordProfile();
            }
        }

    }
