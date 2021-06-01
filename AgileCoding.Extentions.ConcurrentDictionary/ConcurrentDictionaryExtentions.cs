namespace AgileCoding.Extentions.ConcurrentDictionaries
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public static class ConcurrentDictionaryExtentions
    {
        public static Dictionary<TKeyType, TValueType2> ToDictionary<TKeyType, TValueType1, TValueType2>
            (this ConcurrentDictionary<TKeyType, TValueType1> self, Func<KeyValuePair<TKeyType, TValueType1>, KeyValuePair<TKeyType, TValueType2>> mapperFunction)
        {
            Dictionary<TKeyType, TValueType2> resultDictionary = new Dictionary<TKeyType, TValueType2>();
            foreach (KeyValuePair<TKeyType, TValueType1> item in self)
            {
                var result = mapperFunction(item);
                resultDictionary.Add(result.Key, result.Value);
            }

            return resultDictionary;
        }
    }
}
