using System;
using System.Collections.Generic;

namespace dotnetghost.Models
{
    public class UsersCollection : IFetchable
    {
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public Meta Meta { get; set; }
    }
}