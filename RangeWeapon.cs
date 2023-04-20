using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class RangeWeapon : Weapon
    {
        protected Ammo ammo;

        protected RangeWeapon(string name, float damage, float attackSpeed, float price, Ammo ammo) : base(name, damage, attackSpeed, price)
        {
            this.ammo = ammo;
        }

        protected override float GetPrice()
        {
            return price + ammo.Price;
        }

        protected override float GetDamagePerSecond()
        {
            return (damage + ammo.Damage) * attackSpeed;
        }
    }
}
