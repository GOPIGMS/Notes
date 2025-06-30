using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MyList
{
    /// <summary>
    /// CustomList is the manual creation  of list <see cref="CustomList<Type>"/>
    /// </summary>
    /// <typeparam name="Type">
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {

        int position;
        /// <summary>
        /// This method make the list enumeratable and provide the index position as 0 <see cref="CustomList<Type>"/>
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        /// <summary>
        /// The move next method moves the position to another position untill it reaches the end <see cref="CustomList<Type>"/>
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// The reset method is used to reset the position <see cref="CustomList<Type>"/>
        /// </summary>
        public void Reset()
        {
            position = -1;
        }
        /// <summary>
        /// The current method is used to select the current iterated elements <see cref="CustomList<Type>"/>
        /// </summary>
        public object Current
        {
            get { return _array[position]; }
        }

    }
}