namespace Granicus.MediaManager.SDK
{ 
    interface IMeetingServer
    {
        
        void LoadMeeting(string documentId);
        
        void CloseMeeting();

        MeetingDocumentHeader[] GetDocuments();
        
        EncoderStatus GetStatus();
        
        void StartMeeting();
        
        void StopMeeting();

        string ActivateItem(string foreignId);

        string RecordItem(string body, string foreignId);
        
        string RecordNonIndexedItem(string body, string foreignId);
        
        void SetSuspendRecordItem(bool value);

        void ExtendMeeting(int seconds);

        void PauseMeeting();
    }
}
