namespace Himac.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}