using System;

namespace SeaBattle
{
    public class Gun : ShipEquipment, ISeaBattleGameObject
    {

        public Gun(string name):base(name) { }

        public Type Type
        {
            get
            {
                return typeof(Gun);
            }
        }

        public IGameObject Serialize()
        {
            throw new NotImplementedException();
        }
    }
}