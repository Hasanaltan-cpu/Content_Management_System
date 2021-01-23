using CMS_DataLayer.Context;
using CMS_DataLayer.Repositories.Interfaces.Base;
using CMS_DataLayer.Repositories.Interfaces.EntityTypeRepositories;
using Cms_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_DataLayer.Repositories.Concrete.EntityTypeRepositories
{
    public class PageRepository:BaseRepository<Page>,IPageRepository
    {

        public PageRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
       
    }
}
