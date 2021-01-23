using Cms_EntityLayer.Entities.Interface;
using Cms_EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cms_EntityLayer.Entities.Concrete
{
    public class Category : IBaseEntity
    {

        public int  Id { get; set; }

        [Required(ErrorMessage="Must type a title")]
        [MinLength(2,ErrorMessage ="Minimum lenght is 2")]
        [RegularExpression(@"^[a-zA-Z]+$",ErrorMessage ="Only allowed letters")]

        public string Name { get; set; }
        public string Slug { get; set; }


        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get ; set ; }
        public DateTime? DeleteDate { get ; set ; }

        private Status _status = Status.Active;
        public Status Status { get=>_status; set=>_status=value; }

        public virtual List<Product> Products { get; set; }
    }
}
