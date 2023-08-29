using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTK_Shop.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private TTK_ShopDbContext dbContext;
        public TTK_ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TTK_ShopDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
            
        }
    }
}
