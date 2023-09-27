using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Arrays
{
    public partial class frmArray : Form
    {
        public frmArray()
        {
            InitializeComponent();
        }
        string[] zodiacSign = new string[12];
        string[] zodiacDate = new string[12];

        private void btnArrays_Click(object sender, EventArgs e)
        {
            string[] teamMembers = new string[5];
            teamMembers[0] = "Jane";
            teamMembers[1] = "Jack";
            teamMembers[2] = "Timothy";
            teamMembers[3] = "Mary";
            teamMembers[4] = "Elizabeth";
            for (int x=0; x<5; x++)
            {
                rtbDisplay.AppendText(teamMembers[x] + Environment.NewLine);
            }
        }
        double[] monthlySales = new double[3];

        private void btnSearchArray_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            rtbDisplay.Text = "Monthly Sales under 2000 are listed below:" + Environment.NewLine;
            double y;
            for(int x = 0; x < monthlySales.Length; x++)
            {
                y = monthlySales[x];
                if (y<2000)
                {
                    rtbDisplay.AppendText(y.ToString() + Environment.NewLine);
                }
            }
        }

        private void btnArrayMath_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            foreach(double x in monthlySales)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);
            }
            double total= 0, average, largest, smallest;
            foreach(double x in monthlySales)
            {
                total += x;
            }
            average = total / monthlySales.Length;
            largest = monthlySales[0];
            for(int x = 1; x <monthlySales.Length;x++)
            {
                if (monthlySales[x]>largest)
                {
                    largest = monthlySales[x];
                }
            }
            smallest = monthlySales[0];
            for(int x = 1; x <monthlySales.Length; x++)
            {
                if (monthlySales[x] < smallest)
                {
                    smallest = monthlySales[x];
                }
            }
            rtbDisplay.AppendText("Total Sales:" + total.ToString() + Environment.NewLine + "Average Sales:" + average.ToString() + Environment.NewLine + "largest Sales:" + largest.ToString() + Environment.NewLine +
                "smallest sales:" + smallest.ToString());

        }

        private void btnArrayInitialized_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            string[] phones = new string[] { "Iphone", "Samsung", "Nokia Lumia" };
            for(int x = 0; x <3; x++)
            {
                rtbDisplay.AppendText(phones[x] + Environment.NewLine);
            }
            foreach(string x in phones)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);
            }
            int y = 0;
            while(y < phones.Length)
            {
                rtbDisplay.AppendText(y + Environment
                    .NewLine);
                y++;
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize(ref monthlySales, 6);
            monthlySales[3] = 3913;
            monthlySales[4] = 2878;
            monthlySales[5] = 3110;
            foreach(double x in monthlySales)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "Before sorting:" + Environment.NewLine;

            foreach (double x in monthlySales)
                rtbDisplay.AppendText(x + Environment.NewLine);
            foreach (double x in monthlySales)
                rtbDisplay.AppendText(x + Environment.NewLine);
        }

        private void btnAccessingUpdating_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "The 3rd Zodiac sign is :" + zodiacSign[2];
            zodiacSign[6] = "Libra the Scale";
            foreach(string x in zodiacSign)
            {
                rtbDisplay.AppendText(Environment.NewLine + x);
            }
        }

        private void btnInconveniant_Click(object sender, EventArgs e)
        {
            Array.Resize(ref zodiacSign, 13);
            for (int x = 11; x>=5; x--)
            {
                zodiacSign[x + 1] = zodiacSign[x];
            }
            zodiacSign[5] = "Loxodonta The Elephant";
            rtbDisplay.Clear();
            foreach(string x in zodiacSign)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);
            }
            for (int x = 1; x <=11; x++)
            {
                zodiacSign[x] = zodiacSign[x + 1];
            }
            Array.Resize(ref zodiacSign, 12);
            rtbDisplay.AppendText(@"After adding elephant and remove bull the following zodiac signs remains:" + Environment.NewLine);
            foreach(string x in zodiacSign)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);
            }
        }

        private void cboZodiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = cboZodiac.SelectedIndex;
            rtbDisplay.Text = zodiacDate[x];
        }
        string[] monthName = new string[3];

        private void frmArray_Load(object sender, EventArgs e)
        {
            monthlySales[0] = 2300;
            monthlySales[1] = 1938;
            monthlySales[2] = 2399;
            monthName[0] = "January";
            monthName[1] = "February";
            monthName[2] = "March";

            zodiacSign[0] = "Aries The Ram";
            zodiacDate[0] = "Mar. 21 Apr 19";
            zodiacSign[1] = "Taurus The Bull";
            zodiacDate[1] = "Apr 20 May 20";
            zodiacSign[2] = "Gemini The Twins";
            zodiacDate[2] = "May 21 June 21";
            zodiacSign[3] = "Cancer The Carb";
            zodiacDate[3] = "June July 22";
            zodiacSign[4] = "Leo the Lion";
            zodiacDate[4] = "July 23 Aug. 22";
            zodiacSign[5] = "Virgo The Virgin";
            zodiacDate[5] = "Aug 23 Step. 22";
            zodiacSign[6] = "Libra the Balance";
            zodiacDate[6] = "Sept . 23 Oct. 23";
            zodiacSign[7] = "Scorpio The Scorpion";
            zodiacDate[7] = "Oct. 24 Nov. 21";
            zodiacSign[8] = "Sagittarius the Archer";
            zodiacDate[8] = "Nov. 22 Dec. 21";
            zodiacSign[9] = "Capricorn The Goat";
            zodiacDate[9] = "Dec. 22 Jan. 19";
            zodiacSign[10] = "Aquarius The Water Bearer";
            zodiacDate[10] = "Jan. 20 Feb. 18";
            zodiacSign[11] = "Pisces the Firshes";
            zodiacDate[11] = "Feb. 19 Mar. 20";
            foreach(string x in zodiacSign)
            {
                cboZodiac.Items.Add(x);

            }
            cboZodiac.SelectedIndex = 0;


        }
    }
}
