using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Connection_NET
{
    static class Version
    {
        public static string versao = getVersion();

        public static string getVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            return $"v{version.ToString()}"; 
        }
    }
}
