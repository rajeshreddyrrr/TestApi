using TestApi.Repository;

namespace TestApi.Services
{
    public class BaseService<T> : IService<T>
    {
        public IRepository<T> Repository { get; set; }

        
        public virtual async Task<List<T>> Get()
        {
            return await Repository.Get();
        }
    }
}
