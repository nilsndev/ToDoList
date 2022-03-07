using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoListe.Forms
{
    public partial class Add_Formcs : Form
    {
        int index = 0;

        public Add_Formcs()
        {
            InitializeComponent();
        }

        private void title_label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Formcs_Load(object sender, EventArgs e)
        {
            
        }

        private void dateTime_domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void description_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button1_Click(object sender, EventArgs e)
        {
          
            if(this.description_textBox1.Text == "")
            {

                MessageBox.Show("The TextBox can not be empty");
                return;
            }
            SaveChanges();

          
            this.description_textBox1.Text = "";
            this.numericUpDown1.Value = 1;
            this.houer_numericUpDown2.Value = 0;
        }
        private void SaveChanges()
        {
            Microsoft.Win32.RegistryKey k;
            k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\nilsNdev\\toDoList", true);

            if (k == null)
            {
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\nilsNdev\\toDoList", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\nilsNdev\\toDoList", true);

            }
            index = (int)k.GetValue("Index", 0);
            DateTime dt = DateTime.Now;

            string selectDate = dt.AddHours((double)this.houer_numericUpDown2.Value).AddMinutes((double)this.numericUpDown1.Value).ToString("HH:mm");

            k.SetValue($"task_index_{index}", this.description_textBox1.Text);
            k.SetValue($"task_dateTime_{index}", selectDate);
          


            index++;
            k.SetValue($"Index", index);
            k.Close();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void canceL_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
