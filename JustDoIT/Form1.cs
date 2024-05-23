using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JustDoIT
{
    public partial class FrmToDo : MaterialForm
    {
        private bool isTextBoxCleared1;
        private bool isTextBoxCleared2;
        public FrmToDo()
        {
            InitializeComponent();
            isTextBoxCleared1 = false;
            isTextBoxCleared2 = false;
        }

        private void TitleTextBox_Click(object sender, EventArgs e)
        {
            if (!isTextBoxCleared1)
            {
                TitleTextBox.Clear();
                isTextBoxCleared1=true;
            }
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void FrmToDo_Load(object sender, EventArgs e)
        {
            // Create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point our datagridview to our datasource
            dataGridView1.DataSource = todoList;

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            TitleTextBox.Text = todoList.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescriptionTextBox.Text = todoList.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Description"] = DescriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(TitleTextBox.Text, DescriptionTextBox.Text);
            }

            //clear fields
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            isEditing = false;
        }
        
        private void DescriptionTextBox_Click(object sender, EventArgs e)
        {
            if (!isTextBoxCleared2)
            {
                DescriptionTextBox.Clear();
                isTextBoxCleared2 = true;
            }
        }
    }
}
