using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            String json = webClient.DownloadString("http://dummy.restapiexample.com/api/v1/employees");

            JObject jsonData = JObject.Parse(json);
            Console.WriteLine("status = " + jsonData["status"].ToString() );

            /*
             * {
                    "id": "2",
                    "employee_name": "Garrett Winters",
                    "employee_salary": "170750",
                    "employee_age": "63",
                    "profile_image": ""
                }
             */
            foreach (JToken item in jsonData["data"])
            {
                int _id = Convert.ToInt32(item["id"]);
                string name = item["employee_name"].ToString();
                double salary = Convert.ToDouble(item["employee_salary"]);
                int age = Convert.ToInt32(item["employee_age"]);
                String image = item["profile_image"].ToString();

                Console.WriteLine("{0,4}|{1,40}|{2,10}|{3,4}|{4,40}", 
                        _id, name, salary, age, image );
            }

            Console.ReadKey();

        }
    }
}
