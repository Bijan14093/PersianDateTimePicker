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
    [DefaultEvent("TimeChanged")]
    public partial class PersianTimPicker : UserControl
    {
        public delegate void TimeChangedEvent(object sender, TimeChangedEventArgs e);
        public event TimeChangedEvent TimeChanged;
        public PersianTimPicker()
        {
            InitializeComponent();
        }

        public string Value
        {
            get 
            {
                if (txtHour.Text=="")
                {
                    return "";
                }
                if (txtMinute.Text == "")
                {
                    return "";
                }
                if (txtSecond.Text == "")
                {
                    return "";
                }
                return txtHour.Text + sep1.Text + txtMinute.Text + sep2.Text + txtSecond.Text; 
            }
            set 
            {
                if (value=="" || value==null)
                {
                    txtHour.Text = "";
                    txtMinute.Text = "";
                    txtSecond.Text = "";
                }
                else { 
                    var arrtmp=value.Split(':');
                    txtHour.Text = arrtmp[0];
                    txtMinute.Text = arrtmp[1];
                     txtSecond.Text = arrtmp[2];
                }
            }
        }

        private void txtHour_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatetxtHour();
        }

        private bool ValidatetxtHour(bool ShowMessage=true)
        {
            if (txtHour.Text == "")
            {
                return true;
            }
            int Hour;
            Int32.TryParse(txtHour.Text, out Hour);
            if (!(Hour >= 0 && Hour <= 23))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار ساعت وارد شده معتبر نمیباشد" + Environment.NewLine + "مقادیر معتبر بین 0 تا 23 میباشد");
                }

                return false;
            }
            return true;
        }

        private void TimPicker_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinute_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatetxtMinute();
        }

        private bool ValidatetxtMinute(bool ShowMessage = true)
        {
            if (txtMinute.Text == "")
            {
                return true;
            }
            int Minute;
            Int32.TryParse(txtMinute.Text, out Minute);
            if (!(Minute >= 0 && Minute <= 59))
            {
                if (ShowMessage )
                {
                    MessageBox.Show("مقدار دقيقه وارد شده معتبر نمیباشد" + Environment.NewLine + "مقادیر معتبر بین 0 تا 59 میباشد");
                }

                return false;
            }
            return true;
        }

        private void txtSecond_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidatetxtSecond();
        }

        private bool ValidatetxtSecond(bool ShowMessage = true)
        {
            if (txtSecond.Text == "")
            {
                return true;
            }
            int Second;
            Int32.TryParse(txtSecond.Text, out Second);
            if (!(Second >= 0 && Second <= 59))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار ثانيه وارد شده معتبر نمیباشد" + Environment.NewLine + "مقادیر معتبر بین 0 تا 59 میباشد");
                }

                return false;
            }
            return true;
        }

        private void mnuFirstTime_Click(object sender, EventArgs e)
        {
            txtHour.Text = "00";
            txtMinute.Text = "00";
            txtSecond.Text = "00";

        }
        private void mnuNow_Click(object sender, EventArgs e)
        {
            txtHour.Text = DateTime.Now.ToString("hh");
            txtMinute.Text = DateTime.Now.ToString("mm");
            txtSecond.Text = DateTime.Now.ToString("ss");
        }

        private void mnuEndTime_Click(object sender, EventArgs e)
        {
            txtHour.Text = "23";
            txtMinute.Text = "59";
            txtSecond.Text = "59";
        }

        private void txtHour_TextChanged(object sender, EventArgs e)
        {
            RaiseEventTimeChanged();

        }

        private void RaiseEventTimeChanged()
        {
            if (ValidateControl(false)==false)
            {
                return;
            }
            if (TimeChanged !=null)
            {
                TimeChangedEventArgs timeChangedEventArgs = new TimeChangedEventArgs();
                timeChangedEventArgs.Value = this.Value;
                TimeChanged(this, timeChangedEventArgs);
            }
        }

        private bool ValidateControl(bool ShowMessage)
        {
            if (txtHour.Text == "" && (txtMinute.Text != "" || txtSecond.Text != ""))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار زمان معتبر نيست");
                }
                return false;
            }
            if (txtMinute.Text == "" && (txtHour.Text != "" || txtSecond.Text != ""))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار زمان معتبر نيست");
                }
                return false;
            }
            if (txtSecond.Text == "" && (txtMinute.Text != "" || txtHour.Text != ""))
            {
                if (ShowMessage)
                {
                    MessageBox.Show("مقدار زمان معتبر نيست");
                }
                return false;
            }
            if (ValidatetxtHour(false) == false)
            {
                return false;
            }
            if (ValidatetxtMinute(false) == false)
            {
                return false;
            }
            if (ValidatetxtSecond(false) == false)
            {
                return false;
            }
            return true;
        }

        private void txtHour_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtHour.Text == "")
            {
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (Int32.Parse(txtHour.Text) >=23 )
                {
                    return;
                }
                txtHour.Text = (Int32.Parse(txtHour.Text) + 1).ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Int32.Parse(txtHour.Text) <= 0)
                {
                    return;
                }
                txtHour.Text = (Int32.Parse(txtHour.Text) - 1).ToString();
            }
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            RaiseEventTimeChanged();
        }

        private void txtMinute_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMinute.Text == "")
            {
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (Int32.Parse(txtMinute.Text) >= 59)
                {
                    return;
                }
                txtMinute.Text = (Int32.Parse(txtMinute.Text) + 1).ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Int32.Parse(txtMinute.Text) <= 0)
                {
                    return;
                }
                txtMinute.Text = (Int32.Parse(txtMinute.Text) - 1).ToString();
            }
        }

        private void txtSecond_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSecond.Text == "")
            {
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (Int32.Parse(txtSecond.Text) >= 59)
                {
                    return;
                }
                txtSecond.Text = (Int32.Parse(txtSecond.Text) + 1).ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Int32.Parse(txtSecond.Text) <= 0)
                {
                    return;
                }
                txtSecond.Text = (Int32.Parse(txtSecond.Text) - 1).ToString();
            }
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            RaiseEventTimeChanged();
        }
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            txtHour.Text = "";
            txtMinute.Text = "";
            txtSecond.Text = "";
        }

        private void PersianTimPicker_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !ValidateControl(true);
        }
    }

    public class TimeChangedEventArgs
    {
        public string Value;
    }
}
