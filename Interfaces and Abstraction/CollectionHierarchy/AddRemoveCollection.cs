using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    class AddRemoveCollection :AddCollection, ICustomCollection
    {
        List<string> collection { get; set; } = new List<string>();
        public int Remove()
        {
            collection.Remove(collection.Last());
            return this.collection.Count() - 1;
        }
        public int Add(string item)
        {
            collection.Insert(0,item);
            return 0;
        }
    }
}
