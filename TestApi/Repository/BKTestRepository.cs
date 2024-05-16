using System.Data;
using System.Data.SqlClient;
using TestApi.Models;

namespace TestApi.Repository
{
    public class BKTestRepository : BaseRepository<BKTest>
    {
        public BKTestRepository(ISqlConnectionInformation sqlConnectionInformation)
        {
            ConnectionInformation = sqlConnectionInformation;
        }
        public override async Task<List<BKTest>> Get()
        {
            List<BKTest> models = new List<BKTest>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=RRR;Initial Catalog=Rajesh;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * from tblBK", connection) { CommandType = CommandType.Text })
                {
                    //command.Parameters.Add(new SqlParameter("@RequestNumber", code));

                    var reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        var model = Load<BKTest>(reader);
                        models.Add(model);
                    }
                }

            }

            return models;
        }
    }
}
