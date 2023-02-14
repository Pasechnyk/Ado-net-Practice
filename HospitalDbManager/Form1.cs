using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDbApp
{
    // Hospital Manager with Windows Forms Interface
    public partial class Form1 : Form
    {
        HospitalDbManager manager = new HospitalDbManager();
        public Form1()
        {
            InitializeComponent();
        }

        // Button 1 - Get Wards count by name
        private void GetWardsByDepartmentBtnClick(object sender, EventArgs e)
        {
            string name = departmentBox.Text;

            try
            {
                manager.GetAmountByName(name);
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 2 - Get Examination list
        private void GetExaminationsBtnClick(object sender, EventArgs e)
        {
            try
            {
                manager.GetExaminations();
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 3 - Delete Examinations held before given date
        private void DeleteExaminationBtnClick(object sender, EventArgs e)
        {
            string date = endDateMaskedBox.Text;

            try
            {
                manager.DeleteExamination(date);
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 4 - Get Doctor with given or higher Salary amount
        private void GetDoctorsBySalaryBtnClick(object sender, EventArgs e)
        {
            int salary = (int)salaryNumeric.Value;

            try
            {
                manager.GetBySalary(salary);
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 5 - Get biggest Donation made
        private void GetBiggestDonationBtnClick(object sender, EventArgs e)
        {
            try
            {
                manager.GetBiggestDonation();
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button 6 - Add new Examination with properties
        private void AddNewExaminationBtnClick(object sender, EventArgs e)
        {
            int id = (int)idNumeric.Value;
            string name = examNameBtn.Text;
            int day = (int)dayNumeric.Value;
            string start = startBtn.Text;
            string end = endBtn.Text;

            try
            {
                manager.AddExamination(id, name, day, start, end);
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Button 7* - Delete Sponsor who didn't donate any money
        private void DeleteSponsorBtnClick(object sender, EventArgs e)
        {
            try
            {
                manager.DeleteSponsor();
                MessageBox.Show("Operation was successfully completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
