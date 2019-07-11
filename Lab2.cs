using System;

namespace GVLabs

{
    //Task:  Calculate the perimeter and area of various classrooms at Grand Circus 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine(" Welcome {0} To Grand Circus", name);
            Console.WriteLine(" Let's calculate the perimeter and the area of various Class room");

            bool repeatProgram = true;
            while (repeatProgram)

            {
                Console.WriteLine("Enter the name or number of the room");
                string roomName = Console.ReadLine();

                // Input
                Console.WriteLine(" Enter the Lenght of the ");
                double lenght = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Enter the Width of the ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Enter the Height of the ");
                double height = Convert.ToDouble(Console.ReadLine());

                // Calculation
                double perimeter = (lenght + width) * 2;
                double area = (lenght * width);
                double volume = lenght * width * height;

                //Output
                Console.WriteLine("{0},  here are the messurements for room {1}", name, roomName);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("Area is {0}", area);
                Console.WriteLine("Volume is: {0}", volume);

                //Repeat
                Console.WriteLine("Do you want to calculate  another classroom? y/n");
                string repeat = Console.ReadLine();

                while (repeat != "n" && repeat != "N" && repeat != "y" && repeat != "Y")
                {
                    Console.WriteLine("Invalid Entry, please type y or n");
                    repeat = Console.ReadLine();

                }

                if (repeat == "n" || repeat == "N")
                {
                    Console.WriteLine("Thank you {0}, Good Bye", name);
                    Console.WriteLine("Press any key to close program");
                    Console.ReadLine();

                    repeatProgram = false;
                }

            }

        }
    }
}

/*
 * Lab 1 

Task:  Calculate the perimeter and area of various classrooms at Grand Circus 

What the Application do? 

	• the application prompts the use to enter values of length and width of the classroom 
	• The application displays the area and perimeter of that classroom. 
	• The application prompts the user to continue (keep measuring rooms!) 
Build specifications. 
	• Assume that the rooms are perfect rectangles 
	• Assume that the user will enter valid numeric data for length and width 
	• The application should accept decimal entries 
Hints 
	• Don’t mess up the formulas for area or perimeter or perimeter 
	• The snug is 24’ 6” X 20’ 0”. The penthouse is 42’ 6” X 16’ 6”. 
	• Microsoft visual c# step by step chapters 1 and 2 
Extra Challenges: 
	• The application should continue only if the user agrees to 
	• Calculate the volume of the rooms 
Console Preview 
———————————————————————————————— 
Welcome to Grand Circus Room Detail Generator 
Enter Length: { User input here, for example: 24.5} 
Enter Width: {User input here, for example 20} 
Area: answer will show up here 
Perimeter: {Answer will show up here} 
Continuer? (Y/N): {user input here, for example: Y} 
Enter length: {3} 
Enter Width: {4} 
Area: {12} 
Perimeter: {14} 
… 
—————————————————————————————————— 
*/
