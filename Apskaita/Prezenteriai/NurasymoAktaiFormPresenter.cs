using System.Data;
using Apskaita.BussinesLogicLayer;
using Apskaita.Vaizdai;

namespace Apskaita.Prezenteriai
{
    public class NurasymoAktaiFormPresenter : PajamavimoAktaiFormPresenter
    {
        public NurasymoAktaiFormPresenter(IAktaiForma vaizdas) : base(vaizdas)
        {
            bll = new NurasymasBLL();
            bll.ReikiaAtnaujintiAktus += Bll_ReikiaAtnaujintiPajamavimoAktus;
        }

        private void Bll_ReikiaAtnaujintiPajamavimoAktus(object sender, System.EventArgs e)
        {
            Aktai_Operacijos();
        }

        private NurasymasBLL bll;
        public DataTable NurasymoAktai { get; private set; }
        public DataTable NurasymoOperacija { get; private set; }

        public override void Aktai_Operacijos()
        {
            var dataSet = bll.GautiOperacijasPagalAkta();

            _vaizdas.Aktai.DataSource = dataSet.Tables["nurasymo_aktas"];
            _vaizdas.Operacijos.DataSource = _vaizdas.Aktai;
            _vaizdas.Operacijos.DataMember = "nurasymo_operacija_ibfk_2";
 //           _vaizdas.Turtas.DataSource = bll.GautiTurta();
        }
    }
}