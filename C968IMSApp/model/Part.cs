using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968IMSApp
{
   abstract class Part
    {
        public int partID { get; set; }
        public string partName { get; set; }
        public int partInvtry { get; set; }
        public double partPrice { get; set; }
        public int partMax { get; set; }
        public int partMin { get; set; }
        
        public static int partCount;

        public Part (int apartID, string apartName, int apartInvtry, double apartPrice, int apartMin, int apartMax)
        {
            partID = apartID;
            partName = apartName;
            partInvtry = apartInvtry;
            partPrice = apartPrice;
            partMax = apartMax;
            partMin = apartMin;
        }

        public Part(string apartName, int apartInvtry, double apartPrice, int apartMin, int apartMax)
        {
            partID = partCount++;
            partName = apartName;
            partInvtry = apartInvtry;
            partPrice = apartPrice;
            partMax = apartMax;
            partMin = apartMin;
        }





    }
}
