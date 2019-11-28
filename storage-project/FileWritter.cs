using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class FileWritter
    {
        private static string fileName = "ResultFileFromStorage.txt";
        static public void WriteItemsToFile(List<Item> items)
        {
            WriteHeader();
            foreach(var item in items)
            {
                WriteItemToFile(item);
            }
        }
        static private void WriteItemToFile(Item item)
        {
            string text = $"Id: {item.Id}, Код товара: {item.ItemCode}, Наименование товара: {item.Name}," +
                $" Вес товара: {item.Weight}, Объём товара: {item.Volume}," +
                $" Поставщик: {item.Supplier}, Номер стеллажа: {item.NumberOfRack}," +
                $" Дата начала хранения: {item.DateOfStartOfStoraging}, Дата конца хранения: {item.DateOfEndOfStoraging} {Environment.NewLine}";
            File.AppendAllText(fileName, text);
        }
        
        static private void WriteHeader()
        {
            string header = $"========================================================================== { Environment.NewLine}" +
                            $"Выгрузка от {DateTime.Now} {Environment.NewLine}" +
                            $"========================================================================== {Environment.NewLine}" +
                            $"Общий вес товара на складе {StorageHandler.GetTotalWeight()} килограммов {Environment.NewLine}" +
                            $"Общий объём товара на складе {StorageHandler.GetTotalVolume()} кубических сантиметров {Environment.NewLine}" +
                            $"========================================================================== { Environment.NewLine}";
            File.AppendAllText(fileName, header);
        }
    }
}
