using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class StorageHandler
    {
        static private List<Rack> racks = new List<Rack>();
        static private int totalWeight;
        static private int totalVolume;

        static public void AddRack(Rack rack)
        {
            racks.Add(rack);
        }

        static public void AddItemOnRack(int rackId, Item item)
        {
            racks.Find(x => rackId == x.Id).AddNewItem(item);
        }

        static public List<Item> GetItemsOfRack(int rackId)
        {
            return racks.Find(x => rackId == x.Id).GetAllItems();
        }
    }
}
