﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Threading;
using Goedel.Trojan;

namespace Goedel.MeshSampleClient {

    public partial class _Data_PasswordDialog :Goedel.Trojan.Data  {
		public Dialog_PasswordDialog Dialog;

		public override Page Page {
		    get { return Dialog; }
			}

		protected SampleApplication _Data;
		public SampleApplication Data {
			get {return _Data;}
			}


		public void Refresh () {
			if (Dialog != null) {
				Dialog.Refresh ();
				}
			}

//		protected Wizard_SampleApplication  _Wizard;	
//		public Wizard_SampleApplication  Wizard {
//				get {return _Wizard;}
//				}
//		public Data_SampleApplication  Data {
//				get {return Wizard.Data;}
//				}

		// Input backing variables
		string _Input_DomainName;
		public string Input_DomainName {
            get { return _Input_DomainName; }
            set { _Input_DomainName = value;  Refresh (); }
            }
		string _Input_Username;
		public string Input_Username {
            get { return _Input_Username; }
            set { _Input_Username = value;  Refresh (); }
            }
		string _Input_Password;
		public string Input_Password {
            get { return _Input_Password; }
            set { _Input_Password = value;  Refresh (); }
            }

		// Output backing variables



		/// <summary>
		/// Here goes the action to be overriden
		/// </summary>

		public virtual bool AcceptPassword () {
			return true;
			}

		/// <summary>
		/// Here goes the action to be overriden
		/// </summary>

		public virtual bool CancelPassword2 () {
			return true;
			}


		}

    public partial class PasswordDialog : _Data_PasswordDialog {

		
		public PasswordDialog (SampleApplication  Data) {
			_Data = Data;

			// NB call to the initializer before we creaate the dialog so the
			// dialog can display the initialized data.
			Initialize ();
			this.Dialog = new Dialog_PasswordDialog (this);
			}
		}


    /// <summary>
	/// This is the code behind for the XAML generated class.
    /// </summary>
    public partial class Dialog_PasswordDialog : Page {

		public PasswordDialog  Data;


		public Dialog_PasswordDialog (PasswordDialog Data) {
			InitializeComponent();
			this.Data = Data;
			Refresh ();

			}

		public void Refresh () {
			Input_DomainName.Text  = Data.Input_DomainName;
			Input_Username.Text  = Data.Input_Username;
			Input_Password.Text  = Data.Input_Password;
			}

        private void Action_AcceptPassword(object sender, RoutedEventArgs e) {
			var Result = Data.AcceptPassword ();
			if (Result) {
				Data.Data.Navigate (Data.Data.Data_SelectApplication);
				}
            }
        private void Action_CancelPassword2(object sender, RoutedEventArgs e) {
			var Result = Data.CancelPassword2 ();
			if (Result) {
				Data.Data.Navigate (Data.Data.Data_SelectApplication);
				}
            }


		private void Changed_Input_DomainName (object sender, TextChangedEventArgs e) {
			Data.Input_DomainName = Input_DomainName.Text;
			}
		private void Changed_Input_Username (object sender, TextChangedEventArgs e) {
			Data.Input_Username = Input_Username.Text;
			}
		private void Changed_Input_Password (object sender, TextChangedEventArgs e) {
			Data.Input_Password = Input_Password.Text;
			}

		}
	}
