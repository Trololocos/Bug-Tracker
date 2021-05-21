
namespace BugTracker
{
    partial class AddItem
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
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.InformationBox = new System.Windows.Forms.TextBox();
            this.SeverityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ObservationBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BugRadio = new System.Windows.Forms.RadioButton();
            this.TaskRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(12, 87);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(358, 20);
            this.DescriptionBox.TabIndex = 0;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // InformationBox
            // 
            this.InformationBox.Location = new System.Drawing.Point(12, 126);
            this.InformationBox.Multiline = true;
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.Size = new System.Drawing.Size(373, 164);
            this.InformationBox.TabIndex = 1;
            this.InformationBox.Text = " ";
            // 
            // SeverityBox
            // 
            this.SeverityBox.BackColor = System.Drawing.SystemColors.Window;
            this.SeverityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeverityBox.FormattingEnabled = true;
            this.SeverityBox.Items.AddRange(new object[] {
            "Critical",
            "Urgent",
            "Important",
            "Medium",
            "Minor"});
            this.SeverityBox.Location = new System.Drawing.Point(134, 33);
            this.SeverityBox.Name = "SeverityBox";
            this.SeverityBox.Size = new System.Drawing.Size(99, 21);
            this.SeverityBox.TabIndex = 3;
            this.SeverityBox.Tag = "";
            this.SeverityBox.SelectedIndexChanged += new System.EventHandler(this.SeverityBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Severity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Short description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Information (optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observations (optional)";
            // 
            // ObservationBox
            // 
            this.ObservationBox.Location = new System.Drawing.Point(12, 309);
            this.ObservationBox.Multiline = true;
            this.ObservationBox.Name = "ObservationBox";
            this.ObservationBox.Size = new System.Drawing.Size(373, 58);
            this.ObservationBox.TabIndex = 8;
            this.ObservationBox.Text = " ";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(143, 396);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BugRadio
            // 
            this.BugRadio.AutoSize = true;
            this.BugRadio.Location = new System.Drawing.Point(134, 373);
            this.BugRadio.Name = "BugRadio";
            this.BugRadio.Size = new System.Drawing.Size(44, 17);
            this.BugRadio.TabIndex = 10;
            this.BugRadio.TabStop = true;
            this.BugRadio.Text = "Bug";
            this.BugRadio.UseVisualStyleBackColor = true;
            this.BugRadio.CheckedChanged += new System.EventHandler(this.BugRadio_CheckedChanged);
            // 
            // TaskRadio
            // 
            this.TaskRadio.AutoSize = true;
            this.TaskRadio.Location = new System.Drawing.Point(184, 373);
            this.TaskRadio.Name = "TaskRadio";
            this.TaskRadio.Size = new System.Drawing.Size(49, 17);
            this.TaskRadio.TabIndex = 11;
            this.TaskRadio.TabStop = true;
            this.TaskRadio.Text = "Task";
            this.TaskRadio.UseVisualStyleBackColor = true;
            this.TaskRadio.CheckedChanged += new System.EventHandler(this.TaskRadio_SelectedIndexChanged);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 431);
            this.Controls.Add(this.TaskRadio);
            this.Controls.Add(this.BugRadio);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ObservationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeverityBox);
            this.Controls.Add(this.InformationBox);
            this.Controls.Add(this.DescriptionBox);
            this.Name = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox InformationBox;
        private System.Windows.Forms.ComboBox SeverityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ObservationBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton BugRadio;
        private System.Windows.Forms.RadioButton TaskRadio;
    }
}