using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //RootObject obj;
            //string tmpjson = System.IO.File.ReadAllText("demofull.json");
            //obj = ReadToObject(tmpjson);

            test();
            Console.ReadLine();
        }

        // Create a User object and serialize it to a JSON stream.  
        public static string WriteFromObject()
        {
            ////Create User object.  
            //User user = new User("Bob", 42);

            ////Create a stream to serialize the object to.  
            //MemoryStream ms = new MemoryStream();

            //// Serializer the User object to the stream.  
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(User));
            //ser.WriteObject(ms, user);
            //byte[] json = ms.ToArray();
            //ms.Close();
            //return Encoding.UTF8.GetString(json, 0, json.Length);

            return "";
        }

        // Deserialize a JSON stream to a User object.  
        //public static RootObject ReadToObject(string json)
        //{
        //    RootObject deserializedUser = new RootObject();
        //    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
        //    DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedUser.GetType());
        //    deserializedUser = ser.ReadObject(ms) as RootObject;
        //    ms.Close();
        //    return deserializedUser;
        //}

        public static void test()
        {
            QuickType.Welcome we = new QuickType.Welcome();
            //we.SiteDetails = new QuickType.SiteDetails();
            //we.SiteDetails.LocationId = 12;
            //we.SiteDetails.MachineName = "dsfds";
            //we.SiteDetails.OperatorId = "obj";
            string jsonString = "";
            string jsonServiceURL = "";
            jsonString = System.IO.File.ReadAllText("demofull.json");
            jsonString = getJsonFromURL(jsonServiceURL);
            //res = QuickType.Serialize.ToJson(we);

            we = QuickType.Welcome.FromJson(jsonString);
            
            Console.ReadLine();
        }


        public static string getJsonFromURL(string URL)
        { 
            string jsonData = string.Empty;
            using (WebClient httpClient = new WebClient())
            {
                 jsonData = httpClient.DownloadString(URL);              
            }
            return jsonData;
        }


    }
}
