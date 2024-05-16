using TestApi.Models;
using TestApi.Repository;

namespace TestApi.Services
{
    public class BKTestService : BaseService<BKTest>
    {
        public BKTestService(IRepository<BKTest> repository)
        {
            Repository = repository;
        }
        public async Task<List<BKTest>> Get()
        {
            var response = await Repository.Get();
            return response;
        }
    }
}
