using Entities;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace DataAccess
{
    public class Deserialize
    {
        public Root GetAll()
        {
            string fileName = "C:/Users/ikbal/Desktop/Staj/StajAPI/DataAccess/data.json";
            string jsonString = File.ReadAllText(fileName);
            var root = JsonSerializer.Deserialize<Root>(jsonString);
            return root;
        }

    }
}
