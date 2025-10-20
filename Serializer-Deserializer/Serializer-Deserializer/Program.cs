using DataStructures;
using SerDser;

namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Datastructures
            IDataStructure binarySearchTree = new BinarySearchTree();
            IDataStructure linkedList = new LinkedList();

            // Serializer-Deserializer
            SerDerStrategy serializerDeserializerBst = new SerDerStrategy(new BstSerializer());
            SerDerStrategy serializerDeserializerLl = new SerDerStrategy(new LlSerializer());

            // Variable for holding serialized data.
            byte[] serializedData;

            // Node values as input for data structure creation
            List<int> nodeValues = new List<int> { 7, 8, 3, 4, 9 };
            
            // Create and print newly created structures.
            binarySearchTree.CreateDsFromList(nodeValues);
            linkedList.CreateDsFromList(nodeValues);

            Console.WriteLine("Binary Search Tree...\n");
            binarySearchTree.PrintDs();
            
            Console.WriteLine("Linked List...\n");
            linkedList.PrintDs();

            serializedData = serializerDeserializerBst.Serializer(binarySearchTree);

            // Stores deserialized bytestreams.
            IDataStructure decodedBinarySearchTree = new BinarySearchTree();
            IDataStructure decodedLinkedList = new LinkedList();

            decodedBinarySearchTree = (BinarySearchTree) serializerDeserializerBst.Deserializer(serializedData);

            serializedData = serializerDeserializerLl.Serializer(linkedList);
            decodedLinkedList = (LinkedList) serializerDeserializerLl.Deserializer(serializedData);

            // Print the decoded data to check correctness.
            Console.WriteLine("\nDeserialized Binary Search Tree...\n");
            decodedBinarySearchTree.PrintDs();

            Console.WriteLine("\nDeserialize Linked List...\n");
            decodedLinkedList.PrintDs();
        }
    }
}
