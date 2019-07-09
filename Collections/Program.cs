using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Collections");

            // a collection is used to group related objects. unlike array it is dynamic. 
            // they can grow and shrink to accomodate any numbero of objects 
            // Collection classes are organized in namespaces with methods to process elements 
            // within the collection

            //different kinds of collections are suited to different kind of applications
            // tipically a collection includes Add Remove and Count Methods

            //to use a collention (which, remember, is a class) we must instanciate it

            List<int> li = new List<int>();

            //Generic collections are preferred as long as every element is of the same type
            //System.Collections.Generic namespace includes the following:
            List<T>;
            Dictionary<TKey, TValue>;
            SortedList<Tkey, TValue>;
            Stack<T>;
            Queue<T>;
            HashSet<T>;

            //Non Generic collections can store items of type Object
            //System.Collections namespace includes the following:
            /*
            ArrayList
            SortedList
            Stack
            Queue
            HashTable
            BitArray
            */
            //NonGeneric Collections are more error prone and slower in execution. Use Generic Ones if you can




            Console.ReadKey();

        }
    }
}
