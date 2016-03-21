namespace MIDI_Editor_V2._0
{
    partial class FormCreateTrack
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
            this.tBCreateTrack = new System.Windows.Forms.TextBox();
            this.cBInstruments = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBCreateTrack
            // 
            this.tBCreateTrack.Location = new System.Drawing.Point(13, 67);
            this.tBCreateTrack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBCreateTrack.Name = "tBCreateTrack";
            this.tBCreateTrack.Size = new System.Drawing.Size(210, 26);
            this.tBCreateTrack.TabIndex = 0;
            // 
            // cBInstruments
            // 
            this.cBInstruments.FormattingEnabled = true;
            this.cBInstruments.Location = new System.Drawing.Point(13, 123);
            this.cBInstruments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBInstruments.Name = "cBInstruments";
            this.cBInstruments.Size = new System.Drawing.Size(180, 28);
            this.cBInstruments.TabIndex = 1;
            this.cBInstruments.SelectedIndexChanged += new System.EventHandler(this.cBInstruments_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(368, 277);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(231, 42);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(356, 225);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва треку";
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Controls.Add(this.panel1);
            this.panelFrame.Location = new System.Drawing.Point(-3, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(602, 34);
            this.panelFrame.TabIndex = 5;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelClose.Location = new System.Drawing.Point(565, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(37, 34);
            this.panelClose.TabIndex = 1;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 34);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Інструмент";
            // 
            // FormCreateTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.fcrtrack;
            this.ClientSize = new System.Drawing.Size(600, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cBInstruments);
            this.Controls.Add(this.tBCreateTrack);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCreateTrack";
            this.Text = "FormCreateTrack";
            this.Load += new System.EventHandler(this.FormCreateTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBCreateTrack;
        private System.Windows.Forms.ComboBox cBInstruments;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label label2;
    }
}