namespace Granicus.MediaManager.SDK
{
    using System;
    using System.Net;
    using System.Web.Services.Protocols;
    using System.IO;
    

    #region Async Method Event Handlers and EventArgs Classes
    /// <summary>
    /// Delegate for handling file upload complete events from asynchronous calls to <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/>
    /// </summary>
    /// <param name="sender">Object firing the event.</param>
    /// <param name="e">The event arguments.</param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    public delegate void UploadFileCompletedEventHandler(object sender, UploadFileCompletedEventArgs e);

    /// <summary>
    /// Delegate for handling file trim complete events from asynchronous calls to <see cref="Granicus.MediaManager.SDK.MediaVault.TrimClip(int,int,int)"/>
    /// </summary>
    /// <param name="sender">Object firing the event.</param>
    /// <param name="e">The event arguments.</param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    public delegate void TrimClipCompletedEventHandler(object sender, TrimClipCompletedEventArgs e);

    /// <summary>
    /// Container class for the results of the asynchronous call to <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal UploadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <summary>
        /// The result of the call to <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/> the UploadFile method.
        /// </summary>
        public int Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }

    /// <summary>
    /// Container class for the results of the asynchronous call to <see cref="Granicus.MediaManager.SDK.MediaVault.TrimClip(int,int,int)"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TrimClipCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal TrimClipCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <summary>
        /// The result of the call to <see cref="Granicus.MediaManager.SDK.MediaVault.TrimClip(int,int,int)"/> the TrimClip method. This will return null
        /// or throw an exception if the call failed.
        /// </summary>
        public object Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                // TrimClip returns void, so we won't have any results. 
                return null;
            }
        }
    }

    #endregion

    #region MediaVault Class
    /// <summary>
    /// Allows interaction with a MediaVault.
    /// </summary>
    /// <remarks>
    /// The <see cref="Granicus.MediaManager.SDK.MediaVault"/> class is used for an and all interaction with the MediaVault 
    /// architecture component.  The <see cref="Granicus.MediaManager.SDK.MediaVault"/> object allows you to upload new files
    /// to the system and work with video files directly.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "MediaVaultSDKServiceProxySoap", Namespace = "http://granicus.com/MediaVault/SDK")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public class MediaVault : SoapHttpClientProtocol, IMediaVault
    {
        #region Constants
        private const string m_urlSuffix = "/MediaVault/SDK.asmx";
        private const string m_cookieName = "PHPSESSID";
        #endregion

        #region Private Member Variables
        private bool m_Connected = false;
        private SecurityHeader securityHeaderValue;

        private System.Threading.SendOrPostCallback UploadFileOperationCompleted;

        private System.Threading.SendOrPostCallback TrimClipOperationCompleted;

        #endregion

        #region Internal Security Header
        /// <summary>
        /// The SecurityHeader currently in use by the MediaVault.  This property is used internally.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "SecurityHeaderValue")]
        public SecurityHeader SecurityHeaderValue
        {
            get
            {
                return this.securityHeaderValue;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("SecurityHeaderValue");
                }
                if ((this.securityHeaderValue != value))
                {
                    this.securityHeaderValue = value;
                }
            }
        }
        #endregion

        #region Events
        
        /// <summary>
        /// This event indicates when an asynchronous call to <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/> has completed.
        /// </summary>
        public event UploadFileCompletedEventHandler UploadFileCompleted;

        /// <summary>
        /// This event indicates when an asynchronous call to <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/> has completed.
        /// </summary>
        public event TrimClipCompletedEventHandler TrimClipCompleted;


        #endregion

        #region Constructors
         
        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MediaVault"/> class.
        /// </summary>
        public MediaVault()
        {
            this.Url = "http://mediaserver-102.granicus.com:443/MediaVault/SDK.asmx";
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

        /// <summary>
        /// Cancels an asynchronous call to an XML Web service method, unless the call has already completed.
        /// </summary>
        /// <param name="userState"></param>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
        #endregion

        #region Private Utility Methods
        /// <summary>
        /// Converts server name (i.e. streaming.granicus.com) into complete url useful to base
        /// webservices.
        /// </summary>
        /// <param name="Server">Server Name (i.e. streaming.granicus.com)</param>
        /// <returns></returns>
        private string m_SafeServerURL(ServerInterfaceData Server)
        {
            if (!Server.Host.StartsWith("http://"))
            {
                Server.Host = "http://" + Server.Host;
            }
            if (Server.Host.EndsWith("/"))
            {
                Server.Host.TrimEnd("/".ToCharArray());
            }
            return Server.Host + ":" + Server.ControlPort + m_urlSuffix;
        }
        #endregion

        #region Connection Methods

        /// <summary>
        /// Read-only property that indicates whether or not the MediaVault object is currently connected.
        /// </summary>
        public bool Connected
        {
            get
            {
                return this.m_Connected;
            }
        }
 
        /// <summary>
        /// Connects the MediaVault instance to the given ServerInterface on the given MediaManager site using the given 
        /// ImpersonationToken.
        /// </summary>
        /// <remarks>
        /// It is recommended that you use 
        /// <see cref="Granicus.MediaManager.SDK.MediaManager.GetMediaVault(Granicus.MediaManager.SDK.ServerInterfaceData)"/> 
        /// or <see cref="Granicus.MediaManager.SDK.MediaManager.GetMediaVault(int)"/> to connect to 
        /// a MediaVault rather than connecting it manually yourself.
        /// </remarks>
        /// <param name="Server">The ServerInterface that the MediaVault object should be connected to.</param>
        /// <param name="MediaManagerServer">The MediaVault site that the ServerInterface was retrieved from.</param>
        /// <param name="ImpersonationToken">A valid ImpersonationToken.</param>
        public void Connect(ServerInterfaceData Server, string MediaManagerServer, string ImpersonationToken)
        {
            base.Url = m_SafeServerURL(Server);
            SecurityHeaderValue = new SecurityHeader();
            SecurityHeaderValue.ServiceHost = MediaManagerServer;
            SecurityHeaderValue.SecurityToken = ImpersonationToken;
            this.m_Connected = true;
        }

        /// <summary>
        /// Disconnects the MediaVault instance from the server interface it is currently connected to.
        /// </summary>
        public void Disconnect()
        {
            this.m_Connected = false;
        }
        #endregion

        #region Helper Methods

        /// <summary>
        /// Uploads the file at the given location to the MediaVault as a new video file.
        /// </summary>
        /// <param name="FolderID">The folder in which to place the file.</param>
        /// <param name="NewFileName">The name of the new file.</param>
        /// <param name="UploadFilePath">The path of the file to be uploaded.</param>
        /// <returns>The new Clip ID created for the uploaded file.</returns>
        public int UploadFile(int FolderID, string NewFileName, string UploadFilePath)
        {
            FileStream fs = new FileStream(UploadFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int length = (int)new FileInfo(UploadFilePath).Length;
            byte[] filecontents = new byte[length];
            br.Read(filecontents, 0, length);
            return UploadFile(FolderID, NewFileName, filecontents);
        }

        #endregion

        #region Web Service Proxy Methods
        /// <summary>
        /// Uploads the given file data to the MediaVault as a new video file.
        /// </summary>
        /// <param name="FolderID">The folder in which to place the file.</param>
        /// <param name="NewFileName">The name of the new file.</param>
        /// <param name="bytes">A byte array the represents the entire file contents.</param>
        /// <returns>The new Clip ID created for the uploaded file.</returns>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/UploadFile", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UploadFile([System.Xml.Serialization.XmlElementAttribute(ElementName = "FolderID")] int FolderID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "NewFileName")] string NewFileName, [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", ElementName = "bytes")] byte[] bytes)
        {
            object[] results = this.Invoke("UploadFile", new object[] {
                        FolderID,
                        NewFileName,
                        bytes});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Makes an asynchronous call to the <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/> method.
        /// </summary>
        /// <param name="folderID">The folder to place the new file.</param>
        /// <param name="newFileName">The name of the new file.</param>
        /// <param name="bytes">A byte array representing the contents of the new file.</param>
        public void UploadFileAsync(int folderID, string newFileName, byte[] bytes)
        {
            this.UploadFileAsync(folderID, newFileName, bytes, null);
        }

        /// <summary>
        /// Makes an asynchronous call to the <see cref="Granicus.MediaManager.SDK.MediaVault.UploadFile(int,string,string)"/> method.
        /// </summary>
        /// <param name="folderID">The folder to place the new file.</param>
        /// <param name="newFileName">The name of the new file.</param>
        /// <param name="bytes">A byte array representing the contents of the new file.</param>
        /// <param name="userState">An object used to pass state information into the callback delegate.</param>
        public void UploadFileAsync(int folderID, string newFileName, byte[] bytes, object userState)
        {
            if ((this.UploadFileOperationCompleted == null))
            {
                this.UploadFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadFileOperationCompleted);
            }
            this.InvokeAsync("UploadFile", new object[] {
                        folderID,
                        newFileName,
                        bytes}, this.UploadFileOperationCompleted, userState);
        }

        private void OnUploadFileOperationCompleted(object arg)
        {
            if ((this.UploadFileCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadFileCompleted(this, new UploadFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// Starts the upload process by creating a new temporary upload "bucket" on the server for sending chunks.
        /// </summary>
        /// <returns>The GUID of the upload "bucket" created on the server.</returns>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/StartUpload", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string StartUpload()
        {
            object[] results = this.Invoke("StartUpload", new object[0]);
            return ((string)(results[0]));
        }

        /// <summary>
        /// Uploads a file chunk to the server.
        /// </summary>
        /// <param name="GUID">The GUID of the upload "bucket" returned by StartUpload.</param>
        /// <param name="ChunkPosition">The position in the file to begin writing the chunk.</param>
        /// <param name="bytes">A byte array representing the contents of the chunk.</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/SendChunk", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendChunk([System.Xml.Serialization.XmlElementAttribute(ElementName = "GUID")] string GUID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "ChunkPosition")] long ChunkPosition, [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", ElementName = "bytes")] byte[] bytes)
        {
            object[] results = this.Invoke("SendChunk", new object[] {
                        GUID,
                        ChunkPosition,
                        bytes});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Completes the upload process for a given file, closing the upload "bucket".
        /// </summary>
        /// <param name="GUID">The GUID of the upload "bucket" returned by StartUpload.</param>
        /// <returns>A checksum of the file received.</returns>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/FinishUpload", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long FinishUpload([System.Xml.Serialization.XmlElementAttribute(ElementName = "GUID")] string GUID)
        {
            object[] results = this.Invoke("FinishUpload", new object[] {
                        GUID});
            return ((long)(results[0]));
        }

        /// <summary>
        /// Aborts an upload in processing, deleting the contents of the upload "bucket" and destroying it.
        /// </summary>
        /// <param name="GUID">The GUID of the upload "bucket" returned by StartUpload.</param>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/AbortUpload", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AbortUpload([System.Xml.Serialization.XmlElementAttribute(ElementName = "GUID")] string GUID)
        {
            this.Invoke("AbortUpload", new object[] {
                        GUID});
        }

        /// <summary>
        /// Assigns an uploaded file to a clip.
        /// </summary>
        /// <param name="GUID">The GUID of the upload "bucket" for a completed upload.</param>
        /// <param name="ClipUID">The GUID of the clip to assign the new file to.</param>
        /// <param name="Extension">The extension to assign to the file.  i.e. "wmv"</param>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/AssignUploadedFile", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AssignUploadedFile([System.Xml.Serialization.XmlElementAttribute(ElementName = "GUID")] string GUID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "ClipUID")] string ClipUID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "Extension")] string Extension)
        {
            this.Invoke("AssignUploadedFile", new object[] {
                        GUID,
                        ClipUID,
                        Extension});
        }

        /// <summary>
        /// Creates a new clip for an uploaded file.
        /// </summary>
        /// <param name="GUID">The GUID of the upload "bucket" for a completed upload.</param>
        /// <param name="FolderID">The ID of the folder in which to place the new file.</param>
        /// <param name="Name">The name of the new clip.</param>
        /// <param name="Extension">The extension to assign to the file. i.e. "wmv"</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/RegisterUploadedFile", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int RegisterUploadedFile([System.Xml.Serialization.XmlElementAttribute(ElementName = "GUID")] string GUID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "FolderID")] int FolderID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "Name")] string Name, [System.Xml.Serialization.XmlElementAttribute(ElementName = "Extension")] string Extension)
        {
            object[] results = this.Invoke("RegisterUploadedFile", new object[] {
                        GUID,
                        FolderID,
                        Name,
                        Extension});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Trims a video clip to the desired length.
        /// </summary>
        /// <param name="ClipID">The ID of the clip we want to trim.</param>
        /// <param name="StartSeconds">The start time of the new clip relative to the old clip, in seconds.</param>
        /// <param name="EndSeconds">The end time of the new clip relative to the old clip, in seconds</param>
        [System.Web.Services.Protocols.SoapHeaderAttribute("SecurityHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://granicus.com/MediaVault/SDK/TrimClip", RequestNamespace = "http://granicus.com/MediaVault/SDK", ResponseNamespace = "http://granicus.com/MediaVault/SDK", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void TrimClip([System.Xml.Serialization.XmlElementAttribute(ElementName = "ClipID")] int ClipID, [System.Xml.Serialization.XmlElementAttribute(ElementName = "StartSeconds")] int StartSeconds, [System.Xml.Serialization.XmlElementAttribute(ElementName = "EndSeconds")] int EndSeconds)
        {
            object[] results = this.Invoke("TrimClip", new object[] {
                        ClipID,
                        StartSeconds,
                        EndSeconds});
        }
        /// <summary>
        /// Makes an asynchronous call to the <see cref="Granicus.MediaManager.SDK.MediaVault.TrimClip(int,int,int)"/> method.
        /// </summary>
        /// <param name="ClipID">The ID of the clip we want to trim.</param>
        /// <param name="StartSeconds">The start time of the new clip relative to the old clip, in seconds.</param>
        /// <param name="EndSeconds">The end time of the new clip relative to the old clip, in seconds</param>
        /// <param name="userState">An object used to pass state information into the callback delegate.</param>
        public void TrimClipAsync(int ClipID, int StartSeconds, int EndSeconds, object userState)
        {
            if ((this.TrimClipOperationCompleted == null))
            {
                this.TrimClipOperationCompleted = new System.Threading.SendOrPostCallback(this.TrimClipOperationCompleted);
            }
            this.InvokeAsync("TrimClip", new object[] {
                        ClipID,
                        StartSeconds,
                        EndSeconds}, this.TrimClipOperationCompleted, userState);
        }

        private void OnTrimClipOperationCompleted(object arg)
        {
            if ((this.UploadFileCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TrimClipCompleted(this, new TrimClipCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        #endregion 
    }
    #endregion
}
