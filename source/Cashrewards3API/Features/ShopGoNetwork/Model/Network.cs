﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashrewards3API.Features.ShopGoNetwork.Model
{
    public class Network
    {
        public int NetworkId { get; set; }
        public string NetworkName { get; set; }
        public string TrackingHolder { get; set; }
        public string DeepLinkHolder { get; set; }
        public string NetworkKey { get; set; }
        public int Status { get; set; }
        public int TimeZoneId { get; set; }
        public int GstStatusId { get; set; }
    }
}
