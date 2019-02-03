using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amish_CMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amish_CMS.Controllers
{
    public class ProfileController : Controller
    {
        CMS_dbContext db = new CMS_dbContext();

        public IActionResult Index()
        {
            //ProfileSetting profileSetting = new ProfileSetting();
            //profileSetting = db.ProfileSetting.FirstOrDefault();                      

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ProfileSetting profileSetting)
        {
            ProfileSetting profiledb = new ProfileSetting();

            profiledb = db.ProfileSetting.Where(x => x.Id == profileSetting.Id).FirstOrDefault();

            profiledb.Name = profileSetting.Name;
            profiledb.Title = profileSetting.Title;
            profiledb.Dob = profileSetting.Dob;
            profiledb.Email = profileSetting.Email;
            profiledb.Aboutme = profileSetting.Aboutme;
            //profiledb.ProfilePic = profileSetting.ProfilePic;
            profiledb.FacebookLink = profileSetting.FacebookLink;
            profiledb.LinkedinLink = profileSetting.LinkedinLink;
            profiledb.InstagramLink = profileSetting.InstagramLink;            
            profiledb.UpdateTs  = DateTime.UtcNow;            
            profiledb.UpdatedBy  = "Amish";

            //db.ProfileSetting.Add(profileSetting);
            db.SaveChanges();
            return View();

        }

       
    }
}