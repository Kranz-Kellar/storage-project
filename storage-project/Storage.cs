using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class Storage
    {
        private List<Item> items;
        private List<Supplier> suppliers;
        private int maxWeight;
        private int currentWeight;
        private int maxVolume;
        private int currentVolume;

        public Storage(int maxWeight, int maxVolume)
        {
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
            this.currentWeight = 0;
            this.currentVolume = 0;
            this.items = new List<Item>();
            this.suppliers = new List<Supplier>();
        }

        public int GetMaxWeight() => maxWeight;
        public int GetMaxVolume() => maxVolume;
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
            return $"Товар {item.Name} успешно добавлен на склад.";
        }

        public string AddNewSupplier(Supplier supplier)
        {
            this.suppliers.Add(supplier);
            return $"Поставщик {supplier.Name} успешно добавлен.";
        }

        public List<Item> GetItemsBySupplier(Supplier supplier)
        {
            return this.items.FindAll(x => supplier == x.Supplier);
        }

        public Item GetItemById(int id)
        {
            return this.items.Find(x => id == x.Id);
        }
    }
}
