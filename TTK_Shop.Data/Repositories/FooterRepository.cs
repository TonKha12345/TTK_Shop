using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTK_Shop.Data.Infrastructure;
using TTK_Shop.Model.Models;

namespace TTK_Shop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }
    public class FooterRepository: RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory): base(dbFactory)
        {
        } 
    }
}
