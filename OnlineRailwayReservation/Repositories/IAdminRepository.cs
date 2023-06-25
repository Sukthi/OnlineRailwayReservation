namespace OnlineRailwayReservation.Repositories
{
    public interface IAdminRepository<TEntity>
    {
        TEntity ValidateAdmin(TEntity entity);
        void Add(TEntity entity);
    }
}
   
