namespace MIDI_Editor_V2._0
{
    partial class FPerformers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPerformers));
            this.lb_performers = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lb_perfs_comps = new System.Windows.Forms.ListBox();
            this.pb_performer = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_Close = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_performer)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_performers
            // 
            this.lb_performers.FormattingEnabled = true;
            this.lb_performers.ItemHeight = 20;
            this.lb_performers.Location = new System.Drawing.Point(15, 95);
            this.lb_performers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_performers.Name = "lb_performers";
            this.lb_performers.Size = new System.Drawing.Size(430, 344);
            this.lb_performers.TabIndex = 0;
            this.lb_performers.SelectedIndexChanged += new System.EventHandler(this.lb_performers_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(19, 672);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 29);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Додати";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(151, 672);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 29);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Редагувати";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(306, 672);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(120, 29);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Видалити";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lb_perfs_comps
            // 
            this.lb_perfs_comps.FormattingEnabled = true;
            this.lb_perfs_comps.ItemHeight = 20;
            this.lb_perfs_comps.Location = new System.Drawing.Point(19, 525);
            this.lb_perfs_comps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_perfs_comps.Name = "lb_perfs_comps";
            this.lb_perfs_comps.Size = new System.Drawing.Size(407, 124);
            this.lb_perfs_comps.TabIndex = 25;
            // 
            // pb_performer
            // 
            this.pb_performer.BackColor = System.Drawing.Color.Transparent;
            this.pb_performer.Location = new System.Drawing.Point(485, 95);
            this.pb_performer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_performer.Name = "pb_performer";
            this.pb_performer.Size = new System.Drawing.Size(510, 288);
            this.pb_performer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_performer.TabIndex = 19;
            this.pb_performer.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.mainPanel;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.panel_Close);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.panelMain.Location = new System.Drawing.Point(2, 1);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1002, 39);
            this.panelMain.TabIndex = 26;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // panel_Close
            // 
            this.panel_Close.BackColor = System.Drawing.Color.Transparent;
            this.panel_Close.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panel_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_Close.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Close.Location = new System.Drawing.Point(965, 0);
            this.panel_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Close.Name = "panel_Close";
            this.panel_Close.Size = new System.Drawing.Size(37, 35);
            this.panel_Close.TabIndex = 27;
            this.panel_Close.Click += new System.EventHandler(this.panel_Close_Click);
            this.panel_Close.MouseEnter += new System.EventHandler(this.panel_Close_MouseEnter);
            this.panel_Close.MouseLeave += new System.EventHandler(this.panel_Close_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Виконавці";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 38);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(147, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Список виконавців.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Список пісень, вибраного виконавця.";
            // 
            // FPerformers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1007, 741);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lb_perfs_comps);
            this.Controls.Add(this.pb_performer);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lb_performers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FPerformers";
            this.Text = "Виконавці";
            
            this.Load += new System.EventHandler(this.FPerformers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_performer)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_performers;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pb_performer;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox lb_perfs_comps;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}