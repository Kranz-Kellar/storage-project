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

        static public string AddItemOnRack(int rackId, Item item)
        {
            if (IsRackExists(rackId))
            {
                return racks.Find(x => rackId == x.Id).AddNewItem(item);
            }
            return $"Полка с указанным номером ({rackId}) не найдена";
        }

        static public List<Item> GetItemsOfRack(int rackId)
        {
            return racks.Find(x => rackId == x.Id).GetAllItems();
        }

        static private bool IsRackExists(int rackId)
        {
            if(racks.Find(x => rackId == x.Id) == null)
            {
                return false;
            }
            return true;
        }

        static public int GetTotalWeight()
        {
            racks.ForEach(x => totalWeight += x.GetCurrentWeight());
            return totalWeight;
        }

        static public int GetTotalVolume()
        {
            racks.ForEach(x => totalVolume += x.GetCurrentVolume());
            return totalVolume;
        }
    }
}
