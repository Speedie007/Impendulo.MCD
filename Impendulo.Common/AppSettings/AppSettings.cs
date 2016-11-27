using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Impendulo.Common.AppSettings
{
    public class AppSettings
    {
        Configuration config;
        public AppSettings()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string GetConnectionString(string key)
        {
            var Configh3 = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void SaveConnectionString(string key, string value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            //config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
