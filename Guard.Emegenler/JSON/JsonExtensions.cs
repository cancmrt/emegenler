using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.JSON
{
    public class JsonExtensions
    {
        public static T TryParseJson<T>(string jsonData) where T : new()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch
            {
                return default;
            }

        }
    }
}
