using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ivan_WF
{
    public class ArrayWrite : IWrite
    {
        public void Write(string fileName, Array array)
        {
            string json = JsonConvert.SerializeObject(array);

            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(json);
                }
            }
        }
    }
}
