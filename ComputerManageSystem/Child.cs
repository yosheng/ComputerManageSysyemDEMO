using ComputerManageSystem.EF_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerManageSystem
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void btn_accept_Click(object sender, EventArgs e)
        {
            List<TextBox> allData = new List<TextBox>();
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    allData.Add(((TextBox)item));
                }
            }
            if (allData.Any(p => String.IsNullOrEmpty(p.Text)))
            {
                MessageBox.Show("填写内容均不能为空");
            }

            ComputerInfo computerInfo = new ComputerInfo()
            {
                ComputerId = txt_computerId.Text,
                Brand = txt_brand.Text,
                CPU = txt_CPU.Text,
                Employee = txt_employee.Text,
                HardDisk = Int32.Parse(txt_hardDisk.Text),
                Memory = Int32.Parse(txt_memory.Text)
            };

            using (var dbContext = new ComputerManagerDBEntities())
            {
                dbContext.ComputerInfo.Add(computerInfo);

                try
                {
                    dbContext.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    if (!(ex.InnerException is UpdateException) || !(ex.InnerException.InnerException is SqlException))
                    {
                        throw;
                    }

                    var sqlException = (SqlException)ex.InnerException.InnerException;
                    List<string> errorMessages = new List<string>();
                    for (var i = 0; i < sqlException.Errors.Count - 1; i++)
                    {
                        errorMessages.Add(sqlException.Errors[i].Message.ToString());
                    }
                    var returnMessage = string.Join("; ", errorMessages);

                    MessageBox.Show(returnMessage);

                }
                catch (DbEntityValidationException ex)
                {
                    var errorMessages = ex.EntityValidationErrors
                           .SelectMany(x => x.ValidationErrors)
                           .Select(x => x.ErrorMessage);

                    MessageBox.Show(String.Join(",", errorMessages));
                }

                MessageBox.Show("提交成功");
            }
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
    }
}
