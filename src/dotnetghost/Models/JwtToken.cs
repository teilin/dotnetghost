using System;

namespace dotnetghost.Models
{
    internal sealed class JwtToken
    {
        private string _token;

        internal string Token 
        { 
            get
            {
                return _token;
            }
            private set
            {
                _token = value;
            }
        }

        internal int DurationMinutes
        {
            get
            {
                if(CreatedAt==null) return 999;
                else
                {
                    return (int)(DateTime.UtcNow - CreatedAt.Value).TotalMinutes;
                }
            }
        }

        private DateTime? CreatedAt { get; set; }

        internal void SetToken(string token)
        {
            this.CreatedAt = DateTime.UtcNow;
            this.Token = token;
        }
    }
}