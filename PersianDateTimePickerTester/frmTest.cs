using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersianDateTimeControl;

namespace PersianDateTimeControlTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void persianDatePicker1_DateChanged(object sender, DateChangedEventArgs e)
        {

        }

        private void persianDatePicker1_Load(object sender, EventArgs e)
        {

        }

        private void persianDatePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void persianDatePicker1_Load_1(object sender, EventArgs e)
        {

        }

        private void persianDatePicker1_Leave_1(object sender, EventArgs e)
        {

        }

        private void persianDatePicker1_DateChanged_1(object sender, DateChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persianTimPicker1.Value = "23:59:59";
            persianDatePicker1.Value = DateTime.Now;
            persianDateTimePicker1.DatePicker.Value = DateTime.Now;
            persianDateTimePicker1.TimPicker.Value = DateTime.Now.ToString("hh:mm:ss");

        }

        private void persianTimPicker1_TimeChanged(object sender, TimeChangedEventArgs e)
        {
            txtTime.Text = persianTimPicker1.Value;
        }

        private void persianDatePicker1_DateChanged_2(object sender, DateChangedEventArgs e)
        {
            txtDateChangeF.Text = e.Text;
            txtDateChangeM.Text = e.Value?.ToString("yyyy/MM/dd");
        }

        private void persianDatePicker1_Leave_2(object sender, EventArgs e)
        {
            txtDateChangeAF.Text = persianDatePicker1.Text;
            txtDateChangeAM.Text = persianDatePicker1.Value?.ToString("yyyy/MM/dd");

        }

        private void persianDateTimePicker1_DateTimeChanged(object sender, DateTimeChangedEventArgs e)
        {
            txtDateTimechangedtext.Text = persianDateTimePicker1.Text;
            txtDateTimechangedvalue.Text = persianDateTimePicker1.Value.ToString();
        }
    }
}
