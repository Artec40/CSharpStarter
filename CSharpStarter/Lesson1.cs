using System;

namespace CSharpStarter
{
    /// <summary>
    /// Для всех уроков выполнить одно и то же задание - пройти тест и оценить его. 
    /// </summary>
    class Lesson1
    {
        // 1. Условные конструкции:
        // if...else
        // ... ? ...: ...
        // switch - case.
        static void Main1(string[] args)
        {
            byte counter = 0;
            Console.WriteLine("Hello User! Please, say 'y' for ready or 'e' for exit");
            string input = Console.ReadLine();
            if (input == "y")  // Условный оператор.
            {
                Console.WriteLine("1 Question: what kind of operator construction if...else?");
                Console.WriteLine("1. Условный оператор");
                Console.WriteLine("2. Оператор многозначного выбора");
                Console.WriteLine("3. Тернарный оператор");
                Console.Write("Answer: ");
                string answer = Console.ReadLine();
                switch (answer) // Оператор многозначного выбора. Выражение-селектор.
                {
                    case "1":
                        {
                            ++counter;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.WriteLine("2 Question: what kind of operator construction is selector expression?");
                Console.WriteLine("1. Условный оператор");
                Console.WriteLine("2. Оператор многозначного выбора");
                Console.WriteLine("3. Тернарный оператор");
                Console.Write("Answer: ");
                answer = Console.ReadLine();
                switch (answer) // Оператор многозначного выбора. Выражение-селектор.
                {
                    case "2":
                        {
                            ++counter;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.WriteLine("3 Question: what kind of operator construction  ... ? ...: ...");
                Console.WriteLine("1. Условный оператор");
                Console.WriteLine("2. Оператор многозначного выбора");
                Console.WriteLine("3. Тернарный оператор");
                Console.Write("Answer: ");
                answer = Console.ReadLine();
                switch (answer) // Оператор многозначного выбора. Выражение-селектор.
                {
                    case "3":
                        {
                            ++counter;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.WriteLine("Rating {0}/3", counter);
            }
            else
            {
                string a = Console.ReadLine(); // Тернарный оператор.
                string b = Console.ReadLine();
                int d = Int32.Parse(a);
                int e = Int32.Parse(b);
                int c = (d > e) ? d : e; // ЕСЛИ (d>e) ТО: вернуть d, иначе: вернуть e.
                Console.WriteLine(c);
            }

        }
    }
}
