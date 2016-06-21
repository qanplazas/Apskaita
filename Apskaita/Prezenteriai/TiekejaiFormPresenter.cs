using System;
using Apskaita.BussinesLogicLayer;
using Apskaita.Vaizdai;

namespace Apskaita.Prezenteriai
{
    public class TiekejaiFormPresenter
    {
        TiekejaiBLL bll = new TiekejaiBLL();

        private ITiekejaiForm _view;

        public TiekejaiFormPresenter(ITiekejaiForm view)
        {
            _view = view;
            bll.ReikiaAtnaujintiDuomenis += Bll_ReikiaAtnaujintiDuomenis;
        }

        private void Bll_ReikiaAtnaujintiDuomenis(object sender, EventArgs e)
        {
            GautiDuomenis();
        }

        public void GautiDuomenis()
        {
          _view.TiekejaiBindingSource.DataSource =  bll.GautiDuomenis();
        }

    }
}