using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Bybit.Net.Enums.V5;
using Bybit.Net.Interfaces.Clients.V5;
using Bybit.Net.Objects.Models.V5;
using CryptoExchange.Net.Objects;

namespace Bybit.Net.Clients.V5
{
    public class BybitRestClientApiUser : IBybitRestClientApiUser
    {
        private readonly BybitRestClientApi _baseClient;

        internal BybitRestClientApiUser(BybitRestClientApi baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<WebCallResult<CreateSubUIDResponse>> CreateSubMember(string username,
            AccountMemberType memberType, string? password = null, bool? quickLogin = null, bool? isUta = null,
            string? note = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, object>
            {
                { "username", username },
                { "memberType", (int)memberType },
                { "password", password },
                { "switch", quickLogin is null or true ? 1 : 0 },
                { "isUta", isUta },
                { "note", note }
            };

            var response = await _baseClient
                .SendRequestAsync<CreateSubUIDResponse>(_baseClient.GetUrl("v5/user/create-sub-member"),
                    HttpMethod.Post, ct, parameters, true).ConfigureAwait(false);


            return response;
        }
    }
}