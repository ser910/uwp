﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Ammo : ShipEquipment, ISeaBattleGameObject
    {
        public Ammo(string name):base(name) { }

        public Type Type
        {
            get
            {
                return typeof(Ammo);
            }
        }

        public IGameObject Serialize()
        {
            throw new NotImplementedException();
        }
    }
}
