﻿namespace Matahari
{
    partial class ServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clientList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.netzwerkeinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualitätseinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.screenshot = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.machineName = new System.Windows.Forms.Label();
            this.connectedSince = new System.Windows.Forms.Label();
            this.lastHeartbeat = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.memoryAvailable = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshot)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(5, 2);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 30);
            label6.TabIndex = 1;
            label6.Text = "Name:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 30);
            label1.TabIndex = 3;
            label1.Text = "Verbunden seit:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(5, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 30);
            label2.TabIndex = 5;
            label2.Text = "Letzte \r\nAktualisierung:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(5, 98);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 30);
            label7.TabIndex = 7;
            label7.Text = "CPU:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(5, 130);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(94, 30);
            label8.TabIndex = 9;
            label8.Text = "RAM:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clientList);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1399, 583);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // clientList
            // 
            this.clientList.DisplayMember = "MachineName";
            this.clientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientList.FormattingEnabled = true;
            this.clientList.ItemHeight = 15;
            this.clientList.Location = new System.Drawing.Point(0, 24);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(246, 559);
            this.clientList.TabIndex = 0;
            this.clientList.SelectedIndexChanged += new System.EventHandler(this.SelectedClientChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeButton});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem2.Text = "&Datei";
            // 
            // closeButton
            // 
            this.closeButton.Name = "closeButton";
            this.closeButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeButton.Size = new System.Drawing.Size(162, 22);
            this.closeButton.Text = "Beenden";
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netzwerkeinstellungenToolStripMenuItem,
            this.qualitätseinstellungenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItem1.Text = "&Einstellungen";
            // 
            // netzwerkeinstellungenToolStripMenuItem
            // 
            this.netzwerkeinstellungenToolStripMenuItem.Name = "netzwerkeinstellungenToolStripMenuItem";
            this.netzwerkeinstellungenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.netzwerkeinstellungenToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.netzwerkeinstellungenToolStripMenuItem.Text = "&Clienteinstellungen";
            // 
            // qualitätseinstellungenToolStripMenuItem
            // 
            this.qualitätseinstellungenToolStripMenuItem.Name = "qualitätseinstellungenToolStripMenuItem";
            this.qualitätseinstellungenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.qualitätseinstellungenToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.qualitätseinstellungenToolStripMenuItem.Text = "&Servereinstellungen";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.infoToolStripMenuItem.Text = "Info ...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoMenuClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.screenshot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 109);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aktionen:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // screenshot
            // 
            this.screenshot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.screenshot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenshot.ErrorImage = null;
            this.screenshot.InitialImage = null;
            this.screenshot.Location = new System.Drawing.Point(234, 4);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(911, 465);
            this.screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenshot.TabIndex = 4;
            this.screenshot.TabStop = false;
            this.screenshot.Click += new System.EventHandler(this.ScreenshotClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(234, 476);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(911, 103);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(label8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.machineName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.connectedSince, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lastHeartbeat, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cpuUsage, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.memoryAvailable, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(223, 465);
            this.tableLayoutPanel3.TabIndex = 9;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint_1);
            // 
            // machineName
            // 
            this.machineName.AutoSize = true;
            this.machineName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineName.Location = new System.Drawing.Point(107, 2);
            this.machineName.Name = "machineName";
            this.machineName.Size = new System.Drawing.Size(111, 30);
            this.machineName.TabIndex = 2;
            this.machineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectedSince
            // 
            this.connectedSince.AutoSize = true;
            this.connectedSince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedSince.Location = new System.Drawing.Point(107, 34);
            this.connectedSince.Name = "connectedSince";
            this.connectedSince.Size = new System.Drawing.Size(111, 30);
            this.connectedSince.TabIndex = 4;
            this.connectedSince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastHeartbeat
            // 
            this.lastHeartbeat.AutoSize = true;
            this.lastHeartbeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastHeartbeat.Location = new System.Drawing.Point(107, 66);
            this.lastHeartbeat.Name = "lastHeartbeat";
            this.lastHeartbeat.Size = new System.Drawing.Size(111, 30);
            this.lastHeartbeat.TabIndex = 6;
            this.lastHeartbeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuUsage.Location = new System.Drawing.Point(107, 98);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(111, 30);
            this.cpuUsage.TabIndex = 8;
            this.cpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memoryAvailable
            // 
            this.memoryAvailable.AutoSize = true;
            this.memoryAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryAvailable.Location = new System.Drawing.Point(107, 130);
            this.memoryAvailable.Name = "memoryAvailable";
            this.memoryAvailable.Size = new System.Drawing.Size(111, 30);
            this.memoryAvailable.TabIndex = 10;
            this.memoryAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 583);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServerForm";
            this.Text = "matahari";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshot)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox clientList;
        private MenuStrip menuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem closeButton;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem netzwerkeinstellungenToolStripMenuItem;
        private ToolStripMenuItem qualitätseinstellungenToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private PictureBox screenshot;
        private Label label4;
        private Label label1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label machineName;
        private Label connectedSince;
        private Label lastHeartbeat;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private Label cpuUsage;
        private Label memoryAvailable;
    }
}