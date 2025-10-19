using DataStructures;
using SerDser;

namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataStructure binarySearchTree = new BinarySearchTree();
            ISerDser serializerDeserializer = new BstSerializer();

            List<int> nodeValues = new List<int> { 7, 8, 3, 4, 9 };
            
            binarySearchTree.CreateDsFromList(nodeValues);
            binarySearchTree.PrintDs();
        }
    }
}
