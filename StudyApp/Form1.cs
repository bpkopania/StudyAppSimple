using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace StudyApp
{
    public partial class Form1 : Form
    {
        string filePath = "C:/StudyApp/";
        int indexOfTermin = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private int findIndex(int size)
        {
            //build arrays of available indexs to choose from
            
            int index = 0;
            Random rnd = new Random();

            try
            {
                bool[] freeNumbers = new bool[size];
                for (int i = 0; i < size; i++)
                {
                    freeNumbers[i] = true;
                }
                var validIndexs = new System.Collections.Generic.List<int>();
                
                // StreamReader to enable reading from file
                using (StreamReader reader = File.OpenText(filePath + "testowy.txt"))
                {
                    string linia;
                    int notAvIndex;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        notAvIndex = Int32.Parse(linia);
                        freeNumbers[notAvIndex] = false;
                    }
                }

                // build a list from available index
                for (int i = 0; i < freeNumbers.Length; i++)
                {
                    if (freeNumbers[i])
                    {
                        validIndexs.Add(i);
                    }
                }

                if (validIndexs.Count > 0)
                {
                    //chose from valid
                    index = validIndexs[rnd.Next(validIndexs.Count)];
                }
                else
                {
                    //everything is forbiden, you know everything
                    index = -1;
                }

            }
            catch (Exception ex)
            {
                //there is no file of savings, every iindex is available
                
                index = rnd.Next(size);
            }

            return index;
        }
        private void findObject(int mode=0)
        {
            try
            {
                int i = 0;
                
                
                // StreamReader to enable reading from file
                using (StreamReader reader = File.OpenText(filePath+"test.txt"))
                {
                    int size;
                    size = Int32.Parse(reader.ReadLine());
                    indexOfTermin = findIndex(size);

                    if(indexOfTermin == -1)
                    {
                        Termin.Text = "Nie ma więcej pojęc do nauki. Zdasz spiewająco";
                        return;
                    }

                    string linia;
                    string url;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        
                        url = reader.ReadLine();
                        
                        if(i == indexOfTermin)
                        {
                            Process.Start(url);
                            Termin.Text = linia;
                        }
                        i++;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Termin.Text = "Wystapil Blad" + ex.Message;
            }
        }
        private void findNewBtn_Click(object sender, EventArgs e)
        {
            findObject();
        }

        private void knowBtn_Click(object sender, EventArgs e)
        {
            if(indexOfTermin != -1)
            {
                using (StreamWriter sw = new StreamWriter(filePath+"testowy.txt", true))
                {
                    sw.WriteLine(indexOfTermin);
                }
            }
        }
    }
}
