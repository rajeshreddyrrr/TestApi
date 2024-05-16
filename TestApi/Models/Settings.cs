using Newtonsoft.Json;

namespace TestApi.Models
{
    public static class Settings
    {
        public static AppSettings appSettings
        {
            get
            {
                if (_appSettings == null)
                {
                    _appSettings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText("appsettings.json"));
                }
                return _appSettings;
            }
        }
        private static AppSettings _appSettings;
    }
}
