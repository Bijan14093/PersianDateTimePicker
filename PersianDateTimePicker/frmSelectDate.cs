using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace PersianDateTimeControl
{
    internal partial class frmSelectDate : Form
    {
        private DateTime? OrginalDate;
        private DateTime? CurrenSelectedDate;
        private DateTime? ReturnDate;
        private int m_Day, m_Month, m_Year;  //Current SelectedDate
        private PersianDate persianNow;  //Current Date
        private DateTime FirstDayofMonth;
        private DayOfWeek iDayOfWeek;
        public frmSelectDate()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            persianNow = Utility.GetPersianDate(DateTime.Now);

        }
        public DateTime? SelectDate(Point ParentLocation, DateTime? CurrentDateTime) 
        {
            this.Location = ParentLocation ;
            OrginalDate = CurrentDateTime;
            CurrenSelectedDate = CurrentDateTime;
            if (CurrenSelectedDate == null)
            {
                CurrenSelectedDate = DateTime.Now;
            }
            SetFormVariables();
            DrawCalender();
            ReturnDate = OrginalDate;
            this.ShowDialog();
            return ReturnDate;

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            CurrenSelectedDate = Utility.PersianCalendar.ToDateTime(m_Year, m_Month, m_Day, 0, 0, 0, 0);
            ReturnDate = CurrenSelectedDate;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            CurrenSelectedDate = null;
            ReturnDate = CurrenSelectedDate;
            this.Close();

        }
        private void upMonth_MouseDown(object sender, MouseEventArgs e)
        {
            RefreshUpAndDown();
            DrawCalender();
        }

        private void RefreshUpAndDown()
        {
            upYear.ReadOnly = true;

            if (upMonth.SelectedIndex < 1)
            {
                upYear.Value++;
                upMonth.SelectedIndex = 12;
            }
            else if (upMonth.SelectedIndex > 12)
            {
                upYear.Value--;
                upMonth.SelectedIndex = 1;
            }
            upYear.ReadOnly =false;

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            CurrenSelectedDate = DateTime.Now;
            persianNow = Utility.GetPersianDate((DateTime)CurrenSelectedDate);
            SetFormVariables();
            DrawCalender();
        }

        private void SetFormVariables()
        {
            PersianDate p = Utility.GetPersianDate((DateTime)CurrenSelectedDate);
            upYear.ReadOnly = true;
            upMonth.SelectedIndex = 13 - p.Month;
            upYear.Value = p.Year;
            m_Year = p.Year;
            m_Month = p.Month;
            m_Day = p.Day;
            upYear.ReadOnly = false;
        }

        private void upYear_ValueChanged(object sender, EventArgs e)
        {
            if (!upYear.ReadOnly)
            {
                DrawCalender();
            }

        }

        private void DrawCalender()
        {
            m_Year = (int)upYear.Value;
            var Month = 13 - upMonth.SelectedIndex;
            if (Month < 1 || Month > 12)
            {
                return;
            }
            m_Month = Month;
            var m_DaysInMonth = Utility.PersianCalendar.GetDaysInMonth(m_Year, m_Month);
            //First Day Of Month
            StringBuilder HFirstDay = new StringBuilder();
            HFirstDay.AppendFormat("{0}/{1}/1", m_Year, m_Month);
            FirstDayofMonth = Utility.GetDateTime(HFirstDay.ToString());
            iDayOfWeek = FirstDayofMonth.DayOfWeek;

            Dictionary<int, KeyValuePair<int, int>> FirstSevenDays = GenerateFirstSevenDaysPosition(m_Year, m_Month);

            dataGridView1.Rows.Clear();
            int length=4;
            if (m_DaysInMonth >= 30 && iDayOfWeek==DayOfWeek.Friday)
            {
                length = 5;
            }
            if (m_DaysInMonth >= 31 && iDayOfWeek >= DayOfWeek.Thursday)
            {
                length = 5;
            }
            for (int i = 0; i < length; i++)
            {
                dataGridView1.Rows.Add();
            }

            int Row = 0, Column = 0;
            KeyValuePair<int, int> firstSameDay;
            for (int day = 1; day <= m_DaysInMonth; day++)
            {
                //Find Row And Column Base on FirstSevenDay
                int tmp;
                int tmp2;
                tmp = (day % 7);
                if (tmp == 0)
                {
                    tmp = 7;
                    tmp2 = ((int)(day / 7)) - 1;
                }
                else
                {
                    tmp2 = (int)(day / 7);
                }
                firstSameDay = FirstSevenDays[tmp];
                Column = firstSameDay.Value;
                Row = firstSameDay.Key + tmp2;
                dataGridView1.Rows[Row - 1].Cells[Column - 1].Value = day;

                if (m_Day == day)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[Row - 1].Cells[Column - 1];
                }
                if ((persianNow.Day==day) && (persianNow.Month== m_Month) && (persianNow.Year==m_Year))
                {
                    dataGridView1.Rows[Row - 1].Cells[Column - 1].Style.BackColor = Color.WhiteSmoke;
                    dataGridView1.Rows[Row - 1].Cells[Column - 1].Style.ForeColor = Color.Green;
                }
                if (Isholiday(m_Year, m_Month, m_Day) || Column == 7)
                {
                    dataGridView1.Rows[Row - 1].Cells[Column - 1].Style.ForeColor = Color.DarkRed;
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_Day =(int)dataGridView1.CurrentCell.Value;
            CurrenSelectedDate = Utility.PersianCalendar.ToDateTime(m_Year, m_Month, m_Day, 0, 0, 0, 0);
            ReturnDate = CurrenSelectedDate;
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void upMonth_SelectedItemChanged(object sender, EventArgs e)
        {
            RefreshUpAndDown();
            DrawCalender();
        }

        private bool Isholiday(int m_Year, int m_Month, int m_Day)
        {
            return false;
        }

        private Dictionary<int, KeyValuePair<int, int>> GenerateFirstSevenDaysPosition(int m_Year, int m_Month)
        {
            Dictionary<int, KeyValuePair<int, int>> Result = new Dictionary<int, KeyValuePair<int, int>>();
            KeyValuePair<int, int> DayPostition;
            switch (iDayOfWeek)
            {
                case DayOfWeek.Saturday:
                    DayPostition = new KeyValuePair<int, int>(1, 1);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 2);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 3);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 4);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 5);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 6);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(7, DayPostition);
                    break;
                case DayOfWeek.Sunday:
                    DayPostition = new KeyValuePair<int, int>(1, 2);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 3);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 4);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 5);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 6);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 1);
                    Result.Add(7, DayPostition);
                    break;
                case DayOfWeek.Monday:
                    DayPostition = new KeyValuePair<int, int>(1, 3);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 4);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 5);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 6);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 1);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 2);
                    Result.Add(7, DayPostition);

                    break;
                case DayOfWeek.Tuesday:
                    DayPostition = new KeyValuePair<int, int>(1, 4);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 5);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 6);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 1);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 2);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 3);
                    Result.Add(7, DayPostition);
                    break;
                case DayOfWeek.Wednesday:
                    DayPostition = new KeyValuePair<int, int>(1, 5);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 6);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 1);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 2);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 3);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 4);
                    Result.Add(7, DayPostition);
                    break;
                case DayOfWeek.Thursday:
                    DayPostition = new KeyValuePair<int, int>(1, 6);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 1);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 2);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 3);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 4);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 5);
                    Result.Add(7, DayPostition);
                    break;
                case DayOfWeek.Friday:
                    DayPostition = new KeyValuePair<int, int>(1, 7);
                    Result.Add(1, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 1);
                    Result.Add(2, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 2);
                    Result.Add(3, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 3);
                    Result.Add(4, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 4);
                    Result.Add(5, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 5);
                    Result.Add(6, DayPostition);
                    DayPostition = new KeyValuePair<int, int>(2, 6);
                    Result.Add(7, DayPostition);
                    break;
                default:
                    break;
            }
            return Result;
        }
    }
}
