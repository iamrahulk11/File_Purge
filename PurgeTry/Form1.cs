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
using System.Xml.Linq;

namespace PurgeTry
{
    public partial class Form1 : Form
    {
        
        string path = System.Configuration.ConfigurationSettings.AppSettings["Path"];
        string year = "";
        string month = "";
        string days = "";
        int processDay = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings["ProcessDays"]);
              

        public Form1()
        {
            InitializeComponent();
            
        }
        public bool purgeFolderFiles()
        {
            bool complete = false;
            DateTime dt = DateTime.Now.AddDays(-processDay);
            int year = Convert.ToInt32(dt.Year);
            string month = Convert.ToString(dt.Month);
            if(month.Length == 1)
            {
                month = "0" + month;
            }
            string day = Convert.ToString(dt.Day);
            if(day.Length == 1)
            {
                day = "0" + day;
            }
            string folderName = year + month + day;
            if(Directory.GetDirectories(path).Length == 0)
            {
                return false;
            }
            foreach(string fil in Directory.GetDirectories(path)) 
            {
                try
                {
                    string filename = fil.Split('\\')[fil.Split('\\').Length - 1];
                    filename = filename.Replace("-", "");
                    if (Convert.ToInt32(filename) < Convert.ToInt32(folderName))
                    {
                        foreach (string fname in Directory.GetFiles(fil))
                        {
                            // 
                            System.IO.File.Delete(fname);
                        }

                        Directory.Delete(fil);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bool complete = purgeFolderFiles();
            if (complete)
            {
                myLabel.Visible = true;
                myLabel.Text = "Done";
            }
            else
            {
                myLabel.Visible = true;
                myLabel.Text = "File Not Found";
            }
            
            
        }



        
    }
}
