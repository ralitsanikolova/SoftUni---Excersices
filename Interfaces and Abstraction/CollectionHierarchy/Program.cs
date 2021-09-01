using System;

namespace CollectionHierarchy
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddCollection AddCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string itemInput = Console.ReadLine();
            string[] collection = itemInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in collection)
            {
                int addIndex = AddCollection.Add(item);
                Console.Write(addIndex + "");
            }

            Console.WriteLine();

            foreach (string item in collection)
            {
                int addRemoveCollectionIndex = addRemoveCollection.Add(item);
                Console.Write(addRemoveCollectionIndex + "");
            }
            Console.WriteLine();

            foreach (string item in collection)
            {
                int addMyListIndex = myList.Add(item);
                Console.Write(addMyListIndex + "");
            }

            Console.WriteLine();

            foreach (string item in collection)
            {
                for (int i = 0; i < addRemoveCollection.Remove(); i++)
                {
                    string removeItem = myList.Remove();
                    Console.Write(removeItem + " ");
                }
            }

            Console.WriteLine();

            for(int i =0; i <= myList.Used(); i++)
            {
                int allRemovedItems = myList.Used();
                Console.WriteLine(allRemovedItems + " ");
            }
        }
    }
}
