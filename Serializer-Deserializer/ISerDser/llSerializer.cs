using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerDser
{
    public class LlSerializer: ISerDser
    {
        public byte[] Serializer(object linkedList)
        {
            LinkedList list = (LinkedList) linkedList;
            List<int> elementList = new List<int>();
            byte[] byteStream;

            while (list != null)
            {
                elementList.Add(list.Value);
                list = list.next;
            }

            // Flatten and convert elementList to a byteStream
            // Resource: https://stackoverflow.com/questions/3097812/converting-a-list-of-ints-to-a-byte-array
            byteStream = elementList.SelectMany(BitConverter.GetBytes).ToArray();

            return byteStream;
        }

        public object Deserializer(byte[] byteStream)
        {
            LinkedList originalLl = new LinkedList();

            List<int> elementList = new List<int>();

            for (int i = 0; i < byteStream.Length; i += sizeof(int))
            {
                // Resource: https://stackoverflow.com/questions/21312240/read-specific-bytes-out-of-byte-array-c-sharp
                byte[] currentByteSlice = new byte[sizeof(int)];
                Array.Copy(byteStream, i, currentByteSlice, 0, sizeof(int));

                // Convert to int
                int currentVal = BitConverter.ToInt32(currentByteSlice, 0);

                // Add to the list
                elementList.Add(currentVal);

                // Clear the byte slice for next iteration.
                Array.Clear(currentByteSlice, 0, currentByteSlice.Length);
            }

            originalLl.CreateDsFromList(elementList);

            return originalLl;
        }
    }
}
