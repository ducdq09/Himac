using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface ILoaiVanBanRepository : IRepository<LoaiVanBan>
    {
    }

    public class LoaiVanBanRepository : RepositoryBase<LoaiVanBan>, ILoaiVanBanRepository
    {
        public LoaiVanBanRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}