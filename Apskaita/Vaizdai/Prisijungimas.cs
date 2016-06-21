using System;
using System.Windows.Forms;
using Apskaita.BussinesLogicLayer;

namespace Apskaita.Vaizdai
{
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
        }

        PrisijungimasBLL bll = new PrisijungimasBLL();

        private void button1_Click(object sender, EventArgs e)
        {
            var vardas = textBox1.Text;
            var psw = bll.GautiMD5(maskedTextBox1.Text);
            bool teisingas = bll.TikrintiPrisijungimoDuomenis(vardas, psw);

            if(teisingas)
                DialogResult = DialogResult.OK;
            else
            {
                DialogResult = DialogResult.Retry;
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
