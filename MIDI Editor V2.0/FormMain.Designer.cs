namespace MIDI_Editor_V2._0
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.H = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNoteEditorStart = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.mainPanel;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.H);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1366, 32);
            this.panelMain.TabIndex = 2;
            this.panelMain.DoubleClick += new System.EventHandler(this.panelMain_DoubleClick);
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MIDI Editor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 32);
            this.panel1.TabIndex = 2;
            // 
            // H
            // 
            this.H.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.H.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("H.BackgroundImage")));
            this.H.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.H.Location = new System.Drawing.Point(1310, 0);
            this.H.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(28, 32);
            this.H.TabIndex = 1;
            this.H.UseVisualStyleBackColor = false;
            this.H.Click += new System.EventHandler(this.buttonHide_Click);
            this.H.MouseEnter += new System.EventHandler(this.buttonHide_MouseEnter);
            this.H.MouseLeave += new System.EventHandler(this.buttonHide_MouseLeave);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.X.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("X.BackgroundImage")));
            this.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.Location = new System.Drawing.Point(1341, 0);
            this.X.Margin = new System.Windows.Forms.Padding(0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(25, 32);
            this.X.TabIndex = 0;
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseEnter += new System.EventHandler(this.X_MouseEnter);
            this.X.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            // 
            // lblChoose
            // 
            this.lblChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblChoose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChoose.Image = global::MIDI_Editor_V2._0.Properties.Resources.LabelFormMain;
            this.lblChoose.Location = new System.Drawing.Point(1062, 87);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(276, 53);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "Перегляд вже існуючих пісень та композиторів.\r\n";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoose.Click += new System.EventHandler(this.lblChoose_Click);
            this.lblChoose.MouseEnter += new System.EventHandler(this.lblChoose_MouseEnter);
            this.lblChoose.MouseLeave += new System.EventHandler(this.lblChoose_MouseLeave);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbout.Location = new System.Drawing.Point(1236, 739);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(118, 20);
            this.lblAbout.TabIndex = 7;
            this.lblAbout.Text = "Про програму";
            this.lblAbout.MouseEnter += new System.EventHandler(this.lblAbout_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.main;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(73, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1105, 513);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblNoteEditorStart
            // 
            this.lblNoteEditorStart.BackColor = System.Drawing.Color.Transparent;
            this.lblNoteEditorStart.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNoteEditorStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoteEditorStart.Image = global::MIDI_Editor_V2._0.Properties.Resources.noteeditorbckgr;
            this.lblNoteEditorStart.Location = new System.Drawing.Point(357, 121);
            this.lblNoteEditorStart.Name = "lblNoteEditorStart";
            this.lblNoteEditorStart.Size = new System.Drawing.Size(488, 44);
            this.lblNoteEditorStart.TabIndex = 9;
            this.lblNoteEditorStart.Text = "Нотний редактор";
            this.lblNoteEditorStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoteEditorStart.Click += new System.EventHandler(this.lblNoteEditorStart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblNoteEditorStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.X);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNoteEditorStart;
    }
}

