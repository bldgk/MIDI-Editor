namespace MIDI_Editor_V2._0
{
    partial class FChooseComp
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
            this.listBoxComps = new System.Windows.Forms.ListBox();
            this.lblIfIsnt = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxComps
            // 
            this.listBoxComps.FormattingEnabled = true;
            this.listBoxComps.ItemHeight = 17;
            this.listBoxComps.Location = new System.Drawing.Point(32, 48);
            this.listBoxComps.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxComps.Name = "listBoxComps";
            this.listBoxComps.Size = new System.Drawing.Size(310, 191);
            this.listBoxComps.Sorted = true;
            this.listBoxComps.TabIndex = 0;
            // 
            // lblIfIsnt
            // 
            this.lblIfIsnt.AutoSize = true;
            this.lblIfIsnt.BackColor = System.Drawing.Color.Transparent;
            this.lblIfIsnt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIfIsnt.Location = new System.Drawing.Point(29, 274);
            this.lblIfIsnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIfIsnt.Name = "lblIfIsnt";
            this.lblIfIsnt.Size = new System.Drawing.Size(188, 17);
            this.lblIfIsnt.TabIndex = 1;
            this.lblIfIsnt.Text = "Композиції емає в списку?";
            this.lblIfIsnt.Click += new System.EventHandler(this.lblIfIsnt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(267, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ок";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Controls.Add(this.panel2);
            this.panelFrame.Location = new System.Drawing.Point(1, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(380, 28);
            this.panelFrame.TabIndex = 3;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(352, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(25, 28);
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
            this.panel2.Size = new System.Drawing.Size(29, 28);
            this.panel2.TabIndex = 0;
            // 
            // FChooseComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.fchoosetr;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblIfIsnt);
            this.Controls.Add(this.listBoxComps);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FChooseComp";
            this.Text = "FChooseComp";
            this.Load += new System.EventHandler(this.FChooseComp_Load);
            this.panelFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxComps;
        private System.Windows.Forms.Label lblIfIsnt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panel2;
    }
}