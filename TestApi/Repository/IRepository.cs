namespace TestApi.Repository
{
    public interface IRepository<T>
    {
        Task<List<T>> Get();
    }
}
