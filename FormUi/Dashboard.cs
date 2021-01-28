using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUi
{
    public partial class Dashboard : Form
        
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void UpdateFunction()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess database = new DataAccess();
            people = database.GetPeople(lastNameTextbox.Text);

            UpdateFunction(); 
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.insertPerson(FirstNameIns.Text, LastNameIns.Text, EmailIns.Text, PhoneIns.Text);

            FirstNameIns.Text = "";
            LastNameIns.Text = "";
            EmailIns.Text = "";
            PhoneIns.Text = "";
            PhoneIns.Text = "   : ";
            EmailIns.Text = "aDddd";
        }
    }
}
