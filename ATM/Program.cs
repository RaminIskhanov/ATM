using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            bool backToStart = true;

            User[] users = new User[5]; 
            users[0] = new User("Ramin","Isxanov") { PAN = "123456", PIN = "1111", CVC = "345", ExpireDate = "12/21", Balance = 9 };
            users[1] = new User("Pervin", "Qasimli") { PAN = "123456", PIN = "8585", CVC = "085", ExpireDate = "12/21", Balance = 400 };
            users[2] = new User("Qafqaz","Genceli") { PAN = "123456", PIN = "2020", CVC = "020", ExpireDate = "12/21", Balance = 1000 };
            users[3] = new User("Tosu", "Zengilanli") { PAN = "123456", PIN = "4444", CVC = "345", ExpireDate = "12/21", Balance = 90 };
            users[4] = new User("Mehemmed", "Deniz") { PAN = "123456", PIN = "5555", CVC = "345", ExpireDate = "12/21", Balance = 570.67m };


            while (backToStart)
            {
                Console.WriteLine("4 reqemli shifrenizi daxil edin:");
                string pin = Console.ReadLine();

                // For dongusunde userlerin icinde user terefinden daxil edilmish shifreni bir bir yoxlayaraq shifreni mueyyen edirik!!
                for (int i = 0; i < users.Length; i++)
                {
                    if (pin == users[i].PIN)  // Shertin yoxlanilmasi 
                    {
                        Console.WriteLine($" \n {users[i].Name} {users[i].SurName} : Xos gelmisiniz. Zehmet olmasa asagidakilardan birini secin:");
                        Console.WriteLine("----------------------------------------------------------------------------");
                        Console.WriteLine("1. Balans");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("2. Nagd pul");
                        Console.WriteLine("--------------------------------");
                        string choise = Console.ReadLine();
                        switch (choise)
                        {
                            case "1":
                                Console.WriteLine($"Sizin balansiniz: { users[i].Balance} Azn");
                                Console.WriteLine("-----------------------------------");
                                break;
                            case "2":
                                Console.WriteLine("1. 10 AZN");
                                Console.WriteLine("2. 20 AZN");
                                Console.WriteLine("3. 50 AZN");
                                Console.WriteLine("4. 100 AZN");
                                Console.WriteLine("5. Diger"); /// Verilen meblegleri deyl bashqa bir mebleg istediyimizde '5' seciminden istifade edirik!!!
                                string amountChoise = Console.ReadLine();
                                switch (amountChoise)
                                {
                                    case "1":
                                        if (users[i].Balance >= 10)
                                        {
                                            users[i].Balance = users[i].Balance - 10;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "2":
                                        if (users[i].Balance >= 20)
                                        {
                                            users[i].Balance = users[i].Balance - 20;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "3":
                                        if (users[i].Balance >= 50)
                                        {
                                            users[i].Balance = users[i].Balance - 50;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        break;
                                    case "4":
                                        if (users[i].Balance >= 100)
                                        {
                                            users[i].Balance = users[i].Balance - 100;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        Console.WriteLine("Var Zengilannan bidene canavar");
                                        break;
                                    case "5":
                                        Console.WriteLine("Meblegi daxil edin");
                                        decimal freeChoise = int.Parse(Console.ReadLine());
                                        if (users[i].Balance >= freeChoise) // Balansin istediyimiz meblegden boyuk olub olmamasini yoxlayiriq!
                                        {
                                            users[i].Balance = users[i].Balance - freeChoise;
                                            Console.WriteLine(users[i].Balance);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
                                        }
                                        break;
                                }
                                break;
                        }

                        break;
                    }

                    else if (i == users.Length - 1) // Yuxarida verilmish olan donguye esasen shifreye uygun 'Kart' tapilmadiqda verilecek olan shert !!
                    {
                        Console.WriteLine("Bu PIN koda aid kart tapilmadi.");
                    }
                }
            }
        }
    }
}
