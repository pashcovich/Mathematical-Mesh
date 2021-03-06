﻿
//This file was generated automatically.

using System;
using System.Collections.Generic;
using Goedel.Registry;
using Goedel.Trojan;


namespace PHB.Apps.Mesh.ProfileManager {

	// Make extensible partial classes for all the toplevel classes
	// This allows an implementation to decorate any class at will.
	public abstract partial class Object:  Goedel.Trojan.Object {
		}
	public abstract partial class Menu:  Goedel.Trojan.Menu {
		}
	public abstract partial class Window:  Goedel.Trojan.Window {
		}


	/// <summary>
    /// The application data model. This inherits the field declarations and
	/// stub callback methods from the template. The stub callbacks should be
	/// overwritten by the user's code. 
    /// </summary>
	public partial class ProfileManager : _ProfileManager {
		}

	/// <summary>
    /// The template data model  constructed from the specification.
	/// Contains stub methods for each callback.
    /// </summary>
	public abstract class _ProfileManager : Goedel.Trojan.Model {

        /// <summary>
        /// Default constructor.
        /// </summary>
        public _ProfileManager() {
            _About = new About(this) {
				Name = "Mesh Profile Manager"
				};
            }




        /// <summary>
        ///Stub method for ProfileCreatecommand.Override with application implementation.
        /// </summary>
 		public virtual void ProfileCreate () {
			}

        /// <summary>
        ///Stub method for ProfileEscrowcommand.Override with application implementation.
        /// </summary>
 		public virtual void ProfileEscrow (Object Object ) {
			}

        /// <summary>
        ///Stub method for Aboutcommand.Override with application implementation.
        /// </summary>
 		public virtual void About () {
			}

        /// <summary>
        ///Stub method for Quitcommand.Override with application implementation.
        /// </summary>
 		public virtual void Quit () {
			}

        /// <summary>
        ///Stub method for Printcommand.Override with application implementation.
        /// </summary>
 		public virtual void Print (Object Object ) {
			}

        /// <summary>
        ///Stub method for ConnectRefreshcommand.Override with application implementation.
        /// </summary>
 		public virtual void ConnectRefresh () {
			}

        /// <summary>
        ///Stub method for ConnectAcceptcommand.Override with application implementation.
        /// </summary>
 		public virtual void ConnectAccept (Object Object ) {
			}

        /// <summary>
        ///Stub method for ConnectRejectcommand.Override with application implementation.
        /// </summary>
 		public virtual void ConnectReject (Object Object ) {
			}

        /// <summary>
        ///Stub method for ConnectGetOTCcommand.Override with application implementation.
        /// </summary>
 		public virtual void ConnectGetOTC () {
			}

        /// <summary>
        ///Stub method for DeviceDeletecommand.Override with application implementation.
        /// </summary>
 		public virtual void DeviceDelete (Object Object ) {
			}

        /// <summary>
        ///Stub method for DeviceRefreshKeyscommand.Override with application implementation.
        /// </summary>
 		public virtual void DeviceRefreshKeys (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationAddWizardcommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationAddWizard (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationAddMailcommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationAddMail (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationAddSSHcommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationAddSSH (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationAddWiFicommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationAddWiFi (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationAddWebcommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationAddWeb (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationDeletecommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationDelete (Object Object ) {
			}

        /// <summary>
        ///Stub method for ApplicationRefreshKeyscommand.Override with application implementation.
        /// </summary>
 		public virtual void ApplicationRefreshKeys (Object Object ) {
			}

        /// <summary>
        ///Stub method for AdministratorAddcommand.Override with application implementation.
        /// </summary>
 		public virtual void AdministratorAdd (Object Object ) {
			}

        /// <summary>
        ///Stub method for AdministratorRemovecommand.Override with application implementation.
        /// </summary>
 		public virtual void AdministratorRemove (Object Object ) {
			}

        /// <summary>
        ///Stub method for KeyRefreshcommand.Override with application implementation.
        /// </summary>
 		public virtual void KeyRefresh () {
			}

        /// <summary>
        ///Stub method for KeyDeletecommand.Override with application implementation.
        /// </summary>
 		public virtual void KeyDelete () {
			}

        /// <summary>
        ///Stub method for ViewPendingRequestscommand.Override with application implementation.
        /// </summary>
 		public virtual void ViewPendingRequests () {
			}

        /// <summary>
        ///Stub method for ViewPendingApplicationscommand.Override with application implementation.
        /// </summary>
 		public virtual void ViewPendingApplications () {
			}

        /// <summary>
        ///Stub method for ViewPendingDevicescommand.Override with application implementation.
        /// </summary>
 		public virtual void ViewPendingDevices () {
			}




        /// <summary>
        ///Dispatch command callback with required parameters.
        /// </summary>
         public override void  Dispatch(string Command) {
            switch (Command) {
                case "ProfileCreate": {
                        ProfileCreate();
                        return;
                        }
                case "ProfileEscrow": {
                        ProfileEscrow(Selected as Object);
                        return;
                        }
                case "About": {
                        About();
                        return;
                        }
                case "Quit": {
                        Quit();
                        return;
                        }
                case "Print": {
                        Print(Selected as Object);
                        return;
                        }
                case "ConnectRefresh": {
                        ConnectRefresh();
                        return;
                        }
                case "ConnectAccept": {
                        ConnectAccept(Selected as Object);
                        return;
                        }
                case "ConnectReject": {
                        ConnectReject(Selected as Object);
                        return;
                        }
                case "ConnectGetOTC": {
                        ConnectGetOTC();
                        return;
                        }
                case "DeviceDelete": {
                        DeviceDelete(Selected as Object);
                        return;
                        }
                case "DeviceRefreshKeys": {
                        DeviceRefreshKeys(Selected as Object);
                        return;
                        }
                case "ApplicationAddWizard": {
                        ApplicationAddWizard(Selected as Object);
                        return;
                        }
                case "ApplicationAddMail": {
                        ApplicationAddMail(Selected as Object);
                        return;
                        }
                case "ApplicationAddSSH": {
                        ApplicationAddSSH(Selected as Object);
                        return;
                        }
                case "ApplicationAddWiFi": {
                        ApplicationAddWiFi(Selected as Object);
                        return;
                        }
                case "ApplicationAddWeb": {
                        ApplicationAddWeb(Selected as Object);
                        return;
                        }
                case "ApplicationDelete": {
                        ApplicationDelete(Selected as Object);
                        return;
                        }
                case "ApplicationRefreshKeys": {
                        ApplicationRefreshKeys(Selected as Object);
                        return;
                        }
                case "AdministratorAdd": {
                        AdministratorAdd(Selected as Object);
                        return;
                        }
                case "AdministratorRemove": {
                        AdministratorRemove(Selected as Object);
                        return;
                        }
                case "KeyRefresh": {
                        KeyRefresh();
                        return;
                        }
                case "KeyDelete": {
                        KeyDelete();
                        return;
                        }
                case "ViewPendingRequests": {
                        ViewPendingRequests();
                        return;
                        }
                case "ViewPendingApplications": {
                        ViewPendingApplications();
                        return;
                        }
                case "ViewPendingDevices": {
                        ViewPendingDevices();
                        return;
                        }
                }
            }

		}


	// Windows

	/*
	* Window declarations
	*/
        /// <summary>
        ///TBS
        /// </summary>
 	public partial class MainWindow : _MainWindow {

		string _Title = "Mesh Profile Manager";
		public override string Title {
			get {return _Title;}
			set {_Title = value;}
			}

		public MainWindow  (Goedel.Trojan.Model Model, Binding Binding) {
			// Call backing code to populate the data model
			Populate ();

			// Initialize the view and controller
			Initialize (Model, Binding);
			}
		}

	public abstract class _MainWindow : Window {

		Menu _Menu = new MenuTop ();
        public override Goedel.Trojan.Menu Menu { get { return _Menu; } }
		}

	/*
	* Menu declarations
	*/

        /// <summary>
        ///TBS
        /// </summary>
 	public partial class MenuTop : Menu {
	
		public override List<MenuEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<MenuEntry> _Entries = new List<MenuEntry> {
			new SubMenu () {
				Id ="MenuProfile",  
				Label = "Master", 
				Sub = new MenuProfile() },
			new SubMenu () {
				Id ="MenuDevice",  
				Label = "Device", 
				Sub = new MenuDevice() },
			new SubMenu () {
				Id ="MenuApplication",  
				Label = "Application", 
				Sub = new MenuApplication() }};
		}



        /// <summary>
        ///TBS
        /// </summary>
 	public partial class MenuProfile : Menu {
	
		public override List<MenuEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<MenuEntry> _Entries = new List<MenuEntry> {
			new MenuEntry () { 
				Id ="ProfileCreate",  
				Label = "Create New Master Profile" },
			new MenuEntry () { 
				Id ="ProfileEscrow",  
				Label = "Create escrow key set" },
			new MenuDivider () ,
			new MenuEntry () { 
				Id ="Print",  
				Label = "Print" },
			new MenuEntry () { 
				Id ="About",  
				Label = "About" },
			new MenuEntry () { 
				Id ="Quit",  
				Label = "Quit" }};
		}



        /// <summary>
        ///TBS
        /// </summary>
 	public partial class MenuDevice : Menu {
	
		public override List<MenuEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<MenuEntry> _Entries = new List<MenuEntry> {
			new MenuEntry () { 
				Id ="ConnectRefresh",  
				Label = "Get Pending Requests" },
			new MenuEntry () { 
				Id ="ConnectAccept",  
				Label = "Accept Connection" },
			new MenuEntry () { 
				Id ="ConnectReject",  
				Label = "Reject Connection" },
			new MenuEntry () { 
				Id ="ConnectGetOTC",  
				Label = "Issue One Time Code" },
			new MenuEntry () { 
				Id ="DeviceDelete",  
				Label = "Delete Device" },
			new MenuDivider () ,
			new SubMenu () {
				Id ="Administrator",  
				Label = "Administrator", 
				Sub = new Administrator() },
			new MenuDivider () ,
			new MenuEntry () { 
				Id ="DeviceRefreshKeys",  
				Label = "Refresh Keys" }};
		}



        /// <summary>
        ///TBS
        /// </summary>
 	public partial class Administrator : Menu {
	
		public override List<MenuEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<MenuEntry> _Entries = new List<MenuEntry> {
			new MenuEntry () { 
				Id ="AdministratorAdd",  
				Label = "Grant Administrator" },
			new MenuEntry () { 
				Id ="AdministratorRemove",  
				Label = "Remove Administrator" }};
		}



        /// <summary>
        ///TBS
        /// </summary>
 	public partial class MenuApplication : Menu {
	
		public override List<MenuEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<MenuEntry> _Entries = new List<MenuEntry> {
			new SubMenu () {
				Id ="ApplicationAdd",  
				Label = "Add Application", 
				Sub = new ApplicationAdd() },
			new MenuEntry () { 
				Id ="ApplicationDelete",  
				Label = "Delete Application" },
			new MenuEntry () { 
				Id ="ApplicationRefreshKeys",  
				Label = "Refresh Keys" }};
		}



        /// <summary>
        ///TBS
        /// </summary>
 	public partial class ApplicationAdd : Menu {
	
		public override List<MenuEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<MenuEntry> _Entries = new List<MenuEntry> {
			new MenuEntry () { 
				Id ="ApplicationAddMail",  
				Label = "Add Mail" },
			new MenuEntry () { 
				Id ="ApplicationAddSSH",  
				Label = "Add SSH" },
			new MenuEntry () { 
				Id ="ApplicationAddWiFi",  
				Label = "Add WiFi Network" },
			new MenuEntry () { 
				Id ="ApplicationAddWeb",  
				Label = "Add Web Password Manager" }};
		}



	/*
	* Wizard declarations
	*/


	/// <summary>
    /// Wizard callback class.
    /// </summary>

	public partial class WizardCreateProfile : _WizardCreateProfile {
		}


	/// <summary>
    /// Template class for wizard. The application programmer implements
	/// the wizard by overriding wizard methods. Note that since the user 
	/// may backtrack when implementing a method, callbacks MUST tolerate
	/// being called multiple times. It is also permitted for a user to 
	/// cancel a wizard before the final commit.
    /// </summary>
	public partial class _WizardCreateProfile : Wizard {

        public override string Title => "Create a New Mesh Profile";
        public override List<string> Texts => _Texts;
        public override List<Step> Steps => _Steps;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="Model">Model to bind to</param>
        public _WizardCreateProfile(Model Model) : base(Model) {
            }


		/// <summary>
        /// NameDevice
        /// </summary>
		public NameDevice NameDevice {
			get {
				return (NameDevice) Steps[0].Value;
				}

			}
			
		/// <summary>
        /// CreateProfile
        /// </summary>
		public CreateProfile CreateProfile {
			get {
				return (CreateProfile) Steps[1].Value;
				}

			}
			
		/// <summary>
        /// SelectApplications
        /// </summary>
		public SelectApplications SelectApplications {
			get {
				return (SelectApplications) Steps[2].Value;
				}

			}
			
		/// <summary>
        /// Review
        /// </summary>
		public Review Review {
			get {
				return (Review) Steps[3].Value;
				}

			}
			
		/// <summary>
        /// CommitWizardCreateProfile
        /// </summary>
		public CommitWizardCreateProfile CommitWizardCreateProfile {
			get {
				return (CommitWizardCreateProfile) Steps[4].Value;
				}

			}
			

		// WizardCreateProfile
		List<string> _Texts = 		new List<string> {
			"This wizard will guide you through the process of setting up a new mesh profile and configuring it for use with your applications." ,
			"To create a Mesh profile you will need to know the address of the portal where the profile is to be registered and provide a name for the profile at that portal." ,
			"Unlike an email account, a Mesh profile belongs to you and only you. You can always change the portal registration  for your profile at a later date." 
			};
		List<Step> _Steps = new List<Step> {
			new Step () {Value = new NameDevice (), 
				Title = "Name this Device", Description =
				new List<string> {
					}},
			new Step () {Value = new CreateProfile (), 
				Title = "Create Profile", Description =
				new List<string> {
					}},
			new Step () {Value = new SelectApplications (), 
				Title = "Select Applications", Description =
				new List<string> {
					}},
			new Step () {Value = new Review (), 
				Title = "Review", Description =
				new List<string> {
					}},
			new Step () {Value = new CommitWizardCreateProfile (), 
				Title = "Finish", Description =
				new List<string> {
					}}};


		public override bool Dispatch (int Step) {

			switch (Step) {
				case 0 : return NameDevice.Dispatch(this);
				case 1 : return CreateProfile.Dispatch(this);
				case 2 : return SelectApplications.Dispatch(this);
				case 3 : return Review.Dispatch(this);
				case 4 : return CommitWizardCreateProfile.Dispatch(this);
				}
			return false;
			}

		}



	/*
	* Backing object class declarations
	*/
	public partial class Message : Object {

		/// <summary>
        /// Issued
        /// </summary>
		public ObjectFieldDateTime Issued {
			get {
				return ((ObjectFieldDateTime)Entries[0]);
				}

			}
			
		/// <summary>
        /// Expires
        /// </summary>
		public ObjectFieldDateTime Expires {
			get {
				return ((ObjectFieldDateTime)Entries[1]);
				}

			}
			
		/// <summary>
        /// Status
        /// </summary>
		public ObjectFieldString Status {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldDateTime {Id = "Issued", 
						Label = "Sent" // ((ObjectFieldDateTime)Entries[0])
					    },
			new ObjectFieldDateTime {Id = "Expires", 
						Label = "Expires" // ((ObjectFieldDateTime)Entries[1])
					    },
			new ObjectFieldString {Id = "Status", 
						Label = "Status" // ((ObjectFieldString)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class ConnectRequest : Message {

		/// <summary>
        /// Description
        /// </summary>
		public ObjectFieldString Description {
			get {
				return ((ObjectFieldString)Entries[3]);
				}

			}
			
		/// <summary>
        /// Fingerprint
        /// </summary>
		public ObjectFieldString Fingerprint {
			get {
				return ((ObjectFieldString)Entries[4]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldDateTime {Id = "Issued", 
						Label = "Sent" // ((ObjectFieldDateTime)Entries[0])
					    },
			new ObjectFieldDateTime {Id = "Expires", 
						Label = "Expires" // ((ObjectFieldDateTime)Entries[1])
					    },
			new ObjectFieldString {Id = "Status", 
						Label = "Status" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Description", 
						Label = "Device description" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectFieldString {Id = "Fingerprint", 
						Label = "Fingerprint" // ((ObjectFieldString)Entries[4])
					    },
			new ObjectAction {
						Id = "ConnectAccept",  
						Label = "Accept Connection"},
			new ObjectAction {
						Id = "ConnectReject",  
						Label = "Reject Connection"}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class Profile : Object {

		/// <summary>
        /// Identifier
        /// </summary>
		public ObjectFieldString Identifier {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Fingerprint
        /// </summary>
		public ObjectFieldString Fingerprint {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// Devices
        /// </summary>
		public ObjectFieldSet Devices {
			get {
				return ((ObjectFieldSet)Entries[2]);
				}

			}
			
		/// <summary>
        /// Applications
        /// </summary>
		public ObjectFieldSet Applications {
			get {
				return ((ObjectFieldSet)Entries[3]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "Fingerprint", 
						ReadOnly = true,
						Label = "Fingerprint" // ((ObjectFieldString)Entries[1])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Connected devices" // ((ObjectFieldSet)Entries[2])
					    },
			new ObjectFieldSet {Id = "Applications", 
						Label = "Connected applications" // ((ObjectFieldSet)Entries[3])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();
			if (Devices.Value != null) {
				foreach (var Entry in Devices.Value) {
					Result.Add (Entry);
					}
				}
			if (Applications.Value != null) {
				foreach (var Entry in Applications.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class Device : Object {

		/// <summary>
        /// Identifier
        /// </summary>
		public ObjectFieldString Identifier {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Applications
        /// </summary>
		public ObjectFieldSet Applications {
			get {
				return ((ObjectFieldSet)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Applications", 
						Label = "Connected applications" // ((ObjectFieldSet)Entries[1])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();
			if (Applications.Value != null) {
				foreach (var Entry in Applications.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class Application : Object {

		/// <summary>
        /// Identifier
        /// </summary>
		public ObjectFieldString Identifier {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Devices
        /// </summary>
		public ObjectFieldSet Devices {
			get {
				return ((ObjectFieldSet)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Connected devices" // ((ObjectFieldSet)Entries[1])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();
			if (Devices.Value != null) {
				foreach (var Entry in Devices.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class Group : Object {

		/// <summary>
        /// Identifier
        /// </summary>
		public ObjectFieldString Identifier {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Devices
        /// </summary>
		public ObjectFieldSet Devices {
			get {
				return ((ObjectFieldSet)Entries[1]);
				}

			}
			
		/// <summary>
        /// Applications
        /// </summary>
		public ObjectFieldSet Applications {
			get {
				return ((ObjectFieldSet)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Devices" // ((ObjectFieldSet)Entries[1])
					    },
			new ObjectFieldSet {Id = "Applications", 
						Label = "Applications" // ((ObjectFieldSet)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();
			if (Devices.Value != null) {
				foreach (var Entry in Devices.Value) {
					Result.Add (Entry);
					}
				}
			if (Applications.Value != null) {
				foreach (var Entry in Applications.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class ApplicationMail : Application {

		/// <summary>
        /// Account
        /// </summary>
		public ObjectFieldString Account {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// Address
        /// </summary>
		public ObjectFieldString Address {
			get {
				return ((ObjectFieldString)Entries[3]);
				}

			}
			
		/// <summary>
        /// Inbound
        /// </summary>
		public ServerSASL Inbound {
			get {
				return (ServerSASL) (((ObjectFieldItem)Entries[4])).Value;
				}

			}
			
		/// <summary>
        /// Outbound
        /// </summary>
		public ServerSASL Outbound {
			get {
				return (ServerSASL) (((ObjectFieldItem)Entries[5])).Value;
				}

			}
			
		/// <summary>
        /// EnablePGP
        /// </summary>
		public ObjectFieldOption EnablePGP {
			get {
				return ((ObjectFieldOption)Entries[6]);
				}

			}
			
		/// <summary>
        /// PGPPerDeviceSign
        /// </summary>
		public ObjectFieldBoolean PGPPerDeviceSign {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[6]).Entries[0]);
				}

			}
			
		/// <summary>
        /// PGPPerDeviceDecrypt
        /// </summary>
		public ObjectFieldBoolean PGPPerDeviceDecrypt {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[6]).Entries[1]);
				}

			}
			
		/// <summary>
        /// PGPSelectAlgorithms
        /// </summary>
		public ObjectFieldOption PGPSelectAlgorithms {
			get {
				return ((ObjectFieldOption)((ObjectFieldOption)Entries[6]).Entries[2]);
				}

			}
			
		/// <summary>
        /// PGPAlgorithms
        /// </summary>
		public ObjectFieldChooser PGPAlgorithms {
			get {
				return ((ObjectFieldChooser)((ObjectFieldOption)((ObjectFieldOption)Entries[6]).Entries[2]).Entries[0]);
				}

			}
			
		/// <summary>
        /// PGPKeys
        /// </summary>
		public ObjectFieldList PGPKeys {
			get {
				return ((ObjectFieldList)((ObjectFieldOption)Entries[6]).Entries[3]);
				}

			}
			
		/// <summary>
        /// EnableSMIME
        /// </summary>
		public ObjectFieldOption EnableSMIME {
			get {
				return ((ObjectFieldOption)Entries[7]);
				}

			}
			
		/// <summary>
        /// SMIMEPerDeviceSign
        /// </summary>
		public ObjectFieldBoolean SMIMEPerDeviceSign {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[7]).Entries[0]);
				}

			}
			
		/// <summary>
        /// SMIMEPerDeviceDecrypt
        /// </summary>
		public ObjectFieldBoolean SMIMEPerDeviceDecrypt {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[7]).Entries[1]);
				}

			}
			
		/// <summary>
        /// SMIMESelectAlgorithms
        /// </summary>
		public ObjectFieldOption SMIMESelectAlgorithms {
			get {
				return ((ObjectFieldOption)((ObjectFieldOption)Entries[7]).Entries[2]);
				}

			}
			
		/// <summary>
        /// SMIMEAlgorithms
        /// </summary>
		public ObjectFieldChooser SMIMEAlgorithms {
			get {
				return ((ObjectFieldChooser)((ObjectFieldOption)((ObjectFieldOption)Entries[7]).Entries[2]).Entries[0]);
				}

			}
			
		/// <summary>
        /// SMIMEKeys
        /// </summary>
		public ObjectFieldList SMIMEKeys {
			get {
				return ((ObjectFieldList)((ObjectFieldOption)Entries[7]).Entries[3]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Connected devices" // ((ObjectFieldSet)Entries[1])
					    },
			new ObjectFieldString {Id = "Account", 
						Label = "Account name" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Address", 
						Label = "Email address" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectFieldItem {
						Id = "Inbound",  
						Label = "Inbound Server",
						Value = new ServerSASL () 
						},
			new ObjectFieldItem {
						Id = "Outbound",  
						Label = "Outbound Server",
						Value = new ServerSASL () 
						},	
			new ObjectFieldOption {
						Id = "EnablePGP",  
						Label = "OpenPGP",
						Entries = new List<ObjectEntry> {
				new ObjectFieldBoolean {Id = "PGPPerDeviceSign", 
							Label = "Separate signing keys per device" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[6]).Entries[0])
						    },
				new ObjectFieldBoolean {Id = "PGPPerDeviceDecrypt", 
							Label = "Separate decryption keys per device" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[6]).Entries[1])
						    },	
				new ObjectFieldOption {
							Id = "PGPSelectAlgorithms",  
							Label = "Specify permitted algorithms",
							Entries = new List<ObjectEntry> {
					new ObjectFieldChooser {Id = "PGPAlgorithms", 
								Label = "Algorithms" // ((ObjectFieldChooser)((ObjectFieldOption)((ObjectFieldOption)Entries[6]).Entries[2]).Entries[0])
							    }
								}
							},
				new ObjectFieldList {Id = "PGPKeys", 
							Prototype = new KeysPGP (),
							Label = "Keys" // ((ObjectFieldList)((ObjectFieldOption)Entries[6]).Entries[3])
						    },
				new ObjectAction {
							Id = "KeyRefresh",  
							Label = "Rollover Key"}
							}
						},	
			new ObjectFieldOption {
						Id = "EnableSMIME",  
						Label = "S/MIME",
						Entries = new List<ObjectEntry> {
				new ObjectFieldBoolean {Id = "SMIMEPerDeviceSign", 
							Label = "Separate signing keys per device" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[7]).Entries[0])
						    },
				new ObjectFieldBoolean {Id = "SMIMEPerDeviceDecrypt", 
							Label = "Separate decryption keys per device" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[7]).Entries[1])
						    },	
				new ObjectFieldOption {
							Id = "SMIMESelectAlgorithms",  
							Label = "Specify permitted algorithms",
							Entries = new List<ObjectEntry> {
					new ObjectFieldChooser {Id = "SMIMEAlgorithms", 
								Label = "Algorithms" // ((ObjectFieldChooser)((ObjectFieldOption)((ObjectFieldOption)Entries[7]).Entries[2]).Entries[0])
							    }
								}
							},
				new ObjectFieldList {Id = "SMIMEKeys", 
							Prototype = new KeysSMIME (),
							Label = "Keys" // ((ObjectFieldList)((ObjectFieldOption)Entries[7]).Entries[3])
						    },
				new ObjectAction {
							Id = "KeyRefresh",  
							Label = "Rollover Key"}
							}
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class ApplicationSSH : Application {

		/// <summary>
        /// Fingerprint
        /// </summary>
		public ObjectFieldString Fingerprint {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// Algorithm
        /// </summary>
		public ObjectFieldString Algorithm {
			get {
				return ((ObjectFieldString)Entries[3]);
				}

			}
			
		/// <summary>
        /// Key
        /// </summary>
		public ObjectFieldString Key {
			get {
				return ((ObjectFieldString)Entries[4]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Connected devices" // ((ObjectFieldSet)Entries[1])
					    },
			new ObjectFieldString {Id = "Fingerprint", 
						Label = "Fingerprint" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Algorithm", 
						Label = "Algorithm" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectFieldString {Id = "Key", 
						Label = "Key" // ((ObjectFieldString)Entries[4])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class ApplicationPassword : Application {

		/// <summary>
        /// Sites
        /// </summary>
		public ObjectFieldList Sites {
			get {
				return ((ObjectFieldList)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Connected devices" // ((ObjectFieldSet)Entries[1])
					    },
			new ObjectFieldList {Id = "Sites", 
						Prototype = new WebPassword (),
						Label = "Sites" // ((ObjectFieldList)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();
			if (Sites.Value != null) {
				foreach (var Entry in Sites.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class ApplicationWiFi : Application {

		/// <summary>
        /// WiFis
        /// </summary>
		public ObjectFieldList WiFis {
			get {
				return ((ObjectFieldList)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Identifier", 
						Label = "Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSet {Id = "Devices", 
						Label = "Connected devices" // ((ObjectFieldSet)Entries[1])
					    },
			new ObjectFieldList {Id = "WiFis", 
						Prototype = new WiFi (),
						Label = "Networks" // ((ObjectFieldList)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();
			if (WiFis.Value != null) {
				foreach (var Entry in WiFis.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class Key : Object {

		/// <summary>
        /// Fingerprint
        /// </summary>
		public ObjectFieldString Fingerprint {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// KeyValid
        /// </summary>
		public ObjectFieldBoolean KeyValid {
			get {
				return ((ObjectFieldBoolean)Entries[1]);
				}

			}
			
		/// <summary>
        /// Created
        /// </summary>
		public ObjectFieldString Created {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// Expires
        /// </summary>
		public ObjectFieldString Expires {
			get {
				return ((ObjectFieldString)Entries[3]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Fingerprint", 
						ReadOnly = true,
						Label = "Fingerprint" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldBoolean {Id = "KeyValid", 
						ReadOnly = true,
						Label = "Is valid" // ((ObjectFieldBoolean)Entries[1])
					    },
			new ObjectFieldString {Id = "Created", 
						Label = "Created" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Expires", 
						Label = "Expires" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectAction {
						Id = "KeyRemove",  
						Label = ""},
			new ObjectAction {
						Id = "KeyRefresh",  
						Label = "Rollover Key"}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class KeysSMIME : Key {


		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Fingerprint", 
						ReadOnly = true,
						Label = "Fingerprint" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldBoolean {Id = "KeyValid", 
						ReadOnly = true,
						Label = "Is valid" // ((ObjectFieldBoolean)Entries[1])
					    },
			new ObjectFieldString {Id = "Created", 
						Label = "Created" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Expires", 
						Label = "Expires" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectAction {
						Id = "KeyRemove",  
						Label = ""},
			new ObjectAction {
						Id = "KeyRefresh",  
						Label = "Rollover Key"}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class KeysPGP : Key {


		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Fingerprint", 
						ReadOnly = true,
						Label = "Fingerprint" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldBoolean {Id = "KeyValid", 
						ReadOnly = true,
						Label = "Is valid" // ((ObjectFieldBoolean)Entries[1])
					    },
			new ObjectFieldString {Id = "Created", 
						Label = "Created" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Expires", 
						Label = "Expires" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectAction {
						Id = "KeyRemove",  
						Label = ""},
			new ObjectAction {
						Id = "KeyRefresh",  
						Label = "Rollover Key"}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class SSHKey : Key {

		/// <summary>
        /// Algorithm
        /// </summary>
		public ObjectFieldString Algorithm {
			get {
				return ((ObjectFieldString)Entries[4]);
				}

			}
			
		/// <summary>
        /// Key
        /// </summary>
		public ObjectFieldString Key {
			get {
				return ((ObjectFieldString)Entries[5]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Fingerprint", 
						ReadOnly = true,
						Label = "Fingerprint" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldBoolean {Id = "KeyValid", 
						ReadOnly = true,
						Label = "Is valid" // ((ObjectFieldBoolean)Entries[1])
					    },
			new ObjectFieldString {Id = "Created", 
						Label = "Created" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldString {Id = "Expires", 
						Label = "Expires" // ((ObjectFieldString)Entries[3])
					    },
			new ObjectAction {
						Id = "KeyRemove",  
						Label = ""},
			new ObjectAction {
						Id = "KeyRefresh",  
						Label = "Rollover Key"},
			new ObjectFieldString {Id = "Algorithm", 
						Label = "Algorithm" // ((ObjectFieldString)Entries[4])
					    },
			new ObjectFieldString {Id = "Key", 
						Label = "Key" // ((ObjectFieldString)Entries[5])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class SSHService : Object {

		/// <summary>
        /// Server
        /// </summary>
		public Server Server {
			get {
				return (Server) (((ObjectFieldItem)Entries[0])).Value;
				}

			}
			
		/// <summary>
        /// Fingerprint
        /// </summary>
		public ObjectFieldString Fingerprint {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldItem {
						Id = "Server",  
						Label = "Server",
						Value = new Server () 
						},
			new ObjectFieldString {Id = "Fingerprint", 
						Label = "Fingerprint" // ((ObjectFieldString)Entries[1])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class WebPassword : Object {

		/// <summary>
        /// Site
        /// </summary>
		public ObjectFieldString Site {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Account
        /// </summary>
		public ObjectFieldString Account {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// Password
        /// </summary>
		public ObjectFieldSecret Password {
			get {
				return ((ObjectFieldSecret)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Site", 
						Label = "Site" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "Account", 
						Label = "Account" // ((ObjectFieldString)Entries[1])
					    },
			new ObjectFieldSecret {Id = "Password", 
						Label = "Password" // ((ObjectFieldSecret)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class WiFi : Object {

		/// <summary>
        /// SSID
        /// </summary>
		public ObjectFieldString SSID {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Password
        /// </summary>
		public ObjectFieldSecret Password {
			get {
				return ((ObjectFieldSecret)Entries[1]);
				}

			}
			
		/// <summary>
        /// WEP
        /// </summary>
		public ObjectFieldBoolean WEP {
			get {
				return ((ObjectFieldBoolean)Entries[2]);
				}

			}
			
		/// <summary>
        /// WPA
        /// </summary>
		public ObjectFieldBoolean WPA {
			get {
				return ((ObjectFieldBoolean)Entries[3]);
				}

			}
			
		/// <summary>
        /// WPA2
        /// </summary>
		public ObjectFieldBoolean WPA2 {
			get {
				return ((ObjectFieldBoolean)Entries[4]);
				}

			}
			
		/// <summary>
        /// WPAEnterprise
        /// </summary>
		public ObjectFieldBoolean WPAEnterprise {
			get {
				return ((ObjectFieldBoolean)Entries[5]);
				}

			}
			
		/// <summary>
        /// WPA2Enterprise
        /// </summary>
		public ObjectFieldBoolean WPA2Enterprise {
			get {
				return ((ObjectFieldBoolean)Entries[6]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "SSID", 
						Label = "SSID" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldSecret {Id = "Password", 
						Label = "Password" // ((ObjectFieldSecret)Entries[1])
					    },
			new ObjectFieldBoolean {Id = "WEP", 
						Label = "WEP" // ((ObjectFieldBoolean)Entries[2])
					    },
			new ObjectFieldBoolean {Id = "WPA", 
						Label = "WPA" // ((ObjectFieldBoolean)Entries[3])
					    },
			new ObjectFieldBoolean {Id = "WPA2", 
						Label = "WPA2" // ((ObjectFieldBoolean)Entries[4])
					    },
			new ObjectFieldBoolean {Id = "WPAEnterprise", 
						Label = "WPA Enterprise" // ((ObjectFieldBoolean)Entries[5])
					    },
			new ObjectFieldBoolean {Id = "WPA2Enterprise", 
						Label = "WPA2 Enterprise" // ((ObjectFieldBoolean)Entries[6])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class Server : Object {

		/// <summary>
        /// Address
        /// </summary>
		public ObjectFieldString Address {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Port
        /// </summary>
		public ObjectFieldInteger Port {
			get {
				return ((ObjectFieldInteger)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Address", 
						Length = 32,
						Label = "DNS Address" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldInteger {Id = "Port", 
						Length = 5,
						Label = "Port" // ((ObjectFieldInteger)Entries[1])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class ServerTLS : Server {

		/// <summary>
        /// TLS
        /// </summary>
		public ObjectFieldBoolean TLS {
			get {
				return ((ObjectFieldBoolean)Entries[2]);
				}

			}
			
		/// <summary>
        /// Root
        /// </summary>
		public ObjectFieldString Root {
			get {
				return ((ObjectFieldString)Entries[3]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Address", 
						Length = 32,
						Label = "DNS Address" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldInteger {Id = "Port", 
						Length = 5,
						Label = "Port" // ((ObjectFieldInteger)Entries[1])
					    },
			new ObjectFieldBoolean {Id = "TLS", 
						Label = "Require TLS" // ((ObjectFieldBoolean)Entries[2])
					    },
			new ObjectFieldString {Id = "Root", 
						Label = "TLS Root" // ((ObjectFieldString)Entries[3])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class ServerSASL : Server {

		/// <summary>
        /// Password
        /// </summary>
		public ObjectFieldSecret Password {
			get {
				return ((ObjectFieldSecret)Entries[2]);
				}

			}
			
		/// <summary>
        /// Auth
        /// </summary>
		public ObjectFieldBoolean Auth {
			get {
				return ((ObjectFieldBoolean)Entries[3]);
				}

			}
			
		/// <summary>
        /// Schemes
        /// </summary>
		public ObjectFieldString Schemes {
			get {
				return ((ObjectFieldString)Entries[4]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Address", 
						Length = 32,
						Label = "DNS Address" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldInteger {Id = "Port", 
						Length = 5,
						Label = "Port" // ((ObjectFieldInteger)Entries[1])
					    },
			new ObjectFieldSecret {Id = "Password", 
						Label = "Password" // ((ObjectFieldSecret)Entries[2])
					    },
			new ObjectFieldBoolean {Id = "Auth", 
						Label = "Require Secure Auth" // ((ObjectFieldBoolean)Entries[3])
					    },
			new ObjectFieldString {Id = "Schemes", 
						Label = "Only accept" // ((ObjectFieldString)Entries[4])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
            var Result = new List<Goedel.Trojan.Object>();

			return Result;
            }


		}


	public partial class NameDevice : Object {

		/// <summary>
        /// DeviceName
        /// </summary>
		public ObjectFieldString DeviceName {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// DeviceDescription
        /// </summary>
		public ObjectFieldString DeviceDescription {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// NewDeviceProfile
        /// </summary>
		public ObjectFieldBoolean NewDeviceProfile {
			get {
				return ((ObjectFieldBoolean)Entries[3]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectText {
						Text = "What name do you want to use for this device?"
						},
			new ObjectFieldString {Id = "DeviceName", 
						Tip = "This is the name that Mesh applications will use to identify this device to you.",
						Label = "Name for this device" // ((ObjectFieldString)Entries[1])
					    },
			new ObjectFieldString {Id = "DeviceDescription", 
						Label = "Description" // ((ObjectFieldString)Entries[2])
					    },
			new ObjectFieldBoolean {Id = "NewDeviceProfile", 
						Tip = "The device you are currently using will be the initial administration device for the new profile and therefor must have a device profile defined for it.",
						Label = "Create new device profile" // ((ObjectFieldBoolean)Entries[3])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class CreateProfile : Object {

		/// <summary>
        /// PortalAddress
        /// </summary>
		public ObjectFieldString PortalAddress {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// PortalAccount
        /// </summary>
		public ObjectFieldString PortalAccount {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// FriendlyName
        /// </summary>
		public ObjectFieldString FriendlyName {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// Escrow
        /// </summary>
		public ObjectFieldOption Escrow {
			get {
				return ((ObjectFieldOption)Entries[3]);
				}

			}
			
		/// <summary>
        /// Shares
        /// </summary>
		public ObjectFieldInteger Shares {
			get {
				return ((ObjectFieldInteger)((ObjectFieldOption)Entries[3]).Entries[0]);
				}

			}
			
		/// <summary>
        /// Quorum
        /// </summary>
		public ObjectFieldInteger Quorum {
			get {
				return ((ObjectFieldInteger)((ObjectFieldOption)Entries[3]).Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "PortalAddress", 
						Length = 32,
						Label = "Portal Address" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "PortalAccount", 
						Length = 16,
						Label = "Account Name" // ((ObjectFieldString)Entries[1])
					    },
			new ObjectFieldString {Id = "FriendlyName", 
						Length = 32,
						Label = "Identifier" // ((ObjectFieldString)Entries[2])
					    },	
			new ObjectFieldOption {
						Id = "Escrow",  
						Label = "Escrow Keys",
						Entries = new List<ObjectEntry> {
				new ObjectFieldInteger {Id = "Shares", 
							Mode = FieldModeInteger.Slider,
							Minimum = 2,
							Maximum = 16,
							Step = 1,
							Label = "Number of Key Shares" // ((ObjectFieldInteger)((ObjectFieldOption)Entries[3]).Entries[0])
						    },
				new ObjectFieldInteger {Id = "Quorum", 
							Mode = FieldModeInteger.Slider,
							Minimum = 2,
							Maximum = 16,
							Step = 1,
							Label = "Number of shares required for recovery" // ((ObjectFieldInteger)((ObjectFieldOption)Entries[3]).Entries[1])
						    },
				new ObjectText {
							Text = "Creating an escrow record for the Master Key allows it to be  recovered should the need arise.			"
							}
							}
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class EscrowParameters : Object {

		/// <summary>
        /// Shares
        /// </summary>
		public ObjectFieldInteger Shares {
			get {
				return ((ObjectFieldInteger)Entries[0]);
				}

			}
			
		/// <summary>
        /// Quorum
        /// </summary>
		public ObjectFieldInteger Quorum {
			get {
				return ((ObjectFieldInteger)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldInteger {Id = "Shares", 
						Mode = FieldModeInteger.Slider,
						Label = "Number of Key Shares" // ((ObjectFieldInteger)Entries[0])
					    },
			new ObjectFieldInteger {Id = "Quorum", 
						Mode = FieldModeInteger.Slider,
						Label = "Number of shares required for recovery" // ((ObjectFieldInteger)Entries[1])
					    },
			new ObjectText {
						Text = "Creating an escrow record for the Master Key allows it to be  recovered should the need arise."
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class SelectApplications : Object {


		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectText {
						Text = "Which applications do you want to use the Mesh to secure?"
						},
			new ObjectText {
						Text = "(You can always add or remove applications later on.)"
						},
			new ObjectAction {
						Id = "ApplicationAddMail",  
						Text = "Email (S/MIME, OpenPGP)",
						Label = "Add Mail"},
			new ObjectAction {
						Id = "ApplicationAddSSH",  
						Text = "SSH Secure Shell",
						Label = "Add SSH"},
			new ObjectAction {
						Id = "ApplicationAddWiFi",  
						Text = "Secure Network Access",
						Label = "Add WiFi Network"},
			new ObjectAction {
						Id = "ApplicationAddWeb",  
						Text = "World Wide Web",
						Label = "Add Web Password Manager"}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class Review : Object {

		/// <summary>
        /// FriendlyName
        /// </summary>
		public ObjectFieldString FriendlyName {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Fingerprint
        /// </summary>
		public ObjectFieldString Fingerprint {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// MeshAddress
        /// </summary>
		public ObjectFieldString MeshAddress {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// Escrow
        /// </summary>
		public ObjectFieldOption Escrow {
			get {
				return ((ObjectFieldOption)Entries[3]);
				}

			}
			
		/// <summary>
        /// Quorum
        /// </summary>
		public ObjectFieldInteger Quorum {
			get {
				return ((ObjectFieldInteger)((ObjectFieldOption)Entries[3]).Entries[0]);
				}

			}
			
		/// <summary>
        /// Shares
        /// </summary>
		public ObjectFieldList Shares {
			get {
				return ((ObjectFieldList)((ObjectFieldOption)Entries[3]).Entries[1]);
				}

			}
			
		/// <summary>
        /// WebApplication
        /// </summary>
		public ObjectFieldOption WebApplication {
			get {
				return ((ObjectFieldOption)Entries[4]);
				}

			}
			
		/// <summary>
        /// Passwords
        /// </summary>
		public ObjectFieldBoolean Passwords {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[4]).Entries[0]);
				}

			}
			
		/// <summary>
        /// Bookmarks
        /// </summary>
		public ObjectFieldBoolean Bookmarks {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[4]).Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "FriendlyName", 
						ReadOnly = true,
						Label = "Friendly Name" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "Fingerprint", 
						ReadOnly = true,
						Label = "Master Fingerprint" // ((ObjectFieldString)Entries[1])
					    },
			new ObjectFieldString {Id = "MeshAddress", 
						ReadOnly = true,
						Label = "Mesh Portal account" // ((ObjectFieldString)Entries[2])
					    },	
			new ObjectFieldOption {
						Id = "Escrow",  
						Label = "Escrow encryption keys",
						ReadOnly = true,
						Entries = new List<ObjectEntry> {
				new ObjectFieldInteger {Id = "Quorum", 
							ReadOnly = true,
							Label = "Quorum" // ((ObjectFieldInteger)((ObjectFieldOption)Entries[3]).Entries[0])
						    },
				new ObjectFieldList {Id = "Shares", 
							Prototype = new Share (),
							Label = "Shares" // ((ObjectFieldList)((ObjectFieldOption)Entries[3]).Entries[1])
						    }
							}
						},	
			new ObjectFieldOption {
						Id = "WebApplication",  
						Label = "Use the Mesh to store Web data",
						ReadOnly = true,
						Entries = new List<ObjectEntry> {
				new ObjectFieldBoolean {Id = "Passwords", 
							ReadOnly = true,
							Label = "Store Web Passwords in the Mesh" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[4]).Entries[0])
						    },
				new ObjectFieldBoolean {Id = "Bookmarks", 
							ReadOnly = true,
							Label = "Store Web Bookmarks in the Mesh" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[4]).Entries[1])
						    }
							}
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class Share : Object {

		/// <summary>
        /// Number
        /// </summary>
		public ObjectFieldInteger Number {
			get {
				return ((ObjectFieldInteger)Entries[0]);
				}

			}
			
		/// <summary>
        /// Value
        /// </summary>
		public ObjectFieldString Value {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldInteger {Id = "Number", 
						Label = "Number" // ((ObjectFieldInteger)Entries[0])
					    },
			new ObjectFieldString {Id = "Value", 
						Label = "Value" // ((ObjectFieldString)Entries[1])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class CommitWizardCreateProfile : Object {


		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectText {
						Text = "Success! The profile was accepted by the mesh portal."
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class SelectAccountsEmail : Object {

		public enum EnumSelection {
			All  /* Use same security settings for all accounts */
,
			Choose  /* Let me choose options for each account */
			};
		public ObjectFieldEnumerate Selection  {
			get {
				return ((ObjectFieldEnumerate)Entries[1]);
				}
			}
		/// <summary>
        /// Accounts
        /// </summary>
		public ObjectFieldList Accounts {
			get {
				return ((ObjectFieldList)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectText {
						Text = "The following accounts were discovered on your computer."
						},
			new ObjectFieldEnumerate {
						Id = "Selection",  
						Label = "Security settings",
						Entries = new List<ObjectEntry> {
				new ObjectFieldRadio {
						Id = "All",  
						Label = "Use same security settings for all accounts",
						SelectionValue = (int) EnumSelection.All  } ,
				new ObjectFieldRadio {
						Id = "Choose",  
						Label = "Let me choose options for each account",
						SelectionValue = (int) EnumSelection.Choose  } 							}
						},
			new ObjectFieldList {Id = "Accounts", 
						Prototype = new EmailAccount (),
						Label = "Email Accounts" // ((ObjectFieldList)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();
			if (Accounts.Value != null) {
				foreach (var Entry in Accounts.Value) {
					Result.Add (Entry);
					}
				}

			return Result;
            }


		}


	public partial class EmailAccount : Object {

		/// <summary>
        /// Address
        /// </summary>
		public ObjectFieldString Address {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Application
        /// </summary>
		public ObjectFieldString Application {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Address", 
						Label = "Address" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "Application", 
						Label = "Application" // ((ObjectFieldString)Entries[1])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class EmailOptions : Object {

		/// <summary>
        /// Account
        /// </summary>
		public ObjectFieldString Account {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// Application
        /// </summary>
		public ObjectFieldString Application {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// UseOpenPGP
        /// </summary>
		public ObjectFieldOption UseOpenPGP {
			get {
				return ((ObjectFieldOption)Entries[2]);
				}

			}
			
		/// <summary>
        /// PublishPGPMesh
        /// </summary>
		public ObjectFieldBoolean PublishPGPMesh {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[2]).Entries[0]);
				}

			}
			
		/// <summary>
        /// PublishPGPKeyRing
        /// </summary>
		public ObjectFieldBoolean PublishPGPKeyRing {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[2]).Entries[1]);
				}

			}
			
		/// <summary>
        /// EscrowPGP
        /// </summary>
		public ObjectFieldBoolean EscrowPGP {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[2]).Entries[2]);
				}

			}
			
		/// <summary>
        /// UseSMIME
        /// </summary>
		public ObjectFieldOption UseSMIME {
			get {
				return ((ObjectFieldOption)Entries[3]);
				}

			}
			
		/// <summary>
        /// SMIMECA
        /// </summary>
		public ObjectFieldString SMIMECA {
			get {
				return ((ObjectFieldString)((ObjectFieldOption)Entries[3]).Entries[0]);
				}

			}
			
		/// <summary>
        /// EscrowSMIME
        /// </summary>
		public ObjectFieldBoolean EscrowSMIME {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[3]).Entries[1]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "Account", 
						Label = "Account" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "Application", 
						Label = "Application" // ((ObjectFieldString)Entries[1])
					    },	
			new ObjectFieldOption {
						Id = "UseOpenPGP",  
						Label = "Create keys for OpenPGP",
						Entries = new List<ObjectEntry> {
				new ObjectFieldBoolean {Id = "PublishPGPMesh", 
							Label = "Publish public key to the Mesh" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[2]).Entries[0])
						    },
				new ObjectFieldBoolean {Id = "PublishPGPKeyRing", 
							Label = "Publish public key to OpenPGP key servers" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[2]).Entries[1])
						    },
				new ObjectFieldBoolean {Id = "EscrowPGP", 
							Label = "Use personal escrow key to safeguard key" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[2]).Entries[2])
						    }
							}
						},	
			new ObjectFieldOption {
						Id = "UseSMIME",  
						Label = "Create keys for S/MIME",
						Entries = new List<ObjectEntry> {
				new ObjectFieldString {Id = "SMIMECA", 
							Label = "DNS address of CA" // ((ObjectFieldString)((ObjectFieldOption)Entries[3]).Entries[0])
						    },
				new ObjectFieldBoolean {Id = "EscrowSMIME", 
							Label = "Use personal escrow key to safeguard key" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[3]).Entries[1])
						    }
							}
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class SSHOptions : Object {

		public enum EnumKeySeparation {
			PerDevice  /* Create separate SSH keys for each device (recommended). */
,
			OneKey  /* Use one keypair for all devices. */
			};
		public ObjectFieldEnumerate KeySeparation  {
			get {
				return ((ObjectFieldEnumerate)Entries[0]);
				}
			}
		public enum EnumKeyHygiene {
			PerApplication  /* Create separate keys for use with SSH and GIT (recommended) */
,
			Combine  /* Use the same key for both. */
			};
		public ObjectFieldEnumerate KeyHygiene  {
			get {
				return ((ObjectFieldEnumerate)Entries[1]);
				}
			}

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldEnumerate {
						Id = "KeySeparation",  
						Label = "Key separation",
						Entries = new List<ObjectEntry> {
				new ObjectFieldRadio {
						Id = "PerDevice",  
						Label = "Create separate SSH keys for each device (recommended).",
						SelectionValue = (int) EnumKeySeparation.PerDevice  } ,
				new ObjectFieldRadio {
						Id = "OneKey",  
						Label = "Use one keypair for all devices.",
						SelectionValue = (int) EnumKeySeparation.OneKey  } 							}
						},
			new ObjectFieldEnumerate {
						Id = "KeyHygiene",  
						Label = "Key Hygiene",
						Entries = new List<ObjectEntry> {
				new ObjectFieldRadio {
						Id = "PerApplication",  
						Label = "Create separate keys for use with SSH and GIT (recommended)",
						SelectionValue = (int) EnumKeyHygiene.PerApplication  } ,
				new ObjectFieldRadio {
						Id = "Combine",  
						Label = "Use the same key for both.",
						SelectionValue = (int) EnumKeyHygiene.Combine  } 							}
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class WebOptions : Object {

		/// <summary>
        /// Passwords
        /// </summary>
		public ObjectFieldBoolean Passwords {
			get {
				return ((ObjectFieldBoolean)Entries[1]);
				}

			}
			
		/// <summary>
        /// Bookmarks
        /// </summary>
		public ObjectFieldBoolean Bookmarks {
			get {
				return ((ObjectFieldBoolean)Entries[2]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectText {
						Text = "Do you want to use the Mesh to store passwords or bookmarks?"
						},
			new ObjectFieldBoolean {Id = "Passwords", 
						Label = "Use the Mesh to store Web passwords" // ((ObjectFieldBoolean)Entries[1])
					    },
			new ObjectFieldBoolean {Id = "Bookmarks", 
						Label = "Use the Mesh to store Web bookmarks" // ((ObjectFieldBoolean)Entries[2])
					    }			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}


	public partial class NetworkOptions : Object {

		/// <summary>
        /// DNS1
        /// </summary>
		public ObjectFieldString DNS1 {
			get {
				return ((ObjectFieldString)Entries[0]);
				}

			}
			
		/// <summary>
        /// DNS2
        /// </summary>
		public ObjectFieldString DNS2 {
			get {
				return ((ObjectFieldString)Entries[1]);
				}

			}
			
		/// <summary>
        /// Scope
        /// </summary>
		public ObjectFieldString Scope {
			get {
				return ((ObjectFieldString)Entries[2]);
				}

			}
			
		/// <summary>
        /// RequireSecurity
        /// </summary>
		public ObjectFieldOption RequireSecurity {
			get {
				return ((ObjectFieldOption)Entries[3]);
				}

			}
			
		/// <summary>
        /// SecurityConfig
        /// </summary>
		public ObjectFieldString SecurityConfig {
			get {
				return ((ObjectFieldString)((ObjectFieldOption)Entries[3]).Entries[0]);
				}

			}
			
		/// <summary>
        /// DNSTLS
        /// </summary>
		public ObjectFieldBoolean DNSTLS {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[3]).Entries[1]);
				}

			}
			
		/// <summary>
        /// DNSPrivate
        /// </summary>
		public ObjectFieldBoolean DNSPrivate {
			get {
				return ((ObjectFieldBoolean)((ObjectFieldOption)Entries[3]).Entries[2]);
				}

			}
			
		/// <summary>
        /// TrustRoot
        /// </summary>
		public ObjectFieldString TrustRoot {
			get {
				return ((ObjectFieldString)((ObjectFieldOption)Entries[3]).Entries[3]);
				}

			}
			

		public override List<ObjectEntry> Entries {
            get { return _Entries; }
            set { _Entries = value; }
            }

		List<ObjectEntry> _Entries = new List<ObjectEntry> {

			new ObjectFieldString {Id = "DNS1", 
						Label = "DNS server 1" // ((ObjectFieldString)Entries[0])
					    },
			new ObjectFieldString {Id = "DNS2", 
						Label = "DNS server 2" // ((ObjectFieldString)Entries[1])
					    },
			new ObjectFieldString {Id = "Scope", 
						Label = "Restrict scope to domains" // ((ObjectFieldString)Entries[2])
					    },	
			new ObjectFieldOption {
						Id = "RequireSecurity",  
						Label = "Require Security",
						Entries = new List<ObjectEntry> {
				new ObjectFieldString {Id = "SecurityConfig", 
							Label = "Security policy" // ((ObjectFieldString)((ObjectFieldOption)Entries[3]).Entries[0])
						    },
				new ObjectFieldBoolean {Id = "DNSTLS", 
							Label = "Allow DNS over TLS" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[3]).Entries[1])
						    },
				new ObjectFieldBoolean {Id = "DNSPrivate", 
							Label = "Allow Private DNS" // ((ObjectFieldBoolean)((ObjectFieldOption)Entries[3]).Entries[2])
						    },
				new ObjectFieldString {Id = "TrustRoot", 
							Label = "DNS Root of Trust" // ((ObjectFieldString)((ObjectFieldOption)Entries[3]).Entries[3])
						    }
							}
						}			} ;


        /// <summary>
        /// Create a list containing all the current children.
        /// </summary>
        /// <returns></returns>
        public override List<Goedel.Trojan.Object> GetChildren() {
			var Result = base.GetChildren();

			return Result;
            }


		}





	}

