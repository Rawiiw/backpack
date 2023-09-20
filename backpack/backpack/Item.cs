using System;
using System.Collections.Generic;
using System.Text;

namespace backpack
{
   public class Item //класс где хранятся наши характеристики для предметов
    {
            public string Name;
            public int Weight;
            public int Value;
            public int Count;

            public Item(string name, int weight, int value, int count)
            {
                Name = name;
                Weight = weight;
                Value = value;
                Count = count;
            }

        }
    }
