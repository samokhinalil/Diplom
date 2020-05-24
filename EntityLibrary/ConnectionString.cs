using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class ConnectionString
    {
        public static string CurrentConnectionString =
            ConfigurationManager.ConnectionStrings["CurrentConnectionString"].ConnectionString;

        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string IntegratedSecurity { get; set; }
        public string ConnectTimeout { get; set; }
        public string Encrypt { get; set; }

        public string TrustServerCertificate { get; } = "TrustServerCertificate = False";
        public string ApplicationIntent { get; } = "ApplicationIntent = ReadWrite";
        public string MultiSubnetFailover { get; } = "MultiSubnetFailover = False";

        public ConnectionString(string dataSource,
            string initialCatalog,
            string integratedSecurity,
            string connectTimeout,
            string encrypt)
        {
            DataSource = dataSource;
            InitialCatalog = initialCatalog;
            IntegratedSecurity = integratedSecurity;
            ConnectTimeout = connectTimeout;
            Encrypt = encrypt;
        }

        public override string ToString()
        {
            return string.Join(";", DataSource, InitialCatalog, IntegratedSecurity,
                ConnectTimeout, Encrypt, TrustServerCertificate, ApplicationIntent,
                MultiSubnetFailover);
        }
    }
}
