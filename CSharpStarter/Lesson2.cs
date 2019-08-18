using System;

namespace CSharpStarter
{
    /// <summary>
    /// Для всех уроков выполнить одно и то же задание - пройти тест и оценить его. 
    /// </summary>
    class Lesson2
    {
        // 2. Циклические конструкции:
        // Оператор безусловного перехода goto.
        // Цикл с предусловием do-while.
        // Цикл со счетчиком for.
        static void Main2(string[] args)
        {
            byte counter = 0;
            Console.WriteLine("Hello User! Please, say 'y' for ready or 'e' for exit");
            string input = Console.ReadLine();
            if (input == "y")  // Условный оператор.
            {
                Console.WriteLine("1 Question: what constructon is one-way transfer?");
                Console.Write("Answer: ");
                string answer = Console.ReadLine();
                if (answer == "goto") // Условный оператор.
                {
                    ++counter;
                    goto Label; // Оператор безусловного перехода.
                }
                else
                {
                    goto Label; // Оператор безусловного перехода.
                }

            Label: Console.WriteLine("2 Question: which cycle is preconditioned loop?");
                Console.WriteLine("1. goto");
                Console.WriteLine("2. do-while");
                Console.WriteLine("3. for");
                Console.Write("Answer: ");
                string secondanswer = Console.ReadLine();
                while (secondanswer != "2") // Цикл с предусловием.
                {
                    Console.WriteLine("wrong answer");
                    secondanswer = Console.ReadLine();
                }
                ++counter;
                Console.WriteLine("3 Question: which cycle with counter?");
                Console.WriteLine("1. goto");
                Console.WriteLine("2. do-while");
                Console.WriteLine("3. for");
                Console.Write("Answer: ");
                for (int attempt = 0; attempt < 3; attempt++)
                {
                    string thirdanswer = Console.ReadLine();
                    if (thirdanswer == "3")
                    {
                        attempt = 3;
                    }
                }
                ++counter;

                Console.WriteLine("Rating {0}/3", counter);
            }
            else
            {
                Console.WriteLine("end");
            }
        }
    }
}
