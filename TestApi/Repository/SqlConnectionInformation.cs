

using TestApi.Models;

namespace TestApi.Repository
{
    public class SqlConnectionInformation : ISqlConnectionInformation
    {
        public string ConnectionString { get; set; }
        public SqlConnectionInformation(AppSettings appSettings)
        {
            ConnectionString = $@"Data Source={appSettings.DatabaseServer};Initial Catalog={appSettings.DatabaseName};Application Name={appSettings.ApplicationName};uid={appSettings.DatabaseUser};password={appSettings.DatabasePassword}";
        }
    }
}
