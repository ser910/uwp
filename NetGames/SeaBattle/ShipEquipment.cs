using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    
    public abstract class ShipEquipment
    {
        protected string status;
        protected string name;
        protected double weight;
        protected double _hp;
        public ShipEquipment(string name)
        {
            this.name = name;
            GetParams(name, typeof(ShipEquipment));
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

        public string Status
        {
            get
            {
                return status;
            }
        }

        public void Damaged(double value)
        {
            _hp = -value;
            if (_hp >= 0)
                status = "dammaged";
            else
            {
                status = "destroyed";
                _hp = 0;
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
        /// <summary>
        /// get parameter weight from dictionaty by name 
        /// os dependeble;
        /// </summary>
        /// <param name="name"></param>
        private void GetParams(string name, Type classType)
        {
            status = "new";
            IEnumerable<FieldInfo> fields = classType.GetRuntimeFields();
        }
    }
}
