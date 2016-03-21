namespace MIDI_Editor_V2._0
{
    partial class DeleteTrack
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
            this.lBTracks = new System.Windows.Forms.ListBox();
            this.butDeleteTrack = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBTracks
            // 
            this.lBTracks.FormattingEnabled = true;
            this.lBTracks.ItemHeight = 20;
            this.lBTracks.Location = new System.Drawing.Point(13, 69);
            this.lBTracks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lBTracks.Name = "lBTracks";
            this.lBTracks.Size = new System.Drawing.Size(312, 184);
            this.lBTracks.TabIndex = 0;
           
            // 
            // butDeleteTrack
            // 
            this.butDeleteTrack.Location = new System.Drawing.Point(13, 275);
            this.butDeleteTrack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDeleteTrack.Name = "butDeleteTrack";
            this.butDeleteTrack.Size = new System.Drawing.Size(112, 35);
            this.butDeleteTrack.TabIndex = 1;
            this.butDeleteTrack.Text = "Видалити";
            this.butDeleteTrack.UseVisualStyleBackColor = true;
            this.butDeleteTrack.Click += new System.EventHandler(this.butDeleteTrack_Click);
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(213, 275);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(112, 35);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Controls.Add(this.panel2);
            this.panelFrame.Location = new System.Drawing.Point(0, -2);
            this.panelFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(332, 32);
            this.panelFrame.TabIndex = 3;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(298, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(34, 32);
            this.panelClose.TabIndex = 1;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 32);
            this.panel2.TabIndex = 0;
            // 
            // DeleteTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.fdeletetrack;
            this.ClientSize = new System.Drawing.Size(333, 328);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.butDeleteTrack);
            this.Controls.Add(this.lBTracks);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteTrack";
            this.Text = "DeleteTrack";
            this.Load += new System.EventHandler(this.DeleteTrack_Load);
            this.panelFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBTracks;
        private System.Windows.Forms.Button butDeleteTrack;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panel2;
    }
}