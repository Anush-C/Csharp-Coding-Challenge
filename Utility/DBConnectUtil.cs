using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Utility
{
    internal static class DBConnectUtil
    {
        private static IConfiguration _iiconfiguration;
        static DBConnectUtil()
        {
            GetAppSettingsFile();
        }

        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath
               (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            _iiconfiguration = builder.Build();
        }

        public static string GetConnectionString()
        {
            return _iiconfiguration.GetConnectionString("LocalConnectionString");
        }

    }
}
