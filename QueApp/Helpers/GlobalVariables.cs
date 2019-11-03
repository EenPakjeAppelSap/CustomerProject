using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueApp.Helpers
{
   public class GlobalVariables
    {
        private static string globalVar = "";

        public static string GlobalVar
        {
            get { return globalVar; }
            set { globalVar = value; }
        }
    }
}
