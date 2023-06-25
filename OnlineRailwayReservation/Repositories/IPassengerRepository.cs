
using RailwayReservation.Models;

namespace OnlineRailwayReservation.Repositories
{
    public interface IPassengerRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);

        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(int entity);
        IEnumerable<TEntity> GetByPassenger(int id);
    }
}

        

