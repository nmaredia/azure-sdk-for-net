// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of P2S Vpn connection health request. </summary>
    public partial class P2SVpnConnectionHealthRequest
    {
        /// <summary> Initializes a new instance of P2SVpnConnectionHealthRequest. </summary>
        public P2SVpnConnectionHealthRequest()
        {
        }

        /// <summary> Initializes a new instance of P2SVpnConnectionHealthRequest. </summary>
        /// <param name="vpnUserNamesFilter"> The list of p2s vpn user names whose p2s vpn connection detailed health to retrieve for. </param>
        /// <param name="outputBlobSasUrl"> The sas-url to download the P2S Vpn connection health detail. </param>
        internal P2SVpnConnectionHealthRequest(IList<string> vpnUserNamesFilter, string outputBlobSasUrl)
        {
            VpnUserNamesFilter = vpnUserNamesFilter;
            OutputBlobSasUrl = outputBlobSasUrl;
        }

        /// <summary> The list of p2s vpn user names whose p2s vpn connection detailed health to retrieve for. </summary>
        public IList<string> VpnUserNamesFilter { get; set; }
        /// <summary> The sas-url to download the P2S Vpn connection health detail. </summary>
        public string OutputBlobSasUrl { get; set; }
    }
}