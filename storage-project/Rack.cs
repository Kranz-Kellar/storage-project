using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class Rack
    {
        private int id;
        private List<Item> items;
        private int maxWeight;
        private int currentWeight;
        private int maxVolume;
        private int currentVolume;

        public int Id { get => id; set => id = value; }

        public Rack(int id, int maxWeight, int maxVolume, int currentWeight, int currentVolume)
        {
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
            this.currentWeight = 0;
            this.currentVolume = 0;
            this.items = new List<Item>();
            this.id = id;
            this.currentWeight = currentWeight;
            this.currentVolume = currentVolume;
        }

        public int GetMaxWeight() => maxWeight;
        public int GetMaxVolume() => maxVolume;
        public int GetCurrentWeight() => currentWeight;
        public int GetCurrentVolume() => currentVolume;
        public void SetMaxWeight(int newMaxWeight) => maxWeight = newMaxWeight;
        public void SetMaxVolume(int newMaxVolume) => maxVolume = newMaxVolume;

        public string AddNewItem(Item item)
        {
            int newWeight = currentWeight + item.Weight;
            int newVolume = currentVolume + item.Volume;
            if(newWeight > maxWeight)
            {
                return $"Товар {item.Name} слишком тяжёлый! Максимальный вес превышен на {newWeight - maxWeight} киллограммов.";
            }

            if(newVolume > maxVolume)
            {
                return $"Товар {item.Name} слишком большой! Максимальный объём превышен на {newVolume - maxVolume} кубических сантиметров.";
            }

            this.items.Add(item);
            this.currentWeight = newWeight;
            this.currentVolume = newVolume;
            DatabaseHandler.AddItem(item);
            return $"Товар {item.Name} успешно добавлен на склад.";
        }

        public void AddOldItemFromDatabase(Item item)
        {
            int newWeight = currentWeight + item.Weight;
            int newVolume = currentVolume + item.Volume;
            this.items.Add(item);
            this.currentWeight = newWeight;
            this.currentVolume = newVolume;
        }

        public List<Item> GetItemsBySupplier(string supplier)
        {
            return this.items.FindAll(x => supplier == x.Supplier);
        }

        public Item GetItemById(int id)
        {
            return this.items.Find(x => id == x.ItemCode);
        }

        public void DeleteItemById(int id)
        {
            items.RemoveAll(x => x.Id == id);
        }

        public void UpdateItem(Item item)
        {

            items[items.FindIndex(x => x.Id == item.Id)] = item;
        }

        public List<Item> GetAllItems() => items;
    }
}
