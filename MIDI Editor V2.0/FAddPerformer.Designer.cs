namespace MIDI_Editor_V2._0
{
    partial class FAddPerformer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddPerformer));
            this.tb_img_src = new System.Windows.Forms.TextBox();
            this.pb_img_peformer = new System.Windows.Forms.PictureBox();
            this.button_add = new System.Windows.Forms.Button();
            this.tb_name_performer = new System.Windows.Forms.TextBox();
            this.label_img_comp = new System.Windows.Forms.Label();
            this.label_date_performer = new System.Windows.Forms.Label();
            this.label_name_performer = new System.Windows.Forms.Label();
            this.dfound_performer = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_import = new System.Windows.Forms.Label();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlClose = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_peformer)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_img_src
            // 
            this.tb_img_src.Location = new System.Drawing.Point(515, 252);
            this.tb_img_src.Margin = new System.Windows.Forms.Padding(4);
            this.tb_img_src.Name = "tb_img_src";
            this.tb_img_src.Size = new System.Drawing.Size(307, 23);
            this.tb_img_src.TabIndex = 22;
            // 
            // pb_img_peformer
            // 
            this.pb_img_peformer.BackColor = System.Drawing.Color.Transparent;
            this.pb_img_peformer.ErrorImage = global::MIDI_Editor_V2._0.Properties.Resources.photofc;
            this.pb_img_peformer.Location = new System.Drawing.Point(515, 49);
            this.pb_img_peformer.Margin = new System.Windows.Forms.Padding(4);
            this.pb_img_peformer.Name = "pb_img_peformer";
            this.pb_img_peformer.Size = new System.Drawing.Size(297, 195);
            this.pb_img_peformer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img_peformer.TabIndex = 19;
            this.pb_img_peformer.TabStop = false;
            // 
            // button_add
            // 
            this.button_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add.Location = new System.Drawing.Point(29, 275);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Додати";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // tb_name_performer
            // 
            this.tb_name_performer.Location = new System.Drawing.Point(242, 49);
            this.tb_name_performer.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name_performer.Name = "tb_name_performer";
            this.tb_name_performer.Size = new System.Drawing.Size(132, 23);
            this.tb_name_performer.TabIndex = 16;
            // 
            // label_img_comp
            // 
            this.label_img_comp.AutoSize = true;
            this.label_img_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_img_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_img_comp.Location = new System.Drawing.Point(10, 125);
            this.label_img_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_img_comp.Name = "label_img_comp";
            this.label_img_comp.Size = new System.Drawing.Size(71, 17);
            this.label_img_comp.TabIndex = 15;
            this.label_img_comp.Text = "Картинка";
            // 
            // label_date_performer
            // 
            this.label_date_performer.AutoSize = true;
            this.label_date_performer.BackColor = System.Drawing.Color.Transparent;
            this.label_date_performer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_date_performer.Location = new System.Drawing.Point(10, 86);
            this.label_date_performer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date_performer.Name = "label_date_performer";
            this.label_date_performer.Size = new System.Drawing.Size(119, 17);
            this.label_date_performer.TabIndex = 13;
            this.label_date_performer.Text = "Дата заснування";
            // 
            // label_name_performer
            // 
            this.label_name_performer.AutoSize = true;
            this.label_name_performer.BackColor = System.Drawing.Color.Transparent;
            this.label_name_performer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_name_performer.Location = new System.Drawing.Point(13, 49);
            this.label_name_performer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_performer.Name = "label_name_performer";
            this.label_name_performer.Size = new System.Drawing.Size(198, 17);
            this.label_name_performer.TabIndex = 12;
            this.label_name_performer.Text = "Ім\'я виконавця/композитора";
            // 
            // dfound_performer
            // 
            this.dfound_performer.Location = new System.Drawing.Point(242, 80);
            this.dfound_performer.Margin = new System.Windows.Forms.Padding(4);
            this.dfound_performer.Name = "dfound_performer";
            this.dfound_performer.Size = new System.Drawing.Size(265, 23);
            this.dfound_performer.TabIndex = 23;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Всі|*.*|jpg|*.jpg|jpeg|*.jpeg";
            this.openFileDialog.FilterIndex = 2;
            // 
            // lbl_import
            // 
            this.lbl_import.BackColor = System.Drawing.Color.Transparent;
            this.lbl_import.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_import.Location = new System.Drawing.Point(242, 118);
            this.lbl_import.Name = "lbl_import";
            this.lbl_import.Size = new System.Drawing.Size(132, 31);
            this.lbl_import.TabIndex = 24;
            this.lbl_import.Text = "Імпортувати";
            this.lbl_import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_import.Click += new System.EventHandler(this.lbl_import_Click);
            this.lbl_import.MouseEnter += new System.EventHandler(this.lbl_import_MouseEnter);
            this.lbl_import.MouseLeave += new System.EventHandler(this.lbl_import_MouseLeave);
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.panel3);
            this.panelFrame.Controls.Add(this.pnlClose);
            this.panelFrame.Location = new System.Drawing.Point(1, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(840, 33);
            this.panelFrame.TabIndex = 25;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 33);
            this.panel3.TabIndex = 1;
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.pnlClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlClose.Location = new System.Drawing.Point(802, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(35, 33);
            this.pnlClose.TabIndex = 0;
            this.pnlClose.Click += new System.EventHandler(this.pnlClose_Click);
            this.pnlClose.MouseEnter += new System.EventHandler(this.pnlClose_MouseEnter);
            this.pnlClose.MouseLeave += new System.EventHandler(this.pnlClose_MouseLeave);
            // 
            // FAddPerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.backgroundAddPerf;
            this.ClientSize = new System.Drawing.Size(843, 414);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.lbl_import);
            this.Controls.Add(this.dfound_performer);
            this.Controls.Add(this.tb_img_src);
            this.Controls.Add(this.pb_img_peformer);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.tb_name_performer);
            this.Controls.Add(this.label_img_comp);
            this.Controls.Add(this.label_date_performer);
            this.Controls.Add(this.label_name_performer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAddPerformer";
            this.Text = "FAddPerformer";
            this.Load += new System.EventHandler(this.FAddPerformer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_peformer)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_img_src;
        private System.Windows.Forms.PictureBox pb_img_peformer;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox tb_name_performer;
        private System.Windows.Forms.Label label_img_comp;
        private System.Windows.Forms.Label label_date_performer;
        private System.Windows.Forms.Label label_name_performer;
        private System.Windows.Forms.DateTimePicker dfound_performer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_import;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlClose;
    }
}