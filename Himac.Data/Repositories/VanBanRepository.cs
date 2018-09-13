using System.Collections.Generic;
using System.Linq;
using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface IVanBanRepository : IRepository<VanBan>
    {
        IEnumerable<VanBan> Get5VanBanMoiNhat();
    }

    public class VanBanRepository : RepositoryBase<VanBan>, IVanBanRepository
    {
        public VanBanRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<VanBan> Get5VanBanMoiNhat()
        {
            return this.DbContext.VanBans.OrderByDescending(m => m.VanBanId).Take(5);
        }
    }
}