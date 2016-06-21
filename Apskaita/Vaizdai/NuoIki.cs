using System;
using System.Windows.Forms;

namespace Apskaita.Vaizdai
{
    public partial class NuoIki : Form
    {
        public NuoIki()
        {
            InitializeComponent();
        }


        public DateTime Nuo { get { return dateTimePicker1.Value; } }
        public DateTime Iki { get { return dateTimePicker2.Value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
