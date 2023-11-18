using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ivan_WF
{
    public partial class Form1 : Form
    {
        private Array array;
        public Form1()
        {
            InitializeComponent();
            array = new Array();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            lbArray.Items.Clear();
            array = new Array(10);

            Random random = new Random();
            for(int i = 0; i < array.Size; i++)
            {
                array[i] = random.Next(-100, 100);
                lbArray.Items.Add(array[i]);
            }
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < array.Size; i++)
            {
                if (array[i] < 0)
                {
                    lbArray.Items.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }
        }

        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти файл";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ArrayWrite arrayWrite = new ArrayWrite();
                    arrayWrite.Write(saveFileDialog.FileName, array);
                }
                catch
                {
                    MessageBox.Show("Помилка!");
                }
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Title = "Відкрити файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbArray.Items.Clear();
                try
                {
                    ArrayRead arrayRead = new ArrayRead();
                    array = arrayRead.Read(openFileDialog.FileName);
                    for (int i = 0; i < array.Size; i++)
                    {
                        lbArray.Items.Add(array[i].ToString());
                    }
                }
                catch
                {
                    array = new Array();
                    MessageBox.Show("Помилка!");
                }
            }
        }
    }
}
