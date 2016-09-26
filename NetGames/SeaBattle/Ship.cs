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
        private int durability;
        private string status;
        private string name;
        private double weight;
        private int x;
        private int y;

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
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private double CalcWeight()
        {
            throw new NotImplementedException();
        }
    }
}
