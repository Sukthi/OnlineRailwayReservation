using OnlineRailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{
    public interface IUserRepository<TEntity>
    {
        TEntity ValidateAdmin(TEntity entity);
        void Add(TEntity entity);
    }
}