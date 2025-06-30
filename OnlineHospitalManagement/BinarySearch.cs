using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace OnlineHospitalManagement
{
    /// <summary>
    /// Perform binary search on the given value of list BinarySearch<Type>
    /// </summary>
    /// <typeparam name="Type">Dynamic type given by the user</typeparam>
    public class BinarySearch<Type>
    {
        //method perform binary search on the operation
        public Type Search(CustomList<Type> list,string id,string propertyName){
            PropertyInfo property =typeof(Type).GetProperty(propertyName);
            int low =0;
            int high =list.Count-1;
            while(low<=high){
                int mid = (low+high)/2;
                int result = property.GetValue(list[mid]).ToString().CompareTo(id);
                if(result ==0){
                    return list[mid];
                }
                else if(result >=1){
                    high=mid-1;
                }
                else{
                    low =mid+1;
                }
            }
            return default(Type);
        }
    }
}