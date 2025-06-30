using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking
{
    public class BinarySearch<TKey,TValue>
    {
        public TValue Search(MyDictionary<TKey, TValue> dict, string key, string propertyName)
        {
            PropertyInfo property = typeof(TValue).GetProperty(propertyName);
            //getting the keys using the keys custom created method
            TKey [] keys =dict.Keys();
            int low = 0;
            int high = dict.Count - 1;
            while (low <= high)
            {
                //making the mid values
                int mid = (low + high) / 2;
                TKey currentKey=keys[mid];
                int result = property.GetValue(dict[currentKey]).ToString().CompareTo(key);
                if(result ==0){
                    return dict[currentKey];
                }
                else if(result>=1){
                        high =mid-1;
                }
                else{
                    low =mid+1;
                }
            }
            return default(TValue);
        }
    }
}