using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyList
{
    public partial class CustomList<Type>
    {
        /// <summary>
        /// private field used to initiate the count of the list <see cref="CustomList<Type>"/>
        /// </summary>
        private int _count;
        /// <summary>
        /// private method used to initiate the capacity of the list <see cref="CustomList<Type>"/>
        /// </summary>
        private int _capacity;
        /// <summary>
        /// The Count property used as the getter for the count of the list <see cref="CustomList<Type>"/>
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }
        /// <summary>
        /// The Capacity property used as the getter for the capacity of the list <see cref="CustomList<Type>"/>
        /// </summary>

        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }
        /// <summary>
        /// Declaring the private array to store the value <see cref="CustomList<Type>"/>
        /// </summary>
        private Type[] _array;
        //creating the indexer
        /// <summary>
        /// It is a indexer used for making the object accessing as a array <see cref="CustomList<Type>"/>
        /// </summary>
        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        /// <summary>
        /// Default constructor used to initialize the instance without parameter and set the default values to the property <see cref="CustomList<Type>"/>
        /// </summary>
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Parameterized constructor used to initialize the instance with parameter and set the default values to the property <see cref="CustomList<Type>"/>  
        /// </summary>
        /// <param name="size">provide the capacity of the array</param>
        public CustomList(int size)
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// The Add method is used to add the element in a array it will grow if the count reaches the capacity <see cref="CustomList<Type>"/>  
        /// </summary>
        /// <param name="element">
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                Grow();
            }
            _array[_count] = element;
            _count++;
        }
        /// <summary>
        /// Grow method is used to make the  array look dynamic by growing when it reaches the capacity size <see cref="CustomList<Type>"/>  
        /// </summary>
        void Grow()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        // Add the range of value in the array at the end position
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[j];
                j++;
            }
            _array = temp;
            _count = _count + elements.Count;

        }
        // Checks whether the elements is present in the array or not
        public bool Contains(Type element)
        {
            bool contains = false;
            for (int i = 0; i < _count; i++)
            {
                if (element.Equals(_array[i]))
                {
                    contains = true;
                }
            }
            return contains;
        }
        // returns  the index of the elment user provides it will return -1 if not present
        public int IndexOf(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (element.Equals(_array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        //insert a element in a array using the index position
        public void Insert(int position, Type value)
        {
            _capacity = _capacity + 5;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i <= _count; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
                else if (i == position)
                {
                    temp[i] = value;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _array = temp;
            _count++;
        }
        //removing the elements in a array using the index position
        public void RemoveAt(int index)
        {
            for (int i = 0; i < _count - 1; i++)
            {
                if (i >= index)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }
        //removing the element in a array using the value
        public bool Remove(Type element)
        {
            int index = IndexOf(element);
            //if element present
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }
        //Reverse the value in a array 
        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count - 1; i >= 0; i--)
            {
                temp[j] = _array[i];
                j++;
            }
            _array = temp;
        }
        //insert a range of elements in a array using its position
        public void InsertRange(int pos, CustomList<Type> insertrange)
        {
            _capacity = _count + insertrange.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < pos; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = pos; i < insertrange.Count + pos; i++)
            {
                temp[i] = insertrange[j];
                j++;
            }
            for (int i = pos; i < _count; i++)
            {
                temp[i + insertrange.Count] = _array[i];
            }
            _array = temp;
            _count = _count + insertrange.Count;
        }
        //sorting the elements in ascending order
        public void Sort()
        {
            for (int i = 0; i < _count; i++)
            {
                for (int j = 0; j < _count - 1; j++)
                {
                    if (IsGreater(_array[j], _array[j + 1]))
                    {
                        Type temp = _array[j + 1];
                        _array[j + 1] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }
        // Compare the two elements and if value1 is greater return 1
        public bool IsGreater(Type value1, Type value2)
        {
            int result = Comparer<Type>.Default.Compare(value1, value2);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}