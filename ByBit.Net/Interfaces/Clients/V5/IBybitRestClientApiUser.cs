using Bybit.Net.Enums;
using Bybit.Net.Objects.Models.V5;
using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Bybit.Net.Enums.V5;
using System.Security;

namespace Bybit.Net.Interfaces.Clients.V5
{
    /// <summary>
    /// used to manage accounts 
    /// </summary>
    public interface IBybitRestClientApiUser
    {
        /// <summary>
        /// creates a sub account
        /// https://bybit-exchange.github.io/docs/v5/user/create-subuid
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="memberType"></param>
        /// <param name="quickLogin"></param>
        /// <param name="isUta"></param>
        /// <param name="note"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<WebCallResult<CreateSubUIDResponse>> CreateSubMember(string username, AccountMemberType memberType, string? password,  bool? quickLogin,bool? isUta ,string? note, CancellationToken ct = default);


     
    }
}
