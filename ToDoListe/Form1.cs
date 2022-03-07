using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoListe
{
    public partial class Form1 : Form
    {
        List<string> toDoListe = new List<string>();
        string name;
        string time;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.toDO_header_label2.Text = $"{"Time",-68} Reminder";
            loadList();


        }
        private void loadList()
        {
            object obTime = null;
            object obName = null;
            Microsoft.Win32.RegistryKey k;
            k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\nilsNdev\\toDoList", true);
            if (k == null) return;

            if (k.GetValue("Index") != null)
            {
                count = (int)k.GetValue("Index");
                for (int i = 0; i < count; i++)
                {


                    obTime = k.GetValue($"task_dateTime_{i}");
                    obName = k.GetValue($"task_index_{i}");


                    this.checkedListBox1.Items.Add($"{obTime,-100}{obName}");
                }

            }



        }

        private void add_button1_Click(object sender, EventArgs e)
        {
            ToDoListe.Forms.Add_Formcs AF = new Forms.Add_Formcs();
            AF.ShowDialog();
        }


        private void load_button_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Clear();
            loadList();
        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HeaderToDo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear_button3_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey k;
            k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\nilsNdev", true);
            if (k == null) return;

            k.DeleteSubKey("toDoList");
            k.CreateSubKey("toDoList");
            count = 0;
            this.checkedListBox1.Items.Clear();
            MessageBox.Show("To Do List Cleared");
        }

        private void exit_button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good bye");
            Application.Exit();
        }

        private void minimize_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void remove_button2_Click(object sender, EventArgs e)
        {

        }
    }
}

