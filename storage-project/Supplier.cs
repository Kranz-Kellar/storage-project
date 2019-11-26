using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storage_project
{
    public class Supplier
    {
        private int uniqueId;
        private string name;
        private string address;
        private string telephone;

        public Supplier(int uniqueId, string name, string address, string telephone)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.address = address;
            this.telephone = telephone;
        }

        public int UniqueId { get => uniqueId; set => uniqueId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
    }
}
