using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 peopleData = new Class1();
            people = peopleData.People;
            dataGridView1.DataSource = people;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                Person newPerson = new Person
                {
                    Name = form2.PersonName,
                    ID = form2.PersonID
                };

                people.Add(newPerson);

                dataGridView1.DataSource = null;  // Clear the data source
                dataGridView1.DataSource = people; // Rebind the updated list
            }
        }

        // Functionality for edit button which also allows deletion
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected person's index from the DataGridView
                int selectedIndex = dataGridView1.CurrentRow.Index;

                // Confirm deletion
                DialogResult result = MessageBox.Show("Do you want to delete this person?",
                                                      "Delete Confirmation",
                                                      MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove the person from the list
                    people.RemoveAt(selectedIndex);

                    // Refresh the DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = people;
                }
            }
            else
            {
                MessageBox.Show("Please select a person to delete.");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int ID { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
