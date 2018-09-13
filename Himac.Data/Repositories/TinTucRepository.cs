using Himac.Data.Infrastructure;
using Himac.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Himac.Data.Repositories
{
    public interface ITinTucRepository : IRepository<TinTuc>
    {
        IEnumerable<TinTuc> Get16TinPhapLuatMoiNhat();
    }

    public class TinTucRepository : RepositoryBase<TinTuc>, ITinTucRepository
    {
        public TinTucRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<TinTuc> Get16TinPhapLuatMoiNhat()
        {
            return this.DbContext.TinTucs.Where(m => m.LoaiTinTuc.MaLoaiTinTuc == LoaiTinTuc.ConstMaLoaiTinTuc.Tinphapluat).OrderByDescending(m => m.TinTucId).Take(16);
        }
    }
}