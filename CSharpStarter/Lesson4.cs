using System;

namespace CSharpStarter
{
    /// <summary>
    /// Для всех уроков выполнить одно и то же задание - пройти тест и оценить его. 
    /// </summary>
    public class Lesson4
    {
        // 3. Методы:
        // string MyMethod (int arg)
        // {
        // Console.WriteLine("arg")'
        // return "Hello";
        // }
        // string - тип возвращаемого значения;
        // MyMethod - идентификатор (имя метода);
        // (int arg) - формальные аргументы (формальные параметры);
        // {} - тело метода.

        /// <summary>
        /// Метод, используемый при неверном вводе.
        /// </summary>
        private static void GiveWrongCommand()
        {
            Console.WriteLine("Wrong command, try again");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Please, say 'y' for ready or 'e' for exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                    {
                        var firstQuest = new Quest(question: "command 'string firstQuestion = new Question(...)' create ...", trueAnswer: "exemplar", falseAnswer: "class");
                        firstQuest.SetQuestion(question: "command 'string firstQuestion = new Question(...)' create ...", trueAnswer: "exemplar", falseAnswer: "class");
                        firstQuest.SetAnswer();

                        var secondQuest = new Quest(question: "string MyMethod (int arg) is ...", trueAnswer: "method", falseAnswer: "object");
                        secondQuest.SetQuestion(question: "string MyMethod (int arg) is ...", trueAnswer: "method", falseAnswer: "object");
                        secondQuest.SetAnswer();

                        var thirdQuest = new Quest(question: "class is description of object and object introduce exemplar of this class", trueAnswer: "true", falseAnswer: "false");
                        thirdQuest.SetQuestion(question: "class is description of object and object introduce exemplar of this class", trueAnswer: "true", falseAnswer: "false");
                        thirdQuest.SetAnswer();

                        Quest.GetRating();
                        break;
                    }
                case "e":
                    {
                        Console.WriteLine("well, maybe another day, gl hf!");
                        break;
                    }
                default:
                    {
                        GiveWrongCommand();
                        break;
                    }
            }
        }
    }
}
