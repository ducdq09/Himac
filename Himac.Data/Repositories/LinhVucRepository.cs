using Himac.Data.Infrastructure;
using Himac.Model.Models;

namespace Himac.Data.Repositories
{
    public interface ILinhVucRepository : IRepository<LinhVuc>
    {
    }

    public class LinhVucRepository : RepositoryBase<LinhVuc>, ILinhVucRepository
    {
        public LinhVucRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}