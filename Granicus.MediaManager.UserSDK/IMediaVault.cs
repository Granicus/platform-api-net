namespace Granicus.MediaManager.SDK
{   
    interface IMediaVault
    {
        
        int UploadFile(int FolderID, string NewFileName, byte[] bytes);
        
        string StartUpload();
        
        string SendChunk(string GUID, long ChunkPosition, byte[] bytes);
        
        long FinishUpload(string GUID);
        
        void AbortUpload(string GUID);
        
        void AssignUploadedFile(string GUID, string ClipUID, string Extension);
        
        int RegisterUploadedFile(string GUID, int FolderID, string Name, string Extension);

        void TrimClip(int ClipID, int StartSeconds, int EndSeconds);
    }
}
