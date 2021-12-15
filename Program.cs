using System;

namespace If_Exercises_4U
{
    class Program
    {
        static void Main(string[] args)
        {
            int personOne, personTwo, personThree;
            
            // Input three ages ensuring data validity
            Console.WriteLine("Please enter the age of Person 1:");
            while (!Int32.TryParse(Console.ReadLine(), out personOne) || personOne < 0)
                Console.WriteLine("Please enter a valid age");

            Console.WriteLine();
            Console.WriteLine("Please enter the age of Person 2:");
            while (!Int32.TryParse(Console.ReadLine(), out personTwo) || personOne < 0)
                Console.WriteLine("Please enter a valid age");

            Console.WriteLine();
            Console.WriteLine("Please enter the age of Person 3:");
            while (!Int32.TryParse(Console.ReadLine(), out personThree) || personOne < 0)
                Console.WriteLine("Please enter a valid age");

            // Easy Problems
            Console.WriteLine();
            Console.WriteLine("Easy");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine();
            // Easy 1
            if (personOne > personTwo)
                Console.WriteLine("Person 1 is older than person 2.");
            // Easy 2
            if (personThree < personOne)
                Console.WriteLine("Person 3 is younger than person 1.");
            // Easy 3
            if (personTwo == personThree)
                Console.WriteLine("Person 2 and person 3 are the same age.");

            //Medium Problems
            Console.WriteLine();
            Console.WriteLine("Medium");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine();

            // Medium 1
            if (personTwo < personOne && personTwo < personThree)
                Console.WriteLine("Peron 2 is the youngest.");
            // Medium 2
            if (personOne > personTwo && personOne>personThree)
                Console.WriteLine("Person 1 is the oldest.");

            // Medium/Hard Problems
            Console.WriteLine();
            Console.WriteLine("Medium/Hard");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine();

            // Medium/Hard 1
            if ((personTwo == personOne || personTwo == personThree) && personTwo != personThree)
                Console.WriteLine("Person 2 is the same age as one other person");

            // Medium/Hard 2
            if (personOne != personTwo && personOne != personThree)
                Console.WriteLine("Person 1 is not the same age as anyone else.");

            // Medium/Hard 3
            if (personOne == personTwo && personOne == personThree)
                Console.WriteLine("Everyone is the same age");

            // Medium/Hard 4
            if (personOne != personTwo && personOne != personThree && personTwo != personThree)
                Console.WriteLine("Everyone is a different age");

            // Super Challenge
            Console.WriteLine();
            Console.WriteLine("Super Challenge");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine();

            // Make sure not all same, and then check for possible matches
            if (!(personOne == personTwo && personOne == personThree) && (personOne == personTwo || personOne == personThree || personTwo == personThree))
                Console.WriteLine("Exactly 2 people are the same age, but not everyone");
        }
    }
}
