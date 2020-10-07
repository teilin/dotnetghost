using System;
using System.Linq;
using dotnetghost.Models;
using JWT.Algorithms;
using JWT.Builder;

namespace dotnetghost.Common
{
    internal static class TokenGenerator
    {
        internal static JwtToken Generate(string id, string secret)
        {
            var jwtToken = new JwtToken();

            var issuedAt = DateTimeOffset.Now;
            var expiredAt = issuedAt.AddMinutes(5);

            var token = new JwtBuilder()
                .AddHeader(HeaderName.KeyId, id)
                .WithAlgorithm(new HMACSHA256Algorithm())
                .WithSecret(StringToByteArray(secret))
                .AddClaim("exp", expiredAt.ToUnixTimeSeconds())
                .AddClaim("iat", issuedAt.ToUnixTimeSeconds())
                .AddClaim("aud", "/v3/admin/")
                .Encode();

            jwtToken.SetToken(token);
            return jwtToken;
        }

        internal static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x,2), 16))
                .ToArray();
        }
    }
}