using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Welcome to this fruit menu!");

        int userchoice;
        string choice;
        int userC = 0;

        string[] fruits = {};

        while(userC != 5)
        {
            Console.WriteLine("What do you want to do? \n 1. Add new item\n 2. Edit Item\n 3. Remove Item\n 4. View All Items\n 5. Exit");
            userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice == 1)
            {
                Console.WriteLine("Add a fruit: ");
                choice = Console.ReadLine();
                var fruitlist = fruits.ToList();
                fruitlist.Add(choice);
                fruits = fruitlist.ToArray();
                
            }
            else if(userchoice == 2)
            {
                Console.WriteLine("Edit Item");
                foreach(var item in fruits)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Which item do you want to change?: ");
                string itemchoice = Console.ReadLine();
                for(int i = 0; i < fruits.Length; i++)
                {
                    if (fruits[i] == itemchoice)
                    {
                        Console.WriteLine("What do you want to change it to? ");
                        choice=Console.ReadLine();

                        fruits[i] = choice;
                    }
                    else { continue; }
                }

            }
            else if(userchoice == 3)
            {
                Console.WriteLine("Remove Item");
                foreach (var item in fruits)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Which do you want to remove?\n :");
                choice = Console.ReadLine();
                var fruitlist = fruits.ToList();
                fruitlist.Remove(choice);
                fruits = fruitlist.ToArray();

            }
            else if(userchoice == 4)
            {
                Console.WriteLine("View All Items");
                foreach(var item in fruits)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exit!");
                userC = 5;
            }
        }



    }

    



}