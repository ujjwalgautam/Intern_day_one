

namespace Internship
{
    public class Day_One
    {
        /// <summary>
        /// Create a function that takes two numbers as arguments and returns their sum
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <example>
        /// Sum(3, 2) ➞ 5
        /// Sum(-3, -6) ➞ -9
        /// Sum(7, 3) ➞ 10
        /// </example>
        public void sum(int n1,int n2)
        {
            Console.WriteLine($"the sum of {n1} and {n2} is {n1+n2}");
        }
        /// <summary>
        /// Write a function that takes an integer minutes and converts it to seconds.
        /// </summary>
        /// <param name="min"></param>
        /// <example>
        /// convert(5) ➞ 300
        /// </example>
        public void Min_Sec(int min)
        {
            Console.WriteLine($"{min} minutes  = {min*60} seconds");
        }
        /// <summary>
        /// Create a function that takes a number as an argument, increments the number by +1 and returns the result.
        /// </summary>
        /// <param name="num"></param>
        /// <example>
        /// Addition(0) ➞ 1
        /// </example>
        public void Next_Num(int num)
        {
            Console.WriteLine($" next number to {num} is {++num}");
        }
        /// <summary>
        /// Create a function that takes voltage and current and returns the calculated power
        /// </summary>
        /// <param name="voltage"></param>
        /// <param name="current"></param>
        /// <example>
        /// CircuitPower(230, 10) ➞ 2300
        /// </example>
        public void Power_Calculator(int voltage,int current)
        {
            Console.WriteLine($"Power with {voltage} volatage and {current} current is {voltage*current}");
        }
        /// <summary>
        /// Create a function that takes the age in years and returns the age in days.
        /// </summary>
        /// <param name="age"></param>
        /// <example>
        /// CalcAge(65) ➞ 23725
        /// </example>
        public void Age_to_days(int age)
        {
            Console.WriteLine($"{age} age = {age*365} days");
        }
        /// <summary>
        /// Write a function that takes the base and height of a triangle and return its area.
        /// </summary>
        /// <param name="basee"></param>
        /// <param name="height"></param>
        /// <example>
        /// triArea(10, 10) ➞ 50
        /// </example>
        public void Traingle_Area(int basee,int height)
        {
            Console.WriteLine($"base={basee} height={height} and area={basee * height / 2}");
        }
        /// <summary>
        /// There is a single operator in C#, capable of providing the remainder of a 
        /// division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <example>
        /// Remainder(-9, 45) ➞ -9
        /// </example>
        public void Remainder(int num1, int num2)
        {
            Console.WriteLine($"when {num1} divides by {num2} is {num1 % num2}");
        }
        /// <summary>
        /// Create a function that takes a number as its only argument and returns true if it's 
        /// less than or equal to zero, otherwise return false.
        /// </summary>
        /// <param name="num1"></param>
        /// <example>
        /// lessThanOrEqualToZero(-2) ➞ true
        /// </example>
        public void lessThanOrEqualToZero(int num1)
        {
            if (num1 < 0)   
                Console.WriteLine($"{num1} is less than or equal to zero");
            else
                Console.WriteLine($"{num1} is greater than zero");
        }
        /// <summary>
        /// Write a function that returns the string "something" joined with a space " " and 
        /// the given argument a
        /// </summary>
        /// <param name="str1"></param>
        public void GiveMeSomething(string str1)
        {
            Console.WriteLine($" something {str1}");        
        }

        public void ReverseBool(bool b1)
        {
            Console.WriteLine($" reverse of {b1} is {!b1}");
        }
        /// <summary>
        /// Given an n-sided regular polygon n,
        /// return the total sum of internal angles (in degrees).
        /// </summary>
        /// <param name="sides"></param>
        /// <example>
        /// SumPolygon(6) ➞ 720
        /// </example>
        public void SumOfAngles(int sides)
        {
            Console.WriteLine($"Sum of internal angles of polygon of sides {sides} is {(sides - 2) * 180}");
        }
        /// <summary>
        /// Christmas Eve is almost upon us, so naturally we need to prepare some
        /// milk and cookies for Santa! Create a function that accepts year, month 
        /// and day as integers and returns true if it's Christmas Eve 
        /// (December 24th) and false otherwise
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        /// <example>
        /// Date( 2013, 12, 24 )
        /// </example>
        public bool IsChristmas(int year, int month, int date)
        {
            if (month == 12 && date == 24)
                return true;
            else
                return false;
        }
        /// <summary>
        /// You are counting points for a basketball game, given the amount 
        /// of 3-pointers scored and 2-pointers scored, find the final points for 
        /// the team and return that value ([2 -pointers scored, 3-pointers scored])
        /// </summary>
        /// <param name="TwoPoints"></param>
        /// <param name="ThreePoints"></param>
        /// <example>
        /// points(38, 8) ➞ 100
        /// </example>
        public void BasketballPoints(int TwoPoints,int ThreePoints)
        {
            Console.WriteLine($"Two Points= {TwoPoints}  Three Points={ThreePoints}  Total Points={ThreePoints * 3 + TwoPoints * 2}");
        }
        /// <summary>
        /// In this challenge, a farmer is asking you to tell him how many legs can be 
        /// counted among all his animals. The farmer breeds three species:

        ///chickens = 2 legs
        ///cows = 4 legs
        ///pigs = 4 legs
        ///The farmer has counted his animals and he gives you a subtotal for each 
        ///species.You have to implement a function that returns the total number of 
        ///legs of all the animals.
        /// </summary>
        /// <param name="chi"></param>
        /// <param name="cow"></param>
        /// <param name="pig"></param>
        /// <example>
        /// animals(5, 2, 8) ➞ 50
        /// </example>
        public void Legs(int chi,int cow, int pig)
        {
            Console.WriteLine($"chicken = {chi} cow= {cow} pig={pig} Total legs= {chi * 2 + cow * 4 + pig * 4}");
        }
        /// <summary>
        /// Create a function that takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.

        ///wins get 3 points
        ///draws get 1 point
        ///losses get 0 points
        /// </summary>
        /// <param name="win"></param>
        /// <param name="draw"></param>
        /// <param name="loose"></param>
        /// <example>
        /// FootballPoints(3, 4, 2) ➞ 13</example>
        public void FootballPoints(int win,int draw,int loose)
        {
            Console.WriteLine($"Total points= {win*3+draw}");
        }
    }
}
