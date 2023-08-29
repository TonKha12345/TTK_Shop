using System;

namespace TTK_Shop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TTK_ShopDbContext Init();
    }
}