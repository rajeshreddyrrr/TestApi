namespace TestApi.Services
{
    public interface IService<T>
    {
        Task<List<T>> Get();
    }
}
