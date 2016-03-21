namespace MIDI_Editor_V2._0
{
    partial class FEditPerformer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditPerformer));
            this.button_ch_img = new System.Windows.Forms.Button();
            this.tb_img_src = new System.Windows.Forms.TextBox();
            this.pb_img_performer = new System.Windows.Forms.PictureBox();
            this.tb_name_performer = new System.Windows.Forms.TextBox();
            this.label_img_comp = new System.Windows.Forms.Label();
            this.label_perfor_comp = new System.Windows.Forms.Label();
            this.label_alb_comp = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dfound_performer = new System.Windows.Forms.DateTimePicker();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.lbl_import = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_performer)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // tb_img_src
            // 
            this.tb_img_src.Location = new System.Drawing.Point(433, 276);
            this.tb_img_src.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_img_src.Name = "tb_img_src";
            this.tb_img_src.Size = new System.Drawing.Size(284, 23);
            this.tb_img_src.TabIndex = 30;
            // 
            // pb_img_performer
            // 
            this.pb_img_performer.BackColor = System.Drawing.Color.Transparent;
            this.pb_img_performer.Location = new System.Drawing.Point(433, 38);
            this.pb_img_performer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_img_performer.Name = "pb_img_performer";
            this.pb_img_performer.Size = new System.Drawing.Size(381, 230);
            this.pb_img_performer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img_performer.TabIndex = 28;
            this.pb_img_performer.TabStop = false;
            // 
            // tb_name_performer
            // 
            this.tb_name_performer.Location = new System.Drawing.Point(205, 60);
            this.tb_name_performer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name_performer.Name = "tb_name_performer";
            this.tb_name_performer.Size = new System.Drawing.Size(132, 23);
            this.tb_name_performer.TabIndex = 26;
            // 
            // label_img_comp
            // 
            this.label_img_comp.AutoSize = true;
            this.label_img_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_img_comp.Location = new System.Drawing.Point(17, 137);
            this.label_img_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_img_comp.Name = "label_img_comp";
            this.label_img_comp.Size = new System.Drawing.Size(71, 17);
            this.label_img_comp.TabIndex = 25;
            this.label_img_comp.Text = "Картинка";
            // 
            // label_perfor_comp
            // 
            this.label_perfor_comp.AutoSize = true;
            this.label_perfor_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_perfor_comp.Location = new System.Drawing.Point(17, 66);
            this.label_perfor_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_perfor_comp.Name = "label_perfor_comp";
            this.label_perfor_comp.Size = new System.Drawing.Size(102, 17);
            this.label_perfor_comp.TabIndex = 24;
            this.label_perfor_comp.Text = "Ім\'я виконавця";
            // 
            // label_alb_comp
            // 
            this.label_alb_comp.AutoSize = true;
            this.label_alb_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_alb_comp.Location = new System.Drawing.Point(17, 101);
            this.label_alb_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_alb_comp.Name = "label_alb_comp";
            this.label_alb_comp.Size = new System.Drawing.Size(159, 17);
            this.label_alb_comp.TabIndex = 23;
            this.label_alb_comp.Text = "Дата заснування групи";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.Location = new System.Drawing.Point(19, 297);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 30);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "Редагувати";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "jpg|*.jpg|jpeg|*.jpeg";
            // 
            // dfound_performer
            // 
            this.dfound_performer.Location = new System.Drawing.Point(205, 95);
            this.dfound_performer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dfound_performer.Name = "dfound_performer";
            this.dfound_performer.Size = new System.Drawing.Size(220, 23);
            this.dfound_performer.TabIndex = 32;
            // 
            // panelFrame
            // 
            this.panelFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Controls.Add(this.panel2);
            this.panelFrame.Location = new System.Drawing.Point(-2, -2);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(845, 33);
            this.panelFrame.TabIndex = 33;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 30);
            this.panel2.TabIndex = 34;
            // 
            // panelClose
            // 
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(813, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(32, 33);
            this.panelClose.TabIndex = 35;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelClose_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelClose_MouseLeave);
            // 
            // lbl_import
            // 
            this.lbl_import.BackColor = System.Drawing.Color.Transparent;
            this.lbl_import.Location = new System.Drawing.Point(202, 129);
            this.lbl_import.Name = "lbl_import";
            this.lbl_import.Size = new System.Drawing.Size(145, 32);
            this.lbl_import.TabIndex = 34;
            this.lbl_import.Text = "Імпортувати";
            this.lbl_import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_import.Click += new System.EventHandler(this.lbl_import_Click);
            this.lbl_import.MouseEnter += new System.EventHandler(this.lbl_import_MouseEnter);
            this.lbl_import.MouseLeave += new System.EventHandler(this.lbl_import_MouseLeave);
            // 
            // FEditPerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.backgroundAddPerf;
            this.ClientSize = new System.Drawing.Size(843, 414);
            this.Controls.Add(this.lbl_import);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.dfound_performer);
            this.Controls.Add(this.button_ch_img);
            this.Controls.Add(this.tb_img_src);
            this.Controls.Add(this.pb_img_performer);
            this.Controls.Add(this.tb_name_performer);
            this.Controls.Add(this.label_img_comp);
            this.Controls.Add(this.label_perfor_comp);
            this.Controls.Add(this.label_alb_comp);
            this.Controls.Add(this.btn_edit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FEditPerformer";
            this.Load += new System.EventHandler(this.FEditPerformer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_performer)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ch_img;
        private System.Windows.Forms.TextBox tb_img_src;
        private System.Windows.Forms.PictureBox pb_img_performer;
        private System.Windows.Forms.TextBox tb_name_performer;
        private System.Windows.Forms.Label label_img_comp;
        private System.Windows.Forms.Label label_perfor_comp;
        private System.Windows.Forms.Label label_alb_comp;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dfound_performer;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_import;
    }
}