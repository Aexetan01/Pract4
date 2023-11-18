using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ivan_WF
{
    public class Array
    {
        private int[] array;
        private int size;

        public int[] MyArray
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
                size = array.Length;
            }
        }
        public int Size { get => size; }

        public Array()
        {
            MyArray = new int[0];
        }

        public Array(int size)
        {
            MyArray = new int[size];
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += array[i].ToString() + " ";
            }
            return result;
        }

        public string GetAllArrayToString()
        {
            return this.ToString();
        }

        public string GetElementToString(int index)
        {
            return this[index].ToString();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length) throw new IndexOutOfRangeException($"Index out of range({index} from size: {size})");
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length) throw new IndexOutOfRangeException($"Index out of range({index} from size: {size})");
                array[index] = value;
            }
        }

    }
}
