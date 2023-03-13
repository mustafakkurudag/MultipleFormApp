using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleFormApp
{
    public partial class Form1 : Form
    {
        private string filePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void number1Tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void number2tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void number3tBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void buttonResult_Click(object sender, MouseEventArgs e)
        {
            int number1 = int.Parse(number1tBox.Text.ToString().Trim());
            int number2 = int.Parse(number2tBox.Text.ToString().Trim());
            int number3 = int.Parse(number3tBox.Text.ToString().Trim());

            int sum = number1 + number2;
            int mult = sum * number3;

            resultTbox.Text = mult.ToString();


        }

        private void btnZigZag_Click(object sender, MouseEventArgs e)
        {
            var resultList = new List<object>();

            for (int i = 1; i <= 200; i++)
            {
                if (i % 15 == 0)
                {
                    if (i > 100)
                    {
                        resultList.Add("ZagZig ");
                    }
                    else
                    {
                        resultList.Add("ZigZag");
                    }
                }
                else if (i % 3 == 0)
                {
                    resultList.Add("Zig ");
                }
                else if (i % 5 == 0)
                {
                    resultList.Add("Zag ");

                }
                else
                {
                    resultList.Add(i);
                }
            }

            foreach (var result in resultList)
            {
                listView1.Items.Add(result.ToString());
            }


        }

        private void numberMult_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnShowMultTbl_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxMultTable.ScrollBars = ScrollBars.Vertical;
            int numberMult = int.Parse(carpimSayi.Text) + 1;
            StringBuilder carpimStr = new StringBuilder();
            int count = 0;

            if (numberMult != null)
            {
                if (numberMult >= 1 && numberMult <= 16)
                {
                    List<int> multTable = drawMultTable(numberMult);
                    foreach (var result in multTable)
                    {
                        carpimStr.Append(result.ToString() + "\t");
                        count++;
                        if (count % (numberMult) == 0)
                        {
                            carpimStr.Append("\r\n\r\n");
                        }
                    }

                    textBoxMultTable.Text = carpimStr.ToString();
                }
                else
                {
                    MessageBox.Show("Lütfen 15 ile 1 arasında bir sayı giriniz!");
                    carpimSayi.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sayı giriniz!");
            }
        }

      
        private List<int> drawMultTable(int number)
        {
            int[] multArray = new int[number + 1];
            var resultList = new List<int>();

            for (int i = 0; i < number; i++)
            {
                multArray[i] = i;
            }

            for (int i = 0; i < number; i++)
            {
                resultList.Add(i);

                for (int j = 1; j < number; j++)
                {
                    if (i == 0)
                    {
                        resultList.Add(multArray[j]);
                    }
                    else
                    {
                        resultList.Add(i * multArray[j]);
                    }
                }
                //result += "\n";
            }
            //resultList.Add(result);

            return resultList;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog choofdlog = new OpenFileDialog();

            choofdlog.Filter = "All Files (*.*)|*.*";

            choofdlog.FilterIndex = 1;

            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                filePath = choofdlog.FileName;
                textBoxFilePath.Text = filePath;
            }

        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            if (controlFileExists(filePath))
            {
                List<double> fileDatas = readFileData(filePath);
                orderListDesc(fileDatas);

            }
            else
            {
                MessageBox.Show("Geçersiz dosya ismi veya yolu!");
            }
        }

        private void btnEditFile_MouseClick(object sender, MouseEventArgs e)
        {
            if (controlFileExists(filePath))
            {
                List<double> fileDatas = readFileData(filePath);
                orderListDesc(fileDatas);

                writeDataToLabel(fileDatas);

                MessageBox.Show("Dosyadaki sayılar büyükten küçüğe sıralandı!");

            }
            else
            {
                MessageBox.Show("Geçersiz dosya ismi veya yolu!");
            }
        }

        private bool controlFileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("kontrol ediliyor... dosya var");
                return true;
            }
            else
            {
                Console.WriteLine("kontrol ediliyor... dosya yok");
                return false;
            }
        }

        private List<double> readFileData(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            string data = streamReader.ReadToEnd();
            streamReader.Close();

            var fileDatas = new List<double>();
            StringBuilder currentNumber = new StringBuilder("");
            for (int i = 0; i < data.Length; i++)
            {

                if (string.IsNullOrWhiteSpace(data[i].ToString()))
                {
                    if (data[i + 1].ToString() != " ")
                        if (!(string.IsNullOrWhiteSpace(currentNumber.ToString())))
                        {
                            fileDatas.Add(double.Parse(currentNumber.ToString().Trim()));
                            currentNumber.Clear();
                        }
                    continue;
                }
                else
                {
                    if (data[i].ToString() == "-")
                    {
                        currentNumber.Append(data[i].ToString());
                        continue;
                    }
                    currentNumber.Append(data[i].ToString());
                    if (i + 1 >= data.Length)
                        fileDatas.Add(double.Parse(currentNumber.ToString().Trim()));
                }
            }

            return fileDatas;
        }

        private List<double> orderListDesc(List<double> fileDatas)
        {
            fileDatas.Sort();
            fileDatas.Reverse();

            return fileDatas;
        }

        private void writeDataToLabel(List<double> fileDatas)
        {
            //label8.MaximumSize = new Size(400, 0);
            label8.AutoSize = true;

            foreach (var fileData in fileDatas)
            {
                label8.Text += fileData.ToString() + "   ";

            }
        }


        private void buttonCalcFibo_MouseClick(object sender, MouseEventArgs e)
        {
            int numFibo = int.Parse(textBoxFiboNumber.Text);
            int number1 = 0, number2 = 1;
            int fibo = 0;
            if (numFibo == 1)
            {
                labelShowFiboResult.Text = numFibo + ". sıradaki fibonacci sayısı = " + fibo;
            }
            else if (numFibo == 2)
            {
                fibo = 1;
                labelShowFiboResult.Text = numFibo + ". sıradaki fibonacci sayısı = " + fibo;
            }
            else
            {
                for (int j = 2; j < numFibo; j++)
                {
                    fibo = number1 + number2;
                    Console.WriteLine(fibo + ", ");
                    number1 = number2;
                    number2 = fibo;
                }
                labelShowFiboResult.Text = numFibo + ". sıradaki fibonacci sayısı = " + fibo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }
    }
}
