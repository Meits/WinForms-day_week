using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace dz2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateString = this.textBox1.Text;
            string format,resDate = "";
            int dayWeek;
            string[] days1 = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime result = new DateTime();
            format = "dd-MM-yyyy";

            
            try
            {
                if(DateTime.TryParseExact(dateString, format,provider, DateTimeStyles.None, out result))
                {
                    dayWeek = Convert.ToInt32(result.DayOfWeek);
                    
                    resDate = days1[(dayWeek-1)];
                }
                else
                {
                    resDate = "error";
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", dateString);
            }

            this.textBox3.Text = resDate;
        }
    }
}
