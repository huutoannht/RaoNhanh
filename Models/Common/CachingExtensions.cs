using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models.Common
{
    public static class CachingExtensions
    {
        public static async Task SetObjectAsync<T>(
          this IDistributedCache cache, string key, T value)
        {
            await cache.SetStringAsync(key, JsonConvert.SerializeObject(value));
        }

        public static async Task<T> GetSetObjectAsync<T>(
            this IDistributedCache cache, string key, T value)
        {
            var data = await cache.GetStringAsync(key);
            if (value==null)
            {
                await cache.SetStringAsync(key, JsonConvert.SerializeObject(value));
                data = await cache.GetStringAsync(key);
            }
            return value == null ? default(T) :
                                  JsonConvert.DeserializeObject<T>(data);
        }
    }
}
