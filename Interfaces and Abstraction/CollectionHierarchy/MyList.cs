using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : ICustomCollection
    {
        public int Add()
        {
            throw new NotImplementedException();
        }
        List<string> collection { get; set; } = new List<string>();
        public string Remove()
        {
            string elementToRemove = collection.First();
            collection.Remove(elementToRemove);
            return elementToRemove;
        }
        public int Add(string item)
        {
            collection.Insert(0, item);
            return 0;
        }
        public int AddLast()
        {
            string elementToAdd = collection.Last();
            collection.Add(elementToAdd);
            return 0;
        }
        public string RemoveFirst()
        {
            string elementToRemove = collection.First();
            collection.Remove(elementToRemove);
            return elementToRemove;
        }
        public int Used()
        {
            return collection.Count();
        }
    }
}
