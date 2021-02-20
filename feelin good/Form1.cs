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

namespace feelin_good
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            base.StartPosition = FormStartPosition.CenterScreen;
            DirectoryInfo d = new DirectoryInfo(@"C:\Test");
            if (!d.Exists)
                d.Create();
            FileInfo[] files = d.GetFiles("*.cfg");
            string str = "";
            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file.Name);
            }

        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void maxcps_slider_Load(object sender, EventArgs e)
        {
            if (maxcps_slider.Value < mincps_slider.Value)
                maxcps_slider.Value++;
        }

        private void mincps_slider_Load(object sender, EventArgs e)
        {
            if (mincps_slider.Value > maxcps_slider.Value)
                mincps_slider.Value++;
        }

        bool clicked = false;
        bool clicked_2 = false;
        bool clicker_3 = false;

        private void combatL_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                combatTab.Visible = true;
                if (clicker_3)
                    miscL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                if (clicked_2)
                    visL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                combatL.ForeColor = Color.FromArgb(255, 89, 15, 203);
                clicked = true;
            }
            else
            {
                combatTab.Visible = false;
                combatL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                clicked = false;
            }
        }

        private void visL_Click(object sender, EventArgs e)
        {
            if (!clicked_2)
            {
                combatTab.Visible = false;
                if (clicked)
                    combatL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                if (clicker_3)
                    miscL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                visL.ForeColor = Color.FromArgb(255, 89, 15, 203);
                clicked_2 = true;
            }
            else
            {
                visL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                clicked_2 = false;
            }
        }

        private void miscL_Click(object sender, EventArgs e)
        {
            if (!clicker_3)
            {
                combatTab.Visible = false;
                if (clicked)
                    combatL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                if (clicked_2)
                    visL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                miscL.ForeColor = Color.FromArgb(255, 89, 15, 203);
                clicker_3 = true;
            }
            else
            {
                miscL.ForeColor = Color.FromArgb(255, 255, 255, 255);
                clicker_3 = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void skeetGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(configName.Text) || !string.IsNullOrEmpty(configName.Text))
            {
                try
                {
                    File.Create(@"C:\Test\" + configName.Text.Replace(".cfg", " ") + ".cfg", 128, FileOptions.Asynchronous);
                    DirectoryInfo d = new DirectoryInfo(@"C:\Test");
                    if (!d.Exists)
                        d.Create();
                    FileInfo[] files = d.GetFiles("*.cfg");
                    string str = "";
                    listBox1.Items.Clear();
                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file.Name);
                    }
                    configName.Text = "";
                }
                catch (Exception p) { MessageBox.Show("err: " + p.Message); };
            }
            else
            {
                MessageBox.Show("please insert a config name");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { return; }
            try
            {
                File.Delete(@"C:\Test\" + listBox1.SelectedItem.ToString());
                DirectoryInfo d = new DirectoryInfo(@"C:\Test");
                if (!d.Exists)
                    d.Create();
                FileInfo[] files = d.GetFiles("*.cfg");
                string str = "";
                listBox1.Items.Clear();
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add(file.Name);
                }
                configName.Text = "";
            }
            catch
            { listBox1.Items.Remove(listBox1.SelectedItem.ToString()); };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            try
            {
                byte[] faggot = Encoding.ASCII.GetBytes(enabledAC.Checked.ToString());
                File.WriteAllText(@"C:\Test\" + listBox1.SelectedItem.ToString(), Convert.ToBase64String(faggot));
                configName.Text = "";
            }
            catch (Exception p) { MessageBox.Show("err: " + p.Message); };
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            try
            {
                enabledAC.Checked = false;
                mincps_slider.Value = 1;
                maxcps_slider.Value = 1;
                configName.Text = "";
                File.WriteAllText(@"C:\Test\" + listBox1.SelectedItem.ToString(), ""); // shit code
            }
            catch (Exception p) { MessageBox.Show("err: " + p.Message); };
        }
    }
}
