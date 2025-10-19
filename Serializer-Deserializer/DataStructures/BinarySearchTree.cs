namespace DataStructures
{
    /// <summary>
    /// Class for BST DataStructure Object.
    /// </summary>
    public class BinarySearchTree : IDataStructure
    {
        public int _value;
        public BinarySearchTree? _leftNode;
        public BinarySearchTree? _rightNode;

        public BinarySearchTree()
        {
            // empty constructor logic.   
        }

        /// <summary>
        /// Recursivelly inserts new elements based on weights.
        /// Weights here is the numerical value itself.
        /// </summary>
        /// <param name="value"></param>
        private void Insert(int value)
        {
            if (value > _value)
            {
                if (_rightNode != null)
                {
                    _rightNode.Insert(value);
                }
                else
                {
                    BinarySearchTree node = new BinarySearchTree();
                    node._value = value;
                    _rightNode = node;
                }
            }
            else
            {
                if (_leftNode != null)
                {
                    _leftNode.Insert(value);
                }
                else
                {
                    BinarySearchTree node = new BinarySearchTree();
                    node._value = value;
                    _leftNode = node;
                }
            }
        }

        public void CreateDsFromList(List<int> elementList)
        {
            _value = elementList[0];
            for (int i = 1; i < elementList.Count; i++)
            {
                this.Insert(elementList[i]);
            }
        }

        public void PrintDs()
        {
            Console.WriteLine(_value);
            _leftNode?.PrintDs();
            _rightNode?.PrintDs();
        }
    }
}
