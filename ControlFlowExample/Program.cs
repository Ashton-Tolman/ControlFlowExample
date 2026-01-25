/*Ashton tolman
 * Spring 2026
 * control flow example
 * 
 */
namespace ControlFlowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("Excellent! You got an A.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Good job! You passed.");
            }
            else
            {
                Console.WriteLine("Keep trying! Practice makes perfect.");
            }
            */

            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("It's Monday. Time to start the week!");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday. Keep going!");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday. Halfway there!");
                    break;
                default:
                    Console.WriteLine("It's another day. Make it count!");
                    break;

            }
            Console.Read();
        }
    }
}
