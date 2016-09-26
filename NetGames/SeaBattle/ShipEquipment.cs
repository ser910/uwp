using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public abstract class ShipEquipment
    {
 
        public int X
        {
            get
            {
                return int.MinValue;
            }
        }

        public int Y
        {
            get
            {
                return int.MinValue;
            }
        }
    }
}
