using System;
using System.Collections.Generic;

namespace dotnetghost.Models.V3
{
    public class Pagination
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Pages { get; set; }
        public int Total { get; set; }
        public int Next { get; set; }
        public int Prev { get; set; }
    }
}