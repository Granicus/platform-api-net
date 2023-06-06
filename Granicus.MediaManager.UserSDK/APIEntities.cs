namespace Granicus.MediaManager.SDK
{
    using System;

    #region AgendaItem
    /// <summary>
    /// Represents an agenda item within Granicus.
    /// </summary>
    /// <remarks>
    /// Represents an agenda item within Granicus.  Agenda items can be formed into a tree structure to build
    /// a complete agenda document.  Additional items, such as notes, motions, votes and attachments, can be added to the
    /// agenda item as well using the Children property of the containing <see cref="Granicus.MediaManager.SDK.MetaDataData"/>MetaDataData object.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class AgendaItem : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _Department;

        /// <remarks/>
        private string _Actions;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AgendaItem"/> class.
        /// </summary>
        public AgendaItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AgendaItem"/> class with the supplied
        /// Department and Action.
        /// </summary>
        /// <param name="_Department">The department for the Agenda Item (e.g. Planning and Zoning)</param>
        /// <param name="_Actions">The action to be taken on the Item (e.g. Approve Funding)</param>
        public AgendaItem(string _Department, string _Actions)
        {
            this._Department = _Department;
            this._Actions = _Actions;
        }

        /// <summary>
        /// Represents the department for the Agenda Item.
        /// </summary>
        /// <remarks>
        /// Usually Agenda Items come from or belong to a specific department.  This field represents that department.</remarks>
        public string Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                if ((this._Department != value))
                {
                    this._Department = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }

        /// <summary>
        /// Represents the action to be taken on the Agenda Item.
        /// </summary>
        /// <remarks>
        /// Sometimes Agenda Items have a particular action that is taken upon approval.  This can be the approval of funds, routing
        /// to committee, creation of a new ordinance, etc.  This field represents the action that is to be taken on the Item, or the
        /// suggested action by staff.</remarks>
        public string Actions
        {
            get
            {
                return this._Actions;
            }
            set
            {
                if ((this._Actions != value))
                {
                    this._Actions = value;
                    this.RaisePropertyChanged("Actions");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.AgendaItem.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.AgendaItem.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.AgendaItem.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region MeetingDocumentHeader
    /// <summary>
    /// Represents the header (Name and ID) for a MeetingDocument on a MeetingServer (OutcastEncoder).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://granicus.com/lacity/", TypeName = "Document")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class MeetingDocumentHeader : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string documentID;

        /// <remarks/>
        private string documentName;

        /// <summary>
        /// Initialized a new instance of the <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> class.
        /// </summary>
        public MeetingDocumentHeader()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader"/> based on the supplied
        /// ID and Name.
        /// </summary>
        /// <param name="documentID">The ID (GUID string) of the MeetingDocument.  This ID matches the UID property of the <see cref="Granicus.MediaManager.SDK.EventData"/> object for the meeting.</param>
        /// <param name="documentName">The name of the MeetingDocument</param>
        public MeetingDocumentHeader(string documentID, string documentName)
        {
            this.documentID = documentID;
            this.documentName = documentName;
        }

        /// <summary>
        /// The ID (Guid string) of the MeetingDocument
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "DocumentID")]
        public string DocumentID
        {
            get
            {
                return this.documentID;
            }
            set
            {
                if ((this.documentID != value))
                {
                    this.documentID = value;
                    this.RaisePropertyChanged("DocumentID");
                }
            }
        }

        /// <summary>
        /// The Name of the MeetingDocument
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "DocumentName")]
        public string DocumentName
        {
            get
            {
                return this.documentName;
            }
            set
            {
                if ((this.documentName != value))
                {
                    this.documentName = value;
                    this.RaisePropertyChanged("DocumentName");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    #endregion

    #region EncoderStatus
    /// <summary>
    /// Represents the state of the MeetingServer.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://granicus.com/lacity/", TypeName = "Status")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class EncoderStatus : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private bool connectedToMeetingServer;

        /// <remarks/>
        private string encoderState;

        /// <remarks/>
        private string archiveState;

        /// <remarks/>
        private string meetingTimerState;

        /// <remarks/>
        private ulong meetingTimeElapsed;

        /// <remarks/>
        private string meetingName;

        /// <remarks/>
        private string archiveFileName;

        /// <remarks/>
        private string agendaDocumentID;

        /// <remarks/>
        private string minutesDocumentID;

        /// <remarks/>
        private string masterDocumentID;

        /// <remarks/>
        private int archiveFolderID;

        /// <remarks/>
        private ulong archiveDuration;

        /// <remarks/>
        private bool suspendRecordItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.EncoderStatus"/> class.
        /// </summary>
        public EncoderStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.EncoderStatus"/> class completely
        /// populated with the given values.
        /// </summary>
        /// <param name="connectedToMeetingServer">Whether or not the OutcastEncoder object was able to connect to the MeetingServer service.</param>
        /// <param name="encoderState">The state of the Encoder process.</param>
        /// <param name="archiveState">The state of the Encoder's archiving system.</param>
        /// <param name="meetingTimerState">The state of the meeting timer.</param>
        /// <param name="meetingTimeElapsed">The elapsed time since the beginning of the meeting.</param>
        /// <param name="meetingName">The name of the current meeting.</param>
        /// <param name="archiveFileName">The filename currently being archived.</param>
        /// <param name="agendaDocumentID">The current Agenda Document ID</param>
        /// <param name="minutesDocumentID">The current Minutes Document ID</param>
        /// <param name="masterDocumentID">The current Master Document ID</param>
        /// <param name="archiveFolderID">The Archive Folder ID of the currently recording Archive</param>
        /// <param name="archiveDuration">The duration of the current Archive</param>
        /// <param name="suspendRecordItem">Whether or not the ability to record items has been suspended.</param>
        public EncoderStatus(bool connectedToMeetingServer, string encoderState, string archiveState, string meetingTimerState, ulong meetingTimeElapsed, string meetingName, string archiveFileName, string agendaDocumentID, string minutesDocumentID, string masterDocumentID, int archiveFolderID, ulong archiveDuration, bool suspendRecordItem)
        {
            this.connectedToMeetingServer = connectedToMeetingServer;
            this.encoderState = encoderState;
            this.archiveState = archiveState;
            this.meetingTimerState = meetingTimerState;
            this.meetingTimeElapsed = meetingTimeElapsed;
            this.meetingName = meetingName;
            this.archiveFileName = archiveFileName;
            this.agendaDocumentID = agendaDocumentID;
            this.minutesDocumentID = minutesDocumentID;
            this.masterDocumentID = masterDocumentID;
            this.archiveFolderID = archiveFolderID;
            this.archiveDuration = archiveDuration;
            this.suspendRecordItem = suspendRecordItem;
        }

        /// <summary>
        /// Whether or not the web service is connected to the encoder.  If false, no calls to the object will succeed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ConnectedToMeetingServer")]
        public bool ConnectedToMeetingServer
        {
            get
            {
                return this.connectedToMeetingServer;
            }
            set
            {
                if ((this.connectedToMeetingServer != value))
                {
                    this.connectedToMeetingServer = value;
                    this.RaisePropertyChanged("ConnectedToMeetingServer");
                }
            }
        }

        /// <summary>
        /// The state of the encoding process.
        /// </summary>
        /// <remarks>
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>EndPreprocess</term><description></description></item>
        /// <item><term>Pausing</term><description>Preparing to pause encoding.</description></item>
        /// <item><term>Paused</term><description>Encoding video has been paused.</description></item>
        /// <item><term>Running</term><description>Encoding is in progress.</description></item>
        /// <item><term>Starting</term><description>Preparing to start encoding.</description></item>
        /// <item><term>Stopping</term><description>Preparing to stop encoding.</description></item>
        /// <item><term>Stopped</term><description>Encoding is stopped.</description></item>
        /// </list></remarks>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "EncoderState")]
        public string EncoderState
        {
            get
            {
                return this.encoderState;
            }
            set
            {
                if ((this.encoderState != value))
                {
                    this.encoderState = value;
                    this.RaisePropertyChanged("EncoderState");
                }
            }
        }

        /// <summary>
        /// The state of the archiving process.
        /// </summary>
        /// <remarks>
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>Paused</term><description>Video archiving to file is paused.</description></item>
        /// <item><term>Running</term><description>Video is being archived to file.</description></item>
        /// <item><term>Stopped</term><description>Video archiving to file is stopped.</description></item>
        /// </list>
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ArchiveState")]
        public string ArchiveState
        {
            get
            {
                return this.archiveState;
            }
            set
            {
                if ((this.archiveState != value))
                {
                    this.archiveState = value;
                    this.RaisePropertyChanged("ArchiveState");
                }
            }
        }

        /// <summary>
        /// The state of the meeting timer.
        /// </summary>
        /// <remarks>
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>None</term><description>Timer has not been assigned a state.</description></item>
        /// <item><term>Expired</term><description>Timer has expired.</description></item>
        /// <item><term>Paused</term><description>Timer is paused.</description></item>
        /// <item><term>Running</term><description>Timer is running.</description></item>
        /// <item><term>Stopped</term><description>Timer is stopped.</description></item>
        /// </list>
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MeetingTimerState")]
        public string MeetingTimerState
        {
            get
            {
                return this.meetingTimerState;
            }
            set
            {
                if ((this.meetingTimerState != value))
                {
                    this.meetingTimerState = value;
                    this.RaisePropertyChanged("MeetingTimerState");
                }
            }
        }

        /// <summary>
        /// The amount of the the meeting has been running, in seconds.
        /// </summary>
        /// <remarks>
        /// Value is expressed in seconds.
        /// </remarks>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MeetingTimeElapsed")]
        public ulong MeetingTimeElapsed
        {
            get
            {
                return this.meetingTimeElapsed;
            }
            set
            {
                if ((this.meetingTimeElapsed != value))
                {
                    this.meetingTimeElapsed = value;
                    this.RaisePropertyChanged("MeetingTimeElapsed");
                }
            }
        }

        /// <summary>
        /// The name of the currently loaded meeting document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MeetingName")]
        public string MeetingName
        {
            get
            {
                return this.meetingName;
            }
            set
            {
                if ((this.meetingName != value))
                {
                    this.meetingName = value;
                    this.RaisePropertyChanged("MeetingName");
                }
            }
        }

        /// <summary>
        /// The name of the current archive file being recorded.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ArchiveFileName")]
        public string ArchiveFileName
        {
            get
            {
                return this.archiveFileName;
            }
            set
            {
                if ((this.archiveFileName != value))
                {
                    this.archiveFileName = value;
                    this.RaisePropertyChanged("ArchiveFileName");
                }
            }
        }

        /// <summary>
        /// The DocumentID of the current agenda document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "AgendaDocumentID")]
        public string AgendaDocumentID
        {
            get
            {
                return this.agendaDocumentID;
            }
            set
            {
                if ((this.agendaDocumentID != value))
                {
                    this.agendaDocumentID = value;
                    this.RaisePropertyChanged("AgendaDocumentID");
                }
            }
        }

        /// <summary>
        /// The DocumentID of the current minutes document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MinutesDocumentID")]
        public string MinutesDocumentID
        {
            get
            {
                return this.minutesDocumentID;
            }
            set
            {
                if ((this.minutesDocumentID != value))
                {
                    this.minutesDocumentID = value;
                    this.RaisePropertyChanged("MinutesDocumentID");
                }
            }
        }

        /// <summary>
        /// The DocumentID of the agenda document the meeting was loaded from.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "MasterDocumentID")]
        public string MasterDocumentID
        {
            get
            {
                return this.masterDocumentID;
            }
            set
            {
                if ((this.masterDocumentID != value))
                {
                    this.masterDocumentID = value;
                    this.RaisePropertyChanged("MasterDocumentID");
                }
            }
        }

        /// <summary>
        /// The MediaManager Folder ID where the archive will be uploaded after the meeting has concluded.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ArchiveFolderID")]
        public int ArchiveFolderID
        {
            get
            {
                return this.archiveFolderID;
            }
            set
            {
                if ((this.archiveFolderID != value))
                {
                    this.archiveFolderID = value;
                    this.RaisePropertyChanged("ArchiveFolderID");
                }
            }
        }

        /// <summary>
        /// The length of the current video archive.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ArchiveDuration")]
        public ulong ArchiveDuration
        {
            get
            {
                return this.archiveDuration;
            }
            set
            {
                if ((this.archiveDuration != value))
                {
                    this.archiveDuration = value;
                    this.RaisePropertyChanged("ArchiveDuration");
                }
            }
        }

        /// <summary>
        /// Indicates whether record item actions are suspended or not.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "SuspendRecordItem")]
        public bool SuspendRecordItem
        {
            get
            {
                return this.suspendRecordItem;
            }
            set
            {
                if ((this.suspendRecordItem != value))
                {
                    this.suspendRecordItem = value;
                    this.RaisePropertyChanged("SuspendRecordItem");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.MeetingDocumentHeader.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.EncoderStatus.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.EncoderStatus.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region SecurityHeader
    /// <summary>
    /// Security header is used internally by the API for managing credentials.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://granicus.com/MediaVault/SDK", TypeName = "SecurityHeader")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://granicus.com/MediaVault/SDK", IsNullable = false, ElementName = "SecurityHeader")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class SecurityHeader : System.Web.Services.Protocols.SoapHeader
    {

        /// <remarks/>
        private string serviceHost;

        /// <remarks/>
        private string securityToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.SecurityHeader"/> class.
        /// </summary>
        public SecurityHeader()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.SecurityHeader"/> class using the given
        /// service host and security token.
        /// </summary>
        /// <param name="serviceHost">The service host.</param>
        /// <param name="securityToken">A valid security token.</param>
        public SecurityHeader(string serviceHost, string securityToken)
        {
            this.serviceHost = serviceHost;
            this.securityToken = securityToken;
        }

        /// <summary>
        /// The service host that can authenticate the <see cref="Granicus.MediaManager.SDK.SecurityHeader.SecurityToken"/> of
        /// the <see cref="Granicus.MediaManager.SDK.SecurityHeader"/> instance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "ServiceHost")]
        public string ServiceHost
        {
            get
            {
                return this.serviceHost;
            }
            set
            {
                if ((this.serviceHost != value))
                {
                    this.serviceHost = value;
                }
            }
        }

        /// <summary>
        /// The security token that will be validated.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "SecurityToken")]
        public string SecurityToken
        {
            get
            {
                return this.securityToken;
            }
            set
            {
                if ((this.securityToken != value))
                {
                    this.securityToken = value;
                }
            }
        }
    }
    #endregion

    #region CameraData
    /// <summary>
    /// Represents a Camera record within MediaManager.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class CameraData : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int _ID;

        private string _Type;

        private string _Name;

        private string _InternalIP;

        private string _ExternalIP;

        /// <remarks/>
        private int _BroadcastPort;

        /// <remarks/>
        private int _ControlPort;

        /// <remarks/>
        private string _Identifier;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.CameraData"/> class.
        /// </summary>
        public CameraData()
        {
        }

        /// <summary>
        /// Change the attributes of the current CameraData object to hold the specified arguments.  Note that when if you create the Camera
        /// the ID will be assigned per our system's requirements - the one you enter here is irrelevant.
        /// This method is DEPRECATED - please use the 4-argument constructor instead.
        /// </summary>
        /// <param name="_ID">The ID of the Cameradata object.  This is not relevant.</param>
        /// <param name="_Type">This is simply a description of the Camera.  Most cameras use "Meeting"</param>
        /// <param name="_Name">The name of the camera that will be visible to users.  For example "Council Room Encoder"</param>
        /// <param name="_InternalIP">The internal IP address at which the camera can be reached.</param>
        /// <param name="_ExternalIP">The external IP address that will be accessed by our datacenter to pull video streams.</param>
        /// <param name="_BroadcastPort">The inbound port allowed for pulling a video stream (usually 8080)</param>
        /// <param name="_ControlPort">The port over which web services are allowed (usually 80)</param>
        /// <param name="_Identifier">The unique identifier for the camera.  This is often something like "encoder1"</param>
        public CameraData(int _ID, string _Type, string _Name, string _InternalIP, string _ExternalIP, int _BroadcastPort, int _ControlPort, string _Identifier)
        {
            this._ID = _ID;
            this._Type = _Type;
            this._Name = _Name;
            this._InternalIP = _InternalIP;
            this._ExternalIP = _ExternalIP;
            this._BroadcastPort = _BroadcastPort;
            this._ControlPort = _ControlPort;
            this._Identifier = _Identifier;
        }

        /// <summary>
        /// Change the attributes of the current CameraData object to hold the specified arguments.  This is the
        /// preferred way to add a new camera.  By default, the ID will be set to 1, but if you create a new camera,
        /// the ID will be automatically set to a different value.  By default, "Type" is set to "Meeting,"
        /// Broadcast Port is 8080, and Control Port is 80.
        /// </summary>
        /// <param name="_Name">The name of the camera that will be visible to users.  For example "Council Room Encoder"</param>
        /// <param name="_InternalIP">The internal IP address at which the camera can be reached.</param>
        /// <param name="_ExternalIP">The external IP address that will be accessed by our datacenter to pull video streams.</param>
        /// <param name="_Identifier">The unique identifier for the camera.  This is often something like "encoder1"</param>
        public CameraData(string _Name, string _InternalIP, string _ExternalIP, string _Identifier)
        {
            this._ID = 1;
            this._Type = "Meeting";
            this._Name = _Name;
            this._InternalIP = _InternalIP;
            this._ExternalIP = _ExternalIP;
            this._BroadcastPort = 8080;
            this._ControlPort = 80;
            this._Identifier = _Identifier;
        }

        /// <summary>
        /// The Numeric ID associated with this Camera in MediaManager.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// A description of the use for this camera.  Generally, this should be "Meeting".
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this._Type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// The Name that users will see for this camera.  Something like "Council Chambers Encoder" is nice.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The Internal IP address for the encoder.
        /// </summary>
        public string InternalIP
        {
            get
            {
                return this._InternalIP;
            }
            set
            {
                if ((this._InternalIP != value))
                {
                    this._InternalIP = value;
                    this.RaisePropertyChanged("InternalIP");
                }
            }
        }

        /// <summary>
        /// The external IP address for the encoder - our datacenter must be able to make an inbound connection
        /// to this IP address on the BroadcastPort.
        /// </summary>
        public string ExternalIP
        {
            get
            {
                return this._ExternalIP;
            }
            set
            {
                if ((this._ExternalIP != value))
                {
                    this._ExternalIP = value;
                    this.RaisePropertyChanged("ExternalIP");
                }
            }
        }

        /// <summary>
        /// This is the port that external servers (generally the distribution servers at our datacenter) will use
        /// to pull a live video stream from.  Usually this is port 80.
        /// </summary>
        public int BroadcastPort
        {
            get
            {
                return this._BroadcastPort;
            }
            set
            {
                if ((this._BroadcastPort != value))
                {
                    this._BroadcastPort = value;
                    this.RaisePropertyChanged("BroadcastPort");
                }
            }
        }

        /// <summary>
        /// This is the port on which the encoder's web service will be listening.  Usually this is port 80.
        /// </summary>
        public int ControlPort
        {
            get
            {
                return this._ControlPort;
            }
            set
            {
                if ((this._ControlPort != value))
                {
                    this._ControlPort = value;
                    this.RaisePropertyChanged("ControlPort");
                }
            }
        }

        /// <summary>
        /// This is a unique identifier applied to the Camera.  It must only contain alphanumeric characters.
        /// Something like "encoder2" is common.
        /// </summary>
        public string Identifier
        {
            get
            {
                return this._Identifier;
            }
            set
            {
                if ((this._Identifier != value))
                {
                    this._Identifier = value;
                    this.RaisePropertyChanged("Identifier");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.CameraData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.CameraData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.CameraData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Motion
    /// <summary>
    /// Represents a Motion within MediaManager.
    /// </summary>
    /// <remarks>
    /// Motions are the basic element of an action within MediaManager's meeting workflow.  Before a vote can be taken,
    /// a motion must be made, and seconded.  Robert's Rules of Order are used to determine the current Motion on the table,
    /// and how motions should be voted upon.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Motion : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _Mover;

        /// <remarks/>
        private string _Seconder;

        /// <remarks/>
        private string _Type;

        /// <remarks/>
        private string _MotionText;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Motion"/> class.
        /// </summary>
        public Motion()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Motion"/> class with the supplied
        /// Mover, Seconder, Motion Type and Motion Text.
        /// </summary>
        /// <param name="_Mover">The full name of the Attendee that made the motion.</param>
        /// <param name="_Seconder">The full name of the Attendee that seconded the motion.</param>
        /// <param name="_Type">The type of motion (must be a value in the Event or Clip's MotionType collection).</param>
        /// <param name="_MotionText">The text of the motion that was made.</param>
        public Motion(string _Mover, string _Seconder, string _Type, string _MotionText)
        {
            this._Mover = _Mover;
            this._Seconder = _Seconder;
            this._Type = _Type;
            this._MotionText = _MotionText;
        }

        /// <summary>
        /// The name of the member who made the motion.  Name must match the name of a valid Attendee.
        /// </summary>
        public string Mover
        {
            get
            {
                return this._Mover;
            }
            set
            {
                if ((this._Mover != value))
                {
                    this._Mover = value;
                    this.RaisePropertyChanged("Mover");
                }
            }
        }

        /// <summary>
        /// The name of the member who seconded the motion.  Name must match the name of a valid Attendee.
        /// </summary>
        public string Seconder
        {
            get
            {
                return this._Seconder;
            }
            set
            {
                if ((this._Seconder != value))
                {
                    this._Seconder = value;
                    this.RaisePropertyChanged("Seconder");
                }
            }
        }

        /// <summary>
        /// The type of the motion.  Must be a valid motion type for the customer.
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this._Type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// The complete text of the motion as read.
        /// </summary>
        public string MotionText
        {
            get
            {
                return this._MotionText;
            }
            set
            {
                if ((this._MotionText != value))
                {
                    this._MotionText = value;
                    this.RaisePropertyChanged("MotionText");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Motion.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.Motion.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Motion.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region AttendeeStatus
    /// <summary>
    /// Represents the status of a meeting attendee during a rollcall.
    /// </summary>
    /// <remarks>
    /// The <see cref="Granicus.MediaManager.SDK.Rollcall"/> contains the property <see cref="Granicus.MediaManager.SDK.Rollcall.Attendees"/>
    /// which is a collection of <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> objects.  This collection represents the status
    /// of each attendee in the meeting at the time the rollcall was taken.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class AttendeeStatus : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private int _Status;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> class.
        /// </summary>
        public AttendeeStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> class with the supplied
        /// name and status.
        /// </summary>
        /// <param name="_Name">The <see cref="Granicus.MediaManager.SDK.AttendeeStatus.Name"/> of the attendee.</param>
        /// <param name="_Status">The numeric <see cref="Granicus.MediaManager.SDK.AttendeeStatus.Status"/> of the attendee.</param>
        public AttendeeStatus(string _Name, int _Status)
        {
            this._Name = _Name;
            this._Status = _Status;
        }

        /// <summary>
        /// The full name of the attendee as it appears in the attendee list for the event or clip.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The numeric status of the attendee. Valid values are defined as follows:
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>0</term><description>Absent</description></item>
        /// <item><term>1</term><description>Present</description></item>
        /// <item><term>2</term><description>Excused</description></item>
        /// </list>
        /// </summary>
        public int Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this._Status = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.AttendeeStatus.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.AttendeeStatus.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.AttendeeStatus.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Rollcall
    /// <summary>
    /// Represents a rollcall record.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Rollcall : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private AttendeeStatusCollection _Attendees;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Rollcall"/> class.
        /// </summary>
        public Rollcall()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Rollcall"/> class with the provided
        /// attendance data.
        /// </summary>
        /// <param name="_Attendees">A collection of AttendeeStatus objects that describe the complete roll call.</param>
        public Rollcall(AttendeeStatusCollection _Attendees)
        {
            this._Attendees = _Attendees;
        }

        /// <summary>
        /// The list of meeting attendees and their status at the time of the roll call.
        /// </summary>
        /// <remarks>
        /// This list of attendees is in the form of a collection of <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> objects,
        /// which are different from <see cref="Granicus.MediaManager.SDK.Attendee"/> objects in the fact that they contain only the
        /// full name, and the <see cref="Granicus.MediaManager.SDK.AttendeeStatus.Status"/> of the attendee at the time of the roll
        /// call.
        /// </remarks>
        public AttendeeStatusCollection Attendees
        {
            get
            {
                return this._Attendees;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Attendees");
                }
                if ((this._Attendees != value))
                {
                    this._Attendees = value;
                    this.RaisePropertyChanged("Attendees");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Rollcall.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.Rollcall.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Rollcall.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region VoteRecord
    /// <summary>
    /// Represents a vote as recorded by the clerk.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class VoteRecord : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _MotionID;

        /// <remarks/>
        private bool _Passed;

        /// <remarks/>
        private VoteEntryCollection _Votes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.VoteRecord"/> class.
        /// </summary>
        public VoteRecord()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.VoteRecord"/> class with the
        /// supplied MotionID, Passed state, and VoteEntry collection.
        /// </summary>
        /// <param name="_MotionID">The ID of the Motion associated with this VoteRecord.</param>
        /// <param name="_Passed">Whether or not the vote has enough "Yes" votes to pass.</param>
        /// <param name="_Votes">The collection of VoteEntry objects that represent the entire vote record.</param>
        public VoteRecord(int _MotionID, bool _Passed, VoteEntryCollection _Votes)
        {
            this._MotionID = _MotionID;
            this._Passed = _Passed;
            this._Votes = _Votes;
        }

        /// <summary>
        /// The unique numeric ID of the motion for which the Vote Record applies.
        /// </summary>
        /// <remarks>
        /// In order to be valid, a vote must be associated with a Motion.  This motion must already exist within the system
        /// at the time that a vote record is added.</remarks>
        public int MotionID
        {
            get
            {
                return this._MotionID;
            }
            set
            {
                if ((this._MotionID != value))
                {
                    this._MotionID = value;
                    this.RaisePropertyChanged("MotionID");
                }
            }
        }

        /// <summary>
        /// Whether or not the vote had sufficient support to pass.
        /// </summary>
        public bool Passed
        {
            get
            {
                return this._Passed;
            }
            set
            {
                if ((this._Passed != value))
                {
                    this._Passed = value;
                    this.RaisePropertyChanged("Passed");
                }
            }
        }

        /// <summary>
        /// A collection of vote entries that represent the voting details of each voting attendee.
        /// </summary>
        public VoteEntryCollection Votes
        {
            get
            {
                return this._Votes;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Votes");
                }
                if ((this._Votes != value))
                {
                    this._Votes = value;
                    this.RaisePropertyChanged("Votes");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.VoteRecord.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.VoteRecord.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.VoteRecord.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region VoteEntry
    /// <summary>
    /// Represents a vote by an individual attendee within a <see cref="Granicus.MediaManager.SDK.VoteRecord"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class VoteEntry : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private int _Vote;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.VoteEntry"/> class.
        /// </summary>
        public VoteEntry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.VoteEntry"/> class with the
        /// supplied Name and Vote value.
        /// </summary>
        /// <param name="_Name">The full name of the Attendee whose vote is represented by the VoteEntry</param>
        /// <param name="_Vote">The integer value of the vote as recorded by the attendee. See <see cref="Granicus.MediaManager.SDK.VoteEntry.Vote"/> for more information.</param>
        public VoteEntry(string _Name, int _Vote)
        {
            this._Name = _Name;
            this._Vote = _Vote;
        }

        /// <summary>
        /// The full name of the attendee that voted as it appears in the attendee list.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The integer value of the vote as recorded by the attendee.
        /// </summary>
        /// <remarks>
        /// Valid values are:
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>0</term><description>No</description></item>
        /// <item><term>1</term><description>Yes</description></item>
        /// <item><term>2</term><description>Abstain</description></item>
        /// <item><term>3</term><description>Absent</description></item>
        /// <item><term>4</term><description>Recuse</description></item>
        /// <item><term>5</term><description>Not Voting</description></item>
        /// </list></remarks>
        public int Vote
        {
            get
            {
                return this._Vote;
            }
            set
            {
                if ((this._Vote != value))
                {
                    this._Vote = value;
                    this.RaisePropertyChanged("Vote");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.VoteEntry.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.VoteEntry.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.VoteEntry.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Note
    /// <summary>
    /// Represents a note.  Used for summary or verbatim minutes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Note : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _NoteText;

        /// <remarks/>
        private string _EditorsNotes;

        /// <remarks/>
        private bool _Private;

        /// <summary>
        /// Instantiates a new instance of the <see cref="Granicus.MediaManager.SDK.Note"/> class.
        /// </summary>
        public Note()
        {
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="Granicus.MediaManager.SDK.Note"/> class with the
        /// supplies text, editor's note, and private flag.
        /// </summary>
        /// <param name="_NoteText">The text of the note.</param>
        /// <param name="_EditorsNotes">The editor's notes, which are kept private.</param>
        /// <param name="_Private">Whether or not the entire note should be a private note.</param>
        public Note(string _NoteText, string _EditorsNotes, bool _Private)
        {
            this._NoteText = _NoteText;
            this._EditorsNotes = _EditorsNotes;
            this._Private = _Private;
        }

        /// <summary>
        /// The text of the note.
        /// </summary>
        /// <remarks>
        /// This text will appear on the minutes if the <see cref="Granicus.MediaManager.SDK.Note.Private"/>
        /// flag is not checked.
        /// </remarks>
        public string NoteText
        {
            get
            {
                return this._NoteText;
            }
            set
            {
                if ((this._NoteText != value))
                {
                    this._NoteText = value;
                    this.RaisePropertyChanged("NoteText");
                }
            }
        }

        /// <summary>
        /// Private note text for use by staff.  Used to make notes that should not be visible on the minutes.
        /// </summary>
        public string EditorsNotes
        {
            get
            {
                return this._EditorsNotes;
            }
            set
            {
                if ((this._EditorsNotes != value))
                {
                    this._EditorsNotes = value;
                    this.RaisePropertyChanged("EditorsNotes");
                }
            }
        }

        /// <summary>
        /// Whether or not the note is a "Private" note, which will not be displayed on the minutes.
        /// </summary>
        public bool Private
        {
            get
            {
                return this._Private;
            }
            set
            {
                if ((this._Private != value))
                {
                    this._Private = value;
                    this.RaisePropertyChanged("Private");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Note.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.Note.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Note.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Document
    /// <summary>
    /// Represents a document "attachment".
    /// </summary>
    /// <remarks>
    /// Document attachments can be added to videos or to agenda items and represent a related document to the content.  Examples
    /// include staff reports and presentations.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Document : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _Description;

        /// <remarks/>
        private string _Location;

        /// <remarks/>
        private byte[] _FileContents;

        /// <remarks/>
        private string _FileExtension;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Document"/> class.
        /// </summary>
        public Document()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Document"/> class using the supplied
        /// description and location values.
        /// </summary>
        /// <param name="_Description">A short description of the document.</param>
        /// <param name="_Location">The location (URI) of the document.</param>
        public Document(string _Description, string _Location)
        {
            this._Description = _Description;
            this._Location = _Location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Document"/> class using the supplied
        /// description and location values.
        /// </summary>
        /// <param name="_Description">A short description of the document.</param>
        /// <param name="_FileContents">The contents of the attachment to be uploaded.</param>
        public Document(string _Description, byte[] _FileContents)
        {
            this._Description = _Description;
            this._FileContents = _FileContents;
        }

        /// <summary>
        /// A short description of the document.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// The location (URI) of the document.
        /// </summary>
        public string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                if ((this._Location != value))
                {
                    this._Location = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }

        /// <summary>
        /// The location contents, in bytes, of the document.
        /// </summary>
        public byte[] FileContents
        {
            get
            {
                return this._FileContents;
            }
            set
            {
                if ((this._FileContents != value))
                {
                    this._FileContents = value;
                    this.RaisePropertyChanged("FileContents");
                }
            }
        }

        /// <summary>
        /// The extension of document.
        /// </summary>
        public string FileExtension
        {
            get
            {
                return this._FileExtension;
            }
            set
            {
                if ((this._FileExtension != value))
                {
                    this._FileExtension = value;
                    this.RaisePropertyChanged("FileContents");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Document.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.Document.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Document.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region MinutesDocumentData
    /// <summary>
    /// Represents a Clip Minutes Document
    /// </summary>
    /// <remarks>
    /// Minutes documents can be associated with an archive (clip) and represent a published instance of a minutes document.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class MinutesDocumentData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Type;

        /// <remarks/>
        private bool _Published;

        // <remarks/>
        private bool _Default;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MinutesDocumentData"/> class.
        /// </summary>
        public MinutesDocumentData()
        {
        }

        /// <summary>
        /// The document's unique identifier (GUID format)
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The document's name.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The document's type.
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this._Type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// Whether or not the document is public (published).
        /// </summary>
        public bool Published
        {
            get
            {
                return this._Published;
            }
            set
            {
                if ((this._Published != value))
                {
                    this._Published = value;
                    this.RaisePropertyChanged("Published");
                }
            }
        }

        /// <summary>
        /// Whether or not the document is the default minutes doc (shown in the video player, and other places where a default is required).
        /// </summary>
        public bool Default
        {
            get
            {
                return this._Default;
            }
            set
            {
                if ((this._Default != value))
                {
                    this._Default = value;
                    this.RaisePropertyChanged("Default");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Document.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.Document.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Document.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region TrainingChapter
    /// <summary>
    /// BETA: Represents a chapter in a Training Edition video file.  Requires Granicus Training Edition.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class TrainingChapter : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _Subject;


        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.TrainingChapter"/> class.
        /// </summary>
        public TrainingChapter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.TrainingChapter"/> class with
        /// the supplied subject.
        /// </summary>
        /// <param name="_Subject">The subject of the training chapter.</param>
        public TrainingChapter(string _Subject)
        {
            this._Subject = _Subject;
        }

        /// <summary>
        /// The subject of the chapter.
        /// </summary>
        public string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                if ((this._Subject != value))
                {
                    this._Subject = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.TrainingChapter.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.TrainingChapter.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.TrainingChapter.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region PracticeQuestion
    /// <summary>
    /// BETA: Represents a quiz or practice question in a Training Edition video file.  Requires Granicus Training Edition.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class PracticeQuestion : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private string _XMLData;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.PracticeQuestion"/> class.
        /// </summary>
        public PracticeQuestion()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.PracticeQuestion"/> class using
        /// the supplied practice question XML Data.
        /// </summary>
        /// <param name="_XMLData">The practice question XML data.</param>
        public PracticeQuestion(string _XMLData)
        {
            this._XMLData = _XMLData;
        }

        /// <summary>
        /// The XML data that describes the practice question.
        /// </summary>
        public string XMLData
        {
            get
            {
                return this._XMLData;
            }
            set
            {
                if ((this._XMLData != value))
                {
                    this._XMLData = value;
                    this.RaisePropertyChanged("XMLData");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.PracticeQuestion.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.PracticeQuestion.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.PracticeQuestion.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region ViewData
    /// <summary>
    /// Represents a View in the Granicus system.  A view is a collection of content that can be published using templates, web services,
    /// or feeds.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class ViewData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private int _ForeignID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private bool _IsActive;

        /// <remarks/>
        private IntegerCollection _Events;

        /// <remarks/>
        private IntegerCollection _Folders;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.ViewData"/> class.
        /// </summary>
        public ViewData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.ViewData"/> class using the specified
        /// Foreign ID, Name, Status, Event list and Folder list.
        /// </summary>
        /// <param name="_ID">The numeric ID for the view.  This will be reassigned when using CreateView().</param>
        /// <param name="_ForeignID">An integer representing the unique ID for the view in a partner integration's system.</param>
        /// <param name="_Name">The name that users (in MediaManager) will be presented with for the view.</param>
        /// <param name="_IsActive">A true/false value - if this is true, the view can be accessed.  Otherwise, the view is inaccessible.</param>
        /// <param name="_Events">An Int32Collection holding all of the numeric IDs of the events associated with this view.</param>
        /// <param name="_Folders">An Int32Collection holding all of the numeric IDs of the folders associated with this view.</param>
        public ViewData(int _ID, int _ForeignID, string _Name, bool _IsActive, IntegerCollection _Events, IntegerCollection _Folders)
        {
            this._ID = _ID;
            this._ForeignID = _ForeignID;
            this._Name = _Name;
            this._IsActive = _IsActive;
            this._Events = _Events;
            this._Folders = _Folders;
        }

        /// <summary>
        /// The numeric ID for the view.  This will be assigned automatically by the system and cannot be changed.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The Foreign ID (Non-Granicus ID) that will be associated with this view.
        /// </summary>
        public int ForeignID
        {
            get
            {
                return this._ForeignID;
            }
            set
            {
                if ((this._ForeignID != value))
                {
                    this._ForeignID = value;
                    this.RaisePropertyChanged("ForeignID");
                }
            }
        }

        /// <summary>
        /// The name of the view.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// If this is true, the view can be accessed.  Otherwise, the view is inaccessible.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                if ((this._IsActive != value))
                {
                    this._IsActive = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }

        /// <summary>
        /// An <see cref="Granicus.MediaManager.SDK.IntegerCollection"/> containing all of the numeric IDs of the events associated with this view.
        /// </summary>
        public IntegerCollection Events
        {
            get
            {
                return this._Events;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Events");
                }
                if ((this._Events != value))
                {
                    this._Events = value;
                    this.RaisePropertyChanged("Events");
                }
            }
        }

        /// <summary>
        /// An <see cref="Granicus.MediaManager.SDK.IntegerCollection"/> containing all of the numeric IDs of the folders associated with this view.
        /// </summary>
        public IntegerCollection Folders
        {
            get
            {
                return this._Folders;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Folders");
                }
                if ((this._Folders != value))
                {
                    this._Folders = value;
                    this.RaisePropertyChanged("Folders");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ViewData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.ViewData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ViewData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Returns a string with vital details about the ViewData object.
        /// </summary>
        public override string ToString()
        {
            string to_return = "Granicus.MediaManager.SDK.ViewData:\r\n";
            to_return += "Name: " + this.Name + "\r\n";
            to_return += "Events in view: \r\n";
            foreach (Int32 evnt in this.Events)
            {
                to_return += "\t" + evnt + "\r\n";
            }
            return to_return;
        }
    }
    #endregion

    #region KeyMapping
    /// <summary>
    /// A mapping of ForeignIDs to Granicus Numeric IDs.
    /// </summary>
    /// <remarks>
    /// Used when multiple new records are added to the Granicus system. The keymapping object allows the caller of a method to
    /// associate the newly generated Granicus numeric IDs with the ForeignIDs that were assigned to the objects that were
    /// added to the Granicus system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class KeyMapping : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ForeignID;

        /// <remarks/>
        private int _GranicusID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.KeyMapping"/> class.
        /// </summary>
        public KeyMapping()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.KeyMapping"/> class with the supplied
        /// ForeignID and GranicusID.
        /// </summary>
        /// <param name="_ForeignID">The ForeignID of the object that was added to the Granicus system.  Assigned by the caller.</param>
        /// <param name="_GranicusID">The Granicus numeric ID of the object that was added to the Granicus system.  Assigned by Granicus during the creation
        /// of the object.</param>
        public KeyMapping(int _ForeignID, int _GranicusID)
        {
            this._ForeignID = _ForeignID;
            this._GranicusID = _GranicusID;
        }

        /// <summary>
        /// The ForeignID of the object that was added to the Granicus system.  Assigned by the caller.
        /// </summary>
        public int ForeignID
        {
            get
            {
                return this._ForeignID;
            }
            set
            {
                if ((this._ForeignID != value))
                {
                    this._ForeignID = value;
                    this.RaisePropertyChanged("ForeignID");
                }
            }
        }

        /// <summary>
        /// The Granicus numeric ID of the object that was added to the Granicus system.  Assigned by Granicus during the creation
        /// of the object.
        /// </summary>
        public int GranicusID
        {
            get
            {
                return this._GranicusID;
            }
            set
            {
                if ((this._GranicusID != value))
                {
                    this._GranicusID = value;
                    this.RaisePropertyChanged("GranicusID");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.KeyMapping.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.KeyMapping.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.KeyMapping.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region CaptionData

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    //[System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    //public partial class CaptionData : object, System.ComponentModel.INotifyPropertyChanged
    //{

    //    /// <remarks/>
    //    private string _Caption;

    //    /// <remarks/>
    //    private long _TimeStamp;

    //    public CaptionData()
    //    {
    //    }

    //    public CaptionData(string _Caption, long _TimeStamp)
    //    {
    //        this._Caption = _Caption;
    //        this._TimeStamp = _TimeStamp;
    //    }

    //    public string Caption
    //    {
    //        get
    //        {
    //            return this._Caption;
    //        }
    //        set
    //        {
    //            if ((this._Caption != value))
    //            {
    //                this._Caption = value;
    //                this.RaisePropertyChanged("Caption");
    //            }
    //        }
    //    }

    //    public long TimeStamp
    //    {
    //        get
    //        {
    //            return this._TimeStamp;
    //        }
    //        set
    //        {
    //            if ((this._TimeStamp != value))
    //            {
    //                this._TimeStamp = value;
    //                this.RaisePropertyChanged("TimeStamp");
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// Occurs when a property value changes.
    //    /// </summary>
    //    /// <remarks>
    //    /// The <see cref="Granicus.MediaManager.SDK.CaptionData.PropertyChanged"/> event can indicate all properties
    //    /// on the object have changed by using either a null reference or String.Empty as the property name in the
    //    /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
    //    /// </remarks>
    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    //    /// <summary>
    //    /// Raises the <see cref="Granicus.MediaManager.SDK.CaptionData.PropertyChanged"/> event for the given property.
    //    /// </summary>
    //    /// <remarks>
    //    /// The <see cref="Granicus.MediaManager.SDK.CaptionData.PropertyChanged"/> event can indicate all properties
    //    /// on the object have changed by using either a null reference or String.Empty as the property name in the
    //    /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
    //    /// <param name="propertyName">The name of the property that was changed.</param>
    //    protected void RaisePropertyChanged(string propertyName)
    //    {
    //        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    //        if ((propertyChanged != null))
    //        {
    //            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}
    #endregion

    #region ServerInterfaceData
    /// <summary>
    /// ServerInterfaces define how a viewer is directed to a distribution server - what is the address for the content
    /// and which users will be directed to this server?
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class ServerInterfaceData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private int _ServerID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Host;

        /// <remarks/>
        private string _ControlPort;

        /// <remarks/>
        private string _Directory;

        /// <remarks/>
        private string _ReplicationUN;

        /// <remarks/>
        private string _ReplicationPW;

        /// <summary>
        /// Initiates a new instance of the <see cref="Granicus.MediaManager.SDK.ServerInterfaceData"/> class.
        /// </summary>
        public ServerInterfaceData()
        {
        }

        /// <summary>
        /// Initiates a new instance of the <see cref="Granicus.MediaManager.SDK.ServerInterfaceData"/> class
        /// to associate with the given ServerID.
        /// </summary>
        /// <param name="_ID">The numeric ID of the ServerInterface Object.  This will be ignored when you create the ServerInterface.</param>
        /// <param name="_ServerID">The numeric ID of the Server associated with this ServerInterface.</param>
        /// <param name="_Name">The Name provided to MediaManager users for this particular interface</param>
        /// <param name="_Host">The IP address or named address to which users will be directed.</param>
        /// <param name="_ControlPort">The Control Port of the Server.</param>
        /// <param name="_Directory">The directory on the server in which files are stored for the current client context.</param>
        /// <param name="_ReplicationUN">The Windows Username used to copy files to the given Server.</param>
        /// <param name="_ReplicationPW">The password associated with the given Username.</param>
        public ServerInterfaceData(int _ID, int _ServerID, string _Name, string _Host, string _ControlPort, string _Directory, string _ReplicationUN, string _ReplicationPW)
        {
            this._ID = _ID;
            this._ServerID = _ServerID;
            this._Name = _Name;
            this._Host = _Host;
            this._ControlPort = _ControlPort;
            this._Directory = _Directory;
            this._ReplicationUN = _ReplicationUN;
            this._ReplicationPW = _ReplicationPW;
        }

        /// <summary>
        /// The numeric ID of the ServerInterface Object.  This will be ignored when you create the ServerInterface.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The numeric ID of the Server associated with this ServerInterface.
        /// </summary>
        public int ServerID
        {
            get
            {
                return this._ServerID;
            }
            set
            {
                if ((this._ServerID != value))
                {
                    this._ServerID = value;
                    this.RaisePropertyChanged("ServerID");
                }
            }
        }

        /// <summary>
        /// The Name provided to MediaManager users for this particular interface
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The IP address or named address to which users will be directed.
        /// </summary>
        public string Host
        {
            get
            {
                return this._Host;
            }
            set
            {
                if ((this._Host != value))
                {
                    this._Host = value;
                    this.RaisePropertyChanged("Host");
                }
            }
        }

        /// <summary>
        /// The Control Port of the Server.
        /// </summary>
        public string ControlPort
        {
            get
            {
                return this._ControlPort;
            }
            set
            {
                if ((this._ControlPort != value))
                {
                    this._ControlPort = value;
                    this.RaisePropertyChanged("ControlPort");
                }
            }
        }

        /// <summary>
        /// The sub-directory on the server in which files are located.
        /// </summary>
        public string Directory
        {
            get
            {
                return this._Directory;
            }
            set
            {
                if ((this._Directory != value))
                {
                    this._Directory = value;
                    this.RaisePropertyChanged("Directory");
                }
            }
        }

        /// <summary>
        /// The Windows Username used to copy files to the given Server.
        /// </summary>
        public string ReplicationUN
        {
            get
            {
                return this._ReplicationUN;
            }
            set
            {
                if ((this._ReplicationUN != value))
                {
                    this._ReplicationUN = value;
                    this.RaisePropertyChanged("ReplicationUN");
                }
            }
        }

        /// <summary>
        /// The password associated with the given Username.
        /// </summary>
        public string ReplicationPW
        {
            get
            {
                return this._ReplicationPW;
            }
            set
            {
                if ((this._ReplicationPW != value))
                {
                    this._ReplicationPW = value;
                    this.RaisePropertyChanged("ReplicationPW");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ServerInterfaceData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.ServerInterfaceData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ServerInterfaceData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region ServerData
    /// <summary>
    /// A ServerData object represents a media distribution server within Granicus.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class ServerData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private int _ControlPort;

        /// <remarks/>
        private bool _FirewallCompatibility;

        /// <remarks/>
        private bool _Multicast;

        /// <remarks/>
        private int _LoadBalancerScore;

        /// <remarks/>
        private string _ReplicationUN;

        /// <remarks/>
        private string _ReplicationPW;

        /// <remarks/>
        private System.DateTime _CreatedDate;

        /// <summary>
        /// Instantiates a new instance of the <see cref="Granicus.MediaManager.SDK.ServerData"/> class.
        /// </summary>
        public ServerData()
        {
        }

        /// <summary>
        /// Instantiates a new instance of the <see cref="Granicus.MediaManager.SDK.ServerData"/> class using the supplied ID,
        /// Name, ControlPort, FirewallCompatibility, Multicast, LoadBalancerScore, ReplicationUN and ReplicationPW.
        /// </summary>
        /// <param name="_ID">The numeric ID for the server.  This value is generated by the system and will be ignored.</param>
        /// <param name="_Name">The unique name assigned to the server.  This must not match any other server names.</param>
        /// <param name="_ControlPort">The port on which the Distribution Server's web services are running (usually 443 or 80)</param>
        /// <param name="_FirewallCompatibility">This controls whether the server makes outbound requests for videos or instead allows inbound connections.</param>
        /// <param name="_Multicast">If this is set to true, then the requests for video from this server will include multicast request information.</param>
        /// <param name="_LoadBalancerScore">If you have several servers streaming the same data, you can theoretically control the frequency of requests with this value.</param>
        /// <param name="_ReplicationUN">The Windows username used to transfer files to this server.</param>
        /// <param name="_ReplicationPW">The password associated with the USERNAME account.</param>
        /// <param name="_CreatedDate">The date the server entry was created in the Granicus database. This value is generated by the system and will be ignored.</param>
        public ServerData(int _ID, string _Name, int _ControlPort, bool _FirewallCompatibility, bool _Multicast, int _LoadBalancerScore, string _ReplicationUN, string _ReplicationPW, System.DateTime _CreatedDate)
        {
            this._ID = _ID;
            this._Name = _Name;
            this._ControlPort = _ControlPort;
            this._FirewallCompatibility = _FirewallCompatibility;
            this._Multicast = _Multicast;
            this._LoadBalancerScore = _LoadBalancerScore;
            this._ReplicationUN = _ReplicationUN;
            this._ReplicationPW = _ReplicationPW;
            this._CreatedDate = _CreatedDate;
        }

        /// <summary>
        /// This the recommended Constructor.  Create a new Object representing a Distribution Server.
        /// </summary>
        /// <param name="_Name">The unique name assigned to the server.  This must not match any other server names.</param>
        /// <param name="_ControlPort">The port on which the Distribution Server's web services are running (usually 443 or 80)</param>
        /// <param name="_FirewallCompatibility">This controls whether the server makes outbound requests for videos or instead allows inbound connections.</param>
        /// <param name="_Multicast">If this is set to true, then the requests for video from this server will include multicast request information.</param>
        /// <param name="_ReplicationUN">The Windows username used to transfer files to this server.</param>
        /// <param name="_ReplicationPW">The password associated with the USERNAME account.</param>
        public ServerData(string _Name, int _ControlPort, bool _FirewallCompatibility, bool _Multicast, string _ReplicationUN, string _ReplicationPW)
        {
            this._Name = _Name;
            this._ControlPort = _ControlPort;
            this._FirewallCompatibility = _FirewallCompatibility;
            this._Multicast = _Multicast;
            this._LoadBalancerScore = 10;
            this._ReplicationUN = _ReplicationUN;
            this._ReplicationPW = _ReplicationPW;
            this._CreatedDate = System.DateTime.Now;  //hopefully this will be ignored when created?
        }

        /// <summary>
        /// The numeric ID for the server.  This value is generated by the system and will be ignored.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The unique name assigned to the server.  This must not match any other server names.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The port on which the Distribution Server's web services are running (usually 443 or 80)
        /// </summary>
        public int ControlPort
        {
            get
            {
                return this._ControlPort;
            }
            set
            {
                if ((this._ControlPort != value))
                {
                    this._ControlPort = value;
                    this.RaisePropertyChanged("ControlPort");
                }
            }
        }

        /// <summary>
        /// This controls whether the server makes outbound requests for videos or instead allows inbound connections.
        /// </summary>
        public bool FirewallCompatibility
        {
            get
            {
                return this._FirewallCompatibility;
            }
            set
            {
                if ((this._FirewallCompatibility != value))
                {
                    this._FirewallCompatibility = value;
                    this.RaisePropertyChanged("FirewallCompatibility");
                }
            }
        }

        /// <summary>
        /// If this is set to true, then the requests for video from this server will include multicast request information.
        /// </summary>
        public bool Multicast
        {
            get
            {
                return this._Multicast;
            }
            set
            {
                if ((this._Multicast != value))
                {
                    this._Multicast = value;
                    this.RaisePropertyChanged("Multicast");
                }
            }
        }

        /// <summary>
        /// If you have several servers streaming the same data, you can theoretically control the frequency of requests with this value.
        /// </summary>
        public int LoadBalancerScore
        {
            get
            {
                return this._LoadBalancerScore;
            }
            set
            {
                if ((this._LoadBalancerScore != value))
                {
                    this._LoadBalancerScore = value;
                    this.RaisePropertyChanged("LoadBalancerScore");
                }
            }
        }

        /// <summary>
        /// The Windows username used to transfer files to this server.
        /// </summary>
        public string ReplicationUN
        {
            get
            {
                return this._ReplicationUN;
            }
            set
            {
                if ((this._ReplicationUN != value))
                {
                    this._ReplicationUN = value;
                    this.RaisePropertyChanged("ReplicationUN");
                }
            }
        }

        /// <summary>
        /// The password associated with the USERNAME account.
        /// </summary>
        public string ReplicationPW
        {
            get
            {
                return this._ReplicationPW;
            }
            set
            {
                if ((this._ReplicationPW != value))
                {
                    this._ReplicationPW = value;
                    this.RaisePropertyChanged("ReplicationPW");
                }
            }
        }

        /// <summary>
        /// The date the server entry was created in the Granicus database.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ServerData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.ServerData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ServerData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region TemplateData
    /// <summary>
    /// Represents a template in the Granicus system that can be used for generating web pages or documents.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class TemplateData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Description;

        /// <remarks/>
        private string _Type;

        /// <remarks/>
        private System.DateTime _LastModified;

        /// <remarks/>
        private System.DateTime _CreatedDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.TemplateData"/> class.
        /// </summary>
        public TemplateData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.TemplateData"/> class using the supplied
        /// Name, Description, and Type.
        /// </summary>
        /// <param name="_ID">The numeric ID assigned to the template.  This value is generated by the system and cannot be changed.</param>
        /// <param name="_Name">The Name to be assigned to the template.</param>
        /// <param name="_Description">A brief description of the template's purpose.</param>
        /// <param name="_Type">One of four types: "Player", "View", "Document", or "Word"</param>
        /// <param name="_LastModified">The last time the template was modified.  This value is generated by the system and cannot be changed.</param>
        /// <param name="_CreatedDate">The date when the template was created.  This value is generated by the system and cannot be changed.</param>
        public TemplateData(int _ID, string _Name, string _Description, string _Type, System.DateTime _LastModified, System.DateTime _CreatedDate)
        {
            this._ID = _ID;
            this._Name = _Name;
            this._Description = _Description;
            this._Type = _Type;
            this._LastModified = _LastModified;
            this._CreatedDate = _CreatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.TemplateData"/> class using the supplied
        /// Name, Description and Type.
        /// </summary>
        /// <param name="_Name">The Name to be assigned to the template.</param>
        /// <param name="_Description">A brief description of the template's purpose.</param>
        /// <param name="_Type">One of four types: "Player", "View", "Document", or "Word"</param>
        public TemplateData(string _Name, string _Description, string _Type)
        {
            this._Name = _Name;
            this._Description = _Description;
            this._Type = _Type;
        }

        /// <summary>
        /// The numeric ID assigned to the template.  This value is generated by the system and cannot be changed.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The name of the template.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// A short description of the templates purpose.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// The type of the template.
        /// </summary>
        /// <remarks>
        /// Valid values are:
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>Player</term><description>A player template, used to display video players.</description></item>
        /// <item><term>View</term><description>A view template is used to build media portals using the views system.</description></item>
        /// <item><term>Document</term><description>A document template is used to format MetaData into Agenda and Minutes HTML documents.</description></item>
        /// <item><term>Word</term><description>A Word template is used by the Word Integration to format MetaData into Agenda and Minutes Word Documents</description></item>
        /// </list></remarks>
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this._Type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// The last time the template was modified.  This value is generated by the system and cannot be changed.
        /// </summary>
        public System.DateTime LastModified
        {
            get
            {
                return this._LastModified;
            }
            set
            {
                if ((this._LastModified != value))
                {
                    this._LastModified = value;
                    this.RaisePropertyChanged("LastModified");
                }
            }
        }

        /// <summary>
        /// The date when the template was created.  This value is generated by the system and cannot be changed.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.TemplateData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.TemplateData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.TemplateData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region GroupData
    /// <summary>
    /// Represents a group of users within the Granicus system.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class GroupData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Description;

        /// <remarks/>
        private System.DateTime _CreatedDate;


        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.GroupData"/> class.
        /// </summary>
        public GroupData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.GroupData"/> class with the supplied
        /// values for name and description.
        /// </summary>
        /// <param name="_ID">The numeric ID of the group.  This value is assigned for you and cannot be changed.</param>
        /// <param name="_UID">The unique ID of the group.</param>
        /// <param name="_Name">The name of the group.</param>
        /// <param name="_Description">A short description of the group and it's purpose.</param>
        /// <param name="_CreatedDate">The date the group was created.  This value cannot be changed.</param>
        public GroupData(int _ID, string _UID, string _Name, string _Description, System.DateTime _CreatedDate)
        {
            this._ID = _ID;
            this._UID = _UID;
            this._Name = _Name;
            this._Description = _Description;
            this._CreatedDate = _CreatedDate;
        }

        /// <summary>
        /// The numeric ID of the group.  This value is assigned for you and cannot be changed.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The UID of the group.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The name of the group.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// A short description of the group and it's purpose.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// The date the group was created.  This value cannot be changed.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.GroupData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.GroupData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.GroupData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region UserData
    /// <summary>
    /// Represents a user within the Granicus system.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class UserData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private string _Username;

        /// <remarks/>
        private string _Password;

        /// <remarks/>
        private string _FirstName;

        /// <remarks/>
        private string _LastName;

        /// <remarks/>
        private string _MiddleName;

        /// <remarks/>
        private string _Phone;

        /// <remarks/>
        private string _Email;

        /// <remarks/>
        private System.DateTime _CreatedDate;

        /// <remarks/>
        private System.DateTime _LastModified;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.UserData"/> class.
        /// </summary>
        public UserData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.UserData"/> class with the supplied values.
        /// </summary>
        /// <param name="_ID">The numeric ID of the user.  This ID is assigned by the system and cannot be changed.</param>
        /// <param name="_Username">The unique logon name of the user.</param>
        /// <param name="_Password">The password the user may use to login.</param>
        /// <param name="_FirstName">The First name of the user.</param>
        /// <param name="_MiddleName">The Middle name of the user.</param>
        /// <param name="_LastName">The Last name of the user.</param>
        /// <param name="_Email">The user's email address.</param>
        /// <param name="_CreatedDate">The date the user was created. Cannot be changed.</param>
        /// <param name="_LastModified">The date the user record was last modified. Cannot be changed.</param>
        public UserData(int _ID, string _Username, string _Password, string _FirstName, string _MiddleName, string _LastName, string _Email, System.DateTime _CreatedDate, System.DateTime _LastModified)
        {
            this._ID = _ID;
            this._Username = _Username;
            this._Password = _Password;
            this._FirstName = _FirstName;
            this._MiddleName = _MiddleName;
            this._LastName = _LastName;
            this._Email = _Email;
            this._CreatedDate = _CreatedDate;
            this._LastModified = _LastModified;
        }

        /// <summary>
        /// The numeric ID of the user. This ID is assigned by the system and cannot be changed.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The UID of the user.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The unique logon name of the user.
        /// </summary>
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                if ((this._Username != value))
                {
                    this._Username = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }

        /// <summary>
        /// The password the user may use to login.
        /// </summary>
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if ((this._Password != value))
                {
                    this._Password = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if ((this._FirstName != value))
                {
                    this._FirstName = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }

        /// <summary>
        /// The middle name of the user.
        /// </summary>
        public string MiddleName
        {
            get
            {
                return this._MiddleName;
            }
            set
            {
                if ((this._MiddleName != value))
                {
                    this._MiddleName = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if ((this._LastName != value))
                {
                    this._LastName = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                if ((this._Phone != value))
                {
                    this._Phone = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }

        /// <summary>
        /// The user's email address.
        /// </summary>
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if ((this._Email != value))
                {
                    this._Email = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// The date the user was created. Cannot be changed.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// The date the user record was last modified. Cannot be changed.
        /// </summary>
        public System.DateTime LastModified
        {
            get
            {
                return this._LastModified;
            }
            set
            {
                if ((this._LastModified != value))
                {
                    this._LastModified = value;
                    this.RaisePropertyChanged("LastModified");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region ClipData
    /// <summary>
    /// Represents a video clip within Granicus.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class ClipData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private string _EventUID;

        /// <remarks/>
        private int _ForeignID;

        /// <remarks/>
        private string _Type;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Description;

        /// <remarks/>
        private string _Keywords;

        /// <remarks/>
        private System.DateTime _Date;

        /// <remarks/>
        private int _CameraID;

        /// <remarks/>
        private int _FolderID;

        /// <remarks/>
        private string _FileName;

        /// <remarks/>
        private string _MinutesType;

        /// <remarks/>
        private string _MinutesFile;

        /// <remarks/>
        private string _AgendaType;

        /// <remarks/>
        private string _AgendaFile;

        /// <remarks/>
        private int _Duration;

        /// <remarks/>
        private string _Status;

        /// <remarks/>
        private System.DateTime _StartTime;

        /// <remarks/>
        private System.DateTime _LastModified;

        /// <remarks/>
        private AttendeeCollection _Attendees;

        /// <remarks/>
        private StringCollection _MotionTypes;

        /// <remarks/>
        private string _Street1;

        /// <remarks/>
        private string _Street2;

        /// <remarks/>
        private string _City;

        /// <remarks/>
        private string _State;

        /// <remarks/>
        private string _Zip;

        /// <remarks/>
        private string _AgendaTitle;

        /// <remarks/>
        private System.DateTime _AgendaPostedDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.ClipData"/> class.
        /// </summary>
        public ClipData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.ClipData"/> and populates it
        /// with the supplied values.
        /// </summary>
        /// <param name="_ID">The numeric ID of the Clip (this is ignored by the system when creating new clips and a new ID will be assigned for you).</param>
        /// <param name="_UID">The new Unique ID string (GUID) of the clip.</param>
        /// <param name="_EventUID">Unique ID string (GUID) of the event related to clip</param>
        /// <param name="_ForeignID">The Foreign ID of the clip.</param>
        /// <param name="_Type">The type of clip (e.g. Training, Meeting, PSA, etc)</param>
        /// <param name="_Name">The name of the clip.</param>
        /// <param name="_Description">A short description of the clip.</param>
        /// <param name="_Keywords">The keywords associated with the clip.</param>
        /// <param name="_Date">The date of the clip.</param>
        /// <param name="_CameraID">The numeric ID of the camera that created the clip, if any.</param>
        /// <param name="_FolderID">The folder in which the clip resides.</param>
        /// <param name="_FileName">The physical filename of the clip.  This will be ignored and a filename will be assigned for you.</param>
        /// <param name="_MinutesType">The value for the <see cref="Granicus.MediaManager.SDK.ClipData.MinutesType"/> property.</param>
        /// <param name="_MinutesFile">The URL or filename of the minutes document.</param>
        /// <param name="_AgendaType">The value for the <see cref="Granicus.MediaManager.SDK.ClipData.AgendaType"/> property.</param>
        /// <param name="_AgendaFile">The URL or filename of the agenda document.</param>
        /// <param name="_Duration">The duration of the clip, in seconds.</param>
        /// <param name="_Status">The status of the clip (Public, Not Public, etc).</param>
        /// <param name="_StartTime">The date and time at which the video starts.</param>
        /// <param name="_LastModified">The last modified date.  This will be ignored and assigned when new data is written.</param>
        /// <param name="_Attendees">The meeting attendees for the given video, if any.</param>
        /// <param name="_MotionTypes">The valid motion types for this video.</param>
        /// <param name="_Street1">The first part of the street address for the clip.</param>
        /// <param name="_Street2">The second part of the street address for the clip.</param>
        /// <param name="_City">The city in which the event clip took place.</param>
        /// <param name="_State">The state in which the clip took place.</param>
        /// <param name="_Zip">The zip code in which the clip took place.</param>
        /// <param name="_AgendaTitle">The title of the agenda for the meeting.</param>
        /// <param name="_AgendaPostedDate">The date the agenda was posted for this meeting.</param>
        public ClipData(
                    int _ID,
                    string _UID,
                    string _EventUID,
                    int _ForeignID,
                    string _Type,
                    string _Name,
                    string _Description,
                    string _Keywords,
                    System.DateTime _Date,
                    int _CameraID,
                    int _FolderID,
                    string _FileName,
                    string _MinutesType,
                    string _MinutesFile,
                    string _AgendaType,
                    string _AgendaFile,
                    int _Duration,
                    string _Status,
                    System.DateTime _StartTime,
                    System.DateTime _LastModified,
                    AttendeeCollection _Attendees,
                    StringCollection _MotionTypes,
                    string _Street1,
                    string _Street2,
                    string _City,
                    string _State,
                    string _Zip,
                    string _AgendaTitle,
                    DateTime _AgendaPostedDate)
        {
            this._ID = _ID;
            this._UID = _UID;
            this._EventUID = _EventUID;
            this._ForeignID = _ForeignID;
            this._Type = _Type;
            this._Name = _Name;
            this._Description = _Description;
            this._Keywords = _Keywords;
            this._Date = _Date;
            this._CameraID = _CameraID;
            this._FolderID = _FolderID;
            this._FileName = _FileName;
            this._MinutesType = _MinutesType;
            this._MinutesFile = _MinutesFile;
            this._AgendaType = _AgendaType;
            this._AgendaFile = _AgendaFile;
            this._Duration = _Duration;
            this._Status = _Status;
            this._StartTime = _StartTime;
            this._LastModified = _LastModified;
            this._Attendees = _Attendees;
            this._MotionTypes = _MotionTypes;
            this._Street1 = _Street1;
            this._Street2 = _Street2;
            this._City = _City;
            this._State = _State;
            this._Zip = _Zip;
            this._AgendaTitle = _AgendaTitle;
            this._AgendaPostedDate = _AgendaPostedDate;
        }

        /// <summary>
        /// The numeric database ID of the video.  This value is always assigned by the system and should never be changed.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The string representation of the video's GUID.  This value can be assigned when creating a new video, but should never
        /// be updated or changed for existing videos.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The string representation of the associated event's GUID.
        /// </summary>
        public string EventUID
        {
            get
            {
                return this._EventUID;
            }
            set
            {
                if ((this._EventUID != value))
                {
                    this._EventUID = value;
                    this.RaisePropertyChanged("EventUID");
                }
            }
        }

        /// <summary>
        /// The Foreign ID of the clip.  This can be used for tracking numeric IDs that exist outside of the Granicus system, such as
        /// the numeric ID of a related record in an integrated system.
        /// </summary>
        public int ForeignID
        {
            get
            {
                return this._ForeignID;
            }
            set
            {
                if ((this._ForeignID != value))
                {
                    this._ForeignID = value;
                    this.RaisePropertyChanged("ForeignID");
                }
            }
        }

        /// <summary>
        /// The type of the video.  Valid Granicus recognized values are "Meeting" and "Training".  Other values may be used but
        /// will not be recognized by the Granicus system at this time.
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this._Type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// The name of the video.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// A short description of the video and it's contents.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// Keywords for the video, used during searches.
        /// </summary>
        public string Keywords
        {
            get
            {
                return this._Keywords;
            }
            set
            {
                if ((this._Keywords != value))
                {
                    this._Keywords = value;
                    this.RaisePropertyChanged("Keywords");
                }
            }
        }

        /// <summary>
        /// The date of the video.
        /// </summary>
        public System.DateTime Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                if ((this._Date != value))
                {
                    this._Date = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }

        /// <summary>
        /// The numeric ID of the Granicus camera that recorded the clip. If not recorded by a Granicus camera, this value should
        /// be set to 0.
        /// </summary>
        public int CameraID
        {
            get
            {
                return this._CameraID;
            }
            set
            {
                if ((this._CameraID != value))
                {
                    this._CameraID = value;
                    this.RaisePropertyChanged("CameraID");
                }
            }
        }

        /// <summary>
        /// The numeric ID of the Folder within the Granicus system in which the video resides.
        /// </summary>
        public int FolderID
        {
            get
            {
                return this._FolderID;
            }
            set
            {
                if ((this._FolderID != value))
                {
                    this._FolderID = value;
                    this.RaisePropertyChanged("FolderID");
                }
            }
        }

        /// <summary>
        /// The physical filename of the video within the Granicus storage architecture.  This value can never be assigned by the
        /// SDK as it's value is assigned by the storage architecture itself.
        /// </summary>
        public string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                if ((this._FileName != value))
                {
                    this._FileName = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }

        /// <summary>
        /// The type of the Minutes document that is in use.  Usually set to "linked".
        /// </summary>
        /// <remarks>
        /// Valid values are:
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>none</term><description>No minutes are published.</description></item>
        /// <item><term>linked</term><description>The minutes are a link to an external source.</description></item>
        /// <item><term>uploaded</term><description>The minutes are an uploaded document, such as a PDF</description></item>
        /// <item><term>generated</term><description>The minutes are to be generated from a template.</description></item>
        /// </list></remarks>
        public string MinutesType
        {
            get
            {
                return this._MinutesType;
            }
            set
            {
                if ((this._MinutesType != value))
                {
                    this._MinutesType = value;
                    this.RaisePropertyChanged("MinutesType");
                }
            }
        }

        /// <summary>
        /// The URL or filename of the minutes document.
        /// </summary>
        public string MinutesFile
        {
            get
            {
                return this._MinutesFile;
            }
            set
            {
                if ((this._MinutesFile != value))
                {
                    this._MinutesFile = value;
                    this.RaisePropertyChanged("MinutesFile");
                }
            }
        }

        /// <summary>
        /// The type of the Agenda document that is in use.  Usually set to "linked".
        /// </summary>
        /// <remarks>
        /// Valid values are:
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>none</term><description>No agenda is published.</description></item>
        /// <item><term>linked</term><description>The agenda is a link to an external source.</description></item>
        /// <item><term>uploaded</term><description>The agenda is an uploaded document, such as a PDF</description></item>
        /// <item><term>generated</term><description>The agenda is to be generated from a template.</description></item>
        /// </list></remarks>
        public string AgendaType
        {
            get
            {
                return this._AgendaType;
            }
            set
            {
                if ((this._AgendaType != value))
                {
                    this._AgendaType = value;
                    this.RaisePropertyChanged("AgendaType");
                }
            }
        }

        /// <summary>
        /// The URL or filename of the agenda document.
        /// </summary>
        public string AgendaFile
        {
            get
            {
                return this._AgendaFile;
            }
            set
            {
                if ((this._AgendaFile != value))
                {
                    this._AgendaFile = value;
                    this.RaisePropertyChanged("AgendaFile");
                }
            }
        }

        /// <summary>
        /// The duration, in seconds, of the video clip.
        /// </summary>
        public int Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                if ((this._Duration != value))
                {
                    this._Duration = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }

        /// <summary>
        /// The status of the video clip, valid values are determined by configuration.
        /// </summary>
        /// <remarks>
        /// The default valid values are:
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>Public</term><description>The video is publicly accessable.</description></item>
        /// <item><term>Not-Public</term><description>The video is not publicly accessable.</description></item>
        /// <item><term>Pending</term><description>The video is currently not public pending action by staff.</description></item>
        /// </list></remarks>
        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this._Status = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        /// <summary>
        /// The start time of the video.
        /// </summary>
        /// <remarks>
        /// The start time of the video is used to calculate absolute date time offsets for indexing when absolute times are used,
        /// as well as the start time in any generated documents (such as Agendas or Minutes).</remarks>
        public System.DateTime StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                if ((this._StartTime != value))
                {
                    this._StartTime = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }

        /// <summary>
        /// The last time this video was modified.
        /// </summary>
        public System.DateTime LastModified
        {
            get
            {
                return this._LastModified;
            }
            set
            {
                if ((this._LastModified != value))
                {
                    this._LastModified = value;
                    this.RaisePropertyChanged("LastModified");
                }
            }
        }

        /// <summary>
        /// The attendees, or people involved, with the video.
        /// </summary>
        public AttendeeCollection Attendees
        {
            get
            {
                return this._Attendees;
            }
            set
            {
                if ((this._Attendees != value))
                {
                    this._Attendees = value;
                    this.RaisePropertyChanged("Attendees");
                }
            }
        }

        /// <summary>
        /// The valid motion types for the video.
        /// </summary>
        public StringCollection MotionTypes
        {
            get
            {
                return this._MotionTypes;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("MotionTypes");
                }
                if ((this._MotionTypes != value))
                {
                    this._MotionTypes = value;
                    this.RaisePropertyChanged("MotionTypes");
                }
            }
        }


        /// <summary>
        /// The first part of the street address for the event.
        /// </summary>
        public string Street1
        {
            get
            {
                return this._Street1;
            }
            set
            {
                if ((this._Street1 != value))
                {
                    this._Street1 = value;
                    this.RaisePropertyChanged("Street1");
                }
            }
        }

        /// <summary>
        /// The second part of the street address for the event.
        /// </summary>
        public string Street2
        {
            get
            {
                return this._Street2;
            }
            set
            {
                if ((this._Street2 != value))
                {
                    this._Street2 = value;
                    this.RaisePropertyChanged("Street2");
                }
            }
        }

        /// <summary>
        /// The city in which the event is to take place.
        /// </summary>
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if ((this._City != value))
                {
                    this._City = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }

        /// <summary>
        /// The state in which the event is to take place.
        /// </summary>
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this._State = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }

        /// <summary>
        /// The zip code in which the event is to take place.
        /// </summary>
        public string Zip
        {
            get
            {
                return this._Zip;
            }
            set
            {
                if ((this._Zip != value))
                {
                    this._Zip = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }

        /// <summary>
        /// The title of the agenda for the event.
        /// </summary>
        public string AgendaTitle
        {
            get
            {
                return this._AgendaTitle;
            }
            set
            {
                if ((this._AgendaTitle != value))
                {
                    this._AgendaTitle = value;
                    this.RaisePropertyChanged("AgendaTitle");
                }
            }
        }

        /// <summary>
        /// The last modified time of the event.  This property is assigned automatically by the system and will be ignored.
        /// </summary>
        public System.DateTime AgendaPostedDate
        {
            get
            {
                return this._AgendaPostedDate;
            }
            set
            {
                if ((this._AgendaPostedDate != value))
                {
                    this._AgendaPostedDate = value;
                    this.RaisePropertyChanged("AgendaPostedDate");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ClipData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.ClipData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.ClipData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Attendee
    /// <summary>
    /// Represents a meeting attendee.
    /// </summary>
    /// <remarks>
    /// All meetings have attendees.  This class is used to represent a meeting attendee.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Attendee : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private int _OrderID;

        /// <remarks/>
        private bool _Voting;

        /// <remarks/>
        private bool _Chair;

        /// <remarks/>
        private string _PersonUID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Attendee"/> class.
        /// </summary>
        public Attendee()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Attendee"/> class with the supplied
        /// Name, OrderID, Voting Flag and Chair Flag.  The ID parameter is ignored.
        /// </summary>
        /// <param name="_ID">The numeric ID of the Attendee.  This value is ignored when creating new Attendees.</param>
        /// <param name="_Name">The full name of the Attendee.</param>
        /// <param name="_OrderID">The order index of the Attendee in the Attendee list.</param>
        /// <param name="_Voting">Whether or not the Attendee should participate in voting.</param>
        /// <param name="_Chair">Whether or not the Attendee is the chair of the meeting body.</param>
        public Attendee(int _ID, string _Name, int _OrderID, bool _Voting, bool _Chair)
        {
            this._ID = _ID;
            this._Name = _Name;
            this._OrderID = _OrderID;
            this._Voting = _Voting;
            this._Chair = _Chair;
        }

        /// <summary>
        /// The unique numeric Attendee ID for the attendee.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The full name of the attendee.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The position of the attendee in the attendee list.
        /// </summary>
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                if ((this._OrderID != value))
                {
                    this._OrderID = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }

        /// <summary>
        /// Whether or not the attendee should be allowed to vote during the meeting.
        /// </summary>
        public bool Voting
        {
            get
            {
                return this._Voting;
            }
            set
            {
                if ((this._Voting != value))
                {
                    this._Voting = value;
                    this.RaisePropertyChanged("Voting");
                }
            }
        }

        /// <summary>
        /// Whether or not the attendee is the Chair of the meeting body.
        /// </summary>
        public bool Chair
        {
            get
            {
                return this._Chair;
            }
            set
            {
                if ((this._Chair != value))
                {
                    this._Chair = value;
                    this.RaisePropertyChanged("Chair");
                }
            }
        }

        /// <summary>
        /// Whether or not the attendee is the Chair of the meeting body.
        /// </summary>
        public string PersonUID
        {
            get
            {
                return this._PersonUID;
            }
            set
            {
                if ((this._PersonUID != value))
                {
                    this._PersonUID = value;
                    this.RaisePropertyChanged("PersonUID");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Attendee.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.Attendee.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.Attendee.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region FolderData
    /// <summary>
    /// Represents a folder for storing videos within the Granicus system.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class FolderData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Description;

        /// <remarks/>
        private string _Type;

        /// <remarks/>
        private int _PlayerTemplateID;

        /// <remarks/>
        private System.DateTime _CreatedDate;

        /// <remarks/>
        private IntegerCollection _Views;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.FolderData"/> class.
        /// </summary>
        public FolderData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.FolderData"/> class with the supplied
        /// values.
        /// </summary>
        /// <param name="_ID">Numeric ID of the folder.  This value is ignored and a new value will be generated by the system for you.</param>
        /// <param name="_Name">The name of the folder.</param>
        /// <param name="_Description">A short description of the folder.</param>
        /// <param name="_Type">The type of the folder.  Current supported values are "Meeting" and "Training".</param>
        /// <param name="_PlayerTemplateID">The numeric ID of the player template used when viewing archives within the folder.</param>
        /// <param name="_CreatedDate">The date the folder was created.  Cannot be updated.</param>
        /// <param name="_Views">Views for the folder</param>
        public FolderData(int _ID, string _Name, string _Description, string _Type, int _PlayerTemplateID, System.DateTime _CreatedDate, IntegerCollection _Views)
        {
            this._ID = _ID;
            this._Name = _Name;
            this._Description = _Description;
            this._Type = _Type;
            this._PlayerTemplateID = _PlayerTemplateID;
            this._CreatedDate = _CreatedDate;
            this._Views = _Views;
        }

        /// <summary>
        /// Numeric ID of the folder.
        /// </summary>
        /// <remarks>This value is ignored and a new value will be generated by the system for you.</remarks>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// A short description of the folder.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// The type of the folder.  Current supported values are "Meeting" and "Training".
        /// </summary>
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this._Type = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// The numeric ID of the player template used when viewing archives within the folder.
        /// </summary>
        public int PlayerTemplateID
        {
            get
            {
                return this._PlayerTemplateID;
            }
            set
            {
                if ((this._PlayerTemplateID != value))
                {
                    this._PlayerTemplateID = value;
                    this.RaisePropertyChanged("PlayerTemplateID");
                }
            }
        }

        /// <summary>
        /// The date the folder was created.  Cannot be updated.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// An <see cref="Granicus.MediaManager.SDK.IntegerCollection"/> containing all of the numeric IDs of the views associated with this folder.
        /// </summary>
        public IntegerCollection Views
        {
            get
            {
                return this._Views;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Views");
                }
                if ((this._Views != value))
                {
                    this._Views = value;
                    this.RaisePropertyChanged("Views");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region PublishClipData
    /// <summary>
    /// Represents a folder for storing videos within the Granicus system.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class PublishClipData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ClipID;
        
        private bool _Public;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Title;

        /// <remarks/>
        private string _TextField;

        /// <remarks/>
        private int _TemplateID;

        /// <remarks/>
        private int _MetaID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.PublishClipData"/> class.
        /// </summary>
        public PublishClipData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.PublishClipData"/> class with the supplied
        /// </summary>
        public PublishClipData(int _ClipID, bool _Public, string _Name, string _Title, string _TextField, int _TemplateID, int _MetaID)
        {
            this._ClipID = _ClipID;
            this._Public = _Public;
            this._Name = _Name;
            this._Title = _Title;
            this._TextField = _TextField;
            this._TemplateID = _TemplateID;
            this._MetaID = _MetaID;
        }

        /// <summary>
        /// Clip ID.
        /// </summary>
        /// <remarks></remarks>
        public int ClipID
        {
            get
            {
                return this._ClipID;
            }
            set
            {
                if ((this._ClipID != value))
                {
                    this._ClipID = value;
                    this.RaisePropertyChanged("ClipID");
                }
            }
        }

        /// <summary>
        /// Clip ID.
        /// </summary>
        /// <remarks></remarks>
        public bool Public
        {
            get
            {
                return this._Public;
            }
            set
            {
                if ((this._Public != value))
                {
                    this._Public = value;
                    this.RaisePropertyChanged("Public");
                }
            }
        }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// </summary>
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if ((this._Title != value))
                {
                    this._Title = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }

        /// <summary>
        /// </summary>
        public string TextField
        {
            get
            {
                return this._TextField;
            }
            set
            {
                if ((this._TextField != value))
                {
                    this._TextField = value;
                    this.RaisePropertyChanged("TextField");
                }
            }
        }

        /// <summary>
        /// </summary>
        public int TemplateID
        {
            get
            {
                return this._TemplateID;
            }
            set
            {
                if ((this._TemplateID != value))
                {
                    this._TemplateID = value;
                    this.RaisePropertyChanged("TemplateID");
                }
            }
        }
        /// <summary>
        /// </summary>
        public int MetaID
        {
            get
            {
                return this._MetaID;
            }
            set
            {
                if ((this._MetaID != value))
                {
                    this._MetaID = value;
                    this.RaisePropertyChanged("MetaID");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion


    #region PublishClipResult
    /// <summary>
    /// Represents a folder for storing videos within the Granicus system.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class PublishClipResult : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ClipID;

        private string _URL;

        /// <remarks/>
        private string _PublishPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.PublishClipData"/> class.
        /// </summary>
        public PublishClipResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.PublishClipData"/> class with the supplied
        /// </summary>
        public PublishClipResult(int _ClipID, string _URL, string _PublishPoint)
        {
            this._ClipID = _ClipID;
            this._URL = _URL;
            this._PublishPoint = _PublishPoint;
        }

        /// <summary>
        /// Clip ID.
        /// </summary>
        /// <remarks></remarks>
        public int ClipID
        {
            get
            {
                return this._ClipID;
            }
            set
            {
                if ((this._ClipID != value))
                {
                    this._ClipID = value;
                    this.RaisePropertyChanged("ClipID");
                }
            }
        }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        public string URL
        {
            get
            {
                return this._URL ;
            }
            set
            {
                if ((this._URL != value))
                {
                    this._URL = value;
                    this.RaisePropertyChanged("URL");
                }
            }
        }

        /// <summary>
        /// </summary>
        public string PublishPoint
        {
            get
            {
                return this._PublishPoint;
            }
            set
            {
                if ((this._PublishPoint != value))
                {
                    this._PublishPoint = value;
                    this.RaisePropertyChanged("PublishPoint");
                }
            }
        }
        

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.FolderData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region MetaDataData
    /// <summary>
    /// The foundation for agenda and minutes trees in the Granicus system.
    /// </summary>
    /// <remarks>
    /// The MetaDataData class is used to create trees of MetaData that are attached to a clip or event. The class serves as a
    /// container for a payload that can be one of the following types:
    /// <list type="bullet">
    /// <item><description><see cref="Granicus.MediaManager.SDK.AgendaItem"/></description></item>
    /// <item><description><see cref="Granicus.MediaManager.SDK.Note"/></description></item>
    /// <item><description><see cref="Granicus.MediaManager.SDK.Document"/></description></item>
    /// <item><description><see cref="Granicus.MediaManager.SDK.Rollcall"/></description></item>
    /// <item><description><see cref="Granicus.MediaManager.SDK.Motion"/></description></item>
    /// <item><description><see cref="Granicus.MediaManager.SDK.VoteRecord"/></description></item>
    /// </list>
    /// In addition, the class contains a Children property which is a collection of more MetaDataData objects.  This collection can
    /// be used to build a tree structure that can then be attached to the event or clip.  Each MetaDataData object can contain
    /// a timestamp.  This timestamp is used for the purpose of indexing.
    ///
    /// Once loaded into the Granicus system, the ParentID and ParentUID properties are assigned so that the system is able to flatten
    /// the tree structure into a list, and form it back into a tree, depending on how the data is to be used.
    ///
    /// Finally, the ForeignID field allows tracking between integrated systems by allowing the assignment of a numeric ID from
    /// an external database.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class MetaDataData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private int _ParentID;

        /// <remarks/>
        private string _ParentUID;

        /// <remarks/>
        private int _ForeignID;

        /// <remarks/>
        private int _SourceID;

        /// <remarks/>
        private string _Name;

        /// <remarks>
        /// _TimeStamp is set to -1 by default because a default of 0
        /// would mean that the index is actual at 0 seconds
        /// into the video.</remarks>
        private int _TimeStamp = -1;

        /// <remarks/>
        private int _OrderID;

        /// <remarks/>
        private object _Payload;

        /// <remarks/>
        private MetaDataDataCollection _Children;

        /// <remarks/>
        private bool _AllowComment;

        /// <remarks/>
        private int _Consent;

        /// <remarks/>
        private string _ConsentVoteUID;

        /// <remarks/>
        private int _ClosedSession;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> class.
        /// </summary>
        public MetaDataData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> class using the supplied values
        /// for Name and Payload.  This is a common overload for use when creating metadata for Agendas.
        /// </summary>
        /// <param name="_Name">The name field of the MetaData.</param>
        /// <param name="_Payload">The payload of the MetaData, which determines it's type.</param>
        public MetaDataData(string _Name, object _Payload)
        {
            this._Name = _Name;
            this._Payload = _Payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> class using the supplied values
        /// for Name, Payload and TimeStamp.  This is a common overload for use when creating metadata for Minutes with timestamps.
        /// </summary>
        /// <param name="_Name">The name field of the MetaData.</param>
        /// <param name="_Payload">The payload of the MetaData, which determines it's type.</param>
        /// <param name="_TimeStamp">The time (in seconds) at which this MetaData was timestamped.</param>
        public MetaDataData(string _Name, object _Payload, int _TimeStamp)
        {
            this._Name = _Name;
            this._Payload = _Payload;
            this._TimeStamp = _TimeStamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> class using the supplied values
        /// for ID, UID, ForeignID, SourceID, Name, TimeStamp, OrderID, Payload, and Children.
        /// </summary>
        /// <param name="_ID">The numeric ID of the MetaData, this value is ignored when creating MetaData.</param>
        /// <param name="_UID">The unique ID (UID) of the MetaData.</param>
        /// <param name="_ParentID">The ID of the parent node of this MetaData.</param>
        /// <param name="_ParentUID">The unique ID (UID) of the parent node of this MetaData.</param>
        /// <param name="_ForeignID">The ID of the MetaData in an integrated system.</param>
        /// <param name="_SourceID">The ID of the MetaData that this MetaData was copied from, if this is a copy.</param>
        /// <param name="_Name">The name field of the MetaData.</param>
        /// <param name="_TimeStamp">The time (in seconds) at which this MetaData was timestamped.</param>
        /// <param name="_OrderID">The order index of the MetaData object in the tree.</param>
        /// <param name="_Payload">The payload of the MetaData, which determines it's type.</param>
        /// <param name="_Children">Collection of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> that represents the child nodes of the MetaData.</param>
        public MetaDataData(int _ID, string _UID, int _ParentID, string _ParentUID, int _ForeignID, int _SourceID, string _Name, int _TimeStamp, int _OrderID, object _Payload, MetaDataDataCollection _Children)
        {
            this._ID = _ID;
            this._UID = _UID;
            this._ParentID = _ParentID;
            this._ParentUID = _ParentUID;
            this._ForeignID = _ForeignID;
            this._SourceID = _SourceID;
            this._Name = _Name;
            this._TimeStamp = _TimeStamp;
            this._OrderID = _OrderID;
            this._Payload = _Payload;
            this._Children = _Children;
        }

        /// <summary>
        /// The numeric Granicus ID for the object.  This value is automatically generated and cannot be changed.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// The string representation of the objects GUID.  This value can be assigned on creation but never updated.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The numeric ID of the objects parent.
        /// </summary>
        public int ParentID
        {
            get
            {
                return this._ParentID;
            }
            set
            {
                if ((this._ParentID != value))
                {
                    this._ParentID = value;
                    this.RaisePropertyChanged("ParentID");
                }
            }
        }

        /// <summary>
        /// The string representation of the parent's GUID.
        /// </summary>
        public string ParentUID
        {
            get
            {
                return this._ParentUID;
            }
            set
            {
                if ((this._ParentUID != value))
                {
                    this._ParentUID = value;
                    this.RaisePropertyChanged("ParentUID");
                }
            }
        }

        /// <summary>
        /// Should be assigned to the unique numeric ID of the object in an integrated system.
        /// </summary>
        public int ForeignID
        {
            get
            {
                return this._ForeignID;
            }
            set
            {
                if ((this._ForeignID != value))
                {
                    this._ForeignID = value;
                    this.RaisePropertyChanged("ForeignID");
                }
            }
        }

        /// <summary>
        /// The numeric ID of the object that this object was copied from. If any.
        /// </summary>
        /// <remarks>
        /// When MetaData is copied, for instance during the process of indexing, the SourceID is automatically assigned on the
        /// copy so that the original MetaData object can still be known.</remarks>
        public int SourceID
        {
            get
            {
                return this._SourceID;
            }
            set
            {
                if ((this._SourceID != value))
                {
                    this._SourceID = value;
                    this.RaisePropertyChanged("SourceID");
                }
            }
        }

        /// <summary>
        /// The display name of the MetaData.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The index time, in seconds, of the MetaData.
        /// </summary>
        public int TimeStamp
        {
            get
            {
                return this._TimeStamp;
            }
            set
            {
                if ((this._TimeStamp != value))
                {
                    this._TimeStamp = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }

        /// <summary>
        /// The zero-based index of the item if located in a collection.
        /// </summary>
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                if ((this._OrderID != value))
                {
                    this._OrderID = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }

        /// <summary>
        /// Whether or not comments are allowed on this item.
        /// </summary>
        public bool AllowComment
        {
            get
            {
                return this._AllowComment;
            }
            set
            {
                if ((this._AllowComment != value))
                {
                    this._AllowComment = value;
                    this.RaisePropertyChanged("AllowComment");
                }
            }
        }

        /// <summary>
        /// Whether or not item is a consent agenda item.
        /// </summary>
        public int Consent
        {
            get
            {
                return this._Consent;
            }
            set
            {
                if ((this._Consent != value))
                {
                    this._Consent = value;
                    this.RaisePropertyChanged("Consent");
                }
            }
        }

        /// <summary>
        /// Guid of a consent vote item, if THIS item was part of a consent vote.
        /// </summary>
        public string ConsentVoteUID
        {
            get
            {
                return this._ConsentVoteUID;
            }
            set
            {
                if ((this._ConsentVoteUID != value))
                {
                    this._ConsentVoteUID = value;
                    this.RaisePropertyChanged("ConsentVoteUID");
                }
            }
        }

        /// <summary>
        /// Whether or not item is a closed session item.
        /// </summary>
        public int ClosedSession
        {
            get
            {
                return this._ClosedSession;
            }
            set
            {
                if ((this._ClosedSession != value))
                {
                    this._ClosedSession = value;
                    this.RaisePropertyChanged("ClosedSession");
                }
            }
        }

        /// <summary>
        /// The payload of the MetaData.  This is what determines the "type" of metadata (agenda item, rollcall, etc).
        /// </summary>
        /// <remarks>Valid types that can be assigned to this property are:
        /// <list type="bullet">
        /// <item><description><see cref="Granicus.MediaManager.SDK.AgendaItem"/></description></item>
        /// <item><description><see cref="Granicus.MediaManager.SDK.Note"/></description></item>
        /// <item><description><see cref="Granicus.MediaManager.SDK.Document"/></description></item>
        /// <item><description><see cref="Granicus.MediaManager.SDK.Rollcall"/></description></item>
        /// <item><description><see cref="Granicus.MediaManager.SDK.Motion"/></description></item>
        /// <item><description><see cref="Granicus.MediaManager.SDK.VoteRecord"/></description></item>
        /// </list>
        /// </remarks>
        public object Payload
        {
            get
            {
                return this._Payload;
            }
            set
            {
                if ((this._Payload != value))
                {
                    this._Payload = value;
                    this.RaisePropertyChanged("Payload");
                }
            }
        }

        /// <summary>
        /// The children of this MetaData object.
        /// </summary>
        /// <remarks>
        /// This property should be used to build a tree of agenda items and sub items such as supporting documents.</remarks>
        public MetaDataDataCollection Children
        {
            get
            {
                return this._Children;
            }
            set
            {
                if ((this._Children != value))
                {
                    this._Children = value;
                    this.RaisePropertyChanged("Children");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.MetaDataData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.MetaDataData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.MetaDataData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region EventData
    /// <summary>
    /// Represents a video broadcast "event" within the Granicus system.
    /// </summary>
    /// <remarks>
    /// A broadcast event can be any event that utilizes an encoder, whether it's a live broadcast, a recording, or even just using
    /// the live meeting management features to operate a meeting.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class EventData : object, System.ComponentModel.INotifyPropertyChanged
    {

        /// <remarks/>
        private int _ID;

        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private int _ForeignID;

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Description;

        /// <remarks/>
        private int _CameraID;

        /// <remarks/>
        private int _FolderID;

        /// <remarks/>
        private string _Status;

        /// <remarks/>
        private string _AgendaType;

        /// <remarks/>
        private string _AgendaFile;

        /// <remarks/>
        private int _PlayerTemplateID;

        /// <remarks/>
        private string _ArchiveStatus;

        /// <remarks/>
        private int _Duration;

        /// <remarks/>
        private bool _Broadcast;

        /// <remarks/>
        private bool _Record;

        /// <remarks/>
        private bool _AutoStart;

        /// <remarks/>
        private System.DateTime _StartTime;

        /// <remarks/>
        private System.DateTime _LastModified;

        /// <remarks/>
        private AttendeeCollection _Attendees;

        /// <remarks/>
        private StringCollection _MotionTypes;

        /// <remarks/>
        private string _Street1;

        /// <remarks/>
        private string _Street2;

        /// <remarks/>
        private string _City;

        /// <remarks/>
        private string _State;

        /// <remarks/>
        private string _Zip;

        /// <remarks/>
        private string _AgendaTitle;

        /// <remarks/>
        private System.DateTime _MeetingTime;

        /// <remarks/>
        private System.DateTime _AgendaPostedDate;

        /// <remarks/>
        private System.DateTime _NextStartDate;

        /// <remarks/>
        private bool _CommentEnabled;

        /// <remarks/>
        private int _AgendaRolloverID;

        /// <remarks/>
        private int _CommentCloseOffset;

        /// <remarks/>
        private int _ConsentAgenda;

        /// <remarks/>
        private IntegerCollection _Views;

        /// <remarks/>
        private string _LinkedVideoStreamUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.EventData"/> class.
        /// </summary>
        public EventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.EventData"/> class and populates
        /// it with the supplied values.
        /// </summary>
        /// <param name="_ID">The numeric ID of the event.  This property is assigned automatically by the system and will be ignored.</param>
        /// <param name="_UID">A string representation of the Events GUID</param>
        /// <param name="_ForeignID">A numeric foreign ID for association with integrated systems.</param>
        /// <param name="_Name">The name of the event.</param>
        /// <param name="_CameraID">The camera (encoder) ID for the encoder on which the event will take place.</param>
        /// <param name="_FolderID">The folder in which to place any archived files.</param>
        /// <param name="_Status">The status of the event. This property is read only and will be ignored by the web service if altered.</param>
        /// <param name="_AgendaType">The type of the Agenda document that is in use.  Usually set to "linked". See <see cref="Granicus.MediaManager.SDK.EventData.AgendaType"/> for more details.</param>
        /// <param name="_AgendaFile">The URL or filename of the Agenda document.</param>
        /// <param name="_PlayerTemplateID">The player template ID for the template to be used during a live broadcast.</param>
        /// <param name="_ArchiveStatus">The status to be assigned to any archived files created.</param>
        /// <param name="_Duration">The expected duration, in seconds, of the event.</param>
        /// <param name="_Broadcast">Whether or not the event will be broadcast live.</param>
        /// <param name="_Record">Whether or not the event will be recorded for on-demand broadcast.</param>
        /// <param name="_AutoStart">Whether or not the encoder should automatically start the event at the given start time.</param>
        /// <param name="_StartTime">The start time of the event.</param>
        /// <param name="_LastModified">The last modified time of the event.  This property is assigned automatically by the system and will be ignored.</param>
        /// <param name="_Attendees">The expected attendees, or people involved with, the event.</param>
        /// <param name="_MotionTypes">The allowed motion types during the event.</param>
        /// <param name="_Street1">The first part of the street address for the event.</param>
        /// <param name="_Street2">The second part of the street address for the event.</param>
        /// <param name="_City">The city in which the event will take place.</param>
        /// <param name="_State">The state in which the event will take place.</param>
        /// <param name="_Zip">The zip code in which the event will take place.</param>
        /// <param name="_AgendaTitle">The title of the agenda for the event.</param>
        /// <param name="_MeetingTime">The posted start time of the meeting.</param>
        /// <param name="_AgendaPostedDate">The date on which the agenda for the meeting was posted.</param>
        /// <param name="_ConsentAgenda">Whether consent agenda is enabled (0-no, 1-yes)</param>
        /// <param name="_LinkedVideoStreamUrl">URL for events with externally linked videos</param>
        public EventData(
                    int _ID,
                    string _UID,
                    int _ForeignID,
                    string _Name,
                    int _CameraID,
                    int _FolderID,
                    string _Status,
                    string _AgendaType,
                    string _AgendaFile,
                    int _PlayerTemplateID,
                    string _ArchiveStatus,
                    int _Duration,
                    bool _Broadcast,
                    bool _Record,
                    bool _AutoStart,
                    System.DateTime _StartTime,
                    System.DateTime _LastModified,
                    AttendeeCollection _Attendees,
                    StringCollection _MotionTypes,
                    string _Street1,
                    string _Street2,
                    string _City,
                    string _State,
                    string _Zip,
                    string _AgendaTitle,
                    DateTime _MeetingTime,
                    DateTime _AgendaPostedDate,
                    int _ConsentAgenda,
                    string _LinkedVideoStreamUrl
                      )
        {
            this._ID = _ID;
            this._UID = _UID;
            this._ForeignID = _ForeignID;
            this._Name = _Name;
            this._Description = string.Empty; // UT[09/13/2018] Description is not in the list of params, so using string.empty for now
            this._CameraID = _CameraID;
            this._FolderID = _FolderID;
            this._Status = _Status;
            this._AgendaType = _AgendaType;
            this._AgendaFile = _AgendaFile;
            this._PlayerTemplateID = _PlayerTemplateID;
            this._ArchiveStatus = _ArchiveStatus;
            this._Duration = _Duration;
            this._Broadcast = _Broadcast;
            this._Record = _Record;
            this._AutoStart = _AutoStart;
            this._StartTime = _StartTime;
            this._LastModified = _LastModified;
            this._Attendees = _Attendees;
            this._MotionTypes = _MotionTypes;
            this._Street1 = _Street1;
            this._Street2 = _Street2;
            this._City = _City;
            this._State = _State;
            this._Zip = _Zip;
            this._AgendaTitle = _AgendaTitle;
            this._MeetingTime = _MeetingTime;
            this._AgendaPostedDate = _AgendaPostedDate;
            this._ConsentAgenda = _ConsentAgenda;
            this._LinkedVideoStreamUrl = _LinkedVideoStreamUrl;

        }

        /// <summary>
        /// The numeric ID of the event.  This property is assigned automatically by the system and will be ignored.
        /// </summary>
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this._ID = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        /// <summary>
        /// A string representation of the Events GUID.  This value can be assigned during the creation of a new event, but should
        /// not be updated or changed after an event record has already been created.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// A numeric foreign ID for association with integrated systems.
        /// </summary>
        public int ForeignID
        {
            get
            {
                return this._ForeignID;
            }
            set
            {
                if ((this._ForeignID != value))
                {
                    this._ForeignID = value;
                    this.RaisePropertyChanged("ForeignID");
                }
            }
        }

        /// <summary>
        /// The name of the event.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// The name of the event.
        /// </summary>
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this._Description = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// The camera (encoder) ID for the encoder on which the event will take place.
        /// </summary>
        public int CameraID
        {
            get
            {
                return this._CameraID;
            }
            set
            {
                if ((this._CameraID != value))
                {
                    this._CameraID = value;
                    this.RaisePropertyChanged("CameraID");
                }
            }
        }

        /// <summary>
        /// The folder in which to place any archived files.
        /// </summary>
        public int FolderID
        {
            get
            {
                return this._FolderID;
            }
            set
            {
                if ((this._FolderID != value))
                {
                    this._FolderID = value;
                    this.RaisePropertyChanged("FolderID");
                }
            }
        }

        /// <summary>
        /// The status of the event. This property is read only and will be ignored by the web service if altered.
        /// </summary>
        /// <remarks>
        /// Valid values are:
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>Stopped</term><description>The event is not in progress.</description></item>
        /// <item><term>Running</term><description>The event is currently in progress.</description></item>
        /// </list></remarks>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this._Status = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        /// <summary>
        /// The type of the Agenda document that is in use.  Usually set to "linked".
        /// </summary>
        /// <remarks>
        /// Valid values are:
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>none</term><description>No agenda is published.</description></item>
        /// <item><term>linked</term><description>The agenda is a link to an external source.</description></item>
        /// <item><term>uploaded</term><description>The agenda is an uploaded document, such as a PDF</description></item>
        /// <item><term>generated</term><description>The agenda is to be generated from a template.</description></item>
        /// </list></remarks>
        public string AgendaType
        {
            get
            {
                return this._AgendaType;
            }
            set
            {
                if ((this._AgendaType != value))
                {
                    this._AgendaType = value;
                    this.RaisePropertyChanged("AgendaType");
                }
            }
        }

        /// <summary>
        /// The URL or filename of the agenda document.
        /// </summary>
        public string AgendaFile
        {
            get
            {
                return this._AgendaFile;
            }
            set
            {
                if ((this._AgendaFile != value))
                {
                    this._AgendaFile = value;
                    this.RaisePropertyChanged("AgendaFile");
                }
            }
        }

        /// <summary>
        /// The player template ID for the template to be used during a live broadcast.
        /// </summary>
        public int PlayerTemplateID
        {
            get
            {
                return this._PlayerTemplateID;
            }
            set
            {
                if ((this._PlayerTemplateID != value))
                {
                    this._PlayerTemplateID = value;
                    this.RaisePropertyChanged("PlayerTemplateID");
                }
            }
        }

        /// <summary>
        /// The status to be assigned to any archived files created.
        /// </summary>
        /// <remarks>
        /// Valid values for this property are configurable.  The default valid values are:
        /// <list type="table"><listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>Public</term><description>The video is publicly accessable.</description></item>
        /// <item><term>Not-Public</term><description>The video is not publicly accessable.</description></item>
        /// <item><term>Pending</term><description>The video is currently not public pending action by staff.</description></item>
        /// </list></remarks>
        public string ArchiveStatus
        {
            get
            {
                return this._ArchiveStatus;
            }
            set
            {
                if ((this._ArchiveStatus != value))
                {
                    this._ArchiveStatus = value;
                    this.RaisePropertyChanged("ArchiveStatus");
                }
            }
        }

        /// <summary>
        /// The expected duration, in seconds, of the event.
        /// </summary>
        public int Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                if ((this._Duration != value))
                {
                    this._Duration = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }

        /// <summary>
        /// Whether or not the event will be broadcast live.
        /// </summary>
        public bool Broadcast
        {
            get
            {
                return this._Broadcast;
            }
            set
            {
                if ((this._Broadcast != value))
                {
                    this._Broadcast = value;
                    this.RaisePropertyChanged("Broadcast");
                }
            }
        }

        /// <summary>
        /// Whether or not the event will be recorded for on-demand broadcast.
        /// </summary>
        public bool Record
        {
            get
            {
                return this._Record;
            }
            set
            {
                if ((this._Record != value))
                {
                    this._Record = value;
                    this.RaisePropertyChanged("Record");
                }
            }
        }

        /// <summary>
        /// Whether or not the encoder should automatically start the event at the given start time.
        /// </summary>
        public bool AutoStart
        {
            get
            {
                return this._AutoStart;
            }
            set
            {
                if ((this._AutoStart != value))
                {
                    this._AutoStart = value;
                    this.RaisePropertyChanged("AutoStart");
                }
            }
        }

        /// <summary>
        /// Whether or not the event is configured for e-comment.
        /// </summary>
        public bool CommentEnabled
        {
            get
            {
                return this._CommentEnabled;
            }
            set
            {
                if ((this._CommentEnabled != value))
                {
                    this._CommentEnabled = value;
                    this.RaisePropertyChanged("CommentEnabled");
                }
            }
        }

        /// <summary>
        /// The start time of the event.
        /// </summary>
        public System.DateTime StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                if ((this._StartTime != value))
                {
                    this._StartTime = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }

        /// <summary>
        /// The last modified time of the event.  This property is assigned automatically by the system and will be ignored.
        /// </summary>
        public System.DateTime LastModified
        {
            get
            {
                return this._LastModified;
            }
            set
            {
                if ((this._LastModified != value))
                {
                    this._LastModified = value;
                    this.RaisePropertyChanged("LastModified");
                }
            }
        }

        /// <summary>
        /// The expected attendees, or people involved with, the event.
        /// </summary>
        public AttendeeCollection Attendees
        {
            get
            {
                return this._Attendees;
            }
            set
            {
                if ((this._Attendees != value))
                {
                    this._Attendees = value;
                    this.RaisePropertyChanged("Attendees");
                }
            }
        }

        /// <summary>
        /// The allowed motion types during the event.
        /// </summary>
        public StringCollection MotionTypes
        {
            get
            {
                return this._MotionTypes;
            }
            set
            {
                if ((this._MotionTypes != value))
                {
                    this._MotionTypes = value;
                    this.RaisePropertyChanged("MotionTypes");
                }
            }
        }

        /// <summary>
        /// The first part of the street address for the event.
        /// </summary>
        public string Street1
        {
            get
            {
                return this._Street1;
            }
            set
            {
                if ((this._Street1 != value))
                {
                    this._Street1 = value;
                    this.RaisePropertyChanged("Street1");
                }
            }
        }

        /// <summary>
        /// The second part of the street address for the event.
        /// </summary>
        public string Street2
        {
            get
            {
                return this._Street2;
            }
            set
            {
                if ((this._Street2 != value))
                {
                    this._Street2 = value;
                    this.RaisePropertyChanged("Street2");
                }
            }
        }

        /// <summary>
        /// The city in which the event is to take place.
        /// </summary>
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if ((this._City != value))
                {
                    this._City = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }

        /// <summary>
        /// The state in which the event is to take place.
        /// </summary>
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this._State = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }

        /// <summary>
        /// The zip code in which the event is to take place.
        /// </summary>
        public string Zip
        {
            get
            {
                return this._Zip;
            }
            set
            {
                if ((this._Zip != value))
                {
                    this._Zip = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }

        /// <summary>
        /// The numberic version number for tracking ecomment versioning. This value is used internally by the system and is read only.
        /// </summary>
        public int AgendaRolloverID
        {
            get
            {
                return this._AgendaRolloverID;
            }
            set
            {
                if ((this._AgendaRolloverID != value))
                {
                    this._AgendaRolloverID = value;
                    this.RaisePropertyChanged("AgendaRolloverID");
                }
            }
        }

        /// <summary>
        /// The number of minutes before the event start time that the e-comment period will close.
        /// </summary>
        public int CommentCloseOffset
        {
            get
            {
                return this._CommentCloseOffset;
            }
            set
            {
                if ((this._CommentCloseOffset != value))
                {
                    this._CommentCloseOffset = value;
                    this.RaisePropertyChanged("CommentCloseOffset");
                }
            }
        }

        /// <summary>
        /// The title of the agenda for the event.
        /// </summary>
        public string AgendaTitle
        {
            get
            {
                return this._AgendaTitle;
            }
            set
            {
                if ((this._AgendaTitle != value))
                {
                    this._AgendaTitle = value;
                    this.RaisePropertyChanged("AgendaTitle");
                }
            }
        }

        /// <summary>
        /// The last modified time of the event.  This property is assigned automatically by the system and will be ignored.
        /// </summary>
        public System.DateTime MeetingTime
        {
            get
            {
                return this._MeetingTime;
            }
            set
            {
                if ((this._MeetingTime != value))
                {
                    this._MeetingTime = value;
                    this.RaisePropertyChanged("MeetingTime");
                }
            }
        }

        /// <summary>
        /// The last modified time of the event.  This property is assigned automatically by the system and will be ignored.
        /// </summary>
        public System.DateTime AgendaPostedDate
        {
            get
            {
                return this._AgendaPostedDate;
            }
            set
            {
                if ((this._AgendaPostedDate != value))
                {
                    this._AgendaPostedDate = value;
                    this.RaisePropertyChanged("AgendaPostedDate");
                }
            }
        }

        /// <summary>
        /// The next time the event will run.  This property is assigned automatically by the system and will be ignored.
        /// </summary>
        public System.DateTime NextStartDate
        {
            get
            {
                return this._NextStartDate;
            }
            set
            {
                if ((this._NextStartDate != value))
                {
                    this._NextStartDate = value;
                    this.RaisePropertyChanged("NextStartDate");
                }
            }
        }

        /// <summary>
        /// Whether consent agenda is enabled for the event.
        /// </summary>
        public int ConsentAgenda
        {
            get
            {
                return this._ConsentAgenda;
            }
            set
            {
                if ((this._ConsentAgenda != value))
                {
                    this._ConsentAgenda = value;
                    this.RaisePropertyChanged("ConsentAgenda");
                }
            }
        }

        /// <summary>
        /// Video URL for events with externally linked videos
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LinkedVideoStreamUrl
        {
            get
            {
                return this._LinkedVideoStreamUrl;
            }
            set
            {
                if ((this._LinkedVideoStreamUrl != value))
                {
                    this._LinkedVideoStreamUrl = value;
                    this.RaisePropertyChanged("LinkedVideoStreamUrl");
                }
            }
        }


        /// <summary>
        /// An <see cref="Granicus.MediaManager.SDK.IntegerCollection"/> containing all of the numeric IDs of the events associated with this view.
        /// </summary>
        public IntegerCollection Views
        {
            get
            {
                return this._Views;
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("Views");
                }
                if ((this._Views != value))
                {
                    this._Views = value;
                    this.RaisePropertyChanged("Views");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.EventData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.EventData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.EventData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Comment
    /// <summary>
    /// Represents a citizen comment record.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Comment : object, System.ComponentModel.INotifyPropertyChanged
    {
        /// <remarks/>
        private string _UID;
        /// <remarks/>
        private string _EventUID;

        /// <remarks/>
        private string _MetaDataUID;

        /// <remarks/>
        private string _FirstName;

        /// <remarks/>
        private string _LastName;

        /// <remarks/>
        private string _CommentText;

        private string _Email;

        private string _Address;

        private string _City;

        private string _State;

        private string _Zip;

        private string _Area;

        private string _Position;

        private bool _HasVideo;

        /// <remarks/>
        private System.DateTime _CreatedDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.UserData"/> class.
        /// </summary>
        public Comment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Comment"/> class with the supplied values.
        /// </summary>
        /// <param name="_UID">The unique ID of the comment.</param>
        /// <param name="_EventUID">The numeric ID of the user.  This ID is assigned by the system and cannot be changed.</param>
        /// <param name="_MetaDataUID">The unique logon name of the user.</param>
        /// <param name="_FirstName">The password the user may use to login.</param>
        /// <param name="_LastName">The full name of the user.</param>
        /// <param name="_CommentText">The user's email address.</param>
        /// <param name="_Email">The date the user was created. Cannot be changed.</param>
        /// <param name="_Address">The date the user record was last modified. Cannot be changed.</param>
        /// <param name="_City"></param>
        /// <param name="_State"></param>
        /// <param name="_Zip"></param>
        /// <param name="_Area"></param>
        /// <param name="_Position"></param>
        /// <param name="_HasVideo"></param>
        /// <param name="_CreatedDate"></param>
        public Comment(string _UID, string _EventUID, string _MetaDataUID, string _FirstName, string _LastName, string _CommentText, string _Email, string _Address, string _City, string _State, string _Zip, string _Area, string _Position, bool _HasVideo, System.DateTime _CreatedDate)
        {
            this._UID = _UID;
            this._EventUID = _EventUID;
            this._MetaDataUID = _MetaDataUID;
            this._FirstName = _FirstName;
            this._LastName = _LastName;
            this._CommentText = _CommentText;
            this._Email = _Email;
            this._Address = _Address;
            this._City = _City;
            this._State = _State;
            this._Zip = _Zip;
            this._Area = _Area;
            this._Position = _Position;
            this._HasVideo = _HasVideo;
            this._CreatedDate = _CreatedDate;
        }

        /// <summary>
        /// The GUID of the comment.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The GUID of the event on which the comment was made.
        /// </summary>
        public string EventUID
        {
            get
            {
                return this._EventUID;
            }
            set
            {
                if ((this._EventUID != value))
                {
                    this._EventUID = value;
                    this.RaisePropertyChanged("EventUID");
                }
            }
        }

        /// <summary>
        /// The GUID of the metadata (agenda item) on which the comment was made.
        /// </summary>
        public string MetaDataUID
        {
            get
            {
                return this._MetaDataUID;
            }
            set
            {
                if ((this._MetaDataUID != value))
                {
                    this._MetaDataUID = value;
                    this.RaisePropertyChanged("MetaDataUID");
                }
            }
        }

        /// <summary>
        /// The first name of the commenter.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if ((this._FirstName != value))
                {
                    this._FirstName = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }

        /// <summary>
        /// The last name of the commenter.
        /// </summary>
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if ((this._LastName != value))
                {
                    this._LastName = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }

        /// <summary>
        /// The text of the comment made by the user.
        /// </summary>
        public string CommentText
        {
            get
            {
                return this._CommentText;
            }
            set
            {
                if ((this._CommentText != value))
                {
                    this._CommentText = value;
                    this.RaisePropertyChanged("CommentText");
                }
            }
        }

        /// <summary>
        /// The commenter's email address.
        /// </summary>
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if ((this._Email != value))
                {
                    this._Email = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// The commenter's street address.
        /// </summary>
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                if ((this._Address != value))
                {
                    this._Address = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }

        /// <summary>
        /// The commenter's home city.
        /// </summary>
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if ((this._City != value))
                {
                    this._City = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }

        /// <summary>
        /// The commenter's home state/province.
        /// </summary>
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this._State = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }

        /// <summary>
        /// The commenter's zip/postal code.
        /// </summary>
        public string Zip
        {
            get
            {
                return this._Zip;
            }
            set
            {
                if ((this._Zip != value))
                {
                    this._Zip = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }

        /// <summary>
        /// The commenter's area (e.g. district).
        /// </summary>
        public string Area
        {
            get
            {
                return this._Area;
            }
            set
            {
                if ((this._Area != value))
                {
                    this._Area = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }

        /// <summary>
        /// The commenter's email address.
        /// </summary>
        public string Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                if ((this._Position != value))
                {
                    this._Position = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }

        /// <summary>
        /// Whether or not the comment is a video comment.
        /// </summary>
        public bool HasVideo
        {
            get
            {
                return this._HasVideo;
            }
            set
            {
                if ((this._HasVideo != value))
                {
                    this._HasVideo = value;
                    this.RaisePropertyChanged("HasVideo");
                }
            }
        }

        /// <summary>
        /// The date the user was created. Cannot be changed.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Speaker
    /// <summary>
    /// Represents a citizen speaker record.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Speaker : object, System.ComponentModel.INotifyPropertyChanged
    {
        /// <remarks/>
        private string _UID;

        /// <remarks/>
        private string _EventUID;

        /// <remarks/>
        private string _MetaDataUID;

        /// <remarks/>
        private string _FirstName;

        /// <remarks/>
        private string _LastName;

        private string _Email;

        private string _Address;

        private string _City;

        private string _State;

        private string _Zip;

        private string _Area;

        private string _Position;

        /// <remarks/>
        private System.DateTime _CreatedDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.UserData"/> class.
        /// </summary>
        public Speaker()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Speaker"/> class with the supplied values.
        /// </summary>
        /// <param name="_UID"></param>
        /// <param name="_EventUID">The numeric ID of the user.  This ID is assigned by the system and cannot be changed.</param>
        /// <param name="_MetaDataUID">The unique logon name of the user.</param>
        /// <param name="_FirstName">The password the user may use to login.</param>
        /// <param name="_LastName">The full name of the user.</param>
        /// <param name="_CommentText">The user's email address.</param>
        /// <param name="_Email">The date the user was created. Cannot be changed.</param>
        /// <param name="_Address">The date the user record was last modified. Cannot be changed.</param>
        /// <param name="_City"></param>
        /// <param name="_State"></param>
        /// <param name="_Zip"></param>
        /// <param name="_Area"></param>
        /// <param name="_Position"></param>
        /// <param name="_HasVideo"></param>
        /// <param name="_CreatedDate"></param>
        public Speaker(string _UID, string _EventUID, string _MetaDataUID, string _FirstName, string _LastName, string _CommentText, string _Email, string _Address, string _City, string _State, string _Zip, string _Area, string _Position, bool _HasVideo, System.DateTime _CreatedDate)
        {
            this._UID = _UID;
            this._EventUID = _EventUID;
            this._MetaDataUID = _MetaDataUID;
            this._FirstName = _FirstName;
            this._LastName = _LastName;
            this._Email = _Email;
            this._Address = _Address;
            this._City = _City;
            this._State = _State;
            this._Zip = _Zip;
            this._Area = _Area;
            this._Position = _Position;
            this._CreatedDate = _CreatedDate;
        }

        /// <summary>
        /// The GUID of the speaker.
        /// </summary>
        public string UID
        {
            get
            {
                return this._UID;
            }
            set
            {
                if ((this._UID != value))
                {
                    this._UID = value;
                    this.RaisePropertyChanged("UID");
                }
            }
        }

        /// <summary>
        /// The GUID of the event on which the comment was made.
        /// </summary>
        public string EventUID
        {
            get
            {
                return this._EventUID;
            }
            set
            {
                if ((this._EventUID != value))
                {
                    this._EventUID = value;
                    this.RaisePropertyChanged("EventUID");
                }
            }
        }

        /// <summary>
        /// The GUID of the metadata (agenda item) on which the comment was made.
        /// </summary>
        public string MetaDataUID
        {
            get
            {
                return this._MetaDataUID;
            }
            set
            {
                if ((this._MetaDataUID != value))
                {
                    this._MetaDataUID = value;
                    this.RaisePropertyChanged("MetaDataUID");
                }
            }
        }

        /// <summary>
        /// The first name of the commenter.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if ((this._FirstName != value))
                {
                    this._FirstName = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }

        /// <summary>
        /// The last name of the commenter.
        /// </summary>
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if ((this._LastName != value))
                {
                    this._LastName = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }

        /// <summary>
        /// The commenter's email address.
        /// </summary>
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if ((this._Email != value))
                {
                    this._Email = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// The commenter's street address.
        /// </summary>
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                if ((this._Address != value))
                {
                    this._Address = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }

        /// <summary>
        /// The commenter's home city.
        /// </summary>
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if ((this._City != value))
                {
                    this._City = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }

        /// <summary>
        /// The commenter's home state/province.
        /// </summary>
        public string State
        {
            get
            {
                return this._State;
            }
            set
            {
                if ((this._State != value))
                {
                    this._State = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }

        /// <summary>
        /// The commenter's zip/postal code.
        /// </summary>
        public string Zip
        {
            get
            {
                return this._Zip;
            }
            set
            {
                if ((this._Zip != value))
                {
                    this._Zip = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }

        /// <summary>
        /// The commenter's area (e.g. district).
        /// </summary>
        public string Area
        {
            get
            {
                return this._Area;
            }
            set
            {
                if ((this._Area != value))
                {
                    this._Area = value;
                    this.RaisePropertyChanged("Area");
                }
            }
        }

        /// <summary>
        /// The commenter's email address.
        /// </summary>
        public string Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                if ((this._Position != value))
                {
                    this._Position = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }

        /// <summary>
        /// The date the user was created. Cannot be changed.
        /// </summary>
        public System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                if ((this._CreatedDate != value))
                {
                    this._CreatedDate = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/>
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event for the given property.
        /// </summary>
        /// <remarks>
        /// The <see cref="Granicus.MediaManager.SDK.UserData.PropertyChanged"/> event can indicate all properties
        /// on the object have changed by using either a null reference or String.Empty as the property name in the
        /// <see cref="System.ComponentModel.PropertyChangedEventArgs"/></remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion

    #region Setting
    /// <summary>
    /// Represents a setting.
    /// </summary>
    /// <remarks>
    /// This class is used to represent a setting.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.312")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://granicus.com/xsd")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class Setting : object
    {

        /// <remarks/>
        private string _Name;

        /// <remarks/>
        private string _Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Setting"/> class.
        /// </summary>
        public Setting()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.Setting"/> class with the supplied
        /// Name, Value.
        /// </summary>
        /// <param name="_Name">The name of the Setting.</param>
        /// <param name="_Value">Value of the Setting.</param>
        public Setting(string _Name, string _Value)
        {
            this._Name = _Name;
            this._Value = _Value;
        }

        /// <summary>
        /// The full name of the attendee.
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                }
            }
        }


        /// <summary>
        /// Value of the setting.
        /// </summary>
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                if ((this._Value != value))
                {
                    this._Value = value;
                }
            }
        }

    }
    #endregion

    #region AttendeeStatusCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class AttendeeStatusCollection : System.Collections.CollectionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AttendeeStatusCollection"/> class.
        /// </summary>
        public AttendeeStatusCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the desired <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/>
        /// object in the collection.</param>
        /// <returns></returns>
        public AttendeeStatus this[int idx]
        {
            get
            {
                return ((AttendeeStatus)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object has been added.</returns>
        public int Add(AttendeeStatus value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurrance of the <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> value
        /// in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object to locate</param>
        /// <returns>The zero-based index of the given <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object.</returns>
        public int IndexOf(AttendeeStatus value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object should
        /// be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object to insert. The value
        /// can be a null reference.</param>
        public void Insert(int index, AttendeeStatus value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object from
        /// the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object to remove from the collection.</param>
        public void Remove(AttendeeStatus value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.AttendeeStatus"/> object to locate in the collection.</param>
        /// <returns>True if the item is found in the collection, otherwise; False.</returns>
        public bool Contains(AttendeeStatus value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region VoteEntryCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.VoteEntry"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class VoteEntryCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.VoteEntryCollection"/> class.
        /// </summary>
        public VoteEntryCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the desired <see cref="Granicus.MediaManager.SDK.VoteEntry"/>
        /// object in the collection.</param>
        /// <returns></returns>
        public VoteEntry this[int idx]
        {
            get
            {
                return ((VoteEntry)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object has been added.</returns>
        public int Add(VoteEntry value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurrance of the <see cref="Granicus.MediaManager.SDK.VoteEntry"/> value
        /// in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object to locate</param>
        /// <returns>The zero-based index of the given <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object.</returns>
        public int IndexOf(VoteEntry value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object should
        /// be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object to insert. The value
        /// can be a null reference.</param>
        public void Insert(int index, VoteEntry value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object from
        /// the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object to remove from the collection.</param>
        public void Remove(VoteEntry value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.VoteEntry"/> object to locate in the collection.</param>
        /// <returns>True if the item is found in the collection, otherwise; False.</returns>
        public bool Contains(VoteEntry value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region IntegerCollection
    /// <summary>
    /// A collection of integers.
    /// </summary>
    [System.SerializableAttribute()]
    public class IntegerCollection : System.Collections.CollectionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.IntegerCollection"/> class.
        /// </summary>
        public IntegerCollection()
        {
        }


        /// <summary>
        /// Returns the integer value located at the given zero-based index.
        /// </summary>
        /// <param name="idx">Zero-based index of the value to return.</param>
        /// <returns>The integer value at the provided index.</returns>
        public int this[int idx]
        {
            get
            {
                return ((int)(base.InnerList[idx]));
            }
            set
            {
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new integer to the end collection.
        /// </summary>
        /// <param name="value">The integer value to add.</param>
        /// <returns>The zero-based index of the value.</returns>
        public int Add(int value)
        {
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the index of the first occurance of the given integer value.
        /// </summary>
        /// <param name="value">The integer value to search for in the collection.</param>
        /// <returns>The index of the first occurrance of the given value.</returns>
        public int IndexOf(int value)
        {
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts a new integer value into the collection at the given index.
        /// </summary>
        /// <param name="index">The zero-based index at which to insert the new value.</param>
        /// <param name="value">The value to insert.</param>
        public void Insert(int index, int value)
        {
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific integer value from the collection.
        /// </summary>
        /// <param name="value">The value to remove.</param>
        public void Remove(int value)
        {
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific integer value exists in the collection.
        /// </summary>
        /// <param name="value">The integer value to locate in the collection.</param>
        /// <returns>True if the value is found in the collection; otherwise, False.</returns>
        public bool Contains(int value)
        {
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region AttendeeCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.Attendee"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class AttendeeCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AttendeeCollection"/> class.
        /// </summary>
        public AttendeeCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.Attendee"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the <see cref="Granicus.MediaManager.SDK.Attendee"/> object in the collection.</param>
        /// <returns></returns>
        public Attendee this[int idx]
        {
            get
            {
                return ((Attendee)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.Attendee"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Attendee"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.Attendee"/> object has been added.</returns>
        public int Add(Attendee value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurance of a specific <see cref="Granicus.MediaManager.SDK.Attendee"/> object in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Attendee"/> object to locate.</param>
        /// <returns>The index of the given <see cref="Granicus.MediaManager.SDK.Attendee"/> object.</returns>
        public int IndexOf(Attendee value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.Attendee"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.Attendee"/> should be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Attendee"/> object to insert. The value can be a null reference.</param>
        public void Insert(int index, Attendee value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.Attendee"/> object from the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Attendee"/> object to remove from the collection.</param>
        public void Remove(Attendee value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.Attendee"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Attendee"/> to locate in the collection.</param>
        /// <returns>True if the item is found in the collection; otherwise, False.</returns>
        public bool Contains(Attendee value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region StringCollection
    /// <summary>
    /// A collection of strings.
    /// </summary>
    [System.SerializableAttribute()]
    public class StringCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.StringCollection"/> class.
        /// </summary>
        public StringCollection()
        {
        }

        /// <summary>
        /// Returns the string value located at the given zero-based index.
        /// </summary>
        /// <param name="idx">Zero-based index of the value to return.</param>
        /// <returns>The string value at the provided index.</returns>
        public string this[int idx]
        {
            get
            {
                return ((string)(base.InnerList[idx]));
            }
            set
            {
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new string to the end collection.
        /// </summary>
        /// <param name="value">The string value to add.</param>
        /// <returns>The zero-based index of the value.</returns>
        public int Add(string value)
        {
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the index of the first occurance of the given string value.
        /// </summary>
        /// <param name="value">The string value to search for in the collection.</param>
        /// <returns>The index of the first occurrance of the given value.</returns>
        public int IndexOf(string value)
        {
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts a new string value into the collection at the given index.
        /// </summary>
        /// <param name="index">The zero-based index at which to insert the new value.</param>
        /// <param name="value">The value to insert.</param>
        public void Insert(int index, string value)
        {
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific string value from the collection.
        /// </summary>
        /// <param name="value">The value to remove.</param>
        public void Remove(string value)
        {
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific string value exists in the collection.
        /// </summary>
        /// <param name="value">The string value to locate in the collection.</param>
        /// <returns>True if the value is found in the collection; otherwise, False.</returns>
        public bool Contains(string value)
        {
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region MetaDataDataCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class MetaDataDataCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataDataCollection"/> class.
        /// </summary>
        public MetaDataDataCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the desired <see cref="Granicus.MediaManager.SDK.MetaDataData"/>
        /// object in the collection.</param>
        /// <returns></returns>
        public MetaDataData this[int idx]
        {
            get
            {
                return ((MetaDataData)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object has been added.</returns>
        public int Add(MetaDataData value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurrance of the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> value
        /// in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to locate</param>
        /// <returns>The zero-based index of the given <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object.</returns>
        public int IndexOf(MetaDataData value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object should
        /// be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to insert. The value
        /// can be a null reference.</param>
        public void Insert(int index, MetaDataData value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object from
        /// the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to remove from the collection.</param>
        public void Remove(MetaDataData value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to locate in the collection.</param>
        /// <returns>True if the item is found in the collection, otherwise; False.</returns>
        public bool Contains(MetaDataData value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region CommentCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.MetaDataData"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class CommentCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataDataCollection"/> class.
        /// </summary>
        public CommentCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the desired <see cref="Granicus.MediaManager.SDK.MetaDataData"/>
        /// object in the collection.</param>
        /// <returns></returns>
        public Comment this[int idx]
        {
            get
            {
                return ((Comment)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object has been added.</returns>
        public int Add(Comment value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurrance of the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> value
        /// in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to locate</param>
        /// <returns>The zero-based index of the given <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object.</returns>
        public int IndexOf(Comment value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object should
        /// be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to insert. The value
        /// can be a null reference.</param>
        public void Insert(int index, Comment value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object from
        /// the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to remove from the collection.</param>
        public void Remove(Comment value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.MetaDataData"/> object to locate in the collection.</param>
        /// <returns>True if the item is found in the collection, otherwise; False.</returns>
        public bool Contains(Comment value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region SpeakerCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.Speaker"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class SpeakerCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.MetaDataDataCollection"/> class.
        /// </summary>
        public SpeakerCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.Speaker"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the desired <see cref="Granicus.MediaManager.SDK.Speaker"/>
        /// object in the collection.</param>
        /// <returns></returns>
        public Speaker this[int idx]
        {
            get
            {
                return ((Speaker)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.Speaker"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Speaker"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.Speaker"/> object has been added.</returns>
        public int Add(Speaker value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurrance of the <see cref="Granicus.MediaManager.SDK.Speaker"/> value
        /// in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Speaker"/> object to locate</param>
        /// <returns>The zero-based index of the given <see cref="Granicus.MediaManager.SDK.Speaker"/> object.</returns>
        public int IndexOf(Speaker value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.Speaker"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.Speaker"/> object should
        /// be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Speaker"/> object to insert. The value
        /// can be a null reference.</param>
        public void Insert(int index, Speaker value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.Speaker"/> object from
        /// the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Speaker"/> object to remove from the collection.</param>
        public void Remove(Speaker value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.Speaker"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Speaker"/> object to locate in the collection.</param>
        /// <returns>True if the item is found in the collection, otherwise; False.</returns>
        public bool Contains(Speaker value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

    #region SettingCollection
    /// <summary>
    /// Represents a collection of <see cref="Granicus.MediaManager.SDK.Setting"/> objects.
    /// </summary>
    [System.SerializableAttribute()]
    public class SettingCollection : System.Collections.CollectionBase
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Granicus.MediaManager.SDK.AttendeeCollection"/> class.
        /// </summary>
        public SettingCollection()
        {
        }

        /// <summary>
        /// Returns the <see cref="Granicus.MediaManager.SDK.Setting"/> object at the given index in the collection.
        /// </summary>
        /// <param name="idx">The index of the <see cref="Granicus.MediaManager.SDK.Setting"/> object in the collection.</param>
        /// <returns></returns>
        public Setting this[int idx]
        {
            get
            {
                return ((Setting)(base.InnerList[idx]));
            }
            set
            {
                if ((value == null))
                {
                    throw new System.ArgumentNullException("value");
                }
                base.InnerList[idx] = value;
            }
        }

        /// <summary>
        /// Adds a new <see cref="Granicus.MediaManager.SDK.Setting"/> object to the end of the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Setting"/> object to add.</param>
        /// <returns>The collection index at which the <see cref="Granicus.MediaManager.SDK.Setting"/> object has been added.</returns>
        public int Add(Setting value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Add(value);
        }

        /// <summary>
        /// Returns the zero-based index of the first occurance of a specific <see cref="Granicus.MediaManager.SDK.Setting"/> object in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Setting"/> object to locate.</param>
        /// <returns>The index of the given <see cref="Granicus.MediaManager.SDK.Setting"/> object.</returns>
        public int IndexOf(Setting value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.IndexOf(value);
        }

        /// <summary>
        /// Inserts an <see cref="Granicus.MediaManager.SDK.Setting"/> object into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which the <see cref="Granicus.MediaManager.SDK.Setting"/> should be inserted.</param>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Setting"/> object to insert. The value can be a null reference.</param>
        public void Insert(int index, Setting value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurance of a specific <see cref="Granicus.MediaManager.SDK.Setting"/> object from the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Setting"/> object to remove from the collection.</param>
        public void Remove(Setting value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            base.InnerList.Remove(value);
        }

        /// <summary>
        /// Determines whether a specific <see cref="Granicus.MediaManager.SDK.Setting"/> object is in the collection.
        /// </summary>
        /// <param name="value">The <see cref="Granicus.MediaManager.SDK.Setting"/> to locate in the collection.</param>
        /// <returns>True if the item is found in the collection; otherwise, False.</returns>
        public bool Contains(Setting value)
        {
            if ((value == null))
            {
                throw new System.ArgumentNullException("value");
            }
            return base.InnerList.Contains(value);
        }
    }
    #endregion

}