using System;

namespace Proj1_Patel
{
    class Program
    {
        static void Main(string[] args)
        {
            string result, price, type, color, name, leather, audio, mat;
            decimal cost = 0.00m;
            bool hasLeather = false;
            bool hasAudio = false;
            bool hasMat = false;

            //Banner
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Happy Car Company");
            Console.ResetColor();
            Console.WriteLine("Let get good car and deal for you!\n");
            Console.WriteLine("What kind of car  base would you like?");
            Console.WriteLine("1. 2 door Sedan ($20,000)");
            Console.WriteLine("2. 4 door Sedan ($30,000)");
            Console.WriteLine("3. SUV ($50,000)");
            Console.WriteLine("4. Monster Truck ($200,000)");

            while(true)
            {
                Console.Write("Please enter 1, 2, 3 and 4: ");
                result = Console.ReadLine();
                if(result=="1")
                {
                    price = ("$20,000.00");
                    cost = cost + 20000;
                    type = "2 door Sedan";
                    break;
                }
                else if (result=="2")
                {
                    price = ("$30,000.00");
                    cost = cost + 30000;
                    type = "4 door Sedan";
                    break;
                }
                else if (result=="3")
                {
                    price = ("$50,000.00");
                    cost = cost + 50000;
                    type = "SUV";
                    break;
                }
                else if(result=="4")
                {
                    price = ("$200,000.00");
                    cost = cost + 200000;
                    type = "Monster Truck";
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.ResetColor();
                }
            }
            Console.WriteLine($"Cost so far {price}\n");

            //Leather Section

            while(true)
            {
                Console.Write("Would you like to add leather interior for $2000 (Y/N)? ");
                result = Console.ReadLine().ToLower();
                if(result=="y")
                {
                    hasLeather = true;
                    cost = cost + 2000;
                    break;
                }
                else if (result=="n")
                {
                    hasLeather = false;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.ResetColor();
                }
            }
            if (hasLeather==true)
            {
                Console.Write("Leather selected. Good Choice!\n");
            }
            else
            {
                Console.Write("No problem. Leather interior not added\n");
            }
            Console.WriteLine($"Cost so far {cost:C} \n");

            leather = "";
            if (hasLeather == true)
            {
                leather = "awesome leather";
            }

            //Ear Buster Section

            while (true)
            {
                Console.Write("Would you like to add our 'Ear Buster' audio package for $1000 (Y/N)? ");
                result = Console.ReadLine().ToLower();
                if (result=="y")
                {
                    hasAudio = true;
                    cost = cost + 1000;
                    break;
                }
                else if (result=="n")
                {
                    hasAudio = false;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.ResetColor();
                }
            }
            if (hasAudio==true)
            {
                Console.Write("'Ear Buster' audio package selected. Its advanced AI will only allow death metal to be played.\n");
            }
            else
            {
                Console.Write("No problem. 'Ear Buster' audio package not added\n");
            }
            Console.WriteLine($"Cost so far {cost:C} \n");

            audio = "";
            if (hasAudio == true)
            {
                audio = "'Ear Buster'";
            }

            //Mat Section

            while (true)
            {
                Console.Write("Would like to add out premium package of car mats for $200 (Y/N)? ");
                result = Console.ReadLine().ToLower();
                if (result=="y")
                {
                    hasMat = true;
                    cost = cost + 200;
                    break;
                }
                else if (result=="n")
                {
                    hasMat = false;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.ResetColor();
                }
            }
            if (hasMat==true)
            {
                Console.Write("Premium mat package added. Great Choice!\n");
            }
            else
            {
                Console.Write("No problem. Premium package of car mats not added\n");
            }
            Console.WriteLine($"Cost so far {cost:C} \n");

            mat = "";
            if (hasMat == true)
            {
                mat = "premium";
            }

            //Paint Section

            while (true)
            {
                Console.Write("What color would you like to paint for your car? ");
                color = Console.ReadLine().ToLower();
                if(string.IsNullOrEmpty(color))
                {
                    Console.WriteLine("Ok no problem. Car will come with the standard color!\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"Great color. We can paint your car in {color} color.\n");
                    break;
                }
            }
            //Name Section

            while(true)
            {
                Console.Write("Please enter you name for your order: ");
                name = Console.ReadLine();
                if(string.IsNullOrEmpty(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter your name to finish your order");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            //Summary Section

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nThank you for your order {name}!");
            Console.WriteLine("Order Summary:");
            Console.WriteLine($"You ordered {type} with {color} color");
            Console.WriteLine($"We are adding our {leather} interior.");
            Console.WriteLine($"We are installing our {audio} audio package.");
            Console.WriteLine($"Our {mat} mats will be added.");
            Console.WriteLine($"Your Grand total comes to {cost:C}! Congratulations for new car & Thank you for ordering with Happy Car Company!");
            Console.ResetColor();
        }
    }
}