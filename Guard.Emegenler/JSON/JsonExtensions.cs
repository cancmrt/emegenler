using Newtonsoft.Json;

namespace Guard.Emegenler.JSON
{
    public static class JsonExtensions
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
