﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Reg_A_Lot_2017
{
    public partial class CreateUpdateStudent : Form
    {
        public CreateUpdateStudent()
        {
            InitializeComponent();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
// --------------------- Idea 1 -----------------------------------------------------------\\

            // When button is clicked, textbox tools ReadOnly property changes from true to false
            // For all textbox tools in the Student Info groupbox (gbxStudentInfo)
            // To allow for editing of information

            MessageBox.Show("The textboxes should become editable.");

            // Also while textbox ReadOnly properties are False btnEditProfessor should change to a Confirm button to confirm a change                     
            // and while textbox ReadOnly properties are False btnCreateProfessor should change to a Cancel button to cancel changes
            // Upon Confirmation or Cancelation, ReadOnly property value of textboxes should change back to true 

            /* If this doesn't work we'll try something else. */

// --------------------- Idea 1 -----------------------------------------------------------\\
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            // The text boxes should become editable and allow for the creation of a new Student to add to the database or so
            // Basically using the same Confirm and Cancel idea as above in the Idea 1 comment ^ Assuming that works
            MessageBox.Show("Should allow for the creation of a new Student.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Closes the window
            this.Hide();
        }
    }
}
