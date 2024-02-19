using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DotNF_4_8_Playground.Utils
{
    public static class JsonUtil
    {
        public static string GetJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T GetObject<T>(string json) where T : new()
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
