using System;
using Apskaita.Vaizdai;
using Apskaita.BussinesLogicLayer;

namespace Apskaita.Prezenteriai
{
    class MatoVntPrezenteris
    {
        private IMatoVnt matoVnt;

        private readonly MatoVntBLL bll = new MatoVntBLL();

        public MatoVntPrezenteris(IMatoVnt matoVnt)
        {
            this.matoVnt = matoVnt;
            bll.ReikiaAtnaujintiDuomenis += Bll_ReikiaAtnaujintiDuomenis;
        }

        private void Bll_ReikiaAtnaujintiDuomenis(object sender, EventArgs e)
        {
            GautiDuomenis();
        }

        public void GautiDuomenis()
        {
            matoVnt.MatoVnt.DataSource = bll.GautiDuomenis();
        }
    }
}
