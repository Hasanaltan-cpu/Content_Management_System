using Cms_EntityLayer.Entities.Concrete;
using CMS_MapLayer.Mapping.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_MapLayer.Mapping.Concrete
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Occupation).IsRequired(true);
            base.Configure(builder);
        }
    }
}
