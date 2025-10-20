using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList: IDataStructure
    {
        private int _value;
        public LinkedList? next = null;

        public LinkedList(int value = 0)
        {
            _value = value;
        }

        public void CreateDsFromList(List<int> elementList)
        {
            this._value = elementList[0];
            LinkedList head = this;
            for (int i = 1; i < elementList.Count; i++)
            {  
                LinkedList temp = new LinkedList(elementList[i]);
                head.next = temp;
                head = temp;
            }
        }

        public void PrintDs()
        {
            LinkedList temp = this;
            while (temp != null)
            {
                Console.Write(temp.Value);
                temp = temp.next;
                Console.Write("->");
            }
            Console.WriteLine("null");
        }

        public int Value
        { 
            get 
            { 
                return this._value; 
            } 
        }
    }
}
