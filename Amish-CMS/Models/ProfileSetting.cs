using System;
using System.Collections.Generic;

namespace Amish_CMS.Models
{
    public partial class ProfileSetting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public string Aboutme { get; set; }
        public string CoverPic { get; set; }
        public string ProfilePic { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedinLink { get; set; }
        public string InstagramLink { get; set; }
        public DateTime? CreateTs { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
