using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PersianDateTimeControl
{
    [ToolboxItem(true)]
    [DefaultEvent("DateTimeChanged")]
    public partial class PersianDateTimePicker : UserControl
    {
        public delegate void DateTimeChangedEvent(object sender, DateTimeChangedEventArgs e);
        public event DateTimeChangedEvent DateTimeChanged;
        public PersianDateTimePicker()
        {
            InitializeComponent();
        }
        public PersianDatePicker DatePicker { get { return persianDatePicker1; } }
        public PersianTimPicker TimPicker { get { return persianTimPicker1; } }
        public DateTime? Value
        {
            get
            {
                var tmpdatestr = this.persianDatePicker1.Value?.ToString("yyyy/MM/dd");
                var tmpTime = this.persianTimPicker1.Value;
                if (tmpdatestr == null)
                {
                    return null;
                }
                if (tmpdatestr == "")
                {
                    return null;
                }
                if (tmpTime=="")
                {
                    return null;
                }
                DateTime tmpdate;
                DateTime.TryParse(tmpdatestr + " " + tmpTime, out tmpdate);
                return (tmpdate);
            }
        }
        public string Text
        {
            get
            {
                var tmpdatestr = this.persianDatePicker1.Text;
                var tmpTime = this.persianTimPicker1.Value;
                if (tmpdatestr == "")
                {
                    return "";
                }
                if (tmpTime == "")
                {
                    return "";
                }
                var tmp = tmpdatestr + " " + tmpTime;
                return (tmp);
            }
        }
        private void RaiseEventDateTimeChanged()
        {
            if (ValidateControl(false)==false)
            {
                return;
            }
            DateTimeChangedEventArgs param = new DateTimeChangedEventArgs();
            param.Value = this.Value;
            param.Text = this.Text;
            if (!(DateTimeChanged == null))
            {
                DateTimeChanged(this, param);
            }

        }

        private bool ValidateControl(bool ShowMessage=true)
        {
            if (this.persianDatePicker1.Text == "" && this.persianTimPicker1.Value != "")
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار تاريخ و زمان وارد شده معتبر نيست");
                }
                return false;
            }
            if (this.persianTimPicker1.Value == "" && this.persianDatePicker1.Text != "")
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار تاريخ و زمان وارد شده معتبر نيست");
                }
                return false;
            }
            return true;
        }

        private void persianDatePicker1_DateChanged(object sender, DateChangedEventArgs e)
        {
            RaiseEventDateTimeChanged();
        }

        private void persianTimPicker1_TimeChanged(object sender, TimeChangedEventArgs e)
        {
            RaiseEventDateTimeChanged();
        }

        private void PersianDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateControl(true);
        }
    }

    public class DateTimeChangedEventArgs
    {
        public DateTime? Value { get; set; }
        public string Text { get; set; }
    }

}
