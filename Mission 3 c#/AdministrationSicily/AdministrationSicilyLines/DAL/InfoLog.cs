using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.DAL
{   
    //Information de connexion
    class InfoLog
    {
        private static string providerMysql = "localhost";

        private static string dataBaseMysql = "projetsicily";

        private static string uidMysql = "root";

        private static string mdpMysql = "";

        public static string ProviderMysql { get => providerMysql; }
        public static string DataBaseMysql { get => dataBaseMysql; }
        public static string UidMysql { get => uidMysql; }
        public static string MdpMysql { get => mdpMysql; }
    }
}
