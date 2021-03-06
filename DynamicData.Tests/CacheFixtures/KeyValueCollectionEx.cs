using System.Collections.Generic;
using System.Linq;

namespace DynamicData.Tests.CacheFixtures
{
    public static class KeyValueCollectionEx
    {
        public static IDictionary<TKey, IndexedItem<TObject, TKey>> Indexed<TObject, TKey>(this
                                                                                               IKeyValueCollection<TObject, TKey> source)
        {
            return source
                .Select((kv, idx) => new IndexedItem<TObject, TKey>(kv.Value, kv.Key, idx))
                .ToDictionary(i => i.Key);
        }
    }
}
