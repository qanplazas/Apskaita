using System.Data;
using Apskaita.BussinesLogicLayer;
using Apskaita.Vaizdai;
using static Apskaita.DataAccessLayer.ApskaitaDataSet;

namespace Apskaita.Prezenteriai
{
    public class SaskaitosFormPresenter
    {
        private ISaskaitos _view;
        public DataTable Duomenys { get; private set; }
        SaskaitosBLL bll = new SaskaitosBLL();
        public SaskaitosFormPresenter(ISaskaitos view)
        {
            _view = view;
            Duomenys = new saskaitaDataTable();
            bll.ReikiaAtnaujintiDuomenis += Bll_ReikiaAtnaujintiDuomenis;
        }

        private void Bll_ReikiaAtnaujintiDuomenis(object sender, System.EventArgs e)
        {
            _view.SaskaitosBindingSource.DataSource = bll.GautiSaskaitas();
        }

        public void IkeltiDuomenis()
        {
            Duomenys = bll.GautiSaskaitas();
            _view.SaskaitosBindingSource.DataSource = Duomenys;
        }

        public string GautiPasirinktosSaskaitosPavadinima()
        {
            return (_view.SaskaitosBindingSource.Current as DataRowView)["Pavadinimas"].ToString();
        }
    }
}