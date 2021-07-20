using System;

namespace PersianDateTimeControl
{
    partial class PersianTimPicker
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
            this.pnlTime = new System.Windows.Forms.Panel();
            this.mnuMainTime = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEndTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.sep1 = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.pnlTime.SuspendLayout();
            this.mnuMainTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTime.ContextMenuStrip = this.mnuMainTime;
            this.pnlTime.Controls.Add(this.sep2);
            this.pnlTime.Controls.Add(this.txtSecond);
            this.pnlTime.Controls.Add(this.sep1);
            this.pnlTime.Controls.Add(this.txtMinute);
            this.pnlTime.Controls.Add(this.txtHour);
            this.pnlTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlTime.Location = new System.Drawing.Point(0, 0);
            this.pnlTime.MaximumSize = new System.Drawing.Size(55, 19);
            this.pnlTime.MinimumSize = new System.Drawing.Size(55, 19);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(55, 19);
            this.pnlTime.TabIndex = 14;
            // 
            // mnuMainTime
            // 
            this.mnuMainTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFirstTime,
            this.mnuNow,
            this.mnuEndTime,
            this.mnu_Delete});
            this.mnuMainTime.Name = "contextMenuStrip1";
            this.mnuMainTime.Size = new System.Drawing.Size(197, 92);
            // 
            // mnuFirstTime
            // 
            this.mnuFirstTime.Name = "mnuFirstTime";
            this.mnuFirstTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Home)));
            this.mnuFirstTime.Size = new System.Drawing.Size(196, 22);
            this.mnuFirstTime.Text = "ابتداي روز";
            this.mnuFirstTime.Click += new System.EventHandler(this.mnuFirstTime_Click);
            // 
            // mnuNow
            // 
            this.mnuNow.Name = "mnuNow";
            this.mnuNow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.mnuNow.Size = new System.Drawing.Size(196, 22);
            this.mnuNow.Text = "همين لحظه";
            this.mnuNow.Click += new System.EventHandler(this.mnuNow_Click);
            // 
            // mnuEndTime
            // 
            this.mnuEndTime.Name = "mnuEndTime";
            this.mnuEndTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.mnuEndTime.Size = new System.Drawing.Size(196, 22);
            this.mnuEndTime.Text = "انتهاي روز";
            this.mnuEndTime.Click += new System.EventHandler(this.mnuEndTime_Click);
            // 
            // mnu_Delete
            // 
            this.mnu_Delete.Name = "mnu_Delete";
            this.mnu_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnu_Delete.Size = new System.Drawing.Size(196, 22);
            this.mnu_Delete.Text = "خالي";
            this.mnu_Delete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sep2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sep2.Enabled = false;
            this.sep2.Location = new System.Drawing.Point(33, 3);
            this.sep2.Margin = new System.Windows.Forms.Padding(0);
            this.sep2.Multiline = true;
            this.sep2.Name = "sep2";
            this.sep2.ReadOnly = true;
            this.sep2.ShortcutsEnabled = false;
            this.sep2.Size = new System.Drawing.Size(6, 15);
            this.sep2.TabIndex = 18;
            this.sep2.TabStop = false;
            this.sep2.Text = ":";
            this.sep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecond
            // 
            this.txtSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecond.ContextMenuStrip = this.mnuMainTime;
            this.txtSecond.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSecond.Location = new System.Drawing.Point(38, 3);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(0);
            this.txtSecond.MaxLength = 2;
            this.txtSecond.Multiline = true;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.ShortcutsEnabled = false;
            this.txtSecond.Size = new System.Drawing.Size(15, 15);
            this.txtSecond.TabIndex = 17;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecond_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecond_KeyPress);
            this.txtSecond.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecond_Validating);
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sep1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sep1.Enabled = false;
            this.sep1.Location = new System.Drawing.Point(15, 3);
            this.sep1.Margin = new System.Windows.Forms.Padding(0);
            this.sep1.Multiline = true;
            this.sep1.Name = "sep1";
            this.sep1.ReadOnly = true;
            this.sep1.ShortcutsEnabled = false;
            this.sep1.Size = new System.Drawing.Size(6, 15);
            this.sep1.TabIndex = 16;
            this.sep1.TabStop = false;
            this.sep1.Text = ":";
            this.sep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinute
            // 
            this.txtMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinute.ContextMenuStrip = this.mnuMainTime;
            this.txtMinute.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMinute.Location = new System.Drawing.Point(20, 3);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(0);
            this.txtMinute.MaxLength = 2;
            this.txtMinute.Multiline = true;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.ShortcutsEnabled = false;
            this.txtMinute.Size = new System.Drawing.Size(15, 15);
            this.txtMinute.TabIndex = 15;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinute.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinute_KeyDown);
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinute_KeyPress);
            this.txtMinute.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinute_Validating);
            // 
            // txtHour
            // 
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHour.ContextMenuStrip = this.mnuMainTime;
            this.txtHour.Location = new System.Drawing.Point(1, 3);
            this.txtHour.Margin = new System.Windows.Forms.Padding(0);
            this.txtHour.MaxLength = 2;
            this.txtHour.Multiline = true;
            this.txtHour.Name = "txtHour";
            this.txtHour.ShortcutsEnabled = false;
            this.txtHour.Size = new System.Drawing.Size(15, 15);
            this.txtHour.TabIndex = 14;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.TextChanged += new System.EventHandler(this.txtHour_TextChanged);
            this.txtHour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHour_KeyDown);
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHour_KeyPress);
            this.txtHour.Validating += new System.ComponentModel.CancelEventHandler(this.txtHour_Validating);
            // 
            // PersianTimPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTime);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(55, 19);
            this.MinimumSize = new System.Drawing.Size(55, 19);
            this.Name = "PersianTimPicker";
            this.Size = new System.Drawing.Size(55, 19);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimPicker_KeyPress);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.PersianTimPicker_Validating);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.mnuMainTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.TextBox sep1;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox sep2;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.ContextMenuStrip mnuMainTime;
        private System.Windows.Forms.ToolStripMenuItem mnuFirstTime;
        private System.Windows.Forms.ToolStripMenuItem mnuNow;
        private System.Windows.Forms.ToolStripMenuItem mnuEndTime;
        private System.Windows.Forms.ToolStripMenuItem mnu_Delete;
    }
}
