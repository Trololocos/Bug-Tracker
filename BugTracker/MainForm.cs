using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BugTracker
{
    public partial class MainForm : Form
    {
        //The rows from the bugs/tasks and date/severity respectively
        TableLayoutControlCollection listRow;
        TableLayoutControlCollection statusControls;
        BaseObject current;
        Label currentLabel;

        public MainForm()
        {
            InitializeComponent();
        }
        private void ParentForm_Load(object sender, EventArgs e)
        {

            listRow = NameTable.Controls;
            statusControls = StatusTable.Controls;

        }




        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void Show(BaseObject x, Label label)
        {
            current = x;
            currentLabel = label;
            string solved;

            if (x.SolvedDate == DateTime.MinValue)
            {
                solved = "Unsolved";
            }
            else
            {
                solved = x.SolvedDate.ToString();
            }
            Label severityLabel = new Label() { Text = x.Code.ToString(), AutoSize = true };
            Label createdLabel = new Label() { Text = x.Date.ToString(), AutoSize = true };
            Label solvedLabel = new Label() { Text = solved, AutoSize = true };
            statusControls.Clear();
            statusControls.Add(severityLabel, 0, 0);
            statusControls.Add(createdLabel, 1, 0);
            statusControls.Add(solvedLabel, 2, 0);
            statusControls.Add(SolveButton, 3, 0);
            DescriptionBox.Text = x.Description;
            InformationBox.Text = x.Information;
            ObservationsBox.Text = x.Observations;
            DescriptionBox.Enabled = true;
            InformationBox.Enabled = true;
            ObservationsBox.Enabled = true;

        }
        public void AddRow(BaseObject x)
        {
            string text = x.Description;
            if (text.Length > 40)
            {
                text = text.Substring(0, 45);
                text += '…';
            }
            Label label = new Label() { Name = text, Text = text, AutoSize = true };

            NameTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            NameTable.Controls.Add(label, 0, NameTable.RowCount);
            NameTable.RowCount++;
            current = x;
            currentLabel = label;
            label.Click += (send, e) => {
                Show(x, label);
            };
        }
        private void SolveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ngig");
            current.Solve();
            Show(current, currentLabel);
        }
        public void update()
        {
            NameTable.RowCount = 0;
            listRow.Clear();
            foreach (Bug bug in Program.all.BugArray)
            {
                AddRow(bug);
            }
            foreach (Task task in Program.all.TaskArray)
            {
                AddRow(task);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AddItem AddForm = new AddItem();
            AddForm.Show();
        }


        string WorkingFile = "";
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Settings.def))
                Directory.CreateDirectory(Settings.def);
            Stream stream;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Settings.def;
            dialog.Filter = $"{Settings.extension} files (*.{Settings.extension})|*.{Settings.extension}|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = dialog.OpenFile()) != null)
                {
                    WorkingFile = dialog.FileName;
                    //Transforms All type to stream type
                    string str = Program.all.ToString();
                    Console.WriteLine(str);
                    byte[] byteArray = Encoding.UTF8.GetBytes(str);
                    MemoryStream memStream = new MemoryStream(byteArray);
                    memStream.CopyTo(stream);
                    stream.Close();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(Settings.def))
                Directory.CreateDirectory(Settings.def);
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Settings.def;
                dialog.Filter = $"{Settings.extension} files (*.{Settings.extension})|*.{Settings.extension}|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;
                    WorkingFile = filePath;
                    using (StreamReader reader = new StreamReader(dialog.OpenFile()))
                    {
                        string content = reader.ReadToEnd();
                        Program.all = BaseObject.ParseFile(content);
                    }
                }

            }
            update();
        }

        //This events saves the object state every time a box gets modified (goes out of focus)
        private void InformationBox_Changed(object sender, EventArgs e)
        {
            current.Information = InformationBox.Text;
        }
        private void ObservationBox_Changed(object sender, EventArgs e)
        {
            current.Observations = ObservationsBox.Text;
        }

        static int count = 0;
        private void debug_Click(object sender, EventArgs e)
        {
            Bug bug = new Bug("info", BaseObject.Severity.Critical, "object " + count++, "observ");
            Program.all.AddBug(bug);
            Program.mainForm.AddRow(bug);
            Console.WriteLine(Program.all.ToString());
        }

        private void DescriptionBox_Changed(object sender, EventArgs e)
        {
            current.Description = DescriptionBox.Text;
            currentLabel.Text = DescriptionBox.Text;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.all.Wipe();
            WorkingFile = "";
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingFile == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }
            File.WriteAllText(WorkingFile, Program.all.ToString());

        }

        private void debugButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debug.Visible = true;
        }
    }

}
