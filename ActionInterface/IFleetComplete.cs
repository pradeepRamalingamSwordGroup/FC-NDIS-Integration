﻿using FC_NDIS.ApplicationIntegartionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC_NDIS.ActionInterface
{
    interface IFleetComplete
    {
        public FCResponseTokenandUserId GetAccessToken(string URL);
        public void IntegrateAsset(string ClientID, string UserID, string Token);
        public bool PostResource(string ClientID, string UserID, string Token);
        public bool PutResource(string ClientID, string UserID, string Token, List<int> ResourceIds);
    }
}
