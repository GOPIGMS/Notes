using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyQueue
{
    //creating custom queue method and using the IEnumerable,IEnumerator interface for the for loop
    public class CustomQueue<Type> : IEnumerable, IEnumerator
    {
        //private field used to maintain the count of elements in the array
        private int _count;
        //private field used to maintain the capacity of the element in the array
        private int _capacity;
        //private field used to maintain the head value of in the array
        private int _head;
        //private field used to maintain the tail value in the array
        private int _tail;
        // private array which stores the value in the array
        private Type[] _array;
        //property used to get the count of the array
        public int Count
        {
            get
            {
                return _count;
            }
        }
        //Default constructor used the initialize the value with default 
        public CustomQueue()
        {
            _count = 0;
            _head = 0;
            _tail = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        //parameterized constructor used to initialize the value with parameter size
        public CustomQueue(int size)
        {
            _count = 0;
            _head = 0;
            _tail = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        //Add method used to add the element to the arrray and grow based on elements using grow method 
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
            _tail++;
        }
        //GrowSize method make the array to twice its size when it reaches the capacity
        void GrowSize()
        {
            _capacity = _capacity * 2;
            Type[] temp = new Type[_capacity];
            for (int i = _head; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        //Peek is used to show first value in a array
        public Type Peek()
        {
            Type value = default(Type);
            if (_head == _tail)
            {
                return value;
            }
            return _array[_head];
        }
        //Dequeue method is used to remove the last element in the array
        public Type Dequeue()
        {
            Type value = default(Type);
            if (_head == _tail)
            {
                Console.WriteLine($"The queue is empty");
                return value;
            }
            else
            {
                _head++;
                _count--;
                return _array[_head - 1];
            }
        }
        // setting the for each loop
        int position;
        // using the GetEnumerator method to make the lists of values enumerable
        public IEnumerator GetEnumerator()
        {
            position = _head - 1;
            return (IEnumerator)this;
        }
        // MoveNext method used to iterate the next element in lists of elements
        public bool MoveNext()
        {
            if (position < _tail - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        //Reset method used to reset the position to first value present
        public void Reset()
        {
            position = _head - 1;
        }
        //current is a getter used to return the current elements position
        public object Current
        {
            get { return _array[position]; }
        }
    }
}