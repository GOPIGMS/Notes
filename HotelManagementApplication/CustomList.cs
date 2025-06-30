using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace HotelManagementApplication
{
/// <summary>
/// Contains Custom User Created list <see cref="CustomList<Type>"/>
/// </summary>
/// <typeparam name="Type"></typeparam>
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        //fields
        private int _count;
        private int _capacity;
        private Type[] _array;
        //properties
        public int Count
        {
            get
            {
                return _count;
            }
        }
        //indexers
        public Type this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        //constructors
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        //methods
        //adding
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }
        //grow size dyncamically
        void GrowSize()
        {
            _capacity = _capacity * 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        //finding index
        public int IndexOf(Type element)
        {

            for (int i = 0; i < Count; i++)
            {
                if (_array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public void RemoveAt(int index)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                if (i >= index)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }
        //removing range of value
        public void Remove(Type element)
        {
            int index = IndexOf(element);
            if (index! > -1)
            {
                RemoveAt(index);
            }
        }
        //inserting range of value
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _capacity + elements.Count + 5;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = _array[i];
            }
            for (int i = 0; i < elements.Count; i++)
            {
                temp[i + Count] = elements[i];
            }
            _array = temp;
            _count = _count + elements.Count;
        }
        //inserting  element
        public void Insert(int pos, Type element)
        {
            _capacity = _capacity + 5;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i <= _count; i++)
            {
                if (i < pos)
                {
                    temp[i] = _array[i];
                }
                else if (i == pos)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _array = temp;
            _count++;
        }
        // inserting array of elements
        public void InsertRange(int pos, CustomList<Type> elements)
        {
            _capacity = _capacity * 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < pos; i++)
            {
                temp[i] = _array[i];
            }
            for (int j = 0; j < elements.Count; j++)
            {
                temp[j + pos] = elements[pos];
            }
            for (int k = pos; k < Count; k++)
            {
                temp[pos + elements.Count] = _array[pos];
            }
            _array = temp;
            _count = _count + elements.Count;
        }

        //compare the elements
        public bool IsGreater(Type element1, Type element2)
        {
            int value = Comparer<Type>.Default.Compare(element1, element2);
            if (value >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //sort 
        public void Sort()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count-1; j++)
                {
                     if(IsGreater(_array[j],_array[j+1])){
                          Type temp =_array[j+1];
                          _array[j+1]=_array[j];
                          _array[j]=temp;
                     }
                }
            }
        }
        //reverse
        public void Reverse(){
            Type[] temp =new Type[Count];
            int j=0;
            for(int i=Count-1;i>=0;i--){
                temp[j]=_array[i];
                j++;
            }
            _array=temp;
        }
        //for each loop code 
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if (position < Count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get
            {
                return _array[position];
            }
        }
    }
}


