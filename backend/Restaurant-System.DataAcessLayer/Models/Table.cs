using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System.DataAcessLayer.Models
{
    public class Table
    {
        public int Id { get; set; }

        public int NumberOfTable { get; set; }

        public int NumberOfSits { get; set; }

        public Table(int numberOfTable, int numberOfSits)
        {
            NumberOfTable = numberOfTable;
            NumberOfSits = numberOfSits;
        }
    }
}
