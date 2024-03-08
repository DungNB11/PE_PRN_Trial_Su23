using Q2.Models;

namespace Q2
{
    public partial class Form1 : Form
    {
        public PE_Fall21B5Context context;
        public Form1()
        {
            InitializeComponent();
            context = new PE_Fall21B5Context();
        }
        private void loadData()
        {
            dgvEmployee.DataSource = null;
            dgvEmployee.DataSource = (from emp in context.Employees
                                      select new
                                      {
                                          emp.Id,
                                          emp.Name,
                                          emp.Sex,
                                          emp.Dob,
                                          emp.Position
                                      }).ToList();

            cbPosition.DataSource = context.Employees.Select(x => x.Position).Distinct().ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            txtId.Text = dgvEmployee.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            if (dgvEmployee.Rows[e.RowIndex].Cells[2].FormattedValue.ToString().Equals("Male"))
            {
                rbMale.Checked = true;
            }
            else { rbFemale.Checked = true; }
            dtpDOB.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbPosition.SelectedItem = dgvEmployee.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            txtId.Clear();
            txtName.Clear();
            rbFemale.Checked = false; rbMale.Checked = false;
            dtpDOB.Refresh();
            cbPosition.SelectedIndex = 0;
        }

        private Employee GetEmployee()
        {
            Employee employee = new Employee();

            employee.Name = txtName.Text;
            string sex = "";
            if (rbFemale.Checked)
            {
                sex = "Female";
            }
            if (rbMale.Checked)
            {
                sex = "Male";
            }
            employee.Sex = sex;
            employee.Dob = DateTime.Parse(dtpDOB.Text);
            employee.Position = cbPosition.SelectedItem.ToString();
            return employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = GetEmployee();
                context.Employees.Add(emp);
                context.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                Employee newSup = GetEmployee();
                Employee updateSup = context.Employees.FirstOrDefault(x => x.Id == id);

                updateSup.Name = newSup.Name;
                updateSup.Sex = newSup.Sex;
                updateSup.Dob = newSup.Dob;
                updateSup.Position = newSup.Position;
                context.Employees.Update(updateSup);
                context.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
