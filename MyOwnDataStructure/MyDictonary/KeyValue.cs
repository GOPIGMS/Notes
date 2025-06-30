using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDictonary
{
    //creating the key value class to store the key and value in a single object
    public class KeyValue<TKey,TValue>
    {
        public TKey Key {get;set;}
        public TValue Value {get;set;}
        

        
    }
}