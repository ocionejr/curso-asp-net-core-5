using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.VO
{
    public class TokenVO
    {
        public TokenVO(bool authenticated, string created, string expiration, string accessToken, string refreshToken)
        {
            this.authenticated = authenticated;
            this.created = created;
            this.expiration = expiration;
            this.accessToken = accessToken;
            this.refreshToken = refreshToken;
        }

        public TokenVO()
        {
        }

        public bool authenticated { get; set; }
        public string created { get; set; }
        public string expiration { get; set; }
        public string accessToken { get; set; }
        public string refreshToken { get; set; }

    }
}
