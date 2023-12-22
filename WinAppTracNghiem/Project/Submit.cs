using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Submit : Form
    {
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public Submit()
        {
            InitializeComponent();
        }
        public Submit(String username, String code, int? time) : this()
        {
            Practice p = context.Practices.Where(p => p.Username.Equals(username)
            && p.ExamCode.Equals(code) && p.Status.Equals("done")).FirstOrDefault();
            lbTime.Text = (time / 60) + ":" + ((time % 60 < 10) ? "0" : "") + (time % 60);
            if (p != null)
            {
                lbStatus.Text = "Submit successfully!";
            }
            else { lbStatus.Text = "Submit fail!"; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
