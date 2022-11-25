using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class MyList<T>
    {
        private T[] numbers = new T[5];
        
        public T this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }


        public void Add(int num)
        {
           
        }

        public void Clear(int num)
        {

        }
        public void AddRange(int num)
        {

        }
        public void Find(int num)
        {

        }
        public void FindAll(int num)
        {

        }
    }
}
   

 


