﻿using CMS_DataLayer.Context;
using CMS_DataLayer.Repositories.Interfaces.Base;
using CMS_DataLayer.Repositories.Interfaces.EntityTypeRepositories;
using Cms_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_DataLayer.Repositories.Concrete.EntityTypeRepositories
{
   public  class ProductRepository:BaseRepository<Product>,IProductRepository
    {

        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
        
    }
}
