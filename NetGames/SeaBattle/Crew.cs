using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Crew : ShipEquipment, ISeaBattleGameObject
    {
        public Crew(string name):base(name) { }

        public string Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Type Type
        {
            get
            {
                return typeof(Crew);
            }
        }
    }
}
