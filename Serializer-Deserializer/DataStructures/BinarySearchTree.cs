namespace DataStructures
{
    /// <summary>
    /// Class for BST DataStructure Object.
    /// </summary>
    public class BinarySearchTree : IDataStructure
    {
        private int _value;
        public BinarySearchTree? leftNode;
        public BinarySearchTree? rightNode;

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
                if (rightNode != null)
                {
                    rightNode.Insert(value);
                }
                else
                {
                    BinarySearchTree node = new BinarySearchTree();
                    node._value = value;
                    rightNode = node;
                }
            }
            else
            {
                if (leftNode != null)
                {
                    leftNode.Insert(value);
                }
                else
                {
                    BinarySearchTree node = new BinarySearchTree();
                    node._value = value;
                    leftNode = node;
                }
            }
        }

        public int Value
        {
            get { return _value; }
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
            this.PrettyPrint();
        }

        /// <summary>
        /// Pretty printing the binary search tree.
        /// </summary>
        public void PrettyPrint(int padding = 0)
        {
            Console.WriteLine(this._value);

            if (leftNode != null)
            {
                Console.Write(String.Concat(Enumerable.Repeat("-", padding)));
                padding += 5;
                Console.Write("|---");
                leftNode.PrettyPrint(padding);
                padding -= 5;
            }
            else
            {
                Console.Write(String.Concat(Enumerable.Repeat(" ", padding)));
                padding += 5;
                Console.WriteLine("|---null");
                padding -= 5;
            }

            if (rightNode != null)
            {
                Console.Write(String.Concat(Enumerable.Repeat(" ", padding)));
                padding += 5;
                Console.Write("|---");
                rightNode.PrettyPrint(padding);
                padding -= 5;
            }
            else
            {
                Console.Write(String.Concat(Enumerable.Repeat(" ", padding)));
                padding += 5;
                Console.WriteLine("|---null");
                padding -= 5;
            }
        }
    }
}
