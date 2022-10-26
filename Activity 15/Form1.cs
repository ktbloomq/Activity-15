using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class LuckyNumbers : Form
    {
        int[] daysInMonth;
        public LuckyNumbers()
        {
            InitializeComponent();
            // how many days are in each month
            daysInMonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // add years from 2022 down to 1900
            for (int i = 2022; i >= 1900; i--)
            {
                yearPrompt.Items.Add(i);
            }
            monthprompt.Items.Add("January");
            monthprompt.Items.Add("February");
            monthprompt.Items.Add("March");
            monthprompt.Items.Add("April");
            monthprompt.Items.Add("May");
            monthprompt.Items.Add("June");
            monthprompt.Items.Add("July");
            monthprompt.Items.Add("August");
            monthprompt.Items.Add("September");
            monthprompt.Items.Add("October");
            monthprompt.Items.Add("November");
            monthprompt.Items.Add("December");

            // add all days in January
            for (int i = 1; i <= 31; i++)
            {
                dayPrompt.Items.Add(i);
            }

            colorPrompt.Items.Add("Red");
            colorPrompt.Items.Add("Orange");
            colorPrompt.Items.Add("Yellow");
            colorPrompt.Items.Add("Green");
            colorPrompt.Items.Add("Blue");
            colorPrompt.Items.Add("Purple");

            yearPrompt.SelectedIndex = 0;
            monthprompt.SelectedIndex = 0;
            dayPrompt.SelectedIndex = 0;
            colorPrompt.SelectedIndex = 0;

            // do not load selected index handler until element has loaded
            monthprompt.SelectedIndexChanged += new System.EventHandler(monthprompt_SelectedIndexChanged);
        }

        private void GetNumber_Click(object sender, EventArgs e)
        {
            // calculate lucky number by index
            int luckyNumber = (yearPrompt.SelectedIndex 
                + monthprompt.SelectedIndex
                + dayPrompt.SelectedIndex
                + colorPrompt.SelectedIndex)
                // return output from 1 to 100
                % 100 + 1;

            // instantiate and show result form
            ResultForm resultForm = new ResultForm(luckyNumber);
            resultForm.ShowDialog();
        }

        private void monthprompt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int days = daysInMonth[monthprompt.SelectedIndex];

            // update days to reflect the number of days in each month
            dayPrompt.Items.Clear();
            for (int i = 1; i <= days; i++)
            {
                dayPrompt.Items.Add(i);
            }
        }
    }
}
