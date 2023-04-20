using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Ammo : Item
    {
        protected float damage;

        public float Damage { get { return damage; } }
        public float Price { get { return price; } }

        protected Ammo(float damage, float price) : base(price)
        {
            this.damage = damage;
        }


    }
}
