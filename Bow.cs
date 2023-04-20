using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Bow : RangeWeapon
    {
        public Bow(string name, float damage, float attackSpeed, float price, Ammo ammo) : base(name, damage, attackSpeed, price, ammo)
        {
        }
    }
}
