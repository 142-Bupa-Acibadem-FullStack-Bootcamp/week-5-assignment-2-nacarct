﻿using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IProductsByCategoryRepository
    {
        IQueryable ProductsByCategoryReport();
    }
}