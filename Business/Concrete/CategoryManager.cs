﻿using DataAccess.Concrete.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAdd(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3)
            {
                //hata mesajı
            }
            else repo.Insert(p);
        }
    }
}
