using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ErplyAPI
{
    public class CSVReader
    {
        /// <summary>
        /// Read CSV file and convert it's contents to a object list.
        /// </summary>
        /// <typeparam name="T">Object to which every line will be converted to</typeparam>
        /// <param name="lines">CSV file lines as a array</param>
        /// <returns>Returns gotten object T</returns>
        public static List<T> ReadCSVToObject<T>(string[] lines)
        {
            var csv = new List<string[]>(); // or, List<YourClass>

            foreach (string line in lines)
                csv.Add(line.Split(','));

            var properties = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                    objResult.Add(properties[j], csv[i][j].Replace(@"""", ""));

                listObjResult.Add(objResult);
            }

            var json = JsonConvert.SerializeObject(listObjResult);

            return JsonConvert.DeserializeObject<List<T>>(json);
        }
        /// <summary>
        /// Read CSV file and convert it's contents to a object list.
        /// </summary>
        /// <typeparam name="T">Object to which every line will be converted to</typeparam>
        /// <param name="lines">CSV file as a string</param>
        /// <returns>Returns gotten object T</returns>
        public static List<T> ReadCSVToObject<T>(string file)
        {
            var csv = new List<string[]>(); // or, List<YourClass>
            string[] lines = file.Split('\n');

            foreach (string line in lines)
                csv.Add(line.Split(','));

            var properties = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                    objResult.Add(properties[j], csv[i][j].Replace(@"""", ""));

                listObjResult.Add(objResult);
            }

            var json = JsonConvert.SerializeObject(listObjResult);

            return JsonConvert.DeserializeObject<List<T>>(json);
        }
        /// <summary>
        /// Read CSV file and convert it's contents to a object list.
        /// </summary>
        /// <typeparam name="T">Object to which every line will be converted to</typeparam>
        /// <param name="lines">CSV file as a stream</param>
        /// <returns>Returns gotten object T</returns>
        public static List<T> ReadCSVToObject<T>(Stream file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                var csv = new List<string[]>(); // or, List<YourClass>
                string line;
                List<string> lines = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                    csv.Add(line.Split(','));
                }

                var properties = lines[0].Split(',');

                var listObjResult = new List<Dictionary<string, string>>();

                for (int i = 1; i < lines.Count; i++)
                {
                    var objResult = new Dictionary<string, string>();
                    for (int j = 0; j < properties.Length; j++)
                        objResult.Add(properties[j].Replace(@"""", ""), csv[i][j].Replace(@"""", ""));

                    listObjResult.Add(objResult);
                }

                var json = JsonConvert.SerializeObject(listObjResult);

                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }
    }

    public static class Extensions
    {
        /// <summary>
        /// Checks if object has a property with given name
        /// </summary>
        /// <param name="obj">Object from where properties will be searched for</param>
        /// <param name="propertyName">Property name to search for</param>
        /// <returns>Returns a boolean, which shows if class contains property or not</returns>
        public static bool HasProperty(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName) != null;
        }
    }
}
