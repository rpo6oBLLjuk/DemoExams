using DemoExam2024.Forms.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam2024.Forms
{
    public partial class WorkerPanel : Form
    {
        public WorkerPanel()
        {
            InitializeComponent();
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<ChangeRequestStatus>(false);
        }
    }
}
