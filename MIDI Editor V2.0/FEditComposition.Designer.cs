namespace MIDI_Editor_V2._0
{
    partial class FEditComposition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditComposition));
            this.btn_add = new System.Windows.Forms.Button();
            this.pb_img_comp = new System.Windows.Forms.PictureBox();
            this.tb_album = new System.Windows.Forms.TextBox();
            this.tb_name_comp = new System.Windows.Forms.TextBox();
            this.label_img_comp = new System.Windows.Forms.Label();
            this.label_perfor_comp = new System.Windows.Forms.Label();
            this.label_alb_comp = new System.Windows.Forms.Label();
            this.label_name_comp = new System.Windows.Forms.Label();
            this.tb_img_src = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lb_performers_in_comps = new System.Windows.Forms.ListBox();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblImport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_comp)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_add.Location = new System.Drawing.Point(121, 338);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 30);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Редагувати";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // pb_img_comp
            // 
            this.pb_img_comp.BackColor = System.Drawing.Color.Transparent;
            this.pb_img_comp.Location = new System.Drawing.Point(327, 52);
            this.pb_img_comp.Margin = new System.Windows.Forms.Padding(4);
            this.pb_img_comp.Name = "pb_img_comp";
            this.pb_img_comp.Size = new System.Drawing.Size(462, 235);
            this.pb_img_comp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img_comp.TabIndex = 17;
            this.pb_img_comp.TabStop = false;
            // 
            // tb_album
            // 
            this.tb_album.Location = new System.Drawing.Point(169, 88);
            this.tb_album.Margin = new System.Windows.Forms.Padding(4);
            this.tb_album.Name = "tb_album";
            this.tb_album.Size = new System.Drawing.Size(132, 23);
            this.tb_album.TabIndex = 15;
            // 
            // tb_name_comp
            // 
            this.tb_name_comp.Location = new System.Drawing.Point(169, 52);
            this.tb_name_comp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name_comp.Name = "tb_name_comp";
            this.tb_name_comp.Size = new System.Drawing.Size(132, 23);
            this.tb_name_comp.TabIndex = 13;
            // 
            // label_img_comp
            // 
            this.label_img_comp.AutoSize = true;
            this.label_img_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_img_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_img_comp.Location = new System.Drawing.Point(18, 133);
            this.label_img_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_img_comp.Name = "label_img_comp";
            this.label_img_comp.Size = new System.Drawing.Size(71, 17);
            this.label_img_comp.TabIndex = 12;
            this.label_img_comp.Text = "Картинка";
            // 
            // label_perfor_comp
            // 
            this.label_perfor_comp.AutoSize = true;
            this.label_perfor_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_perfor_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_perfor_comp.Location = new System.Drawing.Point(118, 176);
            this.label_perfor_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_perfor_comp.Name = "label_perfor_comp";
            this.label_perfor_comp.Size = new System.Drawing.Size(73, 17);
            this.label_perfor_comp.TabIndex = 11;
            this.label_perfor_comp.Text = "Виконавці";
            this.label_perfor_comp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label_alb_comp
            // 
            this.label_alb_comp.AutoSize = true;
            this.label_alb_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_alb_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_alb_comp.Location = new System.Drawing.Point(18, 92);
            this.label_alb_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_alb_comp.Name = "label_alb_comp";
            this.label_alb_comp.Size = new System.Drawing.Size(59, 17);
            this.label_alb_comp.TabIndex = 10;
            this.label_alb_comp.Text = "Альбом";
            // 
            // label_name_comp
            // 
            this.label_name_comp.AutoSize = true;
            this.label_name_comp.BackColor = System.Drawing.Color.Transparent;
            this.label_name_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_name_comp.Location = new System.Drawing.Point(13, 52);
            this.label_name_comp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name_comp.Name = "label_name_comp";
            this.label_name_comp.Size = new System.Drawing.Size(123, 17);
            this.label_name_comp.TabIndex = 9;
            this.label_name_comp.Text = "Назва композиції";
            // 
            // tb_img_src
            // 
            this.tb_img_src.Location = new System.Drawing.Point(327, 295);
            this.tb_img_src.Margin = new System.Windows.Forms.Padding(4);
            this.tb_img_src.Name = "tb_img_src";
            this.tb_img_src.Size = new System.Drawing.Size(284, 23);
            this.tb_img_src.TabIndex = 19;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lb_performers_in_comps
            // 
            this.lb_performers_in_comps.FormattingEnabled = true;
            this.lb_performers_in_comps.ItemHeight = 17;
            this.lb_performers_in_comps.Location = new System.Drawing.Point(18, 197);
            this.lb_performers_in_comps.Margin = new System.Windows.Forms.Padding(4);
            this.lb_performers_in_comps.Name = "lb_performers_in_comps";
            this.lb_performers_in_comps.ScrollAlwaysVisible = true;
            this.lb_performers_in_comps.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_performers_in_comps.Size = new System.Drawing.Size(283, 106);
            this.lb_performers_in_comps.Sorted = true;
            this.lb_performers_in_comps.TabIndex = 34;
            // 
            // panelFrame
            // 
            this.panelFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Controls.Add(this.panel2);
            this.panelFrame.Location = new System.Drawing.Point(-1, -3);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(846, 32);
            this.panelFrame.TabIndex = 35;
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(816, 3);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(30, 32);
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
            this.panel2.Size = new System.Drawing.Size(32, 32);
            this.panel2.TabIndex = 0;
            // 
            // lblImport
            // 
            this.lblImport.BackColor = System.Drawing.Color.Transparent;
            this.lblImport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImport.Location = new System.Drawing.Point(166, 124);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(102, 34);
            this.lblImport.TabIndex = 36;
            this.lblImport.Text = "Імпортувати";
            this.lblImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblImport.Click += new System.EventHandler(this.lblImport_Click);
            this.lblImport.MouseEnter += new System.EventHandler(this.lblImport_MouseEnter);
            this.lblImport.MouseLeave += new System.EventHandler(this.lblImport_MouseLeave);
            // 
            // FEditComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.backgroundAddPerf;
            this.ClientSize = new System.Drawing.Size(844, 412);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.lb_performers_in_comps);
            this.Controls.Add(this.tb_img_src);
            this.Controls.Add(this.pb_img_comp);
            this.Controls.Add(this.tb_album);
            this.Controls.Add(this.tb_name_comp);
            this.Controls.Add(this.label_img_comp);
            this.Controls.Add(this.label_perfor_comp);
            this.Controls.Add(this.label_alb_comp);
            this.Controls.Add(this.label_name_comp);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FEditComposition";
            this.Text = "FEdit";
            this.Load += new System.EventHandler(this.FEditComposition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_comp)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pb_img_comp;
        private System.Windows.Forms.TextBox tb_album;
        private System.Windows.Forms.TextBox tb_name_comp;
        private System.Windows.Forms.Label label_img_comp;
        private System.Windows.Forms.Label label_perfor_comp;
        private System.Windows.Forms.Label label_alb_comp;
        private System.Windows.Forms.Label label_name_comp;
        private System.Windows.Forms.TextBox tb_img_src;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox lb_performers_in_comps;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblImport;
    }
}