using  System.Text;
using  Goedel.Mesh;
using  Goedel.Confirm;
using  Goedel.Protocol;
using  Goedel.Protocol.Debug;
using System;
using System.IO;
using System.Collections.Generic;
using Goedel.Registry;
namespace RunMeshApps {
	public partial class ExampleGenerator : global::Goedel.Registry.Script {

		  TraceDictionary Traces;
		

		//
		// MakeExamplesConfirm
		//
		public void MakeExamplesConfirm (MakeExamples MakeExamples) {
			 Traces = MakeExamples.ConfirmPortal.Traces;
			 Traces.Level = 0;
			 var Point = Traces.Get (MakeExamples.ConfirmPostRequest);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("#Confirmation Protocol\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("(Configuration).\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("##Creating a confirmation profile\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("[First step is to create a mesh profile and add a confirmation profile.\n{0}", _Indent);
			_Output.Write ("This is not currently supported by the reference code, the implementation\n{0}", _Indent);
			_Output.Write ("uses the device profile instead.]\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("##Posting a request\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("An Enquirer initiates a confirmation request using the EnquireRequest \n{0}", _Indent);
			_Output.Write ("message. This specifies the request to be posted, the account to which \n{0}", _Indent);
			_Output.Write ("it is posted and (optionally) the time at which the enquirer has no\n{0}", _Indent);
			_Output.Write ("further interest in receiving a response.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The signed request is a JsonWebSignature object that contains a payload \n{0}", _Indent);
			_Output.Write ("of type TBSRequest that specifies the confirmation text to be presented\n{0}", _Indent);
			_Output.Write ("to the user in SRML format, the account identifier of the requestor and\n{0}", _Indent);
			_Output.Write ("the account identifier as the responder. The TBSRequest object MAY be \n{0}", _Indent);
			_Output.Write ("encrypted.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The Responder identifier is thus specified in two separate places, in\n{0}", _Indent);
			_Output.Write ("the signed TBSRequest and in the enclosing EnquireRequest message. Following\n{0}", _Indent);
			_Output.Write ("the terminology introduced to describe the SMTP protocol, these \n{0}", _Indent);
			_Output.Write ("correspond to the 'Message to' and 'Envelope to' addresses respectively.\n{0}", _Indent);
			_Output.Write ("Separating these two functions is useful because it allows the unsigned \n{0}", _Indent);
			_Output.Write ("envelope to address to be modified to support request routing capabilities \n{0}", _Indent);
			_Output.Write ("such as aliases and group addresses while maintaining the ability to \n{0}", _Indent);
			_Output.Write ("authenticate the message to address.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("For example, a party claiming to be 'Bob' calls Alice asking her to open\n{0}", _Indent);
			_Output.Write ("the pod bay doors. Following procedure, Alice requires Bob to provide a non-repudiable\n{0}", _Indent);
			_Output.Write ("confirmation of this request. Accordingly, she uses her confirmation account\n{0}", _Indent);
			_Output.Write ("{1} to post a request to Bob's confirmation\n{0}", _Indent, MakeExamples.AliceConfirmAccount);
			_Output.Write ("account {1} asking him to confirm the action.\n{0}", _Indent, MakeExamples.BobConfirmAccount);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("Alice uses the client supplied by the reference implementation to post this \n{0}", _Indent);
			_Output.Write ("request. This client does not form part of the normative Mesh/Confirm \n{0}", _Indent);
			_Output.Write ("specification and is used here purely to illustrate the information that\n{0}", _Indent);
			_Output.Write ("a user or script needs to pass to request a transaction.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The console command is:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, MakeExamples.AlicePostConfirm);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The TBSRequest is:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("$$$$ extract TBS part here.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The HTTP request message is:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[0].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("A confirmation service SHOULD perform some form of request filtering\n{0}", _Indent);
			_Output.Write ("to prevent abuse (e.g. spam, denial of service). In this case the request \n{0}", _Indent);
			_Output.Write ("comes from a user with a local account which is implictly authorized to\n{0}", _Indent);
			_Output.Write ("post request messages without limit.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The confirmation service verifies the signature on the request and \n{0}", _Indent);
			_Output.Write ("returns a response message specifying the broker identifier.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[1].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("[Note that for the sake of concise presentation, the HTTP binding\n{0}", _Indent);
			_Output.Write ("information is omitted from future examples.]\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			 Traces.Level = 5;
			  Point = Traces.Get (MakeExamples.ConfirmStatusFail);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("##Obtaining request status.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("Having posted a request, the enquirer needs to discover the result. Since\n{0}", _Indent);
			_Output.Write ("the protocol assumes that the response will be posted by a person rather\n{0}", _Indent);
			_Output.Write ("than a machine, it is likely that there will be a delay of several seconds\n{0}", _Indent);
			_Output.Write ("at least and possibly many minutes. For certain types of confirmation, the \n{0}", _Indent);
			_Output.Write ("responder might take hours or even days.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("A status request is posted using the StatusRequest message. The enquirer \n{0}", _Indent);
			_Output.Write ("specifies the BrokerID of the request being enquired of.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[0].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The service responds with the status of the request and the Responder's response\n{0}", _Indent);
			_Output.Write ("if they have replied. The first time the enquirer asks, the request is still\n{0}", _Indent);
			_Output.Write ("pending:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[1].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("When the enquirer repeats the status request a short time later, the responder\n{0}", _Indent);
			_Output.Write ("has posted a response. The service returns the response message returned:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			  Point = Traces.Get (MakeExamples.ConfirmStatusSuccess);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[1].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("##List pending requests.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("From the enquirer's point of view, the confirmation protocol is like a very limited\n{0}", _Indent);
			_Output.Write ("version of email.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The enquirer periodically polls the confirmation service to retrieve a list of \n{0}", _Indent);
			_Output.Write ("pending messages using ther PendingRequest message.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			  Point = Traces.Get (MakeExamples.ConfirmPending);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[0].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The response contains a list of pending responses:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[1].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("##Post a response\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The responder posts their response using the RespondRequest message. This contains a\n{0}", _Indent);
			_Output.Write ("ResponseEntry object which contains the response status and the signed response.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The payload of the signed response is a TBSResponse message which contains the \n{0}", _Indent);
			_Output.Write ("signed request and the response value. Currently only Accept/Reject confirmations\n{0}", _Indent);
			_Output.Write ("are supported and the response value is returnes as a boolean.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The TBSResponse object is:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("$$$$$ TBS extract\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The request message is:\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			  Point = Traces.Get (MakeExamples.ConfirmRespond);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[2].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("The response value contains only the status code and description showing the success \n{0}", _Indent);
			_Output.Write ("or failure of the request.\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("{1}\n{0}", _Indent, Point.Messages[3].String());
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			_Output.Write ("\n{0}", _Indent);
			}
		}
	}