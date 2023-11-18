using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ivan_WF
{
    public class ArrayRead : IRead
    {
        public Array Read(string fileName)
        {
            string json = "";
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    json = reader.ReadToEnd();
                }
            }

            return JsonConvert.DeserializeObject<Array>(json);
        }
    }
}
