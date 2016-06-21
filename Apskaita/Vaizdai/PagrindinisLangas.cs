using System;
using System.Windows.Forms;

namespace Apskaita.Vaizdai
{
    public partial class PagrindinisLangas : Form
    {
        public PagrindinisLangas()
        {
            InitializeComponent();
        }

        private void buhSąskaitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form s = new Saskaitos();
            RodytiForma(s);
        }

        private void RodytiForma(Form forma)
        {
            forma.MdiParent = this;
            forma.Show();
        }

        private void pajamavimoAktaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new Pajamavimas());
			
			
        }

        private void išeitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ar tikrai išeiti?", "Patvirtinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void statusoJuostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
            statusoJuostaToolStripMenuItem.Checked = !statusoJuostaToolStripMenuItem.Checked;
        }

        #region LanguIsdestymas
        private void lygiuotiVerikaliaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void lygiuotiHorizontaliaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void lygiuotiPakopomisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        #endregion

        private void nurašymoAktaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new Nurasymas());
        }

        private void registroPeržiūraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new RegistroPerziura());
        }

        private void PagrindinisLangas_Load(object sender, EventArgs e)
        {
            
        }

        public void CheckStatus(Prisijungimas p)
        {
            switch (p.ShowDialog())
            {
                 case DialogResult.Retry:
                    CheckStatus(p);   
                    break;
                    case DialogResult.Abort:
                    Close();
                    break;
                    case DialogResult.OK:
                    break;
            }
        }

        private void PagrindinisLangas_Shown(object sender, EventArgs e)
        {
            Prisijungimas p = new Prisijungimas();
            CheckStatus(p);
        }

        private void tiekejaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new Tiekejai());
        }

        private void turtasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new MaterialinesVertybes());
        }

        private void matavimoVienetaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new MatoVnt());
        }

        private void testasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void likučiaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RodytiForma(new Ataskaita());
        }
    }
}
