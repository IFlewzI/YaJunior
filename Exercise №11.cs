using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isStringCorrect = true;
            string parentheses = "(()(()))";
            int currentDepth = 0;
            int maxDepth = 0;

            foreach (char symbol in parentheses)
            {
                if (symbol == '(')
                    currentDepth++;
                else if (symbol == ')')
                    currentDepth--;

                if (currentDepth < 0)
                {
                    isStringCorrect = false;
                    break;
                }

                if (currentDepth > maxDepth)
                    maxDepth = currentDepth;
            }

            if (currentDepth != 0)
                isStringCorrect = false;

            if (isStringCorrect)
                Console.WriteLine("Строка является корректным скобочным выражением, а максимум глубины составляет {0}", maxDepth);
            else
                Console.WriteLine("Строка НЕ является корректным скобочным выражением");
        }
    }
}
