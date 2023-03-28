using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetDatabasProjekt
{
    public partial class PetInfo : Form
    {
        private readonly Form1 _parent;
        public string id, type, size, color, breed, phonenumber;

        public PetInfo(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdatePet()
        {
            lblAdd.Text = "Update Pet";
            btnSave.Text = "Update";
            txtType.Text = type;
            txtSize.Text = size;
            txtColor.Text = color;
            txtBreed.Text = breed;
            txtPhonenumber.Text = phonenumber;
        }

        public void SaveInfo()
        {
            lblAdd.Text = "Add Pet";
            btnSave.Text = "Save";
        }

       

        public void Clear()
        {
            
            
            txtType.Text = string.Empty;
            txtSize.Text = string.Empty;   
            txtColor.Text = string.Empty;
            txtBreed.Text = string.Empty;    
            txtPhonenumber.Text = string.Empty;
            


        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtType.Text.Trim().Length < 1)
            {
                MessageBox.Show("Pet Type is empty( < 1). ");
                return;
            }
            if (txtSize.Text.Trim().Length < 1)
            {
                MessageBox.Show("Pet Size is empty( < 1). ");
                return;
            }
            if (txtColor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pet Color is empty( < 1). ");
                return;
            }
            if (txtBreed.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pet Breed is empty( > 1). ");
                return;
            }
            if (txtPhonenumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phonenumber is empty( > 1). ");
                return;
            }
            


            if (btnSave.Text == "Save")
            {
               

                Pet pe = new Pet(txtType.Text.Trim(), txtSize.Text.Trim(), txtColor.Text.Trim(), txtBreed.Text.Trim(), txtPhonenumber.Text.Trim()) ;
                PetDB.AddPet(pe);
                Clear();
                
               
            }
            if(btnSave.Text == "Update")
            {
                Pet pe = new Pet(txtType.Text.Trim(), txtSize.Text.Trim(), txtColor.Text.Trim(), txtBreed.Text.Trim(), txtPhonenumber.Text.Trim());
                PetDB.UpdatePet(pe, id);
            }
            _parent.Display();

            
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    } 
}
