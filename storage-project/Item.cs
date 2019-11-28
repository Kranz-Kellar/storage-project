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
        private int itemCode;
        private string name;
        private int weight;
        private int volume;
        private string supplier;
        private int numberOfRack;
        private DateTime dateOfStartOfStoraging;
        private DateTime dateOfEndOfStoraging;

        public Item(int id, int itemCode, string name, int weight, int volume,
            string supplier, int numberOfRack, DateTime dateOfStartOfStoraging, DateTime dateOfEndOfStoraging)
        {
            this.id = id;
            this.itemCode = itemCode;
            this.name = name;
            this.weight = weight;
            this.volume = volume;
            this.supplier = supplier;
            this.numberOfRack = numberOfRack;
            this.dateOfStartOfStoraging = dateOfStartOfStoraging;
            this.dateOfEndOfStoraging = dateOfEndOfStoraging;
        }

        public int Id { get => id; }
        public int ItemCode { get => itemCode; set => itemCode = value; }
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Volume { get => volume; set => volume = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public int NumberOfRack { get => numberOfRack; set => numberOfRack = value; }
        public DateTime DateOfStartOfStoraging { get => dateOfStartOfStoraging; set => dateOfStartOfStoraging = value; }
        public DateTime DateOfEndOfStoraging { get => dateOfEndOfStoraging; set => dateOfEndOfStoraging = value; }
        
    }
}
