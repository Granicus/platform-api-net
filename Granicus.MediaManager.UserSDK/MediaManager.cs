namespace Granicus.MediaManager.SDK
{
    using System;
    using System.Net;
    using System.Web.Services.Protocols;
    using System.Collections;
    using System.Security.Cryptography;
    using System.IO;
    using System.Threading;


    #region MediaManagerSDKService Class
    /// <summary>
    /// Deprecated class. Do not use.
    /// </summary>
    [System.Obsolete("This class is deprecated, please use the MediaManager class instead.")]
    public class MediaManagerSDKService : MediaManager
    {
    }
    #endregion

    #region MediaManager Class
    /// <summary>
    /// Allows interaction with the MediaManager web-based application.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The MediaManager class is the core of the Granicus SDK 1.1. It is a proxy to the web services hosted by
    /// the Granicus MediaManager web application, and provides access to core methods for manipulating data
    /// elements and objects in the system.</para>
    /// <para>
    /// You can use the MediaManager class to create new Events, Cameras, Users, and Groups, as well as to upload new files,
    /// and manipulate Agendas and Minutes within the system.</para>
    /// <para>
    /// Using the MediaManager class requires a valid username and password to a properly configured MediaManager site.</para>
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.312")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "UserSDKBinding", Namespace = "urn:UserSDK")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(Motion))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(AttendeeStatus))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(Rollcall))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(VoteRecord))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(VoteEntry))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(Note))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(Document))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TrainingChapter))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(PracticeQuestion))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(AgendaItem))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(KeyMapping))]
    //[System.Xml.Serialization.SoapIncludeAttribute(typeof(CaptionData))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(Attendee))]
    public class MediaManager : SoapHttpClientProtocol, IMediaManager
    {

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MediaManager"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor does not connect you to an instance of MediaManager and therefore is not usable
        /// until the <see cref="Granicus.MediaManager.SDK.MediaManager.Connect"/> method has been called.
        /// </remarks>
        public MediaManager()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolTypeExtensions.Tls12;
            this.Url = "https://javiervista/SDK/User/index.php";
            this.CookieContainer = new CookieContainer();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MediaManager"/> class and connects it
        /// to the provided MediaManager site.
        /// </summary>
        /// This constructor automatically connects to the given MediaManager site, using the given username and password
        /// combination.  If the connection fails, an exception will be thrown.
        /// <param name="Server">The MediaManager site (e.g. client.granicus.com) to connect to.</param>
        /// <param name="Username">The username (e.g. johnsmith) to connect with.</param>
        /// <param name="Password">The password (e.g. secret) that matches the given username record.</param>
        public MediaManager(string Server, string Username, string Password)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolTypeExtensions.Tls12;
            this.CookieContainer = new CookieContainer();
            this.Connect(Server, Username, Password);
        }
        #endregion

        #region Constants
        private const string m_urlSuffix = "SDK/User/index.php";
        private const string m_cookieName = "PHPSESSID";
        #endregion

        #region Private Member Variables
        private bool m_Connected = false;
        private const int RETRY_INTERVAL = 2000;
        private const int MAXIMUM_RETRIES = 3;
        private const int MESSAGE_COMPLEXITY = 128;
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
        /// Converts server name (i.e. streaming.granicus.com) into complete url useful to base
        /// webservices.
        /// </summary>
        /// <param name="Server">Server Name (i.e. streaming.granicus.com)</param>
        /// <returns></returns>
        private string m_SafeServerURL(string Server)
        {
            if (!Server.StartsWith("https://") && !Server.StartsWith("http://"))
            {
                Server = "https://" + Server;
            } else if(Server.StartsWith("http://") && !Server.Contains("mm.lvh.me")) {
              Server = Server.Replace("http://","https://");
            }
            if (!Server.EndsWith("/"))
            {
                Server = Server + "/";
            }
            return Server + m_urlSuffix;
        }

        /// <summary>
        /// Recursively builds a metadata tree from the contents of an array of metadata.
        /// </summary>
        /// <param name="metalist">The array of metadata to convert to a tree.</param>
        /// <param name="ParentID">The numberic ID of the parent node (0 if building from the root is desired).</param>
        /// <returns>The metadata in tree form in a <see cref="Granicus.MediaManager.SDK.MetaDataDataCollection"/>.</returns>
        private MetaDataDataCollection m_BuildMetaBranch(MetaDataData[] metalist, int ParentID)
        {
            MetaDataDataCollection tree = new MetaDataDataCollection();
            foreach (MetaDataData meta in metalist)
            {
                if (meta.ParentID == ParentID)
                {
                    meta.Children = m_BuildMetaBranch(metalist, meta.ID);
                    tree.Add(meta);
                }
            }
            return tree;
        }

        /// <summary>
        /// Recursively builds a metadata tree from the contents of an array of metadata.
        /// </summary>
        /// <param name="metalist">The array of metadata to convert to a tree.</param>
        /// <param name="ParentID">The numberic ID of the parent node (0 if building from the root is desired).</param>
        /// <returns>The metadata in tree form in a <see cref="Granicus.MediaManager.SDK.MetaDataDataCollection"/>.</returns>
        private MetaDataDataCollection m_BuildMetaBranch(MetaDataDataCollection metalist, int ParentID)
        {
            MetaDataDataCollection tree = new MetaDataDataCollection();
            foreach (MetaDataData meta in metalist)
            {
                if (meta.ParentID == ParentID)
                {
                    meta.Children = m_BuildMetaBranch(metalist, meta.ID);
                    tree.Add(meta);
                }
            }
            return tree;
        }
        #endregion

        #region Public Utility Methods

        /// <summary>
        /// Converts a list of metadata as returned by GetClipMetaData or GetEventMetaData and converts it to
        /// tree form that can be used to write back into MediaManager via ImportClipMetaData or ImportEventMetaData.
        /// </summary>
        /// <param name="MetaData">The array of metadata to be converted to tree form.</param>
        ///
        public void ConvertToMetaTree(ref MetaDataData[] MetaData)
        {
            ArrayList al = new ArrayList(m_BuildMetaBranch(MetaData, 0));
            MetaData = (MetaDataData[])al.ToArray(typeof(MetaDataData));
        }

        /// <summary>
        /// Converts a list of metadata as returned by GetClipMetaData or GetEventMetaData and converts it to
        /// tree form that can be used to write back into MediaManager via ImportClipMetaData or ImportEventMetaData.
        /// </summary>
        /// <param name="MetaData">The collection of metadata to be converted to tree form.</param>
        ///
        public void ConvertToMetaTree(ref MetaDataDataCollection MetaData)
        {
            MetaData = m_BuildMetaBranch(MetaData, 0);
        }

        /// <summary>
        /// Imports an entire tree off metadata into the root level of the given event.
        /// </summary>
        /// <param name="EventID">The numeric Event ID to place the metadata tree on.</param>
        /// <param name="MetaData">A MetaDataDataCollection that represents the entire tree.</param>
        /// <param name="ClearExisting">Whether or not to clear the existing metadata for the event (this is usually True).</param>
        /// <param name="AsTree">Whether or not the data is formed into a tree (this is almost always True).</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.KeyMapping"/> objects that can be used to get the numeric IDs of the new metadata records.</returns>
        public KeyMapping[] ImportEventMetaData(int EventID, MetaDataDataCollection MetaData, bool ClearExisting, bool AsTree)
        {
            ArrayList al = new ArrayList(MetaData);
            MetaDataData[] MetaArray = (MetaDataData[])al.ToArray(typeof(MetaDataData));
            return ImportEventMetaData(EventID, MetaArray, ClearExisting, AsTree);
        }

        /// <summary>
        /// Imports an entire tree off metadata into the root level of the given clip.
        /// </summary>
        /// <param name="ClipID">The numeric Clip ID to place the metadata tree on.</param>
        /// <param name="MetaData">A MetaDataDataCollection that represents the entire tree.</param>
        /// <param name="ClearExisting">Whether or not to clear the existing metadata for the clip (this is usually True).</param>
        /// <param name="AsTree">Whether or not the data is formed into a tree (this is almost always True).</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.KeyMapping"/> objects that can be used to get the numeric IDs of the new metadata records.</returns>
        public KeyMapping[] ImportClipMetaData(int ClipID, MetaDataDataCollection MetaData, bool ClearExisting, bool AsTree)
        {
            ArrayList al = new ArrayList(MetaData);
            MetaDataData[] MetaArray = (MetaDataData[])al.ToArray(typeof(MetaDataData));
            return ImportClipMetaData(ClipID, MetaArray, ClearExisting, AsTree);
        }

        /// <summary>
        /// Upload large (>7MB) minutes documents (document size is limited to 1GB).
        /// </summary>
        /// <param name="ClipID">ID of the clip</param>
        /// <param name="Description">Minutes document description</param>
        /// <param name="FullFilename">Full path to the minutes document including filename</param>
        /// <param name="Name">Name that will be assigned to minutes document in media manager</param>
        public void UploadClipMinutesDocumentXL(int ClipID, string Description, string FullFilename, string Name)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(FullFilename);
            int chunkSize = 7000000;
            int filesizeLimit = 1000 * 1000 * 1000; //1GB
            string ext = System.IO.Path.GetExtension(FullFilename).Replace(".", string.Empty);

            if (fi.Length > filesizeLimit)
            {
                throw new Exception("Upload file size limit exceeded!");
            }
            else if (fi.Length > chunkSize)
            {
                try
                {
                    long bytesLeft = fi.Length;
                    string id = Guid.NewGuid().ToString();

                    using (System.IO.FileStream fs = System.IO.File.OpenRead(FullFilename))
                    {
                        do
                        {
                            Document minDoc = new Document();
                            minDoc.Location = Newtonsoft.Json.JsonConvert.SerializeObject(new
                            {
                                action = "add",
                                id = id
                            });

                            minDoc.FileExtension = ext;
                            minDoc.Description = Description;

                            minDoc.FileContents = new byte[Math.Min(chunkSize, bytesLeft)];
                            int bytesRead = fs.Read(minDoc.FileContents, 0, minDoc.FileContents.Length);

                            bytesLeft -= bytesRead;
                            if (bytesLeft <= 0)
                            {
                                minDoc.Location = Newtonsoft.Json.JsonConvert.SerializeObject(new
                                {
                                    action = "finish",
                                    id = id
                                });
                            }

                            if (bytesRead > 0)
                            {
                                UploadClipMinutesDocument(ClipID, minDoc, Name);
                            }
                            else
                            {
                                Console.WriteLine("I READ ZERO BYTES!!!");
                            }
                        } while (bytesLeft > 0);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
            else
            {
                Document minDoc = new Document();
                minDoc.Location = string.Empty;
                minDoc.FileExtension = ext;
                minDoc.Description = Description;

                try
                {
                    minDoc.FileContents = System.IO.File.ReadAllBytes(FullFilename);
                }
                catch { }

                UploadClipMinutesDocument(ClipID, minDoc, Name);
            }

        }

        /// <summary>
        /// Publishes a clip
        /// </summary>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.PublishClipResult"/> objects that represent the list of clips in the folder.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#PublishClip", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("PublishClipResult")]
        public PublishClipResult PublishClip(PublishClipData PublishClipData)
        {
            object[] results = this.Invoke("PublishClip", new object[] { PublishClipData });
            return ((PublishClipResult)(results[0]));
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// Read-Only boolean property that indicates the connection status of the MediaManager instance.
        /// </summary>
        /// <remarks>
        /// This boolean property is true if and only if the MediaManager instance has been connected to MediaManager and
        /// is ready for use.</remarks>
        public bool Connected
        {
            get
            {
                return this.m_Connected;
            }
        }

        /// <summary>
        /// Read-Only property that represents the MediaManager site that the instance has been connected to.
        /// </summary>
        /// <remarks>
        /// This property will be set to the server host (e.g. client.granicus.com) once the MediaManager object instance has
        /// been connected to a site via the <see cref="Granicus.MediaManager.SDK.MediaManager.Connect"/> method or via the proper
        /// <see cref="Granicus.MediaManager.SDK.MediaManager"/> constructor.
        /// </remarks>
        public string Server
        {
            get
            {
                return new Uri(Url).Host;
            }
        }
        #endregion

        #region Connection Methods
        /// <summary>
        /// Used to initially connect to MediaManager.
        /// </summary>
        /// <remarks>
        /// Before other methods can be called on a MediaManager object, the Connect method must be called.
        /// If Connect has not been called, and the MediaManager object was not instantiated using an overload
        /// that supports automated logon, then an exception will be thrown whenever another method is called on the
        /// MediaManager object.
        /// </remarks>
        /// <param name="Server">The MediaManager Host to connect to (e.g. client.granicus.com)</param>
        /// <param name="Username">The MediaManager username to connect with.</param>
        /// <param name="Password">The MediaManager password for the given username.</param>
        /// <example>This sample shows how to call the <see cref="Granicus.MediaManager.SDK.MediaManager.Connect" /> method.
        /// <code>
        /// MediaManager mm = new MediaManager();
        /// mm.Connect("client.granicus.com","myuser","mypassword");
        /// </code>
        /// </example>
        public void Connect(string Server, string Username, string Password)
        {
            base.Url = m_SafeServerURL(Server);
            this.Login(Username, Password);
            this.m_Connected = true;
        }

        /// <summary>
        /// Used to initially connect to MediaManager.
        /// </summary>
        /// <remarks>
        /// Before other methods can be called on a MediaManager object, the Connect method must be called.
        /// If Connect has not been called, and the MediaManager object was not instantiated using an overload
        /// that supports automated logon, then an exception will be thrown whenever another method is called on the
        /// MediaManager object.
        /// </remarks>
        /// <param name="Server">The MediaManager Host to connect to (e.g. client.granicus.com)</param>
        /// <param name="key">Connection key</param>
        /// <param name="expiration">Expiration</param>
        /// <example>This sample shows how to call the <see cref="Granicus.MediaManager.SDK.MediaManager.Connect" /> method.
        /// <code>
        /// MediaManager mm = new MediaManager();
        /// mm.Connect("client.granicus.com","myuser","mypassword");
        /// </code>
        /// </example>
        public void ServerConnect(string Server, string key, DateTime expiration)
        {
            base.Url = m_SafeServerURL(Server);
            this.SendChallengeResponse(key, expiration);
            this.m_Connected = true;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        public void ServerConnect(string Server, string key, string message)
        {
            base.Url = m_SafeServerURL(Server);
            this.SecureChallengeResponse(key, message);
            this.m_Connected = true;
        }

        /// <summary>
        /// Disconnects the MediaManager instance from the MediaManager web application.
        /// </summary>
        /// <remarks>
        /// Once disconnect has been called you must call <see cref="Granicus.MediaManager.SDK.MediaManager.Connect"/>
        /// before the MediaManager instance is usable again.
        /// </remarks>
        public void Disconnect()
        {
            this.Logout();
            this.m_Connected = false;
        }

        /// <summary>
        /// Allows impersonation of a given user via the use of an ImpersonationToken.
        /// </summary>
        /// <remarks>
        /// Impersonation allows you to connect to an existing MediaManager session using an ImpersonationToken.  In order to
        /// be valid, the ImpersonationToken must be from a currently logged on session.  If the user has logged off, the impersonation
        /// token will be rendered invalid immediately.</remarks>
        /// <param name="Server">The MediaManager site (e.g. client.granicus.com) on which to impersonate the given user.</param>
        /// <param name="ImpersonationToken">The impersonation token of the currently logged on user that is to be impersonated.</param>
        public void Impersonate(string Server, string ImpersonationToken)
        {
            base.Url = m_SafeServerURL(Server);
            base.CookieContainer.Add(new Cookie(m_cookieName, ImpersonationToken, "/", Server));
            this.m_Connected = true;
        }
        #endregion

        #region ImpersonationToken
        /// <summary>
        /// The ImpersonationToken of the current session.
        /// </summary>
        /// <remarks>
        /// Impersonation allows connecting to an existing MediaManager user session.  This token can be used in conjuction
        /// with the Impersonate method to transfer or copy a session from one MediaManager object to another.  However, great
        /// care should be taken to ensure that the user session remains logged in while using impersonation as the impersonation
        /// token is rendered invalid immediately on user logout.
        /// </remarks>
        public string ImpersonationToken
        {
            get
            {
                return base.CookieContainer.GetCookies(new Uri(base.Url))[m_cookieName].Value;
            }
        }
        #endregion

        #region Encoder Helper Methods
        /// <summary>
        /// Returns a usable OutcastEncoder object for the given camera.
        /// </summary>
        /// <remarks>
        /// This method should be used to connect to a given Outcast Encoder. While it is possible to connect by instantiating
        /// a new <see cref="Granicus.MediaManager.SDK.OutcastEncoder"/> object and manually connecting it, it is not recommended.</remarks>
        /// <param name="Camera">The CameraData object for the desired OutcastEncoder.</param>
        /// <returns>A connected and usable OutcastEncoder instance.</returns>
        public OutcastEncoder GetOutcastEncoder(CameraData Camera)
        {
            OutcastEncoder encoder = new OutcastEncoder();
            encoder.Connect(Camera, ImpersonationToken);
            return encoder;
        }

        /// <summary>
        /// Returns a usable OutcastEncoder object for the given CameraID
        /// </summary>
        /// <remarks>
        /// This method should be used to connect to a given Outcast Encoder. While it is possible to connect by instantiating
        /// a new <see cref="Granicus.MediaManager.SDK.OutcastEncoder"/> object and manually connecting it, it is not recommended.</remarks>
        /// <param name="CameraID">The numeric ID of the desired OutcastEncoder.</param>
        /// <returns>A connected and usable OutcastEncoder instance.</returns>
        public OutcastEncoder GetOutcastEncoder(int CameraID)
        {
            if(!Connected)
            {
                throw new InvalidOperationException("You must be connected to MediaManager to perform this operation.");
            }
            CameraData cam = GetCamera(CameraID);
            return GetOutcastEncoder(cam);
        }
        #endregion

        #region MediaVault Helper Methods
        /// <summary>
        /// Returns a usable MediaVault object for the given ServerInterface.
        /// </summary>
        /// <remarks>
        /// This method should be used to connect to a given MediaVault. While it is possible to connect by instantiating
        /// a new <see cref="Granicus.MediaManager.SDK.MediaVault"/> object and manually connecting it, it is not recommended.</remarks>
        /// <param name="ServerInterface">The ServerInterfaceData object for the desired MediaVault connection.</param>
        /// <returns>A connected and usable MediaVault instance.</returns>
        public MediaVault GetMediaVault(ServerInterfaceData ServerInterface)
        {
            if (!Connected)
            {
                throw new InvalidOperationException("You must be connected to MediaManager to perform this operation.");
            }
            MediaVault mv = new MediaVault();
            mv.Connect(ServerInterface, Server, ImpersonationToken);
            return mv;
        }

        /// <summary>
        /// Returns a usable MediaVault object for the given Folder ID.
        /// </summary>
        /// <remarks>
        /// This method should be used to connect to a given MediaVault. While it is possible to connect by instantiating
        /// a new <see cref="Granicus.MediaManager.SDK.MediaVault"/> object and manually connecting it, it is not recommended.</remarks>
        /// <param name="FolderID">The ID of the Folder that the MediaVault object must have access to.</param>
        /// <returns>A connected and usable MediaVault instance for the given folder.</returns>
        public MediaVault GetMediaVault(int FolderID)
        {
            if (!Connected)
            {
                throw new Exception("You must be connected to MediaManager to perform this operation.");
            }
            ServerInterfaceData si = this.GetFolderUploadInterface(FolderID);
            MediaVault mv = new MediaVault();
            mv.Connect(si, Server, ImpersonationToken);
            return mv;
        }
        #endregion

        #region Web Service Proxy Methods
        /// <summary>
        /// Used to log a message into the Granicus audit log.
        /// </summary>
        /// <param name="Message">The message to log.</param>
        /// <param name="Application">The application that generated the message.</param>
        /// <param name="Class">The class within the application that created the message.</param>
        /// <param name="Priority">The priority of the message.</param>
        /// <returns>Returns 1 if the messages has been logged. 0 otherwise.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#LogMessage", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("result")]
        public int LogMessage(string Message, string Application, string Class, int Priority)
        {
            object[] results = this.Invoke("LogMessage", new object[] {
                        Message,
                        Application,
                        Class,
                        Priority});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Logs into the current Granicus site using the provided username and password.
        /// </summary>
        /// <remarks>
        /// It is recommended that you use <see cref="Granicus.MediaManager.SDK.MediaManager.Connect"/> instead of login to connect
        /// to Granicus.</remarks>
        /// <param name="Username">Username of the user to login as.</param>
        /// <param name="Password">The password that matches the provided username.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#Login", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void Login(string Username, string Password)
        {
            this.Invoke("Login", new object[] {
                        Username,
                        Password});
        }

        /// <summary>
        /// Gets a challenge for Challenge/Response Authentication.
        /// </summary>
        /// <remarks>Challenge/Response authentication is an authentication method that has been abondoned and should not be used.</remarks>
        /// <param name="ChallengeCode">The seed for the challenge.</param>
        /// <returns>The challenge.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetChallenge", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("Challenge")]
        public string GetChallenge(string ChallengeCode)
        {
            object[] results = this.Invoke("GetChallenge", new object[] {
                        ChallengeCode});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Sends challengeResponse based on Key/Expiration
        /// </summary>
        /// <param name="key"></param>
        /// <param name="expiration"></param>
        public void SendChallengeResponse(string key, DateTime expiration)
        {
          string json = string.Format("{{\"exp\": \"{0}\"}}", expiration.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
          HMACSHA256 hmac = new HMACSHA256(System.Text.Encoding.ASCII.GetBytes(key));

          string Challenge = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json)).Replace("=", null).Replace('+', '-').Replace('/', '_');
          string Response = Convert.ToBase64String(hmac.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Challenge))).Replace("=", null).Replace('+', '-').Replace('/', '_');

          SendChallengeResponse(Challenge, Response);
        }

        /// <summary>
        /// Provides a more secure authentication method than the one based on Key/Expiration
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <param name="retry"></param>
        public void SecureChallengeResponse(string key, string message, int retry = 0)
        {
            byte[] encrypted;
            string initVector;
            string application = message;//save the application name
            byte[] randomMessageContent = new byte[MESSAGE_COMPLEXITY];
            var generator = new RNGCryptoServiceProvider();
            generator.GetBytes(randomMessageContent);//generate a random byte string of length 'MESSAGE_COMPLEXITY
            message = message + BitConverter.ToString(randomMessageContent);//convert random bytes and append to string to create complex message

            Int32 currentUnixTime = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            currentUnixTime >>= 8;//Shift out the 8 low-order bits. This will give a value that is valid for approx. 4 min.

            string passKey = key + currentUnixTime.ToString();//our passkey will be secret + Unix time as modified above
            string encryptKey = passKey;//the key used for message encryption must be limited to 32 characters
            //the passkey is not subject to length constraints
            using (Rijndael aesAlg = Rijndael.Create())//Rijndael was AES before AES was cool
            {
                int keyMinSize = aesAlg.LegalKeySizes[0].MinSize / 8;//key sizes are in bits, need to convert to bytes
                int keyMaxSize = aesAlg.LegalKeySizes[0].MaxSize / 8;


                if (encryptKey.Length > keyMaxSize)
                {
                    encryptKey = encryptKey.Substring(encryptKey.Length - keyMaxSize);
                }
                if (encryptKey.Length < keyMinSize)
                {
                    encryptKey = encryptKey.PadLeft(keyMinSize, 'X');
                }

                // Specify the key, but allow the library to randomly generate an initialization vector
                aesAlg.Key = System.Text.Encoding.ASCII.GetBytes(encryptKey);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write data to the stream.
                            swEncrypt.Write(message);
                        }
                        encrypted = msEncrypt.ToArray();
                        initVector = Convert.ToBase64String(aesAlg.IV);
                    }
                }
            }

            HMACSHA512 hmac = new HMACSHA512(System.Text.Encoding.ASCII.GetBytes(passKey));

            string encryptedMessage = Convert.ToBase64String(encrypted);
            string authHash = Convert.ToBase64String(hmac.ComputeHash(System.Text.Encoding.ASCII.GetBytes(message)));
            try
            {
                AuthenticateApp(encryptedMessage, authHash, initVector, application);
            }
            catch (Exception e)
            {
                if (retry < MAXIMUM_RETRIES)//set to 3
                {
                    Thread.Sleep(RETRY_INTERVAL * ++retry);//interval of 2 gives retries at 2,4,6 seconds
                    SecureChallengeResponse(key, application, retry);//application holds the original value of 'message'
                }
            }

        }
        /// <summary>
        /// Send the response to a Challenge that was received using <see cref="Granicus.MediaManager.SDK.MediaManager.GetChallenge"/>.
        /// </summary>
        /// <remarks>Challenge/Response authentication is an authentication method that has been abondoned and should not be used.</remarks>
        /// <param name="Challenge">The key for the challenge response</param>
        /// <param name="Response">The expiration of the response.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SendChallengeResponse", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SendChallengeResponse(string Challenge, string Response)
        {
          this.Invoke("SendChallengeResponse", new object[] {
                        Challenge,
                        Response});
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Message"></param>
        /// <param name="AuthHash"></param>
        /// <param name="InitVector"></param>
        /// <param name="Application"></param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#AuthenticateApp", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void AuthenticateApp(string Message, string AuthHash, string InitVector, string Application)
        {
            this.Invoke("AuthenticateApp", new object[] {
                        Message,
                        AuthHash,
                        InitVector,
                        Application});
        }

        /// <summary>
        /// Logs out the current user and invalidates the session.
        /// </summary>
        /// <remarks>
        /// It is recommended that you use <see cref="Granicus.MediaManager.SDK.MediaManager.Disconnect"/> to disconnect rather than calling
        /// the Logout method directly.</remarks>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#Logout", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void Logout()
        {
            this.Invoke("Logout", new object[0]);
        }

        /// <summary>
        /// Creates a new Camera record in the Granicus system using the given <see cref="Granicus.MediaManager.SDK.CameraData"/> object.
        /// </summary>
        /// <param name="CameraData">The camera object to be created in the system.</param>
        /// <returns>The unique numeric ID of the new <see cref="Granicus.MediaManager.SDK.CameraData"/> object.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateCamera", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("CameraID")]
        public int CreateCamera(CameraData CameraData)
        {
            object[] results = this.Invoke("CreateCamera", new object[] {
                        CameraData});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Gets a list of all the cameras in the Granicus system.
        /// </summary>
        /// <returns>Array of <see cref="Granicus.MediaManager.SDK.CameraData"/> objects that represents the entire camera list.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetCameras", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("cameras")]
        public CameraData[] GetCameras()
        {
            object[] results = this.Invoke("GetCameras", new object[0]);
            return ((CameraData[])(results[0]));
        }

        /// <summary>
        /// Gets a specific camera in the Granicus system.
        /// </summary>
        /// <param name="CameraID">The unique numeric ID of the <see cref="Granicus.MediaManager.SDK.CameraData"/> object to return.</param>
        /// <returns>The <see cref="Granicus.MediaManager.SDK.CameraData"/> object that represents the requested camera.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetCamera", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("camera")]
        public CameraData GetCamera(int CameraID)
        {
            object[] results = this.Invoke("GetCamera", new object[] {
                        CameraID});
            return ((CameraData)(results[0]));
        }

        /// <summary>
        /// Returns the video location (URI) of a camera for live video playback.
        /// </summary>
        /// <param name="CameraID">ID of the Camera.</param>
        /// <returns>Video location (URI) for playback.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetCameraVideoLocation", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("url")]
        public string GetCameraVideoLocation(int CameraID)
        {
            object[] results = this.Invoke("GetCameraVideoLocation", new object[] {
                        CameraID});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Updates a camera record within the Granicus system.
        /// </summary>
        /// <param name="camera">The <see cref="Granicus.MediaManager.SDK.CameraData"/> object to be updated.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateCamera", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateCamera(CameraData camera)
        {
            this.Invoke("UpdateCamera", new object[] {
                        camera});
        }

        /// <summary>
        /// Removes a camera record from the Granicus system.
        /// </summary>
        /// <param name="CameraID">The ID of the camera to be removed.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteCamera", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteCamera(int CameraID)
        {
            this.Invoke("DeleteCamera", new object[] {
                        CameraID});
        }

        /// <summary>
        /// Creates a new broadcast event.
        /// </summary>
        /// <param name="EventData">The <see cref="Granicus.MediaManager.SDK.EventData"/> object that represents the event to be created.</param>
        /// <returns>The new unique ID of the created event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateEvent", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("EventID")]
        public int CreateEvent(EventData EventData)
        {
            object[] results = this.Invoke("CreateEvent", new object[] {
                        EventData});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Gets a list of broadcast events in the Granicus system that occur no more than 2 weeks in the past, or 2 months in the future.
        /// </summary>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.EventData"/> objects the represent the entire event list.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEvents", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("events")]
        public EventData[] GetEvents()
        {
            object[] results = this.Invoke("GetEvents", new object[0]);
            return ((EventData[])(results[0]));
        }

        /// <summary>
        /// Gets a list of events with a ForeignID the matches the given value.
        /// </summary>
        /// <param name="ForeignID">The ForeignID to locate in the event list.</param>
        /// <returns>A list of <see cref="Granicus.MediaManager.SDK.EventData"/> objects with matching Foreign IDs.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventsByForeignID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("events")]
        public EventData[] GetEventsByForeignID(int ForeignID)
        {
            object[] results = this.Invoke("GetEventsByForeignID", new object[] {
                        ForeignID});
            return ((EventData[])(results[0]));
        }

        /// <summary>
        /// Gets a list of events between the given date range.
        /// </summary>
        /// <param name="StartTime">The start time of the range.</param>
        /// <param name="EndTime">The end time of the range.</param>
        /// <returns>A list of <see cref="Granicus.MediaManager.SDK.EventData"/> objects with matching Foreign IDs.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventsByForeignID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("events")]
        public EventData[] GetEventsByDateRange(DateTime StartTime, DateTime EndTime)
        {
            object[] results = this.Invoke("GetEventsByDateRange", new object[] {
                        StartTime, EndTime});
            return ((EventData[])(results[0]));
        }

        /// <summary>
        /// Gets a specific event in the Granicus system.
        /// </summary>
        /// <param name="EventID">The unique numeric ID of the Event to retreive.</param>
        /// <returns>An <see cref="Granicus.MediaManager.SDK.EventData"/> object that represents the requested event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEvent", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("event")]
        public EventData GetEvent(int EventID)
        {
            object[] results = this.Invoke("GetEvent", new object[] {
                        EventID});
            return ((EventData)(results[0]));
        }

        /// <summary>
        /// Gets a specific event in the Granicus system by GUID.
        /// </summary>
        /// <param name="EventUID">A string representation of the Event's Guaranteed Unique Identifier (GUID).</param>
        /// <returns>An <see cref="Granicus.MediaManager.SDK.EventData"/> object that represents the requested event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("event")]
        public EventData GetEventByUID(string EventUID)
        {
            object[] results = this.Invoke("GetEventByUID", new object[] {
                        EventUID});
            return ((EventData)(results[0]));
        }

        /// <summary>
        /// Returns the video location (URI) of an event for live video playback.
        /// </summary>
        /// <param name="EventID">The unique ID of the event.</param>
        /// <returns>The video location (URI) that can be used for playback.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventVideoLocation", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("url")]
        public string GetEventVideoLocation(int EventID)
        {
            object[] results = this.Invoke("GetEventVideoLocation", new object[] {
                        EventID});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Returns the video location (URI) of an event for live video playback.
        /// </summary>
        /// <param name="EventUID">A string representation of the event's GUID.</param>
        /// <returns>The video location (URI) that can be used for playback.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventVideoLocationByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("url")]
        public string GetEventVideoLocationByUID(string EventUID)
        {
            object[] results = this.Invoke("GetEventVideoLocationByUID", new object[] {
                        EventUID});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Gets all MetaData associated with the given event.
        /// </summary>
        /// <param name="EventID">The event's numeric ID.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> that represents all MetaData associated with the given event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("metadata")]
        public MetaDataData[] GetEventMetaData(int EventID)
        {
            object[] results = this.Invoke("GetEventMetaData", new object[] {
                        EventID});
            return ((MetaDataData[])(results[0]));
        }

        /// <summary>
        /// Gets all MetaData associated with the given event.
        /// </summary>
        /// <param name="EventUID">The event's GUID.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> that represents all MetaData associated with the given event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetEventMetaDataByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("metadata")]
        public MetaDataData[] GetEventMetaDataByUID(string EventUID)
        {
            object[] results = this.Invoke("GetEventMetaDataByUID", new object[] {
                        EventUID});
            return ((MetaDataData[])(results[0]));
        }

        /// <summary>
        /// Sets the URL for an event's agenda.
        /// </summary>
        /// <param name="EventID">The numeric ID of the event to assign the agenda URL.</param>
        /// <param name="URL">The URL of the agenda document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetEventAgendaURL", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SetEventAgendaURL(int EventID, string URL)
        {
            this.Invoke("SetEventAgendaURL", new object[] {
                        EventID,
                        URL});
        }

        /// <summary>
        /// Uploads a document for an event's agenda.
        /// </summary>
        /// <param name="EventID">The numeric ID of the event to assign the agenda URL.</param>
        /// <param name="Document">The details of the uploaded document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetEventAgendaURL", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UploadEventAgendaDocument(int EventID, Document Document)
        {
            this.Invoke("UploadEventAgendaDocument", new object[] {
                        EventID,
                        Document});
        }

        /// <summary>
        /// Sets the URL for an event's agenda.
        /// </summary>
        /// <param name="EventUID">The GUID of the event to assign the agenda URL.</param>
        /// <param name="URL">The URL of the agenda document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetEventAgendaURLByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SetEventAgendaURLByUID(string EventUID, string URL)
        {
            this.Invoke("SetEventAgendaURLByUID", new object[] {
                        EventUID,
                        URL});
        }

        /// <summary>
        /// Uploads a document for an event's agenda.
        /// </summary>
        /// <param name="EventUID">The UID of the event to assign the agenda URL.</param>
        /// <param name="Document">The details of the uploaded document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetEventAgendaURL", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UploadEventAgendaDocumentByUID(string EventUID, Document Document)
        {
            this.Invoke("UploadEventAgendaDocumentByUID", new object[] {
                        EventUID,
                        Document});
        }

        /// <summary>
        /// Creates a linked video object AND adds video stream url to connected Event
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="videoUrl"></param>
        /// <returns>The new unique ID of the created linkedvideo.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateLinkedVideoFromEvent", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public int CreateLinkedVideoFromEvent(int eventId, string videoUrl)
        {
            object[] results = this.Invoke("CreateLinkedVideoFromEvent", new object[]
            {
                eventId,
                videoUrl
            });
            return ((int)(results[0]));
        }

        /// <summary>
        /// Updates a linked video object
        /// </summary>
        /// <param name="linkedVideoData"></param>
        /// <returns>The ID of the updated linkedvideo</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateLinkedVideo", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public int UpdateLinkedVideo(LinkedVideoData @linkedVideoData)
        {
            object[] results = this.Invoke("UpdateLinkedVideo", new object[]
            {
                @linkedVideoData
            });
            return ((int)(results[0]));
        }

        /// <summary>
        /// Creates a linked video object
        /// </summary>
        /// <param name="linkedVideoData"></param>
        /// <returns>The new unique ID of the created linkedvideo.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateLinkedVideo", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public int CreateLinkedVideo(LinkedVideoData @linkedVideoData)
        {
            object[] results = this.Invoke("CreateLinkedVideo", new object[]
            {
                @linkedVideoData
            });
            return ((int)(results[0]));
        }

        /// <summary>
        /// Deletes a linked video object
        /// </summary>
        /// <param name="linkedVideoId"></param>
        /// <returns>The ID of the deleted linkedvideo</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteLinkedVideo", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public int DeleteLinkedVideo(int @linkedVideoId)
        {
            object[] results = this.Invoke("DeleteLinkedVideo", new object[]
            {
                @linkedVideoId
            });
            return ((int)(results[0]));
        }

        /// <summary>
        /// Get a linked video object by ID
        /// </summary>
        /// <param name="LinkedVideoID"></param>
        /// <returns>A linked video object</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetLinkedVideo", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("linkedVideo")]
        public LinkedVideoData GetLinkedVideo(int LinkedVideoID)
        {
            object[] results = this.Invoke("GetLinkedVideo", new object[] {
                        LinkedVideoID});
            return ((LinkedVideoData)(results[0]));
        }

        /// <summary>
        /// Updates an event.
        /// </summary>
        /// <param name="event">The <see cref="Granicus.MediaManager.SDK.EventData"/> object to update.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateEvent", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateEvent(EventData @event)
        {
            this.Invoke("UpdateEvent", new object[] {
                        @event});

        }

        /// <summary>
        /// Deletes an event from the Granicus system.
        /// </summary>
        /// <param name="EventID">The unique numeric ID of the event to delete.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteEvent", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteEvent(int EventID)
        {
            this.Invoke("DeleteEvent", new object[] {
                        EventID});
        }

        /// <summary>
        /// Adds MetaData to an event.
        /// </summary>
        /// <param name="EventID">The ID of the event to add MetaData to.</param>
        /// <remarks>
        /// This method can be used to add a single MetaDataData object or a tree of MetaDataData objects
        /// (using the <see cref="Granicus.MediaManager.SDK.MetaDataData.Children"/> property) to an event.  This method respects the
        /// <see cref="Granicus.MediaManager.SDK.MetaDataData.ParentID"/> and <see cref="Granicus.MediaManager.SDK.MetaDataData.ParentUID"/>
        /// properties of the root level <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object that is passed in allowing the
        /// caller to specify the place in the MetaData tree where the object should be added.
        /// </remarks>
        /// <param name="MetaDataData">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to add.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.KeyMapping"/> objects that can be used to get the
        /// IDs of the newly added <see cref="Granicus.MediaManager.SDK.MetaDataData"/> objects.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#AddEventMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("KeyTable")]
        public KeyMapping[] AddEventMetaData(int EventID, MetaDataData MetaDataData)
        {
            object[] results = this.Invoke("AddEventMetaData", new object[] {
                        EventID,
                        MetaDataData});
            return ((KeyMapping[])(results[0]));
        }


        /// <summary>
        /// Imports an entire tree off metadata into the root level of the given event.
        /// </summary>
        /// <param name="EventID">The numeric Event ID to place the metadata tree on.</param>
        /// <param name="MetaData">An array of MetaDataData that represents the entire tree.</param>
        /// <param name="ClearExisting">Whether or not to clear the existing metadata for the event (this is usually True).</param>
        /// <param name="AsTree">Whether or not the data is formed into a tree (this is almost always True).</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.KeyMapping"/> objects that can be used to get the numeric IDs of the new metadata records.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#ImportEventMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("KeyTable")]
        public KeyMapping[] ImportEventMetaData(int EventID, MetaDataData[] MetaData, bool ClearExisting, bool AsTree)
        {
            object[] results = this.Invoke("ImportEventMetaData", new object[] {
                        EventID,
                        MetaData,
                        ClearExisting,
                        AsTree});
            return ((KeyMapping[])(results[0]));
        }

        /// <summary>
        /// Create a new folder in the system.
        /// </summary>
        /// <param name="FolderData">A <see cref="Granicus.MediaManager.SDK.FolderData"/> object that contains the values for the new folder.</param>
        /// <returns>The numeric ID of the created folder.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateFolder", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("FolderID")]
        public int CreateFolder(FolderData FolderData)
        {
            object[] results = this.Invoke("CreateFolder", new object[] {
                        FolderData});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Retreives all folder records from Granicus.
        /// </summary>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.FolderData"/> object that represents the list of all folders.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetFolders", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("folders")]
        public FolderData[] GetFolders()
        {
            object[] results = this.Invoke("GetFolders", new object[0]);
            return ((FolderData[])(results[0]));
        }

        /// <summary>
        /// Get all the folders of the specified type.
        /// </summary>
        /// <param name="Type">The type of folders you wish to retreive.  Current valid values are "Meeting" and "Training".</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.FolderData"/> object that represents the list of folders of the specified type.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetFoldersByType", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("folders")]
        public FolderData[] GetFoldersByType(string Type)
        {
            object[] results = this.Invoke("GetFoldersByType", new object[] {
                        Type});
            return ((FolderData[])(results[0]));
        }

        /// <summary>
        /// Retreives a folder record from the system.
        /// </summary>
        /// <param name="FolderID">The numeric ID of the folder to retreive.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.FolderData"/> object that represents the folder record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetFolder", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("folder")]
        public FolderData GetFolder(int FolderID)
        {
            object[] results = this.Invoke("GetFolder", new object[] {
                        FolderID});
            return ((FolderData)(results[0]));
        }

        /// <summary>
        /// Retreives an upload interface for a given Folder.
        /// </summary>
        /// <remarks>
        /// While it is possible to use this method to connect to a MediaVault, it is recommended that you use the
        /// <see cref="Granicus.MediaManager.SDK.MediaManager.GetMediaVault(Int32)"/> method instead.</remarks>
        /// <param name="FolderID">The ID of the folder that you wish to upload to.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.ServerInterfaceData"/> object that can be used to connect a new MediaVault object.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetFolderUploadInterface", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("interface")]
        public ServerInterfaceData GetFolderUploadInterface(int FolderID)
        {
            object[] results = this.Invoke("GetFolderUploadInterface", new object[] {
                        FolderID});
            return ((ServerInterfaceData)(results[0]));
        }

        /// <summary>
        /// Updates a folder record.
        /// </summary>
        /// <param name="folder">A <see cref="Granicus.MediaManager.SDK.FolderData"/> that contains the new values for the record.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateFolder", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateFolder(FolderData folder)
        {
            this.Invoke("UpdateFolder", new object[] {
                        folder});
        }

        /// <summary>
        /// Removes a folder record from the Granicus system.
        /// </summary>
        /// <param name="FolderID">The ID of the folder to be removed.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteFolder", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteFolder(int FolderID)
        {
            this.Invoke("DeleteFolder", new object[] {
                        FolderID});
        }

        /// <summary>
        /// Register a clip that has been uploaded to a given server.
        /// </summary>
        /// <remarks>
        /// This is the only method that respects the FileName property of a Clip record.  It should be used with extreme caution as
        /// setting the FileName improperly will result in a video file that will not play.  This method should not be used for normal
        /// upload procedures.  Instead, use the <see cref="Granicus.MediaManager.SDK.MediaVault.RegisterUploadedFile"/> method.
        /// </remarks>
        /// <param name="ClipData">The clip data that will be written to the database.</param>
        /// <param name="ServerID">The ID of the server to which the file has been uploaded.</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#RegisterClipUpload", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("ClipID")]
        public int RegisterClipUpload(ClipData ClipData, int ServerID)
        {
            object[] results = this.Invoke("RegisterClipUpload", new object[] {
                        ClipData,
                        ServerID});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Retreives the entire list of clips from a given folder.
        /// </summary>
        /// <param name="FolderID">The numeric ID of the folder to retreive clips from.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.ClipData"/> objects that represent the list of clips in the folder.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClips", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("clips")]
        public ClipData[] GetClips(int FolderID)
        {
            object[] results = this.Invoke("GetClips", new object[] {
                        FolderID});
            return ((ClipData[])(results[0]));
        }


        /// <summary>
        /// Retreives all clip records that have a matching Foreign ID.
        /// </summary>
        /// <param name="ForeignID">The numeric Foreign ID that is to be matched.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.ClipData"/> objects that matched the given Foreign ID.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipsByForeignID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("clips")]
        public ClipData[] GetClipsByForeignID(int ForeignID)
        {
            object[] results = this.Invoke("GetClipsByForeignID", new object[] {
                        ForeignID});
            return ((ClipData[])(results[0]));
        }


        /// <summary>
        /// Retreives a clip record.
        /// </summary>
        /// <param name="ClipID">The clip's numeric ID.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.ClipData"/> object that represents the requested clip.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClip", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("clip")]
        public ClipData GetClip(int ClipID)
        {
            object[] results = this.Invoke("GetClip", new object[] {
                        ClipID});
            return ((ClipData)(results[0]));
        }

        /// <summary>
        /// Retreives a clip record.
        /// </summary>
        /// <param name="ClipUID">A string representation of the clip's GUID.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.ClipData"/> object that represents the requested clip.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("clip")]
        public ClipData GetClipByUID(string ClipUID)
        {
            object[] results = this.Invoke("GetClipByUID", new object[] {
                        ClipUID});
            return ((ClipData)(results[0]));
        }

        /// <summary>
        /// Returns the video location (URI) of a clip record for on-demand video playback.
        /// </summary>
        /// <param name="ClipID">The unique ID of the clip.</param>
        /// <returns>The video location (URI) that can be used for playback.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipVideoLocation", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("url")]
        public string GetClipVideoLocation(int ClipID)
        {
            object[] results = this.Invoke("GetClipVideoLocation", new object[] {
                        ClipID});
            return ((string)(results[0]));
        }


        /// <summary>
        /// Gets all MetaData associated with the given clip.
        /// </summary>
        /// <param name="ClipID">The clip's numeric ID.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> that represents all MetaData associated with the given event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("metadata")]
        public MetaDataData[] GetClipMetaData(int ClipID)
        {
            object[] results = this.Invoke("GetClipMetaData", new object[] {
                        ClipID});
            return ((MetaDataData[])(results[0]));
        }


        /// <summary>
        /// Gets all MetaData associated with the given clip.
        /// </summary>
        /// <param name="ClipUID">The clip's GUID.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> that represents all MetaData associated with the given event.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipMetaDataByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("metadata")]
        public MetaDataData[] GetClipMetaDataByUID(string ClipUID)
        {
            object[] results = this.Invoke("GetClipMetaDataByUID", new object[] {
                        ClipUID});
            return ((MetaDataData[])(results[0]));
        }


        /// <summary>
        /// Retreive an index list for the clip.
        /// </summary>
        /// <param name="ClipID">The Clip's numeric ID.</param>
        /// <returns>An array of MetaDataData that represents the index list for the clip.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipIndices", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("metadata")]
        public MetaDataData[] GetClipIndices(int ClipID)
        {
            object[] results = this.Invoke("GetClipIndices", new object[] {
                        ClipID});
            return ((MetaDataData[])(results[0]));
        }

        /// <summary>
        /// Retreive an index list for the clip.
        /// </summary>
        /// <param name="ClipUID">The string representation of the Clip's GUID.</param>
        /// <returns>An array of MetaDataData that represents the index list for the clip.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipIndicesByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("metadata")]
        public MetaDataData[] GetClipIndicesByUID(string ClipUID)
        {
            object[] results = this.Invoke("GetClipIndicesByUID", new object[] {
                        ClipUID});
            return ((MetaDataData[])(results[0]));
        }


        /// <summary>
        /// Retreive the transcript (captions) for a given clip.
        /// </summary>
        /// <param name="ClipID">The Clip's numeric ID.</param>
        /// <returns>The entire transcript for the clip.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipCaptions", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("captions")]
        public string GetClipCaptions(int ClipID)
        {
            object[] results = this.Invoke("GetClipCaptions", new object[] {
                        ClipID});
            return ((string)(results[0]));
        }


        /// <summary>
        /// Retreive the transcript (captions) for a given clip.
        /// </summary>
        /// <param name="ClipUID">The string representation of the Clip's GUID.</param>
        /// <returns>The entire transcript for the clip.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipCaptionsByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("captions")]
        public string GetClipCaptionsByUID(string ClipUID)
        {
            object[] results = this.Invoke("GetClipCaptionsByUID", new object[] {
                        ClipUID});
            return ((string)(results[0]));
        }


        /// <summary>
        /// Sets the URL to be used as the agenda for a clip.
        /// </summary>
        /// <param name="ClipID">The clip ID to assign the URL to.</param>
        /// <param name="URL">The URL that will become the new location of the agenda document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetClipAgendaURL", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SetClipAgendaURL(int ClipID, string URL)
        {
            this.Invoke("SetClipAgendaURL", new object[] {
                        ClipID,
                        URL});
        }

        /// <summary>
        /// Sets the URL to be used as the minutes for a clip.
        /// </summary>
        /// <param name="ClipID">The clip ID to assign the URL to.</param>
        /// <param name="URL">The URL that will become the new location of the minutes document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetClipMinutesURL", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SetClipMinutesURL(int ClipID, string URL)
        {
            this.Invoke("SetClipMinutesURL", new object[] {
                        ClipID,
                        URL});
        }

        /// <summary>
        /// Sets the URL to be used as the minutes for a clip, and includes the name of the document.
        /// </summary>
        /// <param name="ClipID">The clip ID to assign the URL to.</param>
        /// <param name="URL">The URL that will become the new location of the minutes document.</param>
        /// <param name="Name">The Name to use for the new minutes document.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetClipMinutesURLWithName", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SetClipMinutesURLWithName(int ClipID, string URL, string Name)
        {
            this.Invoke("SetClipMinutesURLWithName", new object[] {
                        ClipID,
                        URL,Name});
        }

        /// <summary>
        /// Uploads a minutes document for a clip, and includes the name of the document.
        /// </summary>
        /// <param name="ClipID">The clip ID to assign the URL to.</param>
        /// <param name="Document">Minutes Document.</param>
        /// <param name="Name">Name for the minutes document</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UploadClipMinutesDocument", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UploadClipMinutesDocument(int ClipID, Document Document, string Name)
        {
            this.Invoke("UploadClipMinutesDocument", new object[] {
                        ClipID,
                        Document,Name});
        }

        /// <summary>
        /// Gets a listing of the minutes documents currently associated with a clip
        /// </summary>
        /// <param name="ClipID">The numeric ID of the clip.</param>
        /// <returns>Array of <see cref="Granicus.MediaManager.SDK.CameraData"/> objects that represents the entire camera list.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetClipMinutesDocuments", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("MinutesDocuments")]
        public MinutesDocumentData[] GetClipMinutesDocuments(int ClipID)
        {
            object[] results = this.Invoke("GetClipMinutesDocuments", new object[] { ClipID });
            return ((MinutesDocumentData[])(results[0]));
        }

        /// <summary>
        /// Deletes a minutes document associated with a clip.
        /// </summary>
        /// <param name="UID">The unique id (UID) of the minutes document to delete.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteMinutesDocument", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteMinutesDocument(string UID)
        {
            this.Invoke("DeleteMinutesDocument", new object[] { UID });
        }

        /// <summary>
        /// Updates a clip record.
        /// </summary>
        /// <param name="clip">A <see cref="Granicus.MediaManager.SDK.ClipData"/> object that contains the new values for the clip.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateClip", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateClip(ClipData clip)
        {
            this.Invoke("UpdateClip", new object[] {
                        clip});
        }

        /// <summary>
        /// Deletes a clip from the Granicus system.
        /// </summary>
        /// <param name="ClipID">The unique numeric ID of the clip to delete.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteClip", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteClip(int ClipID)
        {
            this.Invoke("DeleteClip", new object[] {
                        ClipID});
        }


        /// <summary>
        /// Adds MetaData to an event.
        /// </summary>
        /// <param name="ClipID">The ID of the event to add MetaData to.</param>
        /// <remarks>
        /// This method can be used to add a single MetaDataData object or a tree of MetaDataData objects
        /// (using the <see cref="Granicus.MediaManager.SDK.MetaDataData.Children"/> property) to an event.  This method respects the
        /// <see cref="Granicus.MediaManager.SDK.MetaDataData.ParentID"/> and <see cref="Granicus.MediaManager.SDK.MetaDataData.ParentUID"/>
        /// properties of the root level <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object that is passed in allowing the
        /// caller to specify the place in the MetaData tree where the object should be added.
        /// </remarks>
        /// <param name="MetaDataData">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to add.</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.KeyMapping"/> objects that can be used to get the
        /// IDs of the newly added <see cref="Granicus.MediaManager.SDK.MetaDataData"/> objects.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#AddClipMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("KeyTable")]
        public KeyMapping[] AddClipMetaData(int ClipID, MetaDataData MetaDataData)
        {
            object[] results = this.Invoke("AddClipMetaData", new object[] {
                        ClipID,
                        MetaDataData});
            return ((KeyMapping[])(results[0]));
        }

        /// <summary>
        /// Imports an entire tree off metadata into the root level of the given clip.
        /// </summary>
        /// <param name="ClipID">The numeric Clip ID to place the metadata tree on.</param>
        /// <param name="MetaData">An array of MetaDataData that represents the entire tree.</param>
        /// <param name="ClearExisting">Whether or not to clear the existing metadata for the clip (this is usually True).</param>
        /// <param name="AsTree">Whether or not the data is formed into a tree (this is almost always True).</param>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.KeyMapping"/> objects that can be used to get the numeric IDs of the new metadata records.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#ImportClipMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("KeyTable")]
        public KeyMapping[] ImportClipMetaData(int ClipID, MetaDataData[] MetaData, bool ClearExisting, bool AsTree)
        {
            object[] results = this.Invoke("ImportClipMetaData", new object[] {
                        ClipID,
                        MetaData,
                        ClearExisting,
                        AsTree});
            return ((KeyMapping[])(results[0]));
        }

        /// <summary>
        /// Retreives a metadata record from the system.
        /// </summary>
        /// <param name="MetaDataID">The unique numeric ID of the metadata.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object that represents the metadata record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("MetaData")]
        public MetaDataData GetMetaData(int MetaDataID)
        {
            object[] results = this.Invoke("GetMetaData", new object[] {
                        MetaDataID});
            return ((MetaDataData)(results[0]));
        }

        /// <summary>
        /// Retreives a metadata record from the system.
        /// </summary>
        /// <param name="MetaDataUID">A string representation of the metadata's GUID.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object that represents the metadata record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetMetaDataByUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("MetaData")]
        public MetaDataData GetMetaDataByUID(string MetaDataUID)
        {
            object[] results = this.Invoke("GetMetaDataByUID", new object[] {
                        MetaDataUID});
            return ((MetaDataData)(results[0]));
        }

        /// <summary>
        /// Downloads an attachment from the system.
        /// </summary>
        /// <param name="MetaDataID">The ID of the attachment.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.Document"/> object that represents the attachment record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#FetchAttachment", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("Attachment")]
        public Document FetchAttachment(int MetaDataID)
        {
            object[] results = this.Invoke("FetchAttachment", new object[] {
                        MetaDataID});
            return ((Document)(results[0]));
        }

        /// <summary>
        /// Returns the video location (URI) of a metadata record for on-demand video playback.
        /// </summary>
        /// <param name="MetaDataID">The unique ID of the metadata.</param>
        /// <returns>The video location (URI) that can be used for playback.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetMetaDataVideoLocation", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("url")]
        public string GetMetaDataVideoLocation(int MetaDataID)
        {
            object[] results = this.Invoke("GetMetaDataVideoLocation", new object[] {
                        MetaDataID});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Updates a metadata record.
        /// </summary>
        /// <param name="MetaData">A <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object that contains the new values for the record.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateMetaData(MetaDataData MetaData)
        {
            this.Invoke("UpdateMetaData", new object[] {
                        MetaData});
        }

        /// <summary>
        /// Deletes a metadata record.
        /// </summary>
        /// <param name="MetaDataID">The ID of the metadata record to delete.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteMetaData", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteMetaData(int MetaDataID)
        {
            this.Invoke("DeleteMetaData", new object[] {
                        MetaDataID});
        }

        /// <summary>
        /// Creates a new view record in Granicus.
        /// </summary>
        /// <param name="ViewData">A <see cref="Granicus.MediaManager.SDK.ViewData"/> object that contains the values for the new record.</param>
        /// <returns>The unique numeric ID of the new view record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateView", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("ViewID")]
        public int CreateView(ViewData ViewData)
        {
            object[] results = this.Invoke("CreateView", new object[] {
                        ViewData});
            return ((int)(results[0]));
        }


        /// <summary>
        /// Returns the complete list of views in Granicus.
        /// </summary>
        /// <returns>The complete list of views as an array of <see cref="Granicus.MediaManager.SDK.ViewData"/> objects.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetViews", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("views")]
        public ViewData[] GetViews()
        {
            object[] results = this.Invoke("GetViews", new object[0]);
            return ((ViewData[])(results[0]));
        }

        /// <summary>
        /// Retreives a view record from the system.
        /// </summary>
        /// <param name="ViewID">The unique ID of the view to be retreived.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.ViewData"/> object that represents the view record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetView", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("view")]
        public ViewData GetView(int ViewID)
        {
            object[] results = this.Invoke("GetView", new object[] {
                        ViewID});
            return ((ViewData)(results[0]));
        }


        /// <summary>
        /// Updates a view record in the system.
        /// </summary>
        /// <param name="view">A <see cref="Granicus.MediaManager.SDK.ViewData"/> object that contains the new values for the record.</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateView", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateView(ViewData view)
        {
            this.Invoke("UpdateView", new object[] {
                        view});
        }

        /// <summary>
        /// Creates a new user in the system.
        /// </summary>
        /// <param name="UserData">A <see cref="Granicus.MediaManager.SDK.UserData"/> object that contains the values for the new user.</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateUser", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("UserUID")]
        public string CreateUser(UserData UserData)
        {
            object[] results = this.Invoke("CreateUser", new object[] {
                        UserData});
            return ((string)(results[0]));
        }

        /// <summary>
        /// Returns the numeric user ID for the currently logged in user.
        /// </summary>
        /// <returns>The numeric user ID.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetCurrentUserID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("UserID")]
        public int GetCurrentUserID()
        {
            object[] results = this.Invoke("GetCurrentUserID", new object[0]);
            return ((int)(results[0]));
        }

        /// <summary>
        /// Returns the UID for the currently logged in user.
        /// </summary>
        /// <returns>The numeric user ID.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetCurrentUserUID", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("UserUID")]
        public string GetCurrentUserUID()
        {
            object[] results = this.Invoke("GetCurrentUserUID", new object[0]);
            return ((string)(results[0]));
        }

        /// <summary>
        /// Returns the user logon name of the currently logged in user.
        /// </summary>
        /// <returns>The current username.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetCurrentUserLogon", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("Logon")]
        public string GetCurrentUserLogon()
        {
            object[] results = this.Invoke("GetCurrentUserLogon", new object[0]);
            return ((string)(results[0]));
        }

        /// <summary>
        /// Returns the complete list of users in Granicus.
        /// </summary>
        /// <returns>The complete list of users as an array of <see cref="Granicus.MediaManager.SDK.UserData"/> objects.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetUsers", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("users")]
        public UserData[] GetUsers()
        {
            object[] results = this.Invoke("GetUsers", new object[0]);
            return ((UserData[])(results[0]));
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.UserData"/> object for a specific user.
        /// </summary>
        /// <param name="UserUID">The UID of the user to be returned.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.UserData"/> object that represents the requested user.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetUser", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("user")]
        public UserData GetUser(string UserUID)
        {
            object[] results = this.Invoke("GetUser", new object[] {
                        UserUID});
            return ((UserData)(results[0]));
        }

        /// <summary>
        /// Updates a user record within the Granicus system.
        /// </summary>
        /// <param name="UserUID">The UID of the user to assign groups to.</param>
        /// <param name="GroupUIDs">An array of UIDs representing the groups to be assigned.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#SetUserMemberships", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void SetUserMemberships(string UserUID, string[] GroupUIDs)
        {
            this.Invoke("SetUserMemberships", new object[] {
                        UserUID,
                        GroupUIDs});
        }

        /// <summary>
        /// Sets the groups for the given user.
        /// </summary>
        /// <param name="user">The <see cref="Granicus.MediaManager.SDK.UserData"/> object to update.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateUser", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateUser(UserData user)
        {
            this.Invoke("UpdateUser", new object[] {
                        user});
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="GroupData">The <see cref="Granicus.MediaManager.SDK.GroupData"/> object to create in the system.</param>
        /// <returns>The Group ID of the new group.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateGroup", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("GroupID")]
        public int CreateGroup(GroupData GroupData)
        {
            object[] results = this.Invoke("CreateGroup", new object[] {
                        GroupData});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Returns the complete list of groups within the Granicus system.
        /// </summary>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.GroupData"/> objects that represents the list of groups.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetGroups", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("groups")]
        public GroupData[] GetGroups()
        {
            object[] results = this.Invoke("GetGroups", new object[0]);
            return ((GroupData[])(results[0]));
        }

        /// <summary>
        /// Returns a specific group from the Granicus system.
        /// </summary>
        /// <param name="GroupID">The unique ID of the group to be returned.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.GroupData"/> object that represents the requested group.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetGroup", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("group")]
        public GroupData GetGroup(int GroupID)
        {
            object[] results = this.Invoke("GetGroup", new object[] {
                        GroupID});
            return ((GroupData)(results[0]));
        }

        /// <summary>
        /// Updates a group.
        /// </summary>
        /// <param name="group">The <see cref="Granicus.MediaManager.SDK.GroupData"/> object to be updated. </param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateGroup", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateGroup(GroupData group)
        {
            this.Invoke("UpdateGroup", new object[] {
                        group});
        }

        /// <summary>
        /// Removes a group record from the Granicus system.
        /// </summary>
        /// <param name="GroupID">The ID of the group to be removed.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteFolder", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteGroup(int GroupID)
        {
            this.Invoke("DeleteGroup", new object[] {
                        GroupID});
        }

        /// <summary>
        /// Creates a new template in the Granicus system.
        /// </summary>
        /// <param name="TemplateData">The <see cref="Granicus.MediaManager.SDK.TemplateData"/> object to be created.</param>
        /// <returns>The unique ID of the newly created template.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateTemplate", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("TemplateID")]
        public int CreateTemplate(TemplateData TemplateData)
        {
            object[] results = this.Invoke("CreateTemplate", new object[] {
                        TemplateData});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Get the entire list of templates from the system.
        /// </summary>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.TemplateData"/> objects that represent the entire list of templates.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetTemplates", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("templates")]
        public TemplateData[] GetTemplates()
        {
            object[] results = this.Invoke("GetTemplates", new object[0]);
            return ((TemplateData[])(results[0]));
        }

        /// <summary>
        /// Retreives a template record from the system.
        /// </summary>
        /// <param name="TemplateID">The id of the template record to retreive.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.TemplateData"/> object that represents the record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetTemplate", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("template")]
        public TemplateData GetTemplate(int TemplateID)
        {
            object[] results = this.Invoke("GetTemplate", new object[] {
                        TemplateID});
            return ((TemplateData)(results[0]));
        }

        /// <summary>
        /// Updates a template record in the system.
        /// </summary>
        /// <param name="template">The <see cref="Granicus.MediaManager.SDK.TemplateData"/> object that contains the new values for the record.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateTemplate", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateTemplate(TemplateData template)
        {
            this.Invoke("UpdateTemplate", new object[] {
                        template});
        }

        /// <summary>
        /// Creates a new server record in the system.
        /// </summary>
        /// <param name="ServerData">The <see cref="Granicus.MediaManager.SDK.ServerData"/> object that contains the values for the new record.</param>
        /// <returns>The unique numeric ID for the new record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateServer", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("ServerID")]
        public int CreateServer(ServerData ServerData)
        {
            object[] results = this.Invoke("CreateServer", new object[] {
                        ServerData});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Retreive all server records from the system.
        /// </summary>
        /// <returns>An array of <see cref="Granicus.MediaManager.SDK.ServerData"/> objects that represent the entire list of servers.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetServers", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("servers")]
        public ServerData[] GetServers()
        {
            object[] results = this.Invoke("GetServers", new object[0]);
            return ((ServerData[])(results[0]));
        }

        /// <summary>
        /// Retreive a server record from the system.
        /// </summary>
        /// <param name="ServerID">The unique numeric ID of the server.</param>
        /// <returns>A <see cref="Granicus.MediaManager.SDK.ServerData"/> object that represents the server record.</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetServer", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("server")]
        public ServerData GetServer(int ServerID)
        {
            object[] results = this.Invoke("GetServer", new object[] {
                        ServerID});
            return ((ServerData)(results[0]));
        }

        /// <summary>
        /// Updates a server record.
        /// </summary>
        /// <param name="server">The ServerData object to update.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#UpdateServer", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void UpdateServer(ServerData server)
        {
            this.Invoke("UpdateServer", new object[] {
                        server});
        }

        /// <summary>
        /// Removes a server record from the Granicus system.
        /// </summary>
        /// <param name="ServerID">The ID of the server to be removed.</param>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#DeleteFolder", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void DeleteServer(int ServerID)
        {
            this.Invoke("DeleteServer", new object[] {
                        ServerID});
        }

        /// <summary>
        /// Gets the permission level of the current user to a specific asset in the system.
        /// </summary>
        /// <param name="AssetType">The type of asset (e.g. event, clip, metadata, user, group, folder, etc).</param>
        /// <param name="AssetID">The unique numeric ID of the asset.</param>
        /// <returns><list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>0</term><description>No permission.</description></item>
        /// <item><term>1</term><description>Read only permission.</description></item>
        /// <item><term>2</term><description>Read/Write permission.</description></item>
        /// </list></returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetPermissionLevel", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("PermissionLevel")]
        public int GetPermissionLevel(string AssetType, int AssetID)
        {
            object[] results = this.Invoke("GetPermissionLevel", new object[] {
                        AssetType,
                        AssetID});
            return ((int)(results[0]));
        }

        /// <summary>
        /// Creates new attendees in the system.
        /// </summary>
        /// <param name="AttendeesData">An array of objects <see cref="Granicus.MediaManager.SDK.Attendee"/>  that contains the values for new attendees.</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateAttendees", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void CreateAttendees(Attendee[] AttendeesData)
        {
            object[] results = this.Invoke("CreateAttendees", new object[] { AttendeesData });
        }

        /// <summary>
        /// Send the definitive list of Motion-Actions to MM.
        /// </summary>
        /// <param name="motionActions">A <see cref="Granicus.MediaManager.SDK.StringCollection"/> An array containing all the motion actions.</param>
        /// <returns></returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#CreateMotionActions", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        public void CreateMotionActions(StringCollection motionActions)
        {
            this.Invoke("CreateMotionActions", new object[] { motionActions});
        }

        /// <summary>
        /// Get the list of Motion-Actions from MM.
        /// </summary>
        /// <returns>Motion action string array</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetMotionActions", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("motionActions")]
        public StringCollection GetMotionActions()
        {
            object[] results = this.Invoke("GetMotionActions", new object[0]);
            return ((StringCollection)results[0]);
        }

        /// <summary>
        /// Get the list of Settings from MM.
        /// </summary>
        /// <returns>Setting collection</returns>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:UserSDK#userwebservice#GetSettings", RequestNamespace = "urn:UserSDK", ResponseNamespace = "urn:UserSDK")]
        [return: System.Xml.Serialization.SoapElementAttribute("settings")]
        public SettingCollection GetSettings()
        {
            object[] results = this.Invoke("GetSettings", new object[0]);
            return ((SettingCollection)results[0]);
        }

        #endregion
    }
    #endregion
}
