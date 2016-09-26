using System;

namespace SeaBattle
{
    public class Gun : ShipEquipment, ISeaBattleGameObject
    {

        public Gun(string name):base(name) { }

        public string Status
        {
            get
            {
                return status;
            }
        }

        public Type Type
        {
            get
            {
                return typeof(Gun);
            }
        }



    }
}