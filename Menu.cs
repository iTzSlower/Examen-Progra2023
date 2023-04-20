using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Menu
    {
        private List<Weapon> weapons;
        private bool continueFlag;

        public void Execute()
        {
            weapons = new List<Weapon>();
            continueFlag = true;

            while (continueFlag)
            {
                AddWeaponMenu();
                EndingMenu();
            }
        }

        private void AddWeaponMenu()
        {
            Console.WriteLine("Ingresar el número del arma a agregar:");
            Console.WriteLine("1. Espada");
            Console.WriteLine("2. Arco");
            Console.WriteLine("3. Pistola");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddSwordMenu();
                    break;
                case "2":
                    AddBowMenu();
                    break;
                case "3":
                    AddGunMenu();
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }
        }

        private void AddSwordMenu()
        {
            string name;
            float damage;
            float attackSpeed;
            float price;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir el daño:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque:");
            attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            price = float.Parse(Console.ReadLine());

            weapons.Add(new Sword(name, damage, attackSpeed, price));


        }

        private void AddBowMenu()
        {
            string name;
            float damage;
            float attackSpeed;
            float price;
            float ammoDamage;
            float ammoPrice;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir el daño:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque:");
            attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("Introducir el daño:");
            ammoDamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            ammoPrice = float.Parse(Console.ReadLine());

            Arrow arrow = new Arrow(ammoDamage, ammoPrice);

            weapons.Add(new Bow(name, damage, attackSpeed, price, arrow));

        }

        private void AddGunMenu()
        {
            string name;
            float damage;
            float attackSpeed;
            float price;
            float ammoDamage;
            float ammoPrice;

            Console.WriteLine("Introducir el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introducir el daño:");
            damage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la velocidad de ataque:");
            attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine("Introducir el daño:");
            ammoDamage = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el precio:");
            ammoPrice = float.Parse(Console.ReadLine());

            Bullet bullet = new Bullet(ammoDamage, ammoPrice);

            weapons.Add(new Gun(name, damage, attackSpeed, price, bullet));

        }


        private void EndingMenu()
        {
            bool endingContinueFlag = true;

            while (endingContinueFlag)
            {
                Console.WriteLine("Introducir el número de la acción que quiere realizar");
                Console.WriteLine("1. Añadir otra arma");
                Console.WriteLine("2. Mostrar todas las armas");
                Console.WriteLine("3. Eliminar un arma");
                Console.WriteLine("4: Salir");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        endingContinueFlag = false;
                        break;
                    case "2":
                        ShowAllWeapons();
                        break;
                    case "3":
                        RemoveWeapon();
                        break;
                    case "4":
                        endingContinueFlag = false;
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("No es una opción válida");
                        break;
                }


            }
        }

        private void ShowAllWeapons()
        {
            Console.WriteLine("La lista de armas es: ");
            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine($"{i}: {weapons[i].GetDetails()}");
            }
        }

        private void RemoveWeapon()
        {
            Console.WriteLine("Introducir el número del arma a remover:");
            ShowAllWeapons();
            int option = int.Parse(Console.ReadLine());

            if (option >= 0 && option < weapons.Count)
            {
                weapons.RemoveAt(option);
            }
            else
            {
                Console.WriteLine("No es un número válido");
            }
        }

    }
}
}
