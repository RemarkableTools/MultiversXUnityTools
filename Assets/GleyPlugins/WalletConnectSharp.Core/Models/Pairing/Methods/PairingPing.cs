using System.Collections.Generic;
using WalletConnectSharp.Common.Utils;
using WalletConnectSharp.Network.Models;

namespace WalletConnectSharp.Core.Models.Pairing.Methods
{
    /// <summary>
    /// A class that represents the request wc_pairingPing. Used to ping a pairing
    /// request
    /// </summary>
    [RpcMethod("wc_pairingPing")]
    [RpcRequestOptions(Clock.THIRTY_SECONDS, false, 1002)]
    [RpcResponseOptions(Clock.THIRTY_SECONDS, false, 1003)]
    public class PairingPing : Dictionary<string, object>
    {
    }
}
