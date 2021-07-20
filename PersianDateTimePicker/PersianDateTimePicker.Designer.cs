namespace PersianDateTimeControl
{
    partial class PersianDateTimePicker
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
            this.persianDatePicker1 = new PersianDateTimeControl.PersianDatePicker();
            this.persianTimPicker1 = new PersianDateTimeControl.PersianTimPicker();
            this.SuspendLayout();
            // 
            // persianDatePicker1
            // 
            this.persianDatePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDatePicker1.Location = new System.Drawing.Point(0, 0);
            this.persianDatePicker1.MaximumSize = new System.Drawing.Size(93, 19);
            this.persianDatePicker1.MinimumSize = new System.Drawing.Size(93, 19);
            this.persianDatePicker1.Name = "persianDatePicker1";
            this.persianDatePicker1.Size = new System.Drawing.Size(93, 19);
            this.persianDatePicker1.TabIndex = 0;
            this.persianDatePicker1.Value = null;
            this.persianDatePicker1.DateChanged += new PersianDateTimeControl.PersianDatePicker.DateChangedEvent(this.persianDatePicker1_DateChanged);
            // 
            // persianTimPicker1
            // 
            this.persianTimPicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianTimPicker1.Location = new System.Drawing.Point(93, 0);
            this.persianTimPicker1.MaximumSize = new System.Drawing.Size(55, 19);
            this.persianTimPicker1.MinimumSize = new System.Drawing.Size(55, 19);
            this.persianTimPicker1.Name = "persianTimPicker1";
            this.persianTimPicker1.Size = new System.Drawing.Size(55, 19);
            this.persianTimPicker1.TabIndex = 1;
            this.persianTimPicker1.Value = "";
            this.persianTimPicker1.TimeChanged += new PersianDateTimeControl.PersianTimPicker.TimeChangedEvent(this.persianTimPicker1_TimeChanged);
            // 
            // PersianDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.persianTimPicker1);
            this.Controls.Add(this.persianDatePicker1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximumSize = new System.Drawing.Size(148, 19);
            this.MinimumSize = new System.Drawing.Size(148, 19);
            this.Name = "PersianDateTimePicker";
            this.Size = new System.Drawing.Size(148, 19);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.PersianDateTimePicker_Validating);
            this.ResumeLayout(false);

        }

        #endregion

        private PersianDatePicker persianDatePicker1;
        private PersianTimPicker persianTimPicker1;
    }
}
