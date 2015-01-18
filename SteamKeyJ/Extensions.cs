using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamKeyJ
{
    public static class Extensions
    {
        public static void AddOrUpdate<T,V>(this Dictionary<T,V> dictionary, T key, V value)
        {
            V output;
            if (dictionary.TryGetValue(key, out output))
            {
                //update
                dictionary[key] = value;                
            }
            else
            {
                //add
                dictionary.Add(key, value);
            }

        }
    }
}
