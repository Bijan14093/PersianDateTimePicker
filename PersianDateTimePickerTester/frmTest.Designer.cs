using PersianDateTimeControl;

namespace PersianDateTimeControlTester
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDateChangeF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateChangeAF = new System.Windows.Forms.TextBox();
            this.txtDateChangeM = new System.Windows.Forms.TextBox();
            this.txtDateChangeAM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.persianTimPicker1 = new PersianDateTimeControl.PersianTimPicker();
            this.persianDatePicker1 = new PersianDateTimeControl.PersianDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateTimechangedtext = new System.Windows.Forms.TextBox();
            this.txtDateTimechangedvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.persianDateTimePicker1 = new PersianDateTimeControl.PersianDateTimePicker();
            this.SuspendLayout();
            // 
            // txtDateChangeF
            // 
            this.txtDateChangeF.Location = new System.Drawing.Point(147, 53);
            this.txtDateChangeF.Name = "txtDateChangeF";
            this.txtDateChangeF.Size = new System.Drawing.Size(100, 20);
            this.txtDateChangeF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DateChanged";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DateChangedAfterLeave";
            // 
            // txtDateChangeAF
            // 
            this.txtDateChangeAF.Location = new System.Drawing.Point(403, 53);
            this.txtDateChangeAF.Name = "txtDateChangeAF";
            this.txtDateChangeAF.Size = new System.Drawing.Size(100, 20);
            this.txtDateChangeAF.TabIndex = 3;
            // 
            // txtDateChangeM
            // 
            this.txtDateChangeM.Location = new System.Drawing.Point(253, 53);
            this.txtDateChangeM.Name = "txtDateChangeM";
            this.txtDateChangeM.Size = new System.Drawing.Size(100, 20);
            this.txtDateChangeM.TabIndex = 5;
            // 
            // txtDateChangeAM
            // 
            this.txtDateChangeAM.Location = new System.Drawing.Point(509, 53);
            this.txtDateChangeAM.Name = "txtDateChangeAM";
            this.txtDateChangeAM.Size = new System.Drawing.Size(100, 20);
            this.txtDateChangeAM.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TimeChanged";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(225, 105);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(619, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // persianTimPicker1
            // 
            this.persianTimPicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianTimPicker1.Location = new System.Drawing.Point(12, 92);
            this.persianTimPicker1.MaximumSize = new System.Drawing.Size(55, 19);
            this.persianTimPicker1.MinimumSize = new System.Drawing.Size(55, 19);
            this.persianTimPicker1.Name = "persianTimPicker1";
            this.persianTimPicker1.Size = new System.Drawing.Size(55, 19);
            this.persianTimPicker1.TabIndex = 9;
            this.persianTimPicker1.Value = "";
            this.persianTimPicker1.TimeChanged += new PersianDateTimeControl.PersianTimPicker.TimeChangedEvent(this.persianTimPicker1_TimeChanged);
            // 
            // persianDatePicker1
            // 
            this.persianDatePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDatePicker1.Location = new System.Drawing.Point(12, 53);
            this.persianDatePicker1.MaximumSize = new System.Drawing.Size(93, 19);
            this.persianDatePicker1.MinimumSize = new System.Drawing.Size(93, 19);
            this.persianDatePicker1.Name = "persianDatePicker1";
            this.persianDatePicker1.Size = new System.Drawing.Size(93, 19);
            this.persianDatePicker1.TabIndex = 7;
            this.persianDatePicker1.Value = null;
            this.persianDatePicker1.DateChanged += new PersianDateTimeControl.PersianDatePicker.DateChangedEvent(this.persianDatePicker1_DateChanged_2);
            this.persianDatePicker1.Leave += new System.EventHandler(this.persianDatePicker1_Leave_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DatetimeChanged";
            // 
            // txtDateTimechangedtext
            // 
            this.txtDateTimechangedtext.Location = new System.Drawing.Point(160, 176);
            this.txtDateTimechangedtext.Name = "txtDateTimechangedtext";
            this.txtDateTimechangedtext.Size = new System.Drawing.Size(165, 20);
            this.txtDateTimechangedtext.TabIndex = 14;
            // 
            // txtDateTimechangedvalue
            // 
            this.txtDateTimechangedvalue.Location = new System.Drawing.Point(331, 176);
            this.txtDateTimechangedvalue.Name = "txtDateTimechangedvalue";
            this.txtDateTimechangedvalue.Size = new System.Drawing.Size(172, 20);
            this.txtDateTimechangedvalue.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(619, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // persianDateTimePicker1
            // 
            this.persianDateTimePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimePicker1.Location = new System.Drawing.Point(12, 144);
            this.persianDateTimePicker1.MaximumSize = new System.Drawing.Size(148, 19);
            this.persianDateTimePicker1.MinimumSize = new System.Drawing.Size(148, 19);
            this.persianDateTimePicker1.Name = "persianDateTimePicker1";
            this.persianDateTimePicker1.Size = new System.Drawing.Size(148, 19);
            this.persianDateTimePicker1.TabIndex = 18;
            this.persianDateTimePicker1.DateTimeChanged += new PersianDateTimeControl.PersianDateTimePicker.DateTimeChangedEvent(this.persianDateTimePicker1_DateTimeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 205);
            this.Controls.Add(this.persianDateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateTimechangedvalue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDateTimechangedtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.persianTimPicker1);
            this.Controls.Add(this.persianDatePicker1);
            this.Controls.Add(this.txtDateChangeAM);
            this.Controls.Add(this.txtDateChangeM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateChangeAF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateChangeF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDateChangeF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateChangeAF;
        private System.Windows.Forms.TextBox txtDateChangeM;
        private System.Windows.Forms.TextBox txtDateChangeAM;
        private PersianDatePicker persianDatePicker1;
        private PersianTimPicker persianTimPicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateTimechangedtext;
        private System.Windows.Forms.TextBox txtDateTimechangedvalue;
        private System.Windows.Forms.Label label3;
        private PersianDateTimePicker persianDateTimePicker1;
    }
}

