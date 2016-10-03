using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SQLite;

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
        private int size;
        private double buoyancy;
        private int x = int.MinValue;
        private int y = int.MinValue;
        private int angle;

        public Ship(int name, int size)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ship">Update </param>
        public Ship(Ship ship, ref decimal money)
        {

        }
        /// <summary>
        /// Set position of all parts of ship
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="angle">1 up, -1 down, 10 left, -10 right</param>
        public void SetPositon(int x, int y, int angle)
        {
            this.x = x;
            this.y = y;
            this.angle = angle; 
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
            if (buoyancy<=0)
                return "wreck";
            if (weight >= buoyancy)
                return "sank";
            if (buoyancy < size * 1000)
                return "";
            return "new";
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

        public bool IsHitBy(Ammo ammo, int x, int y)
        {

            return false;
        }

        public IGameObject Serialize()
        {
            throw new NotImplementedException();
        }
    }
}
