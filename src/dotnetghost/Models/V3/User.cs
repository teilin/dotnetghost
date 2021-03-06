using System;

namespace dotnetghost.Models.V3
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public string Bio { get; set; }
        public string Website { get; set; }
        public string Location { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Accessibility { get; set; }
        public string Status { get; set; } // might change to enum
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Tour { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Url { get; set; }
    }
}