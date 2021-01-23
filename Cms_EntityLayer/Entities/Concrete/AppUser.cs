using Cms_EntityLayer.Entities.Interface;
using Cms_EntityLayer.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cms_EntityLayer.Entities.Concrete
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        public  string Occupation { get; set; }
        //I ve added a property which is not included by IdentityUser.
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get ; set; }
        public DateTime? DeleteDate { get ; set; }

        private Status _status = Status.Active;
        public Status Status { get=>_status ; set=>_status=value ; }
    }
}
