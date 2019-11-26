using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class Item
    {
        private int id;
        private string name;
        private int amount;
        private int weight;
        private int volume;
        private Supplier supplier;

        public Item(int id, string name, int amount, int weight, int volume)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.weight = weight;
            this.volume = volume;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Volume { get => volume; set => volume = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
    }
}
