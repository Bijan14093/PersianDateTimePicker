namespace PersianDateTimeControl
{
    partial class PersianDatePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSelectDate = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuToday = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFirstDayofMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLastDayofMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowCalender = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.sep1 = new System.Windows.Forms.TextBox();
            this.sep2 = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.mnuMain.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.ContextMenuStrip = this.mnuMain;
            this.btnSelectDate.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectDate.Location = new System.Drawing.Point(0, 0);
            this.btnSelectDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(21, 19);
            this.btnSelectDate.TabIndex = 0;
            this.btnSelectDate.Text = "...";
            this.btnSelectDate.UseVisualStyleBackColor = true;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            this.btnSelectDate.Enter += new System.EventHandler(this.btnSelectDate_Enter);
            this.btnSelectDate.Validating += new System.ComponentModel.CancelEventHandler(this.btnSelectDate_Validating);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToday,
            this.mnuEmpty,
            this.mnuFirstDayofMonth,
            this.mnuLastDayofMonth,
            this.mnuShowCalender});
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(216, 114);
            this.mnuMain.Opening += new System.ComponentModel.CancelEventHandler(this.mnuMain_Opening);
            // 
            // mnuToday
            // 
            this.mnuToday.Name = "mnuToday";
            this.mnuToday.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.mnuToday.Size = new System.Drawing.Size(215, 22);
            this.mnuToday.Text = "تاریخ امروز";
            this.mnuToday.Click += new System.EventHandler(this.mnuToday_Click);
            // 
            // mnuEmpty
            // 
            this.mnuEmpty.Name = "mnuEmpty";
            this.mnuEmpty.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnuEmpty.Size = new System.Drawing.Size(215, 22);
            this.mnuEmpty.Text = "خالی";
            this.mnuEmpty.Click += new System.EventHandler(this.mnuEmpty_Click);
            // 
            // mnuFirstDayofMonth
            // 
            this.mnuFirstDayofMonth.Name = "mnuFirstDayofMonth";
            this.mnuFirstDayofMonth.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Home)));
            this.mnuFirstDayofMonth.Size = new System.Drawing.Size(215, 22);
            this.mnuFirstDayofMonth.Text = "ابتدای ماه جاری";
            this.mnuFirstDayofMonth.Click += new System.EventHandler(this.mnuFirstDayofMonth_Click);
            // 
            // mnuLastDayofMonth
            // 
            this.mnuLastDayofMonth.Name = "mnuLastDayofMonth";
            this.mnuLastDayofMonth.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.mnuLastDayofMonth.Size = new System.Drawing.Size(215, 22);
            this.mnuLastDayofMonth.Text = "انتهای ماه جاری";
            this.mnuLastDayofMonth.Click += new System.EventHandler(this.mnuLastDayofMonth_Click);
            // 
            // mnuShowCalender
            // 
            this.mnuShowCalender.Name = "mnuShowCalender";
            this.mnuShowCalender.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuShowCalender.Size = new System.Drawing.Size(215, 22);
            this.mnuShowCalender.Text = "مشاهده تفویم";
            this.mnuShowCalender.Click += new System.EventHandler(this.mnuShowCalender_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonth.ContextMenuStrip = this.mnuMain;
            this.txtMonth.Location = new System.Drawing.Point(33, 3);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(0);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Multiline = true;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ShortcutsEnabled = false;
            this.txtMonth.Size = new System.Drawing.Size(15, 15);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            this.txtMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonth_KeyDown);
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            this.txtMonth.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonth_Validating);
            this.txtMonth.Validated += new System.EventHandler(this.txtMonth_Validated);
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDate.Controls.Add(this.sep1);
            this.pnlDate.Controls.Add(this.sep2);
            this.pnlDate.Controls.Add(this.txtDay);
            this.pnlDate.Controls.Add(this.txtYear);
            this.pnlDate.Controls.Add(this.txtMonth);
            this.pnlDate.Location = new System.Drawing.Point(21, 0);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(72, 19);
            this.pnlDate.TabIndex = 1;
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sep1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sep1.Enabled = false;
            this.sep1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sep1.HideSelection = false;
            this.sep1.Location = new System.Drawing.Point(28, 0);
            this.sep1.Margin = new System.Windows.Forms.Padding(0);
            this.sep1.Multiline = true;
            this.sep1.Name = "sep1";
            this.sep1.ReadOnly = true;
            this.sep1.Size = new System.Drawing.Size(7, 15);
            this.sep1.TabIndex = 2;
            this.sep1.TabStop = false;
            this.sep1.Text = "/";
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sep2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sep2.Enabled = false;
            this.sep2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sep2.Location = new System.Drawing.Point(47, 0);
            this.sep2.Margin = new System.Windows.Forms.Padding(0);
            this.sep2.Multiline = true;
            this.sep2.Name = "sep2";
            this.sep2.ReadOnly = true;
            this.sep2.ShortcutsEnabled = false;
            this.sep2.Size = new System.Drawing.Size(7, 15);
            this.sep2.TabIndex = 3;
            this.sep2.TabStop = false;
            this.sep2.Text = "/";
            this.sep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDay
            // 
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDay.ContextMenuStrip = this.mnuMain;
            this.txtDay.Location = new System.Drawing.Point(54, 3);
            this.txtDay.Margin = new System.Windows.Forms.Padding(0);
            this.txtDay.MaxLength = 2;
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.ShortcutsEnabled = false;
            this.txtDay.Size = new System.Drawing.Size(15, 15);
            this.txtDay.TabIndex = 3;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            this.txtDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDay_KeyDown);
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            this.txtDay.Validating += new System.ComponentModel.CancelEventHandler(this.txtDay_Validating);
            this.txtDay.Validated += new System.EventHandler(this.txtDay_Validated);
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.ContextMenuStrip = this.mnuMain;
            this.txtYear.Location = new System.Drawing.Point(2, 3);
            this.txtYear.Margin = new System.Windows.Forms.Padding(0);
            this.txtYear.MaxLength = 4;
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.ShortcutsEnabled = false;
            this.txtYear.Size = new System.Drawing.Size(25, 15);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // PersianDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.btnSelectDate);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximumSize = new System.Drawing.Size(93, 19);
            this.MinimumSize = new System.Drawing.Size(93, 19);
            this.Name = "PersianDatePicker";
            this.Size = new System.Drawing.Size(93, 19);
            this.Load += new System.EventHandler(this.PersianDatePicker_Load);
            this.Enter += new System.EventHandler(this.PersianDatePicker_Enter);
            this.Leave += new System.EventHandler(this.PersianDatePicker_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.PersianDatePicker_Validating);
            this.mnuMain.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectDate;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.TextBox sep1;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox sep2;
        private System.Windows.Forms.ContextMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuToday;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpty;
        private System.Windows.Forms.ToolStripMenuItem mnuShowCalender;
        private System.Windows.Forms.ToolStripMenuItem mnuFirstDayofMonth;
        private System.Windows.Forms.ToolStripMenuItem mnuLastDayofMonth;
    }
}
