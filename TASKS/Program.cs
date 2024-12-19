using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person client = new Person("Павел Дуров","папа телеграмма и не только");
            Person teamlead = new Person("Екатерина B", "тимлид");
            Person developer1 = new Person("Кирилл", "разработчик");
            Person developer2 = new Person("Аня", "разработчица");
            Person tester1 = new Person("Алексей", "тестировщик");
            Person tester2 = new Person("Полина", "тестрировщица");
            Person designer1 = new Person("Нурсултан", "проектировщик");
            Person designer2 = new Person("Весна", "проектировщица");
            Person developer3 = new Person("Семен", "разработчик");
            Person developer4 = new Person("Катерина", "разработчица");
            Person tester3 = new Person("Данил", "тестировщица");
            Person tester4 = new Person("Иван", "тестировщик");

            Project Telegram = new Project("Создать новые никому ненужные функции для телеграма премиум", client,teamlead);
            Telegram.SetDeadLine(DateTime.Now.AddMonths(6));

            Telegram.AddTask("Разработать новые стикеры с обезьянами", developer1);
            Telegram.AddTask("Разработать", developer2);
            Telegram.AddTask("Провести НТ", tester1);
            Telegram.AddTask("Помочь провести НТ", tester2);
            Telegram.AddTask("Ну сделать что-нибудь", designer2);
            Telegram.AddTask("Сделать всю работу", designer1);
            Telegram.AddTask("Разработать новые стикеры с котиками", developer3);
            Telegram.AddTask("Разработать новые функции", developer4);
            Telegram.AddTask("Тестировать", tester3);
            Telegram.AddTask("Плакать", tester4);

            Telegram.StartProject();
        }
    }
}
