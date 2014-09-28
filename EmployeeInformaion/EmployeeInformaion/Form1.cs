using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformaion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> idList = new List<int>();
        List<string> nameList = new List<string>();
        List<double> salaryList = new List<double>();
        List<string> addressList = new List<string>(); 

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string name = nameTextBox.Text;
            double salary = Convert.ToDouble(salaryTextBox.Text);
            string address = addressTextBox.Text;

            SaveEmployee(id, name, salary, address);
            InsertIntoListView(id, name, salary);
        }

        private void InsertIntoListView(int id, string name, double salary)
        {
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(name);
            item.SubItems.Add(salary.ToString());
            listView1.Items.Add(item);
        }

        private void SaveEmployee(int id, string name, double salary, string address)
        {
            idList.Add(id);
            nameList.Add(name);
            salaryList.Add(salary);
            addressList.Add(address);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listView1.SelectedIndices[0];
            idTextBox.Text = idList[selectedIndex].ToString();
            nameTextBox.Text = nameList[selectedIndex];
            salaryTextBox.Text = salaryList[selectedIndex].ToString();
            addressTextBox.Text = addressList[selectedIndex];

        }

       
    }
}
