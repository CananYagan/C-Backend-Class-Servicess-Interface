using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //constructor
        T[] items;
        public MyList()
        {
            items = new T[0];   //T string
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];  //Diziye artı 1 eleman ekler
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
