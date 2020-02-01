using Newtonsoft.Json;

namespace Guard.Emegenler.JSON
{
    public static class JsonExtensions
    {
        /// <summary>
        /// Method try to convert string to Json
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="jsonData">String Json data</param>
        /// <returns>Return new T Type or Parsed Json Data</returns>
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
