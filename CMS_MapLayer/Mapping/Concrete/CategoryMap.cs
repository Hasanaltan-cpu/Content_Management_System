using Cms_EntityLayer.Entities.Concrete;
using CMS_MapLayer.Mapping.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_MapLayer.Mapping.Concrete
{
  public  class CategoryMap :BaseMap<Category>
    {


        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);
            base.Configure(builder);
        }
    }
}
