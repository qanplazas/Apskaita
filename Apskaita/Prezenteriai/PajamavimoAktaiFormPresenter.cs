using Apskaita.BussinesLogicLayer;
using Apskaita.Vaizdai;

namespace Apskaita.Prezenteriai
{
    public class PajamavimoAktaiFormPresenter
    {
        protected readonly IAktaiForma _vaizdas;

        private PajamavimasBLL bll;

        public PajamavimoAktaiFormPresenter(IAktaiForma vaizdas)
        {
            _vaizdas = vaizdas;
            bll = new PajamavimasBLL();
            bll.ReikiaAtnaujintiAktus += Bll_ReikiaAtnaujintiAktus;
        }

        private void Bll_ReikiaAtnaujintiAktus(object sender, System.EventArgs e)
        {
            Aktai_Operacijos();
        }

        public void GautiDuomenis()
        {
            Aktai_Operacijos();
            _vaizdas.Turtas.DataSource = bll.GautiTurta();
            _vaizdas.Tiekejai.DataSource = bll.GautiTiekejus();
            _vaizdas.Padaliniai.DataSource = bll.GautiPadalinius();
            _vaizdas.TiekejasDisplayMember = "Pavadinimas";
            _vaizdas.TurtoKodasDisplayMember = "Kodas";
            _vaizdas.TurtoPavadinimasDisplayMember = "Pavadinimas";
            _vaizdas.PadalinysDisplayMember = "Pavadinimas";
            _vaizdas.PadalinysValueMember = _vaizdas.TiekejasValueMember = _vaizdas.TurtoKodasValueMember = _vaizdas.TurtoPavadinimasValueMember = "Id";
        }

        //aktai ir susijusios operacijos susiejamos ryšium vienas su daugeliu
        public virtual void Aktai_Operacijos()
        {
            var dataSet = bll.GautiOperacijasPagalAkta();
            _vaizdas.Aktai.DataSource = dataSet.Tables["pajamavimo_aktas"];
            _vaizdas.Operacijos.DataSource = _vaizdas.Aktai;
            _vaizdas.Operacijos.DataMember = "pajamavimo_operacija_ibfk_2";
 //           _vaizdas.Turtas.DataSource = bll.GautiTurta();
        }
    }
}
