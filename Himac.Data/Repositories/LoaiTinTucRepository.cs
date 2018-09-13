using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface ILoaiTinTucRepository : IRepository<LoaiTinTuc>
    {
    }

    public class LoaiTinTucRepository : RepositoryBase<LinhVuc>, ILinhVucRepository
    {
        public LoaiTinTucRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
