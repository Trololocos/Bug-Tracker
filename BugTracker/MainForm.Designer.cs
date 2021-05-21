
namespace BugTracker
{
    partial class MainForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NameTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.InformationBox = new System.Windows.Forms.TextBox();
            this.ObservationsBox = new System.Windows.Forms.TextBox();
            this.StatusTable = new System.Windows.Forms.TableLayoutPanel();
            this.SolveButton = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.debugButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.StatusTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1063, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem,
            this.debugButtonToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1063, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NameTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.StatusTable);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 406);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.TabIndex = 6;
            // 
            // NameTable
            // 
            this.NameTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTable.AutoScroll = true;
            this.NameTable.AutoSize = true;
            this.NameTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTable.BackColor = System.Drawing.SystemColors.Control;
            this.NameTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.NameTable.ColumnCount = 1;
            this.NameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NameTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTable.Location = new System.Drawing.Point(6, 3);
            this.NameTable.Margin = new System.Windows.Forms.Padding(0);
            this.NameTable.Name = "NameTable";
            this.NameTable.RowCount = 1;
            this.NameTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.NameTable.Size = new System.Drawing.Size(329, 2);
            this.NameTable.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.DescriptionBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.InformationBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ObservationsBox, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22925F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.77075F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(671, 356);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AllowDrop = true;
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(3, 3);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(666, 23);
            this.DescriptionBox.TabIndex = 0;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_Changed);
            // 
            // InformationBox
            // 
            this.InformationBox.AllowDrop = true;
            this.InformationBox.Enabled = false;
            this.InformationBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationBox.Location = new System.Drawing.Point(3, 39);
            this.InformationBox.Multiline = true;
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(666, 211);
            this.InformationBox.TabIndex = 1;
            this.InformationBox.TextChanged += new System.EventHandler(this.InformationBox_Changed);
            // 
            // ObservationsBox
            // 
            this.ObservationsBox.AllowDrop = true;
            this.ObservationsBox.Enabled = false;
            this.ObservationsBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservationsBox.Location = new System.Drawing.Point(3, 256);
            this.ObservationsBox.Multiline = true;
            this.ObservationsBox.Name = "ObservationsBox";
            this.ObservationsBox.Size = new System.Drawing.Size(666, 97);
            this.ObservationsBox.TabIndex = 2;
            this.ObservationsBox.TextChanged += new System.EventHandler(this.ObservationBox_Changed);
            // 
            // StatusTable
            // 
            this.StatusTable.ColumnCount = 4;
            this.StatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16279F));
            this.StatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.83721F));
            this.StatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.StatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.StatusTable.Controls.Add(this.SolveButton, 3, 0);
            this.StatusTable.Location = new System.Drawing.Point(0, 0);
            this.StatusTable.Name = "StatusTable";
            this.StatusTable.RowCount = 1;
            this.StatusTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.StatusTable.Size = new System.Drawing.Size(671, 41);
            this.StatusTable.TabIndex = 0;
            // 
            // SolveButton
            // 
            this.SolveButton.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolveButton.Location = new System.Drawing.Point(547, 3);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(119, 38);
            this.SolveButton.TabIndex = 0;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(671, 464);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(75, 23);
            this.debug.TabIndex = 0;
            this.debug.Text = "debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Visible = false;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add bug or task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // debugButtonToolStripMenuItem
            // 
            this.debugButtonToolStripMenuItem.Name = "debugButtonToolStripMenuItem";
            this.debugButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.debugButtonToolStripMenuItem.Text = "Debug button";
            this.debugButtonToolStripMenuItem.Click += new System.EventHandler(this.debugButtonToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 514);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(745, 286);
            this.Name = "MainForm";
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.StatusTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel NameTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel StatusTable;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox InformationBox;
        private System.Windows.Forms.TextBox ObservationsBox;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.ToolStripMenuItem debugButtonToolStripMenuItem;
    }
}

