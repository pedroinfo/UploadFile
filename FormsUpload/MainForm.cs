using FormsUpload.Models;
using FormsUpload.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUpload
{
    public partial class MainForm : Form
    {
        private readonly EmployeeRepository _employeeRepository; 
        public MainForm()
        {
            _employeeRepository = new EmployeeRepository();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            /*
            GridDocuments.DataSource = null;
            GridDocuments.AutoGenerateColumns = false;
            GridDocuments.DataSource = _employeeRepository.GetAllEmployees();*/
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            TxtName.Text = string.Empty;
            TxtFiles.Text = string.Empty;
            TxtFiles.Text = string.Empty;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void SaveForm()
        {

            Employee employee = new Employee();

            _employeeRepository.SaveEmployee(employee);
        }

        private void BtnUploadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                TxtFiles.Text = result.ToString();
            }
        }
    }
}
