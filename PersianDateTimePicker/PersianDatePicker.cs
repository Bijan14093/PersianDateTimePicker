using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PersianDateTimeControl
{
    [ToolboxItem(true)]
    [DefaultEvent("DateChanged")]
    public partial class PersianDatePicker: UserControl
    {
        
        public delegate void DateChangedEvent(object sender, DateChangedEventArgs e);
        public event DateChangedEvent DateChanged;
        frmSelectDate frmSelectDate= new frmSelectDate();
        public PersianDatePicker()
        {
            InitializeComponent();
        }
        #region Public memebers
        public DateTime? Value
        {
            get
            {
                try
                {
                    int year, month, day;
                    Int32.TryParse(txtYear.Text, out year);
                    Int32.TryParse(txtMonth.Text, out month);
                    Int32.TryParse(txtDay.Text, out day);
                    return Utility.PersianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
                }
                catch (Exception ex)
                {

                    return null;
                }
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        txtYear.Text = "";
                        txtMonth.Text = "";
                        txtDay.Text = "";
                    }
                    else
                    {
                        PersianDate persianDate = Utility.GetPersianDate((DateTime)value);
                        txtYear.Text = persianDate.Year.ToString();
                        txtMonth.Text = persianDate.Month.ToString();
                        txtDay.Text = persianDate.Day.ToString();

                    }


                }
                catch (Exception)
                {

                    txtYear.Text = "";
                    txtMonth.Text = "";
                    txtDay.Text = "";
                }
            }
        }
        public string Text
        {
            get
            {
                var tmp = txtYear.Text + sep1.Text + txtMonth.Text + sep2.Text + txtDay.Text;
                if (tmp == (sep1.Text + sep2.Text))
                {
                    return "";
                }
                return tmp ;
            }
        }
        #endregion

        private void btnSelectDate_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void ShowForm()
        {
            DateTime? CurrentDate;
            if (txtYear.Text!="" && txtMonth.Text!="" && txtDay.Text!="")
            {
                try
                {
                    CurrentDate = Utility.PersianCalendar.ToDateTime(Int32.Parse(txtYear.Text), Int32.Parse(txtMonth.Text), Int32.Parse(txtDay.Text), 0, 0, 0, 0);
                }
                catch (Exception)
                {
                    CurrentDate = null;
                }

            }
            else
            {
                CurrentDate = null;
            }

            Point locationOnScreen = btnSelectDate.Parent.PointToScreen(btnSelectDate.Location);
            locationOnScreen.Y = locationOnScreen.Y + btnSelectDate.Height;
            var result = frmSelectDate.SelectDate(locationOnScreen, CurrentDate);
            txtYear.ReadOnly = true;
            if (result == null)
            {
                txtYear.Text = "";
                txtMonth.Text = "";
                txtDay.Text = "";
            }
            else
            {

                PersianDate persianDate = Utility.GetPersianDate((DateTime)result);
                txtYear.Text = persianDate.Year.ToString();
                txtMonth.Text = persianDate.Month.ToString();
                txtDay.Text = persianDate.Day.ToString();
            }
            btnSelectDate.Focus();
            txtYear.ReadOnly = false;
            if (result!=CurrentDate)
            {
                RaiseEventDateChanged();
            }
        }


        private void txtYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtYear.Text == "")
            {
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                txtYear.Text = (Int32.Parse(txtYear.Text) +1).ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Int32.Parse(txtYear.Text) <= 1)
                {
                    return;
                }
                txtYear.Text = (Int32.Parse(txtYear.Text)-1).ToString();
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMonth.Text == "")
            {
                return;
            }
            int Month = Int32.Parse(txtMonth.Text);
            if (e.KeyCode == Keys.Up)
            {
                if (Month >= 12)
                {
                    return;
                }
                txtMonth.Text = (Int32.Parse(txtMonth.Text) + 1).ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Month <= 1)
                {
                    return;
                }
                txtMonth.Text = (Int32.Parse(txtMonth.Text) - 1).ToString();
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatetxtYear();
        }

        private bool ValidatetxtYear(bool showmessage = true)
        {
            if (txtYear.Text=="")
            {
                return true;
            }
            int year;
            Int32.TryParse(txtYear.Text, out year);
            if (!(year>= 1000 && year<=4000))
            {
                if (showmessage)
                {
                    MessageBox.Show("مقدار سال وارد شده معتبر نمیباشد" + Environment.NewLine + "مقادیر معتبر بین 1000 تا 4000 میباشد");
                }

                return false;
            }
            return true;
        }

        private void txtMonth_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatetxtMonth();
        }

        private bool ValidatetxtMonth(bool showmessage = true)
        {
            if (txtMonth.Text == "")
            {
                return true;
            }
            int Month;
            Int32.TryParse(txtMonth.Text, out Month);
            if (!(Month >= 1 && Month <= 12))
            {
                if (showmessage)
                {
                    MessageBox.Show("مقدار ماه وارد شده معتبر نمیباشد" + Environment.NewLine + "مقادیر معتبر بین 1 تا 12 میباشد");
                }

                return false;
            }
            return true;
        }

        private void txtDay_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatetxtDay();
        }

        private bool ValidatetxtDay(bool showmessage=true)
        {
            if (txtDay.Text == "")
            {
                return true;
            }
            int Day;
            Int32.TryParse(txtDay.Text, out Day);
            if (!(Day >= 1 && Day <= 31))
            {
                if (showmessage)
                {
                    MessageBox.Show("مقدار روز وارد شده معتبر نمیباشد" + Environment.NewLine + "مقادیر معتبر بین 1 تا 31 میباشد");
                }

                return false;
            }
            return true;
        }

        private void txtDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDay.Text == "")
            {
                return;
            }
            int Day;
            Int32.TryParse(txtDay.Text, out Day);
            if (e.KeyCode == Keys.Up)
            {
                if (Day >= 31)
                {
                    return;
                }
                txtDay.Text = (Int32.Parse(txtDay.Text) + 1).ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Int32.Parse(txtDay.Text) <= 1)
                {
                    return;
                }
                txtDay.Text = (Int32.Parse(txtDay.Text) - 1).ToString();
            }

        }

        private void mnuToday_Click(object sender, EventArgs e)
        {
            PersianDate p = Utility.GetPersianDate(DateTime.Now);
            txtYear.Text = p.Year.ToString();
            txtMonth.Text = p.Month.ToString();
            txtDay.Text = p.Day.ToString();
        }

        private void mnuEmpty_Click(object sender, EventArgs e)
        {
            txtYear.Text ="";
            txtMonth.Text = "";
            txtDay.Text = "";
        }


        private void mnuShowCalender_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void mnuFirstDayofMonth_Click(object sender, EventArgs e)
        {
            PersianDate p = Utility.GetPersianDate(DateTime.Now);
            txtYear.Text = p.Year.ToString();
            txtMonth.Text = p.Month.ToString();
            txtDay.Text = "1";
        }

        private void mnuLastDayofMonth_Click(object sender, EventArgs e)
        {
            PersianDate p = Utility.GetPersianDate(DateTime.Now);
            Utility.PersianCalendar.GetDaysInMonth(p.Year, p.Month);
            txtYear.Text = p.Year.ToString();
            txtMonth.Text = p.Month.ToString();
            txtDay.Text = Utility.PersianCalendar.GetDaysInMonth(p.Year, p.Month).ToString() ; 
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            RaiseEventDateChanged();
        }

        private void RaiseEventDateChanged()
        {
            if (ValidateControl(false)==false)
            {
                return;
            }
            if (txtYear.ReadOnly) // To Control Event
            {
                return;
            }
            int year, month, day;
            Int32.TryParse(txtYear.Text, out year);
            Int32.TryParse(txtMonth.Text, out month);
            Int32.TryParse(txtDay.Text, out day);
            DateChangedEventArgs param = new DateChangedEventArgs();
            param.Value = this.Value;
            param.Text = this.Text;

           if (!(DateChanged == null))
            {
                DateChanged(this, param);
            }

        }

        private bool ValidateControl(bool ShowMessage=true)
        {
            if (txtYear.Text == "" && (txtMonth.Text != "" || txtDay.Text != ""))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار تاريخ معتبر نيست");
                }
                return false;
            }
            if (txtMonth.Text == "" && (txtYear.Text != "" || txtDay.Text != ""))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار تاريخ معتبر نيست");
                }
                return false;
            }
            if (txtDay.Text == "" && (txtMonth.Text != "" || txtYear.Text != ""))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار تاريخ معتبر نيست");
                }
                return false;
            }
            if (ValidatetxtDay(ShowMessage) == false)
            {
                return false;
            }
            if (ValidatetxtMonth(ShowMessage) == false)
            {
                return false;
            }
            if (ValidatetxtYear(ShowMessage) == false)
            {
                return false;
            }
            if (this.Text != "" & this.Value==null)
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار تاريخ معتبر نيست");
                }
                return false;
            }
            return true;

        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            RaiseEventDateChanged();
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            RaiseEventDateChanged();
        }

        private void btnSelectDate_Validating(object sender, CancelEventArgs e)
        {

        }

        private void PersianDatePicker_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateControl(true);
        }

        private void btnSelectDate_Enter(object sender, EventArgs e)
        {
        }

        private void PersianDatePicker_Leave(object sender, EventArgs e)
        {

        }

        private void PersianDatePicker_Load(object sender, EventArgs e)
        {
            
        }

        private void PersianDatePicker_Enter(object sender, EventArgs e)
        {
        }

        private void mnuMain_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
        }

        private void txtMonth_Validated(object sender, EventArgs e)
        {

        }

        private void txtDay_Validated(object sender, EventArgs e)
        {

        }
    }

    public class DateChangedEventArgs
    {
       public DateTime? Value { get; set; }
        public string Text { get; set; }
    }
}
