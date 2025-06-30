using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace OnlineTheatreTicketBooking
{
    /// <summary>
    /// Custom created Dictonary and its methods <see cref=" MyDictionary<TKey, TValue> "/>
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class MyDictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        //creating the private count field to count the elements in the array
        private int _count = 0;
        //creating the private capacity field to count the set the maximum elments store in the array
        private int _capacity = 0;
        //creating the getter Property count to get the count value 
        public int Count
        {
            get
            {
                return _count;
            }
        }
        //creating the capacity property to get the capacity of the array
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }
        //creating a keyvalue array to create the object which stores the keys and the values
        private KeyValue<TKey, TValue>[] _array;
        //creating the indexer to get and set the values in the array
        public TValue this[TKey key]
        {
            get
            {
                TValue value = default(TValue);
                LinearSearch(key, out value);
                return value;
            }
            set
            {
                int position = LinearSearch(key, out TValue value2);
                if (position > -1)
                {
                    _array[position].Value = value;
                }
            }
        }
        //Creating the default constructor and initializing the instance with the default value
        public MyDictionary()
        {
            _count = 0;
            _capacity = 4;
            _array = new KeyValue<TKey, TValue>[_capacity];
        }
        //creating the parameterized constructor and initiating the instance with the value that the user give
        public MyDictionary(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new KeyValue<TKey, TValue>[_capacity];
        }
        // adding the values in the dictonary  using the key value object
        public void Add(TKey key, TValue value)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            int searchResult = LinearSearch(key, out TValue value2);
            if (searchResult == -1)
            {
                KeyValue<TKey, TValue> data = new KeyValue<TKey, TValue>();
                data.Key = key;
                data.Value = value;
                _array[_count] = data;
                _count++;
            }
            else
            {
                _array[searchResult].Value = value;
            }
        }
        //growing the size of the array based on the count and capacity
        void GrowSize()
        {
            _capacity = _capacity * 2;
            KeyValue<TKey, TValue>[] temp = new KeyValue<TKey, TValue>[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        //Getting all the keys
        public TKey[] Keys()
        {
            TKey[] temp = new TKey[Count];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = _array[i].Key;
            }
            return temp;
        }
        //getting all the values
        public TValue[] Values(){
            TValue[] temp =new TValue[Count];
            for (int i=0; i<Count;i++){
                temp[i] =_array[i].Value;
            }
            return temp;
        }
        // searching the value and if present return the index and value
        int LinearSearch(TKey key, out TValue value)
        {
            int position = -1;
            value = default(TValue);
            for (int i = 0; i < _count; i++)
            {
                if (key.Equals(_array[i].Key))
                {
                    position = i;
                    value = _array[i].Value;
                    break;
                }
            }
            return position;
        }
        //setting the property for the GetEm=numerator class
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        // moving to next object using movenext method
        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        // reseting the index position 
        public void Reset()
        {
            position = -1;
        }
        //getting the current iterating value
        public object Current
        {
            get { return _array[position]; }
        }
    }
}