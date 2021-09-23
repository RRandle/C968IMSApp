using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968IMSApp.model
{
    class OutSource : Part
    {
        public OutSource(int apartID, string apartName, int apartInvtry, double apartPrice, int apartMax, int apartMin, string comName)
    : base(apartID, apartName, apartInvtry, apartPrice, apartMax, apartMin)
        {
            CompanyName = comName;
        }

        public OutSource(string apartName, int apartInvtry, double apartPrice, int apartMax, int apartMin, string comName)
: base(apartName, apartInvtry, apartPrice, apartMax, apartMin)
        {
           CompanyName = comName;
        }
        public string CompanyName { get; set; }
    }
}
