using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Armor : ShipEquipment, ISeaBattleGameObject
    {
        public Armor(string name):base(name) { }

        public Type Type
        {
            get
            {
                return typeof(Armor);
            }
        }
        public double Durability { get { return _hp; } }

        public IGameObject Serialize()
        {
            throw new NotImplementedException();
        }
    }
}
