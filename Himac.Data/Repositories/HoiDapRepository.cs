using System.Collections.Generic;
using System.Linq;
using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface IHoiDapRepository : IRepository<HoiDap>
    {
        IEnumerable<HoiDap> Get5HoiDapMoiNhat();
    }

    public class HoiDapRepository : RepositoryBase<HoiDap>, IHoiDapRepository
    {
        public HoiDapRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<HoiDap> Get5HoiDapMoiNhat()
        {
            return this.DbContext.HoiDaps.OrderByDescending(m => m.HoiDapId).Take(5);
        }
    }
}