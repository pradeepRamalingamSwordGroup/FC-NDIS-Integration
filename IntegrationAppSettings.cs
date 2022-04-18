using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC_NDIS
{
    public class IntegrationAppSettings
    {
        public string ClientID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string GetTokenURL { get; set; }
        public string AssetURL { get; set; }
        public string IndividualAssetURL { get; set; }
        public string ResourcePost { get; set; }
        public string ResourcePut { get; set; }
        public string ResourceGetDetails { get; set; }
        public string SFDCUserName { get; set; }
        public string SFDCUserPassword { get; set; }
        public string SFDCClientId { get; set; }
        public string SFDCClientSecret { get; set; }
        public string SFDCLoginEndpoint { get; set; }
        public string SFDCApiEndpoint { get; set; }
        public string ConnexUserName { get; set; }
        public string ConnexUserPassword { get; set; }
        public string AppConnection { get; set; }
        public string ApplicationTimeZone { get; set; }
        public string CustomerScheduleTime { get; set; }
        public string CustomerServiceLineScheduleTime { get; set; }
        public string DriverScheduleTime { get; set; }
        public string FCAssetScheduleTime { get; set; }
        public string SFDCIDScheduleTime { get; set; }
        public string TravelTime { get; set; }
        public string TransportTime { get; set; }
        public string IntegrationforSandbox { get; set; }
        public string FirstTimeDownload { get; set; }

    }
}
