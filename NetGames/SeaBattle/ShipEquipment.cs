using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    
    public abstract class ShipEquipment
    {
        protected string status;
        protected string name;
        protected double weight;

        public ShipEquipment(string name)
        {
            this.name = name;
            GetParams(name);
        }
        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

        }
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

        private void GetParams(string name)
        {
            throw new NotImplementedException();
        }
    }
}
