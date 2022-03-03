using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P225WinFotm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_1_Click(object sender, EventArgs e)
        {
            ulong result = await LoopAsync();
            lbl_1.Text = result.ToString();
        }

        private async Task<ulong> LoopAsync()
        {
            ulong result = 0;

            Task task = Task.Run(() =>
            {
                for (ulong i = 0; i < 9999999999; i++)
                {
                    result += i;
                }
            });

            await task;

            return result;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_2.Text = "P225 Code Academy";
        }
    }
}
