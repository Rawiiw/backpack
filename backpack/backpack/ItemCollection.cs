using System;
using System.Collections.Generic;
using System.Text;

namespace backpack
{
    public class ItemCollection
    {

        public Dictionary<string, int> Contents = new Dictionary<string, int>();
        public int TV; //такое название потому что total значение 
        public int TW; //и вес

        public void AddItem(Item item, int count)
        {
            if (Contents.ContainsKey(item.Name)) Contents[item.Name] += count;
            else Contents[item.Name] = count;
            TV += count * item.Value;
            TW += count * item.Weight;
        }
        public ItemCollection Copy()
        {
            var itmcol = new ItemCollection();
            itmcol.Contents = new Dictionary<string, int>(this.Contents);
            itmcol.TV = this.TV;
            itmcol.TW = this.TW;
            return itmcol;
        }
    }
    }

