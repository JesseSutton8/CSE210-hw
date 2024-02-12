using System;

class Program
{
    static void Main(string[] args)
    {
        Entry Entry1 = new Entry();
        Journal Journal1 = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program! ");

        int number = -1;

        while (number !=5) {

            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            int userNumber = int.Parse(choice);

            if (userNumber == 1) {
                Entry1.AddEntry();
            }
            else if (userNumber == 2) {
                Entry1.DisplayEntry();
            }
            else if (userNumber == 3) {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                Entry1.LoadFile(fileName);
            }
            else if (userNumber == 4) {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                Entry1.SaveEntry(fileName);
            }
            else {
                number = 5;
            }
        }
    }
}