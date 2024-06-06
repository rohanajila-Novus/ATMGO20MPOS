namespace ATMGO20MPOS.RequestModels
{
    public class LoginRequestModel
    {
            public string TranType { get; set; }
            public string SourceID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string GCMID { get; set; }
            public string IMEI { get; set; }
            public string MakeModel { get; set; }
            public int OSVersion { get; set; }
            public int Version { get; set; }
            // Add other properties as needed
        
    }
}
