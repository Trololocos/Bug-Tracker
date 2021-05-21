using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class AddItem : Form
    {
        private struct Filled
        {
            
            public bool severity, description, type;

        }
        Filled filled;
        public AddItem()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            BaseObject.Severity severity = (BaseObject.Severity)Enum.Parse(typeof(BaseObject.Severity), SeverityBox.Text); //Converting the string severity code to enum type
            if(BugRadio.Checked){
                Bug item = new Bug(InformationBox.Text, severity, DescriptionBox.Text, ObservationBox.Text);
                Program.all.AddBug(item);
                Program.mainForm.AddRow(item);
            }
            else
            {
                Task item = new Task(InformationBox.Text, severity, DescriptionBox.Text, ObservationBox.Text);
                Program.all.AddTask(item);
                Program.mainForm.AddRow(item);
            }
                this.Close();

        }

        private void Check(object sender,Filled filled)
        {
            if (filled.description &&
                filled.type &&
                filled.severity)
                SaveButton.Enabled = true;
            else
                //This prevents a bug where the save button won't deactivate if the user erases the contents of a box
                SaveButton.Enabled = false; 
        }


        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            if(DescriptionBox.Text != "")
                filled.description = true;
            else
                filled.description = false;

            Check(sender, filled);
        }

        private void BugRadio_CheckedChanged(object sender, EventArgs e)
        {
            filled.type = true;
            Check(sender, filled);
        }

        private void TaskRadio_SelectedIndexChanged(object sender, EventArgs e)
        {
            filled.type = true;
            Check(sender, filled);
        }

        private void SeverityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filled.severity = true;
            Check(sender, filled);
        }

    }
}
