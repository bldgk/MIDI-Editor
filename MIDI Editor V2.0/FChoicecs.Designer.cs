namespace MIDI_Editor_V2._0
{
    partial class FChoicecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChoicecs));
            this.panel_Close = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_perf = new System.Windows.Forms.Label();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.pnlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Close
            // 
            this.panel_Close.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panel_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Close.Location = new System.Drawing.Point(458, 4);
            this.panel_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Close.Name = "panel_Close";
            this.panel_Close.Size = new System.Drawing.Size(38, 31);
            this.panel_Close.TabIndex = 2;
            this.panel_Close.Click += new System.EventHandler(this.panel_Close_Click);
            this.panel_Close.MouseEnter += new System.EventHandler(this.panel_Close_MouseEnter);
            this.panel_Close.MouseLeave += new System.EventHandler(this.panel_Close_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 31);
            this.panel2.TabIndex = 3;
            // 
            // pnlFrame
            // 
            this.pnlFrame.BackColor = System.Drawing.Color.Transparent;
            this.pnlFrame.Controls.Add(this.label1);
            this.pnlFrame.Controls.Add(this.panel_Close);
            this.pnlFrame.Controls.Add(this.panel2);
            this.pnlFrame.Location = new System.Drawing.Point(3, -2);
            this.pnlFrame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(496, 35);
            this.pnlFrame.TabIndex = 4;
            this.pnlFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFrame_MouseDown);
            this.pnlFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFrame_MouseMove);
            this.pnlFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlFrame_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вибір вже існуючих пісень";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.photofc;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(46, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 342);
            this.panel1.TabIndex = 5;
            // 
            // lbl_perf
            // 
            this.lbl_perf.BackColor = System.Drawing.Color.Transparent;
            this.lbl_perf.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_perf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_perf.Image = global::MIDI_Editor_V2._0.Properties.Resources.fch1;
            this.lbl_perf.Location = new System.Drawing.Point(254, 37);
            this.lbl_perf.Name = "lbl_perf";
            this.lbl_perf.Size = new System.Drawing.Size(245, 33);
            this.lbl_perf.TabIndex = 6;
            this.lbl_perf.Text = "Виконавці";
            this.lbl_perf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_perf.Click += new System.EventHandler(this.lbl_perf_Click);
            this.lbl_perf.MouseEnter += new System.EventHandler(this.lbl_perf_MouseEnter);
            this.lbl_perf.MouseLeave += new System.EventHandler(this.lbl_perf_MouseLeave);
            // 
            // lbl_comp
            // 
            this.lbl_comp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_comp.Image = global::MIDI_Editor_V2._0.Properties.Resources.fch1;
            this.lbl_comp.Location = new System.Drawing.Point(6, 37);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(240, 33);
            this.lbl_comp.TabIndex = 7;
            this.lbl_comp.Text = "Композиції";
            this.lbl_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_comp.Click += new System.EventHandler(this.lbl_comp_Click);
            this.lbl_comp.MouseEnter += new System.EventHandler(this.lbl_comp_MouseEnter);
            this.lbl_comp.MouseLeave += new System.EventHandler(this.lbl_comp_MouseLeave);
            // 
            // FChoicecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.backFChn;
            this.ClientSize = new System.Drawing.Size(506, 513);
            this.Controls.Add(this.lbl_comp);
            this.Controls.Add(this.lbl_perf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFrame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FChoicecs";
            this.Text = "Перегляд вже існуючих пісень";
            this.pnlFrame.ResumeLayout(false);
            this.pnlFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_perf;
        private System.Windows.Forms.Label lbl_comp;
    }
}