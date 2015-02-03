using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;
using Newtonsoft.Json;

namespace WLSXX.DataAccess
{
    public static class DataManager
    {
        public static Data Data { get; set; }

        public static void LoadData()
        {
            string importJson = System.IO.File.ReadAllText(@"Data\data.json");
            Data = JsonConvert.DeserializeObject<Data>(importJson);
        }

        public static void UpdateData()
        {
            string exportJson = JsonConvert.SerializeObject(Data);
            System.IO.File.WriteAllText(@"Data\data.json", exportJson);

        }
    }
}
