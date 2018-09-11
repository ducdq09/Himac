using System;

namespace Himac.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HimacDbContext Init();
    }
}