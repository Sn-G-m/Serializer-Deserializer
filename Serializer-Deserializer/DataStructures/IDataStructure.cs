using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface IDataStructure
    {
        void CreateDsFromList(List<int> elements);
        void PrintDs();
    }
}
