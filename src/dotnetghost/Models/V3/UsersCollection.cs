using System;
using System.Collections.Generic;

namespace dotnetghost.Models.V3
{
    public class UsersCollection : IFetchable
    {
        public IList<User> Users { get; set; } = new List<User>();
        public Meta Meta { get; set; }
    }
}