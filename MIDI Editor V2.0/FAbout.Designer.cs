namespace MIDI_Editor_V2._0
{
    partial class FAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAbout));
            this.panelFrame = new System.Windows.Forms.Panel();
            this.lblform = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.labelRun = new System.Windows.Forms.Label();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.lblform);
            this.panelFrame.Controls.Add(this.panel3);
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Location = new System.Drawing.Point(-1, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(505, 33);
            this.panelFrame.TabIndex = 0;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // lblform
            // 
            this.lblform.AutoSize = true;
            this.lblform.Location = new System.Drawing.Point(36, 9);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(118, 20);
            this.lblform.TabIndex = 2;
            this.lblform.Text = "Про програму";
            this.lblform.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblform_MouseDown);
            this.lblform.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblform_MouseMove);
            this.lblform.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblform_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 33);
            this.panel3.TabIndex = 1;
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(470, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(35, 33);
            this.panelClose.TabIndex = 0;
            this.panelClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Location = new System.Drawing.Point(25, 55);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(441, 169);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // labelRun
            // 
            this.labelRun.BackColor = System.Drawing.Color.Transparent;
            this.labelRun.Location = new System.Drawing.Point(136, 196);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(216, 39);
            this.labelRun.TabIndex = 2;
            this.labelRun.Text = "Управління програмою";
            this.labelRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRun.Click += new System.EventHandler(this.labelRun_Click);
            // 
            // FAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.fabout;
            this.ClientSize = new System.Drawing.Size(504, 244);
            this.Controls.Add(this.labelRun);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.panelFrame);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FAbout";
            this.Text = "FAbout";
            this.panelFrame.ResumeLayout(false);
            this.panelFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label labelRun;
    }
}