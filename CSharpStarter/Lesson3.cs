using System;

namespace CSharpStarter
{
    /// <summary>
    /// Для всех уроков выполнить одно и то же задание - пройти тест и оценить его. 
    /// </summary>
    class Lesson3
    {
        // 3. Массивы:
        // byte[,,] array = new byte[3,3,3]; 
        // byte - тип элементов массива, 
        // [] - указывают что переменная array типа byte является массивом, 
        // new byte - выражение создания массива, 
        // [3] - количество элементов массива.
        // Способы создания массива:
        // byte [] array = new byte[3];
        // byte [] array = new byte[3] {1, 2, 3};
        // byte [] array = new byte [] {1, 2 ,3};
        // byte [] array = {1, 2, 3}.
        static void Main3(string[] args)
        {
            byte[] counter = new byte[3] { 1, 2, 3 };
            Console.WriteLine("Hello User! Please, say 'y' for ready or 'e' for exit");
            string input = Console.ReadLine();
            if (input == "y")  // Условный оператор.
            {
                Console.WriteLine("1 Question: which variant of array wrong? ");
                Console.WriteLine("1. byte [] array = new byte [3]");
                Console.WriteLine("2. byte [] array = new byte [] {1, 2, 3}");
                Console.WriteLine("3. byte [] array = new byte {1, 2, 3}");
                Console.Write("Answer: ");
                string firstanswer = Console.ReadLine();

                Console.WriteLine("2 Question: which of array is jagged?");
                Console.WriteLine("1. byte [] array = new byte [3]");
                Console.WriteLine("2. byte [][] array = new byte [3][]");
                Console.WriteLine("3. byte [,,] array = new byte [3,3,3]");
                Console.Write("Answer: ");
                string secondanswer = Console.ReadLine();

                Console.WriteLine("3 Question: This code is bad?");
                Console.WriteLine("1. No, is dastishfantastish");
                Console.WriteLine("2. No, im idiot");
                Console.WriteLine("3. yes , its govnocode");
                Console.Write("Answer: ");
                string thirdanswer = Console.ReadLine();

                if ((firstanswer == "3") && (secondanswer == "2") && (thirdanswer == "3"));
                {
                    Console.WriteLine("You done it! Rating {0}/3", counter[2]);
                }
            
            }
            else
            {
                Console.WriteLine("end");
            }
        }
    }
}
