using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetDatabasProjekt
{
    public partial class Form1 : Form
    {
        PetInfo form;

       
        public Form1()
        {
            InitializeComponent();
            form = new PetInfo(this);
        }
        //metod för att displaya
        public void Display()
        {
            PetDB.DisplayAndSearch("SELECT PetID, Type, Size, Color, Breed, Phonenumber FROM pet", dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void Form1_shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            PetDB.DisplayAndSearch("SELECT PetID, Type, Size, Color, Breed, Phonenumber FROM pet WHERE Type LIKE'%"+ txtBox.Text +"%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Édit
                form.Clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.type = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.size = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.color = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.breed = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.phonenumber = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.UpdatePet();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Do you want to delete all info about the pet?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Delete
                    PetDB.DeletePet(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
