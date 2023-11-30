using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace DemoAPI
{
    public static class DataModificationService
    {
        private static readonly string file = File.ReadAllText("C:\\Users\\rpandey\\tavisca\\New folder\\DemoAPI\\DemoAPI\\POS.json");
        private static readonly JObject defaultPosSettings = JObject.Parse(file);
        public static POSSetting GetModifiedData(Dictionary<string,string> settingsToModify)
        {
            

            foreach(string key in settingsToModify.Keys)
            {
                var selectToken = defaultPosSettings.SelectToken(key);
                selectToken?.Replace(JToken.FromObject(settingsToModify[key]));
            }
            
            var settings = defaultPosSettings.ToObject<POSSetting>();

            return settings;


            //var settings = new POSSetting();
            //if (string.IsNullOrWhiteSpace(mockPos) || mockPos == "default")
            //    return settings;

            // settings = JsonConvert.DeserializeObject<POSSetting>(file);


            //var js = "{\"Field\": {\"FieldKey1\": \"FieldValue1\",\"FieldKey2\": \"FieldValue2\"}}";

            //var jObject = JObject.Parse(js);
            //var selectToken = jObject.SelectToken("Field.FieldKey1");
            //selectToken.Replace(JToken.FromObject("NewValue"));
            //Console.WriteLine(JsonConvert.SerializeObject(jObject));


            //var fields = mockPos.Split('.');
            //PropertyInfo pi = null;
            //var type = typeof(POSSetting);

            //foreach ( var field in fields)
            //{

            //    pi = type.GetProperty(field);
            //    type = pi.PropertyType;

            //}
            //pi.SetValue(settings, Convert.ChangeType(value, pi.PropertyType), null);

        }
    }
}
