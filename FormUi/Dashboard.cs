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
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess database = new DataAccess();
            people = database.GetPeople(lastNameTextbox.Text);

            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }
    }
}
