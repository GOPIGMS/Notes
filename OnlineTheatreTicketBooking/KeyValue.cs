using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking
{
    /// <summary>
    /// Class used to create key value as a single object <see cref="KeyValue<TKey,TValue>"/>
    /// </summary>
    public class KeyValue<TKey,TValue>
    {
        //properties
        public TKey Key {get;set;}
        public TValue Value {get;set;}
    }
}