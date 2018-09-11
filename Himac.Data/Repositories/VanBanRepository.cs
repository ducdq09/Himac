using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface IVanBanRepository : IRepository<VanBan>
    {

    }

    public class VanBanRepository : RepositoryBase<VanBan>, IVanBanRepository
    {
        public VanBanRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}