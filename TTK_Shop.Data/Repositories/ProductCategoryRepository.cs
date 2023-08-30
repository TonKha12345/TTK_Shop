﻿using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using TTK_Shop.Data.Infrastructure;
using TTK_Shop.Model.Models;

namespace TTK_Shop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
        IEnumerable<ProductCategory> GetByParentId(int parentID );
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }

        public IEnumerable<ProductCategory> GetByParentId(int parentID)
        {
            return this.DbContext.ProductCategories.Where(x => x.ParentID == parentID);
        }
    }
}