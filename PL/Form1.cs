using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Interface.BL;
namespace PL
{
    public partial class Form1 : Form
    {
        private iTransducerCtrl mytransducerctrl;
        public Form1()
        {
            InitializeComponent();
            mytransducerctrl = new TransducerController();
            mytransducerctrl.InitTransducer();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mytransducerctrl.StartKalibaration();
        }
    }
}
