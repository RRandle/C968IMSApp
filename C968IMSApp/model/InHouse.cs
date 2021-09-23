using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968IMSApp.model
{
    class InHouse : Part 
    {
        public InHouse (int apartID, string apartName, int apartInvtry, double apartPrice, int apartMin, int apartMax, int machID)
            :base(apartID,apartName,apartInvtry,apartPrice,apartMin,apartMax)
        {
            MachineID = machID; 
        }

        public InHouse( string apartName, int apartInvtry, double apartPrice, int apartMin, int apartMax, int machID)
    : base(apartName, apartInvtry, apartPrice, apartMin, apartMax)
        {
            MachineID = machID;
        }
        public int MachineID { get; set; }
    }

   
}
