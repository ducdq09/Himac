using System;

namespace Himac.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HimacDbContext dbContext;

        public HimacDbContext Init()
        {
            return dbContext ?? (dbContext = new HimacDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}