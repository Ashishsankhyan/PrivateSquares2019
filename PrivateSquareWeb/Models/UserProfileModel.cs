﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSquareWeb.Models
{
    public class UserProfileModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        public string Description { get; set; }
        public string EmailId { get; set; }
        public long ProfessionalCatId { get; set; }
        public string Title { get; set; }
        public string ProfessionalKeyword { get; set; }
        public long CityId { get; set; }
        public string Password { get; set; }
        public long GenderId { get; set; }
        public DateTime DOB { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Pincode { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
    }
}