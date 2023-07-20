﻿namespace Mx.NET.SDK.Provider
{
    public interface IMultiversxProvider :
        API.IGenericProvider,
        API.IAccountsProvider,
        API.IBlocksProvider,
        API.ICollectionsProvider,
        API.INetworkProvider,
        API.INftsProvider,
        API.ITokensProvider,
        API.ITransactionsProvider,
        API.IUsernamesProvider,
        API.IxExchangeProvider,

        Gateway.IGenericProvider,
        Gateway.IAddressesProvider,
        Gateway.ITransactionsProvider,
        Gateway.INetworkProvider,
        Gateway.INodesProvider,
        Gateway.IBlocksProvider,
        Gateway.IQueryVmProvider
    { }
}
