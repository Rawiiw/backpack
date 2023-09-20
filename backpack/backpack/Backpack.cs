using System;
using System.IO;
using System.Collections.Generic;
//значение добавления меньшего количества, которое подходит, или доступного количества каждого элемента

namespace backpack
{

    class Backpack
    { 
        static void Main()
        {
      var items = new List<Item>() //список предметов
      {
      new Item("Яблоко", 76, 88, 9),
      new Item("Телефон", 27, 60, 7),
      new Item("Спрей от горла", 52, 10, 4),
      new Item("Ноутбук", 30, 100, 67),
      new Item("Книга", 32, 30, 12),
      new Item("Молоко", 23, 30, 3),
      new Item("Шоколадка", 15, 60, 4),
      new Item("Плеер", 13, 35, 7),
      new Item("Футболка", 48, 10, 6),
      new Item("Кот", 9, 150, 8),
      new Item("Наушники", 22, 80, 8),
    };
            int capacity = 1000;

            //операции нужные для присваивания определенному прдмету колекции
            //ценность в рюкзаке последством добавления меньшего количества, которое подходит, или доступного количества каждого элемента

            ItemCollection[] itmcol = new ItemCollection[capacity + 1]; //создание экземпляра класса 

            for (int i = 0; i <= capacity; i++) 
            itmcol[i] = new ItemCollection(); //ищем меньшее количество

            for (int i = 0; i < items.Count; i++)
                for (int j = capacity; j >= 0; j--) //условие для вместимости рюкзачка и проверка на вместимость
                    if (j >= items[i].Weight) 
                    {
                        int count = Math.Min(items[i].Count, j / items[i].Weight);
                        for (int k = 1; k <= count; k++)
                        {
                            ItemCollection lowerCollection = itmcol[j - k * items[i].Weight]; 
                            int tmpValue = lowerCollection.TV + k * items[i].Value; //промежуточное наименьшее значение
                            if (tmpValue > itmcol[j].TV)
                            {
                                (itmcol[j] = lowerCollection.Copy()).AddItem(items[i], k);
                            }
                        }
                    }

            Console.WriteLine("Вместимость рюкзака: " 
                + capacity + " Заполненный вес: "
                + itmcol[capacity].TW
                + " Заполненное значение: "
                + itmcol[capacity].TV + "Предметики в рюкзаке:");

            foreach (KeyValuePair<string, int> itm in itmcol[capacity].Contents)
            Console.WriteLine(itm.Key + " (" + itm.Value + ")"); //выводит содержимое в строки, а также количество каждого предмета
            //ощзощзоозозозщозозщ
        }

    }
}
