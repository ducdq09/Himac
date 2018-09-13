using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface ILoaiHoiDapRepository : IRepository<LoaiHoiDap>
    {
    }

    public class LoaiHoiDapRepository : RepositoryBase<LoaiHoiDap>, ILoaiHoiDapRepository
    {
        public LoaiHoiDapRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}