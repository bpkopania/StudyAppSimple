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
        string filePath = "C:\\StudyApp/";
        int indexOfTermin;
        public Form1()
        {
            InitializeComponent();
        }

        private int findIndex(int size)
        {
            Random rnd = new Random();
            return rnd.Next(size);
        }
        private void findObject(int mode=0)
        {
            try
            {
                int i = 0;
                
                
                // Utwórz obiekt StreamReader do odczytu pliku
                using (StreamReader reader = File.OpenText(filePath+"test.txt"))
                {
                    int size;
                    size = Int32.Parse(reader.ReadLine());
                    indexOfTermin = findIndex(size);
                    // Odczytaj plik linia po linii
                    string linia;
                    string url;
                    while ((linia = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(linia);
                        // Tutaj możesz przetwarzać każdą linię, jak chcesz
                        
                        url = reader.ReadLine();
                        
                        if(i== indexOfTermin)
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
    }
}
