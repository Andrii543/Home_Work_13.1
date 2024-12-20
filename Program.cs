using System.Text;

namespace Home_Work_13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            List<ToDoItem> list = new List<ToDoItem>();

            while (true)
            {
                Console.WriteLine("Оберіть операцію:\n");

                Console.WriteLine("1 - Додати справу");
                Console.WriteLine("2 - Вивести всі справи");
                Console.WriteLine("3 - Позначити справу як виконану");
                Console.WriteLine("4 - Видалити справу");
                Console.WriteLine("5 - Вихід\n");

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        ToDoItem.AddItem(list);
                        break;
                    case "2":
                        ToDoItem.DisplayItem(list);
                        break;
                    case "3":
                        ToDoItem.MarkCompilted(list);
                        break;
                    case "4":
                        ToDoItem.RemoveItem(list);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Вибрана не правельна операція");
                        break;
                }
            }
        }
    }
}
