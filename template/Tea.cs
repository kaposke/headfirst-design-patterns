using System;

namespace template
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override bool UserWantsCondiments()
        {
            string answer = GetUserInput();
            return answer.ToLower().StartsWith("y");
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like to add lemon? (y/n)");
            string answer = Console.ReadLine();
            return answer;
        }
    }
}