using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Granicus.MediaManager.SDK
{
    using System;
    using System.Net;
    using System.Web.Services.Protocols;

    #region OutcastEncoder Class
    /// <summary>
    /// Allows interaction with an Outcast Encoder.
    /// </summary>
    /// <remarks>
    /// The OutcastEncoder class is used for any and all interactions with the Outcast Encoder architecture component 
    /// (also referred to as a MeetingServer, or simply an encoder).  The OutcastEncoder object allows you to list meetings
    /// that are currently on the encoder, load meeting agendas, close meetings, start/stop meetings, as well as index items.
    /// <para/>
    /// After creating an OutcastEncoder object, the basic steps to use the OutcastEncoder are:
    /// <list type="number">
    /// <item><description><b>GetStatus</b> - Get the <see cref="Granicus.MediaManager.SDK.EncoderStatus"/> of the encoder to
    /// determine its current state. Be sure to determine whether or not the web service is connected to the encoder by checking
    /// the <see cref="Granicus.MediaManager.SDK.EncoderStatus.ConnectedToMeetingServer"/> property. If the web service
    /// is not connected to the encoder all subsequent calls to the service will fail.
    /// </description></item>
    /// <item><description><b>GetDocuments</b> - Get a list of <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> objects
    /// to determine which meeting to run.
    /// </description></item>
    /// <item><description><b>LoadMeeting</b> - Configures the encoder so that it is ready to start archiving video and indexing items.</description></item>
    /// <item><description><b>StartMeeting</b> - Starts video archiving and/or broadcasting.</description></item>
    /// <item><description><b>RecordItem</b> - Used to add indexed items to the archive. These items are stored in the minutes document which is referenced by the video archive.</description></item>
    /// <item><description><b>StopMeeting</b> - Stops the archiving process and causes the final video archive to be uploaded to Granicus.</description></item>
    /// <item><description><b>CloseMeeting</b> - Resets the state of the meeting server.</description></item>
    /// </list>
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "MeetingServerWebServiceSoap", Namespace = "http://granicus.com/lacity/")]
    public class OutcastEncoder : SoapHttpClientProtocol, IMeetingServer
    {
        #region Constants
        private const string m_urlSuffix = "/Outcast/meetingserverwebservice.asmx";
        private const string m_cookieName = "PHPSESSID";
        #endregion

        #region Private Member Variables
        private bool m_Connected = false;
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.OutcastEncoder"/> class.
        /// </summary>
        public OutcastEncoder()
        {
            this.Url = "http://10.100.0.32/outcast/meetingserverwebservice.asmx";
        }
        #endregion

        #region Base Class Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri uri)
        {
            HttpWebRequest webRequest = (HttpWebRequest)base.GetWebRequest(uri);
            webRequest.KeepAlive = false;
            webRequest.Timeout = base.Timeout;
            return webRequest;
        }
        #endregion

        #region Private Utility Methods
        /// <summary>
        /// Converts cameradata into complete url useful to base
        /// webservices.
        /// </summary>
        /// <param name="Camera">CameraData object.</param>
        /// <returns></returns>
        private string m_SafeServerURL(CameraData Camera)
        {
            return "http://" + Camera.InternalIP + ":" + Camera.ControlPort + m_urlSuffix;
        }
        #endregion

        #region Connection Methods
        /// <summary>
        /// Read only property that indicates whether or not the OutcastEncoder instance is currently connected to an encoder.
        /// </summary>
        public bool Connected
        {
            get
            {
                return this.m_Connected;
            }
        }

        /// <summary>
        /// Connects the OutcastEncoder instance to the given Camera using the given ImpersonationToken.
        /// </summary>
        /// <remarks>
        /// It is recommended that you use <see cref="Granicus.MediaManager.SDK.MediaManager.GetOutcastEncoder(Granicus.MediaManager.SDK.CameraData)"/> instead of
        /// creating and connecting the object on your own.
        /// </remarks>
        /// <param name="Camera">CameraData object that represents the desired Camera.</param>
        /// <param name="ImpersonationToken">Valid ImpersonationToken.</param>
        public void Connect(CameraData Camera, string ImpersonationToken)
        {
            base.Url = m_SafeServerURL(Camera);
            this.m_Connected = true;
        }

        /// <summary>
        /// Disconnects the OutcastEncoder instance from any camera it was previously connected to.
        /// </summary>
        public void Disconnect()
        {
            this.m_Connected = false;
        }
        #endregion

        #region Web Service Proxy Methods
        
        /// <summary>
        /// Loads a meeting by DocumentID.
        /// </summary>
        /// <remarks>
        /// This method is used to prepare the encoder for running a meeting.  LoadMeeting loads the meeting from the server,
        /// creates a new Agenda Document and Minutes Document, and assigns the documents to the encoder.  To load a meeting,
        /// first retrieve a list of the available meetings by calling 
        /// <see cref="Granicus.MediaManager.SDK.OutcastEncoder.GetDocuments"/>.  From the list, determine which meeting to load
        /// and pass the DocumentID from the <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> object to 
        /// <see cref="Granicus.MediaManager.SDK.OutcastEncoder.LoadMeeting"/>.  If the meeting fails to load, an exception will be
        /// thrown.
        /// </remarks>
        /// <param name="documentId"></param>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/LoadMeeting", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LoadMeeting([System.Xml.Serialization.XmlElementAttribute(ElementName = "documentId")] string documentId)
        {
            this.Invoke("LoadMeeting", new object[] {
                        documentId});
        }

        /// <summary>
        /// Closes a meeting.
        /// </summary>
        /// <remarks>
        /// This method removes the documents assigned to the encoder, and stops the encoder archival process.  It is not necessary
        /// to call this method after a meeting has been stopped, but it has been made available so that client applications have the
        /// ability to reset the state of the encoder after running a meeting.
        /// </remarks>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/CloseMeeting", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CloseMeeting()
        {
            this.Invoke("CloseMeeting", new object[0]);
        }

        /// <summary>
        /// Retreives a list of <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> objects that can be loaded by the
        /// encoder.
        /// </summary>
        /// <remarks>
        /// <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> objects represent meetings that can be loaded into
        /// the encoder.
        /// </remarks>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> objects.</returns>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/GetDocuments", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MeetingDocumentHeader[] GetDocuments()
        {
            object[] results = this.Invoke("GetDocuments", new object[0]);
            return ((MeetingDocumentHeader[])(results[0]));
        }

        /// <summary>
        /// Gets the status of the encoder.
        /// </summary>
        /// <remarks>
        /// This method will only throw an exception if there is a communications or network problem. If an error occurs, 
        /// it will be logged and an 
        /// empty <see cref="Granicus.MediaManager.SDK.EncoderStatus"/> object will be returned. 
        /// </remarks>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.EncoderStatus"/> object that represents the encoder's current state.</returns>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/GetStatus", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public EncoderStatus GetStatus()
        {
            object[] results = this.Invoke("GetStatus", new object[0]);
            return ((EncoderStatus)(results[0]));
        }

        /// <summary>
        /// Starts a meeting.
        /// </summary>
        /// <remarks>
        /// This method enables archiving and/or broadcasting for the currently loaded.
        /// A meeting must be loaded before calling this method.</remarks>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/StartMeeting", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StartMeeting()
        {
            this.Invoke("StartMeeting", new object[0]);
        }

        /// <summary>
        /// Pauses a meeting.
        /// </summary>
        /// <remarks>
        /// This method disables archiving for a meeting but keeps it running, placing it in a paused state.
        /// A meeting must be loaded and started before calling this method.</remarks>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/PauseMeeting", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void PauseMeeting()
        {
            this.Invoke("PauseMeeting", new object[0]);
        }

        /// <summary>
        /// Extends a meeting.
        /// </summary>
        /// <remarks>
        /// This extends a meeting by adding the given number of seconds to the meeting time.
        /// A meeting must be loaded and started before calling this method.</remarks>
        /// <param name="seconds">The number of seconds to extend the meeting.</param>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/ExtendMeeting", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExtendMeeting([System.Xml.Serialization.XmlElementAttribute(ElementName = "seconds")] int seconds)
        {
            this.Invoke("ExtendMeeting", new object[] {
                        seconds});
        }

        /// <summary>
        /// Stops the currently running meeting.
        /// </summary>
        /// <remarks>
        /// Stops the current meeting, which will also stop archiving and/or broadcasting.  A meeting must be started before calling
        /// this method.
        /// </remarks>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/StopMeeting", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StopMeeting()
        {
            this.Invoke("StopMeeting", new object[0]);
        }

        /// <summary>
        /// Adds an (time stamped) item to the minutes document on the encoder.
        /// </summary>
        /// <remarks>
        /// Call this method to add a indexed (time stamped) item to the minutes document 
        /// in the video. This method cannot be called unless a meeting is loaded and running. 
        /// <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> can be suspended by 
        /// calling <see cref="Granicus.MediaManager.SDK.OutcastEncoder.SetSuspendRecordItem"/> and passing true 
        /// as its parameter. To determine if <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> 
        /// has been suspended, call <see cref="Granicus.MediaManager.SDK.OutcastEncoder.GetStatus"/> and check 
        /// the <see cref="Granicus.MediaManager.SDK.EncoderStatus.SuspendRecordItem"/> value. 
        /// </remarks>
        /// <param name="body">Text content that represents the name or title of the recorded item.</param>
        /// <param name="foreignId">An ID derived from an integrated system.</param>
        /// <returns>A string representation of the GUID for the item added to the minutes document.</returns>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/RecordItem", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RecordItem([System.Xml.Serialization.XmlElementAttribute(ElementName = "body")] string body, [System.Xml.Serialization.XmlElementAttribute(ElementName = "foreignId")] string foreignId)
        {
            object[] results = this.Invoke("RecordItem", new object[] {
                        body,
                        foreignId});
            return ((string)(results[0]));
        }


        /// <summary>
        /// Activates (time-stamps) an existing item in the agenda and adds it to the minutes document on the encoder.
        /// </summary>
        /// <remarks>
        /// Call this method to index (time stamp) an existing item in the agenda/minutes. 
        /// This method cannot be called unless a meeting is loaded and running. 
        /// <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> can be suspended by 
        /// calling <see cref="Granicus.MediaManager.SDK.OutcastEncoder.SetSuspendRecordItem"/> and passing true 
        /// as its parameter. To determine if <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> 
        /// has been suspended, call <see cref="Granicus.MediaManager.SDK.OutcastEncoder.GetStatus"/> and check 
        /// the <see cref="Granicus.MediaManager.SDK.EncoderStatus.SuspendRecordItem"/> value. 
        /// </remarks>
        /// <param name="foreignId">An ID derived from an integrated system.</param>
        /// <returns>A string representation of the GUID for the item added to the minutes document.</returns>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/ActivateItem", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ActivateItem([System.Xml.Serialization.XmlElementAttribute(ElementName = "foreignId")] string foreignId)
        {
            object[] results = this.Invoke("ActivateItem", new object[] {
                        foreignId});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Adds a non-indexed (not time stamped) item to the minutes document on the encoder.
        /// </summary>
        /// <remarks>
        /// Call this method to add a non-indexed (not time stamped) item to the minutes document 
        /// in the video. This method cannot be called unless a meeting is loaded and running. 
        /// <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordNonIndexedItem"/> can be suspended by 
        /// calling <see cref="Granicus.MediaManager.SDK.OutcastEncoder.SetSuspendRecordItem"/> and passing true 
        /// as its parameter. To determine if <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordNonIndexedItem"/> 
        /// has been suspended, call <see cref="Granicus.MediaManager.SDK.OutcastEncoder.GetStatus"/> and check 
        /// the <see cref="Granicus.MediaManager.SDK.EncoderStatus.SuspendRecordItem"/> value. 
        /// </remarks>
        /// <param name="body">Text content that represents the name or title of the recorded item.</param>
        /// <param name="foreignId">An ID derived from an integrated system.</param>
        /// <returns>A string representation of the GUID for the item added to the minutes document.</returns>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/RecordNonIndexedItem", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RecordNonIndexedItem([System.Xml.Serialization.XmlElementAttribute(ElementName = "body")] string body, [System.Xml.Serialization.XmlElementAttribute(ElementName = "foreignId")] string foreignId)
        {
            object[] results = this.Invoke("RecordNonIndexedItem", new object[] {
                        body,
                        foreignId});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Suspends action taken by RecordItem.
        /// </summary>
        /// <remarks>
        /// This method allow the client application to control whether <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> 
        /// adds an indexed item to the archive. When <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> 
        /// is suspended, <see cref="Granicus.MediaManager.SDK.OutcastEncoder.RecordItem"/> method calls succeed, 
        /// but the item isn't actually recorded. To determine the current state of 
        /// <see cref="Granicus.MediaManager.SDK.EncoderStatus.SuspendRecordItem"/>, use the 
        /// <see cref="Granicus.MediaManager.SDK.OutcastEncoder.GetStatus"/> method to retrieve the Status of the server and check the 
        /// <see cref="Granicus.MediaManager.SDK.EncoderStatus.SuspendRecordItem"/> member. 
        /// </remarks>
        /// <param name="value">Whether or not actions should be suspended.  True to suspend recorded actions, false to allow.</param>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/lacity/SetSuspendRecordItem", RequestNamespace = "http://granicus.com/lacity/", ResponseNamespace = "http://granicus.com/lacity/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetSuspendRecordItem([System.Xml.Serialization.XmlElementAttribute(ElementName = "value")] bool value)
        {
            this.Invoke("SetSuspendRecordItem", new object[] {
                        value});
        }
        #endregion
    }
    #endregion
}
