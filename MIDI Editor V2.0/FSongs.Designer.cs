namespace MIDI_Editor_V2._0
{
    partial class FSongs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSongs));
            this.lb_songs = new System.Windows.Forms.ListBox();
            this.label_album_comp = new System.Windows.Forms.Label();
            this.label_album_name = new System.Windows.Forms.Label();
            this.pb_comp = new System.Windows.Forms.PictureBox();
            this.lb_performers_in_comps = new System.Windows.Forms.ListBox();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_comp)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_songs
            // 
            this.lb_songs.FormattingEnabled = true;
            this.lb_songs.ItemHeight = 17;
            this.lb_songs.Location = new System.Drawing.Point(13, 76);
            this.lb_songs.Margin = new System.Windows.Forms.Padding(4);
            this.lb_songs.Name = "lb_songs";
            this.lb_songs.Size = new System.Drawing.Size(485, 276);
            this.lb_songs.Sorted = true;
            this.lb_songs.TabIndex = 0;
            this.lb_songs.SelectedIndexChanged += new System.EventHandler(this.lb_songs_SelectedIndexChanged);
            // 
            // label_album_comp
            // 
            this.label_album_comp.AutoSize = true;
            this.label_album_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_album_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_album_comp.Location = new System.Drawing.Point(705, 350);
            this.label_album_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_album_comp.Name = "label_album_comp";
            this.label_album_comp.Size = new System.Drawing.Size(0, 17);
            this.label_album_comp.TabIndex = 4;
            // 
            // label_album_name
            // 
            this.label_album_name.AutoSize = true;
            this.label_album_name.BackColor = System.Drawing.Color.Transparent;
            this.label_album_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_album_name.Location = new System.Drawing.Point(538, 350);
            this.label_album_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_album_name.Name = "label_album_name";
            this.label_album_name.Size = new System.Drawing.Size(59, 17);
            this.label_album_name.TabIndex = 6;
            this.label_album_name.Text = "Альбом";
            // 
            // pb_comp
            // 
            this.pb_comp.BackColor = System.Drawing.Color.Transparent;
            this.pb_comp.Location = new System.Drawing.Point(534, 49);
            this.pb_comp.Margin = new System.Windows.Forms.Padding(4);
            this.pb_comp.Name = "pb_comp";
            this.pb_comp.Size = new System.Drawing.Size(516, 282);
            this.pb_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_comp.TabIndex = 9;
            this.pb_comp.TabStop = false;
            // 
            // lb_performers_in_comps
            // 
            this.lb_performers_in_comps.FormattingEnabled = true;
            this.lb_performers_in_comps.ItemHeight = 17;
            this.lb_performers_in_comps.Location = new System.Drawing.Point(13, 395);
            this.lb_performers_in_comps.Margin = new System.Windows.Forms.Padding(4);
            this.lb_performers_in_comps.Name = "lb_performers_in_comps";
            this.lb_performers_in_comps.Size = new System.Drawing.Size(485, 140);
            this.lb_performers_in_comps.TabIndex = 12;
            // 
            // panelFrame
            // 
            this.panelFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.mainPanel;
            this.panelFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrame.Controls.Add(this.label1);
            this.panelFrame.Controls.Add(this.panel3);
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Location = new System.Drawing.Point(-1, -2);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(1066, 36);
            this.panelFrame.TabIndex = 17;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Композиції";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 36);
            this.panel3.TabIndex = 1;
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(1033, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(33, 36);
            this.panelClose.TabIndex = 0;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(110, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Список композицій";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(76, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Виконувачі (Композитори) даної композиції.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1059, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 23;
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdd.Location = new System.Drawing.Point(10, 543);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(121, 34);
            this.lblAdd.TabIndex = 24;
            this.lblAdd.Text = "Додати";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            this.lblAdd.MouseEnter += new System.EventHandler(this.lblAdd_MouseEnter);
            this.lblAdd.MouseLeave += new System.EventHandler(this.lblAdd_MouseLeave);
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdit.Location = new System.Drawing.Point(182, 543);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(121, 34);
            this.lblEdit.TabIndex = 25;
            this.lblEdit.Text = "Редагувати";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            this.lblEdit.MouseEnter += new System.EventHandler(this.lblEdit_MouseEnter);
            this.lblEdit.MouseLeave += new System.EventHandler(this.lblEdit_MouseLeave);
            // 
            // lblRemove
            // 
            this.lblRemove.BackColor = System.Drawing.Color.Transparent;
            this.lblRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemove.Location = new System.Drawing.Point(368, 543);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(121, 34);
            this.lblRemove.TabIndex = 26;
            this.lblRemove.Text = "Видалити";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            this.lblRemove.MouseEnter += new System.EventHandler(this.lblRemove_MouseEnter);
            this.lblRemove.MouseLeave += new System.EventHandler(this.lblRemove_MouseLeave);
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShow.Location = new System.Drawing.Point(674, 409);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(214, 45);
            this.lblShow.TabIndex = 27;
            this.lblShow.Text = "Перегляд вибраної композиції";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            this.lblShow.MouseEnter += new System.EventHandler(this.lblShow_MouseEnter);
            this.lblShow.MouseLeave += new System.EventHandler(this.lblShow_MouseLeave);
            // 
            // FSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1063, 586);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.lb_performers_in_comps);
            this.Controls.Add(this.pb_comp);
            this.Controls.Add(this.label_album_name);
            this.Controls.Add(this.label_album_comp);
            this.Controls.Add(this.lb_songs);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FSongs";
            this.Text = "FSongs1";
           
            this.Load += new System.EventHandler(this.FSongs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_comp)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.panelFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_songs;
        private System.Windows.Forms.Label label_album_comp;
        private System.Windows.Forms.Label label_album_name;
        private System.Windows.Forms.PictureBox pb_comp;
        private System.Windows.Forms.ListBox lb_performers_in_comps;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblShow;
    }
}