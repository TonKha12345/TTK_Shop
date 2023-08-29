using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTK_Shop.Data.Infrastructure;
using TTK_Shop.Model.Models;

namespace TTK_Shop.Data.Repositories
{
    public interface IMenuGroupRepository: IRepository<MenuGroup>
    {

    }
    public class MenuGroupRepository: RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
