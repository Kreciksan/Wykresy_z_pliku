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

namespace wykresy_z_pliku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                sr = File.OpenText(openFileDialog1.FileName);

                Char[] separators = { ',', ' ', '\n'};
                String[] nums = sr.ReadToEnd().Split(separators);

                for(int i = 0; i < nums.Length; i++)
                {
                    if(i % 2 != 0)
                    {
                        chart1.Series["punkty"].Points.AddXY(nums[i - 1], nums[i]);
                    }

                }
                
                sr.Close();

            }
        }
    }
}
