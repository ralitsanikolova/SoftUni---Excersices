using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : ICustomCollection
    {
        List<string> collection = new List<string>();

        public int Add(string item)
        {
            collection.Add(item);
            return this.collection.Count() - 1;
        }
        public int Add()
        {
            string elementToAdd = collection.First();
            collection.Add(elementToAdd);
            return 0;
        }
    }
}
