namespace MIDI_Editor_V2._0
{
    partial class FNoteEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNoteEdit));
            this.SongTitle_label = new System.Windows.Forms.Label();
            this.pnl_for_graph = new System.Windows.Forms.Panel();
            this.lblTrack = new System.Windows.Forms.Label();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTracks = new System.Windows.Forms.Panel();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.panelHide = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.lblRowState = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_for_graph.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // SongTitle_label
            // 
            this.SongTitle_label.AutoSize = true;
            this.SongTitle_label.Location = new System.Drawing.Point(419, 17);
            this.SongTitle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SongTitle_label.Name = "SongTitle_label";
            this.SongTitle_label.Size = new System.Drawing.Size(0, 17);
            this.SongTitle_label.TabIndex = 0;
            // 
            // pnl_for_graph
            // 
            this.pnl_for_graph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_for_graph.Controls.Add(this.lblTrack);
            this.pnl_for_graph.Location = new System.Drawing.Point(31, 109);
            this.pnl_for_graph.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_for_graph.Name = "pnl_for_graph";
            this.pnl_for_graph.Size = new System.Drawing.Size(1045, 580);
            this.pnl_for_graph.TabIndex = 1;
            // 
            // lblTrack
            // 
            this.lblTrack.BackColor = System.Drawing.Color.Transparent;
            this.lblTrack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTrack.Location = new System.Drawing.Point(369, 23);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(275, 40);
            this.lblTrack.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.NameToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip.Location = new System.Drawing.Point(6, 37);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1378, 34);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseEnter += new System.EventHandler(this.menuStrip_MouseEnter);
            this.menuStrip.MouseLeave += new System.EventHandler(this.menuStrip_MouseLeave);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.зберегтиToolStripMenuItem1});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 30);
            this.toolStripMenuItem2.Text = "Файл";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.NewToolStripMenuItem.Text = "Новий";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem1
            // 
            this.зберегтиToolStripMenuItem1.Name = "зберегтиToolStripMenuItem1";
            this.зберегтиToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.зберегтиToolStripMenuItem1.Text = "Зберегти";
            this.зберегтиToolStripMenuItem1.Click += new System.EventHandler(this.зберегтиToolStripMenuItem1_Click);
            // 
            // NameToolStripMenuItem
            // 
            this.NameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.NameToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameToolStripMenuItem.Name = "NameToolStripMenuItem";
            this.NameToolStripMenuItem.Size = new System.Drawing.Size(76, 30);
            this.NameToolStripMenuItem.Text = "Доріжка";
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.створитиToolStripMenuItem.Text = "Створити";
            this.створитиToolStripMenuItem.Click += new System.EventHandler(this.створитиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 30);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(22, 30);
            this.toolStripMenuItem5.Text = " ";
            // 
            // panelTracks
            // 
            this.panelTracks.BackColor = System.Drawing.Color.Transparent;
            this.panelTracks.Location = new System.Drawing.Point(12, 71);
            this.panelTracks.Name = "panelTracks";
            this.panelTracks.Size = new System.Drawing.Size(1350, 31);
            this.panelTracks.TabIndex = 5;
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.Transparent;
            this.panelFrame.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.mainPanel;
            this.panelFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrame.Controls.Add(this.lblMain);
            this.panelFrame.Controls.Add(this.lblFormName);
            this.panelFrame.Controls.Add(this.panelHide);
            this.panelFrame.Controls.Add(this.panelClose);
            this.panelFrame.Controls.Add(this.panel);
            this.panelFrame.Location = new System.Drawing.Point(0, -1);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(1362, 35);
            this.panelFrame.TabIndex = 6;
            this.panelFrame.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDoubleClick);
            this.panelFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseDown);
            this.panelFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseMove);
            this.panelFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFrame_MouseUp);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMain.Location = new System.Drawing.Point(485, 10);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(123, 17);
            this.lblMain.TabIndex = 10;
            this.lblMain.Text = "Нотний редактор";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormName.Location = new System.Drawing.Point(40, 10);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(80, 17);
            this.lblFormName.TabIndex = 9;
            this.lblFormName.Text = "NameSong";
            this.lblFormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormName_MouseDown);
            this.lblFormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFormName_MouseMove);
            this.lblFormName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblFormName_MouseUp);
            // 
            // panelHide
            // 
            this.panelHide.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnHide;
            this.panelHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHide.Location = new System.Drawing.Point(1299, 2);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(29, 30);
            this.panelHide.TabIndex = 8;
            this.panelHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelHide_MouseClick);
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.Color.Transparent;
            this.panelClose.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.btnClose;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelClose.Location = new System.Drawing.Point(1323, 0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(39, 32);
            this.panelClose.TabIndex = 1;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.icon;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(34, 32);
            this.panel.TabIndex = 0;
            // 
            // lblRowState
            // 
            this.lblRowState.AutoSize = true;
            this.lblRowState.BackColor = System.Drawing.Color.Transparent;
            this.lblRowState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRowState.Location = new System.Drawing.Point(3, 692);
            this.lblRowState.Name = "lblRowState";
            this.lblRowState.Size = new System.Drawing.Size(0, 17);
            this.lblRowState.TabIndex = 7;
            // 
            // lblMan
            // 
            this.lblMan.BackColor = System.Drawing.Color.Transparent;
            this.lblMan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMan.Location = new System.Drawing.Point(1083, 692);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(122, 32);
            this.lblMan.TabIndex = 9;
            this.lblMan.Text = "Управління ";
            this.lblMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMan.Click += new System.EventHandler(this.lblMan_Click);
           
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1140, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // FNoteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIDI_Editor_V2._0.Properties.Resources.backgroundFNoteEdit;
            this.ClientSize = new System.Drawing.Size(1354, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMan);
            this.Controls.Add(this.lblRowState);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.panelTracks);
            this.Controls.Add(this.pnl_for_graph);
            this.Controls.Add(this.SongTitle_label);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FNoteEdit";
            this.Text = "FNoteEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FNoteEdit_FormClosed);
            this.Load += new System.EventHandler(this.FNoteEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FNoteEdit_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FNoteEdit_KeyDown);
            this.pnl_for_graph.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelFrame.ResumeLayout(false);
            this.panelFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SongTitle_label;
        private System.Windows.Forms.Panel pnl_for_graph;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem NameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.Panel panelTracks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lblRowState;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem1;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.TextBox textBox1;
    }
}