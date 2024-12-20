namespace Home_Work_13._1
{
    public class ToDoItem
    {

        public string Item { get; set; }

        public bool IsCompleted { get; set; }

        public ToDoItem(string item)
        {
            Item = item;
            IsCompleted = false;
        }


        public string ToString()
        {
            return Item;
        }

        public static void AddItem(List<ToDoItem> list)
        {
            Console.Write("Введіть назву справи:");
            string inputTitle = Console.ReadLine();
            list.Add(new ToDoItem(inputTitle));
            Console.WriteLine("Справу додано!");
        }

        public static void RemoveItem(List<ToDoItem> list)
        {
            DisplayItem(list);
            if (list.Count > 0)
            {
                return;
            }
            Console.WriteLine("Введіть номнер справи для видалення: ");
            if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= list.Count)
            {
                list.RemoveAt(input - 1);
                Console.WriteLine("Cправу видалено!");
            }
            else
            {
                Console.WriteLine("Невірний вибір справи");
            }
        }

        public static void DisplayItem(List<ToDoItem> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Список срав порожній");
            }
            else
            {
                Console.WriteLine("Cписок справ:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{list[i].ToString()}");
                }
            }
        }

        public static void MarkCompilted(List<ToDoItem> list)
        {
            DisplayItem(list);
            if (list.Count == 0)
            {
                return;
            }

            Console.WriteLine("Введіть номер справи яку хочете завершити");
            if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= list.Count)
            {
                list[input - 1].IsCompleted = true;
                Console.WriteLine("Справу позначено як завершину!");
            }
            else
            {
                Console.WriteLine("Невірний вибір справи");
            }
        }
    }
}
