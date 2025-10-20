using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerDser
{
    public class SerDerStrategy
    {
        private ISerDser serDerStrategy;

        public SerDerStrategy(ISerDser serDerStrategy)
        {
            this.serDerStrategy = serDerStrategy;
        }

        public byte[] Serializer(object inputDataStructure)
        {
            return serDerStrategy.Serializer(inputDataStructure);
        }

        public object Deserializer(byte[] inputByteStream)
        {
            return serDerStrategy.Deserializer(inputByteStream);
        }
    }
}
