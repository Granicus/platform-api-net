using System;
namespace Granicus.MediaManager.SDK
{
    interface IMediaManager
    {
        
        int LogMessage(string Message, string Application, string Class, int Priority);
        
        void Login(string Username, string Password);
        
        string GetChallenge(string ChallengeCode);
        
        void SendChallengeResponse(string key, DateTime expiration);
        
        void Logout();
        
        int CreateCamera(CameraData CameraData);
        
        CameraData[] GetCameras();
        
        CameraData GetCamera(int CameraID);
        
        string GetCameraVideoLocation(int CameraID);
        
        void UpdateCamera(CameraData camera);
        
        void DeleteCamera(int CameraID);
        
        int CreateEvent(EventData EventData);
        
        EventData[] GetEvents();
        
        EventData[] GetEventsByForeignID(int ForeignID);
        
        EventData GetEvent(int EventID);
        
        EventData GetEventByUID(string EventUID);
        
        string GetEventVideoLocation(int EventID);
        
        string GetEventVideoLocationByUID(string EventUID);
        
        MetaDataData[] GetEventMetaData(int EventID);
        
        MetaDataData[] GetEventMetaDataByUID(string EventUID);
        
        void SetEventAgendaURL(int EventID, string URL);
        
        void SetEventAgendaURLByUID(string EventUID, string URL);
        
        void UpdateEvent(EventData @event);
        
        KeyMapping[] AddEventMetaData(int EventID, MetaDataData MetaDataData);
        
        KeyMapping[] ImportEventMetaData(int EventID, MetaDataData[] MetaData, bool ClearExisting, bool AsTree);
        
        int CreateFolder(FolderData FolderData);
        
        FolderData[] GetFolders();
        
        FolderData[] GetFoldersByType(string Type);
        
        FolderData GetFolder(int FolderID);
        
        ServerInterfaceData GetFolderUploadInterface(int FolderID);
        
        void UpdateFolder(FolderData folder);
        
        int RegisterClipUpload(ClipData ClipData, int ServerID);
        
        ClipData[] GetClips(int FolderID);
        
        ClipData[] GetClipsByForeignID(int ForeignID);
        
        ClipData GetClip(int ClipID);
        
        ClipData GetClipByUID(string ClipUID);
        
        string GetClipVideoLocation(int ClipID);
        
        MetaDataData[] GetClipMetaData(int ClipID);
        
        MetaDataData[] GetClipMetaDataByUID(string ClipUID);
        
        MetaDataData[] GetClipIndices(int ClipID);
        
        MetaDataData[] GetClipIndicesByUID(string ClipUID);
        
        string GetClipCaptions(int ClipID);
        
        string GetClipCaptionsByUID(string ClipUID);
        
        void SetClipAgendaURL(int ClipID, string URL);
        
        void SetClipMinutesURL(int ClipID, string URL);
        
        void UpdateClip(ClipData clip);
        
        void DeleteClip(int ClipID);

        PublishClipResult PublishClip(PublishClipData data);

        KeyMapping[] AddClipMetaData(int ClipID, MetaDataData MetaDataData);
        
        KeyMapping[] ImportClipMetaData(int ClipID, MetaDataData[] MetaData, bool ClearExisting, bool AsTree);
        
        MetaDataData GetMetaData(int MetaDataID);
        
        MetaDataData GetMetaDataByUID(string MetaDataUID);
        
        string GetMetaDataVideoLocation(int MetaDataID);
        
        void UpdateMetaData(MetaDataData MetaData);
        
        void DeleteMetaData(int MetaDataID);
        
        int CreateView(ViewData ViewData);
        
        ViewData[] GetViews();
        
        ViewData GetView(int ViewID);
        
        void UpdateView(ViewData view);
        
        string CreateUser(UserData UserData);
        
        int GetCurrentUserID();

        string GetCurrentUserUID();
        
        string GetCurrentUserLogon();
        
        UserData[] GetUsers();
        
        UserData GetUser(string UserUID);
        
        void UpdateUser(UserData user);
        
        int CreateGroup(GroupData GroupData);
        
        GroupData[] GetGroups();
        
        GroupData GetGroup(int GroupID);
        
        void UpdateGroup(GroupData group);
        
        int CreateTemplate(TemplateData TemplateData);
        
        TemplateData[] GetTemplates();
        
        TemplateData GetTemplate(int TemplateID);
        
        void UpdateTemplate(TemplateData template);
        
        int CreateServer(ServerData ServerData);
        
        ServerData[] GetServers();
        
        ServerData GetServer(int ServerID);
        
        void UpdateServer(ServerData server);
        
        int GetPermissionLevel(string AssetType, int AssetID);

        void CreateAttendees(Attendee[] AttendeesData);

        void CreateMotionActions(StringCollection motionActions);

        StringCollection GetMotionActions();

        SettingCollection GetSettings();
    }
}
