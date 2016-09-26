using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Ship : ISeaBattleGameObject
    {
        private Dictionary<Crew, int> crew;
        private Dictionary<Ammo, int> ammo;
        private Dictionary<Gun, int> guns;
        private Armor armor;
        private string status;
        private string name;
        private double weight;
        private int dimention;
        private int x = int.MinValue;
        private int y = int.MinValue;

        public Ship(int name, int dimenshion)
        {

        }
        
        public string Status
        {
            get
            {
                return GetStatus();
            }
        }

        private string GetStatus()
        {
            throw new NotImplementedException();
        }

        public bool Transparante
        {
            get
            {
                return false;
            }
        }

        public Type Type
        {
            get
            {
                return typeof(Ship);
            }
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public double Weight
        {
            get
            {
                return CalcWeight();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if(checkName(value))
                    name = value;
            }
        }
        /// <summary>
        /// check new name
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true if new name, false existing name</returns>
        private bool checkName(string value)
        {
            return false;
        }

        private double CalcWeight()
        {
            double weight = 0;
            ammo.AsParallel().ForAll((a) => 
            {
                weight += a.Key.Weight*a.Value;
            });
            crew.AsParallel().ForAll((c) =>
            {
                weight += c.Key.Weight*c.Value;
            });
            guns.AsParallel().ForAll((g) =>
            {
                weight += g.Key.Weight * g.Value;
            });
            weight += armor.Weight;
            return weight;
        }
    }
}
