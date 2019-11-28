using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class StorageHandler
    {
        static private List<Rack> racks = new List<Rack>();
        static private int totalWeight = 0;
        static private int totalVolume = 0;

        static public void Init()
        {
            FillRacksFromDataBase();
            FillItemsFromDataBase();
        }

        static private void FillRacksFromDataBase()
        {
            var racksTable = DatabaseHandler.GetAllRacks();
            for (int i = 0; i < racksTable.Rows.Count; i++)
            {
                Rack rack = new Rack(Convert.ToInt32(racksTable.Rows[i]["id"]),
                                     Convert.ToInt32(racksTable.Rows[i]["MaxWeight"]),
                                     Convert.ToInt32(racksTable.Rows[i]["MaxVolume"]),
                                     Convert.ToInt32(racksTable.Rows[i]["currentWeight"]),
                                     Convert.ToInt32(racksTable.Rows[i]["currentVolume"]));
                racks.Add(rack);
            }
        }

        static private void FillItemsFromDataBase()
        {
            var itemsTable = DatabaseHandler.GetAllItems();
            // List<Item> items = new List<Item>();
            for (int i = 0; i < itemsTable.Rows.Count; i++)
            {
                Item item = new Item(Convert.ToInt32(itemsTable.Rows[i]["id"]),
                                     Convert.ToInt32(itemsTable.Rows[i]["code"]),
                                     itemsTable.Rows[i]["name"].ToString(),
                                     Convert.ToInt32(itemsTable.Rows[i]["weight"]),
                                     Convert.ToInt32(itemsTable.Rows[i]["volume"]),
                                     itemsTable.Rows[i]["supplier"].ToString(),
                                     Convert.ToInt32(itemsTable.Rows[i]["numberOfRack"]),
                                     Convert.ToDateTime(itemsTable.Rows[i]["startOfStorage"]),
                                     Convert.ToDateTime(itemsTable.Rows[i]["endOfStorage"]));
                //  items.Add(item);

                racks.FirstOrDefault(x => item.NumberOfRack == x.Id).AddOldItemFromDatabase(item);
            }
        }

        static public void AddRack(Rack rack)
        {
            racks.Add(rack);
            DatabaseHandler.AddRack(rack);
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

        static public DataTable GetAllItemsForDataGridView()
        {
            return DatabaseHandler.GetAllItems();
        }

        static public void UpdateItem(Item item)
        {
            if(item.Id == -1)
            {
                return;
            }
            racks.Find(x => item.NumberOfRack == x.Id).UpdateItem(item);
            //TODO Get item from rack and update it locally
            DatabaseHandler.UpdateItem(item);
        }

        static public void DeleteItem(int itemId)
        {
            if(itemId == -1)
            {
                return;
            }
            var rack = racks.Find(x => x.GetAllItems().Find(y => y.Id == itemId) != null);
            rack.DeleteItemById(itemId);
            DatabaseHandler.DeleteItem(itemId);
        }

        static public List<Item> GetAllItemsForFileWritter()
        {
            var itemsTable = DatabaseHandler.GetAllItems();
            List<Item> items = new List<Item>();
            for (int i = 0; i < itemsTable.Rows.Count; i++)
            {
                Item item = new Item(Convert.ToInt32(itemsTable.Rows[i]["id"]),
                                     Convert.ToInt32(itemsTable.Rows[i]["code"]),
                                     itemsTable.Rows[i]["name"].ToString(),
                                     Convert.ToInt32(itemsTable.Rows[i]["weight"]),
                                     Convert.ToInt32(itemsTable.Rows[i]["volume"]),
                                     itemsTable.Rows[i]["supplier"].ToString(),
                                     Convert.ToInt32(itemsTable.Rows[i]["numberOfRack"]),
                                     Convert.ToDateTime(itemsTable.Rows[i]["startOfStorage"]),
                                     Convert.ToDateTime(itemsTable.Rows[i]["endOfStorage"]));
                  items.Add(item);
            }

            return items;
        }
    }
}
