using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStarter
{
    /// <summary>
    /// Класс, формирующий вопрос.
    /// </summary>
    public class Quest
    {
        /// <summary>
        /// Поле "содержание вопроса".
        /// </summary>
        private string Question { get; set; }

        /// <summary>
        /// Поле "правильный ответ".
        /// </summary>
        private string TrueAnswer { get; set; }

        /// <summary>
        /// Поле "ложный ответ."
        /// </summary>
        private string FalseAnswer { get; set; }

        /// <summary>
        /// Поле "ответ пользователя".
        /// </summary>
        private string Answer { get; set; }

        /// <summary>
        /// Оценка за ответ.
        /// </summary>
        private static byte rating = 0;

        /// <summary>
        /// Метод-аксессор для получения оценки за тест (getter).
        /// </summary>
        /// <returns></returns>
        public static byte GetRating()
        {
            Console.WriteLine("Rating {0}/3", rating);
            return rating;
        }

        /// <summary>
        /// Инициализация объекта "Вопрос".
        /// </summary>
        /// <param name="question"> Инициализация поля "содержание вопроса"</param>
        /// <param name="trueAnswer"> инициализация поля "правильный ответ"</param>
        /// <param name="falseAnswer"> Инициализация поля "ложный ответ"</param>
        public Quest(string question, string trueAnswer, string falseAnswer)
        {
            this.Question = question;
            this.TrueAnswer = trueAnswer;
            this.FalseAnswer = falseAnswer;
        }
        /// <summary>
        /// Метод-мутатор, получающий ответ пользователя (setter).
        /// </summary>
        /// 
        public void SetAnswer()
        {
        Label:
            this.Answer = Console.ReadLine();
            if (this.Answer == this.TrueAnswer)
            { rating++; }
            else if (this.Answer == this.FalseAnswer) { }
            else
            {
                Console.WriteLine("Wrong Command, pleasy try again");
                goto Label;
            }
        }
        /// <summary>
        /// Метод-мутатор и аксессор, получающий значения переменных question, trueAnswer и falseAnswer из Lesson4, и выдающий данные поля обратно.
        /// </summary>
        public void SetQuestion(string question, string trueAnswer, string falseAnswer)
        {
            this.Question = question;
            this.TrueAnswer = trueAnswer;
            this.FalseAnswer = falseAnswer;
            Console.WriteLine(Question);
            Console.WriteLine($"1. {TrueAnswer}");
            Console.WriteLine($"2. {FalseAnswer}");
        }
    }
}
