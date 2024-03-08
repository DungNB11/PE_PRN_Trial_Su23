using Q1.DAO;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            List<Employee> employees = EmployeeDAO.getListEmployee();
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = employees;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPosition.SelectedIndex = 0;
            loadData();
        }

        private void search()
        {
            string searchName = txtName.Text;
            string searchPos = cbPosition.SelectedItem.ToString();
            if (searchPos.Equals("All positions"))
            {
                searchPos = "";
            }
            string searchGender = selectedGender();
            List<Employee> list = EmployeeDAO.getListEmployee().Where(e => e.Name.Contains(searchName) &&
                                            e.Position.Contains(searchPos) &&
                                            e.Sex.Contains(searchGender)).ToList();
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = list;
        }

        private string selectedGender()
        {
            if (rbMale.Checked)
                return "Male";
            else if (rbFemale.Checked)
                return "Female";
            else
                return "";
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
