using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace storage_project
{
    public class DatabaseHandler
    {
        static private string databaseFileName = "storage.sqlite";
        static private string connectionString = $"Data Source = {databaseFileName};";

       
        static public void AddRack(Rack rack)
        {
            if(!IsDatabaseExists())
            {
                RestoreDatabase();
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"INSERT INTO Rack (id, MaxWeight, MaxVolume, currentWeight, currentVolume) " +
                    $"VALUES('{rack.Id}', '{rack.GetMaxWeight()}', '{rack.GetMaxVolume()}', '{rack.GetCurrentWeight()}', '{rack.GetCurrentVolume()}')";


                var command = new SQLiteCommand(commandText, connection);
                command.ExecuteNonQuery();
            }
        }

        static public void AddItem(Item item)
        {
            if (!IsDatabaseExists())
            {
                RestoreDatabase();
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"INSERT INTO Item (code, name, weight, volume, supplier, numberOfRack, startOfStorage, endOfStorage) " +
                    $"VALUES('{item.ItemCode}', '{item.Name}', '{item.Weight}', '{item.Volume}', '{item.Supplier}', '{item.NumberOfRack}'," +
                    $" '{item.DateOfStartOfStoraging.ToString()}', '{item.DateOfEndOfStoraging.ToString()}')";

                var command = new SQLiteCommand(commandText, connection);
                command.ExecuteNonQuery();
            }
        }

        static public DataTable GetAllItems()
        {
            return GetAllDataFromTable("Item");
        }

        static public DataTable GetAllRacks()
        {
            return GetAllDataFromTable("Rack");
        }

        static public void UpdateItem(Item item)
        {
            using(var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"UPDATE Item SET code='{item.ItemCode}', name='{item.Name}', weight='{item.Weight}'," +
                                     $" volume='{item.Volume}', supplier='{item.Supplier}', numberOfRack='{item.NumberOfRack}'," +
                                     $" startOfStorage='{item.DateOfStartOfStoraging}', endOfStorage='{item.DateOfEndOfStoraging}'" +
                                     $" WHERE id = {item.Id}";
                var command = new SQLiteCommand(commandText, connection);
                command.ExecuteNonQuery();
            }
        }

        static public void DeleteItem(int itemId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"DELETE FROM Item WHERE id = {itemId}";
                var command = new SQLiteCommand(commandText, connection);
                command.ExecuteNonQuery();
            }
        }

        static public DataTable GetAllItemsOfSupplier(string supplier)
        {
            if (!IsDatabaseExists())
            {
                RestoreDatabase();
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"SELECT * FROM Item where supplier = '{supplier}'";
                var adapter = new SQLiteDataAdapter(commandText, connection);

                using (var dataTable = new DataTable())
                {
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
        }

        static private DataTable GetAllDataFromTable(string tableName)
        {
            if (!IsDatabaseExists())
            {
                RestoreDatabase();
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"SELECT * FROM {tableName}";
                var adapter = new SQLiteDataAdapter(commandText, connection);

                using (var dataTable = new DataTable())
                {
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
        }

        static private bool IsDatabaseExists()
        {
            return File.Exists(databaseFileName);
        }

        static private void RestoreDatabase()
        {
            SQLiteConnection.CreateFile(databaseFileName);
            CreateTables();
            CreateBaseInfo();
        }

        static private void CreateTables()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string rackTableCreationQuery = "CREATE TABLE 'Rack'('id' Integer Primary Key  NOT NULL  ," +
                                                    " 'MaxWeight' Integer  NOT NULL  ," +
                                                    " 'MaxVolume' Integer  NOT NULL  ," +
                                                    " 'currentWeight' Integer  NOT NULL  ," +
                                                    " 'currentVolume' Integer  NOT NULL  )";
                string itemTableCreationQuery = "CREATE TABLE 'Item'('id' Integer Primary Key Autoincrement  NOT NULL  ," +
                                                    " 'code' Integer  NOT NULL  ," +
                                                    " 'name' Text  NOT NULL  ," +
                                                    " 'weight' Integer  NOT NULL  ," +
                                                    " 'volume' Integer  NOT NULL  ," +
                                                    " 'supplier' Text  NOT NULL  ," +
                                                    " 'numberOfRack' Integer  NOT NULL  ," +
                                                    " 'startOfStorage' Text  NOT NULL  ," +
                                                    " 'endOfStorage' Text  NOT NULL  )";

                var command = new SQLiteCommand(rackTableCreationQuery, connection);
                command.ExecuteNonQuery();
                command.CommandText = itemTableCreationQuery;
                command.ExecuteNonQuery();
            }
        }

        static private void CreateBaseInfo()
        {
            for (int i = 1; i <= 10; i++)
            {
                Rack rack = new Rack(i, 1000, 1000, 0, 0);
                AddRack(rack);
            }
        }   
    }
}
