using Apskaita.BussinesLogicLayer;
using Apskaita.Vaizdai;
using System.Data;

namespace Apskaita.Prezenteriai
{
    public class TurtasPrezenteris
    {
        private ITurtasForma turtas;
        private TurtasBLL bll;
        public DataTable Duomenys { get; private set; }
        public TurtasPrezenteris(ITurtasForma turtas)
        {
            this.turtas = turtas;
            bll = new TurtasBLL();
            bll.ReikiaAtnaujintiDuomenis += Bll_ReikiaAtnaujintiDuomenis;
        }

        private void Bll_ReikiaAtnaujintiDuomenis(object sender, System.EventArgs e)
        {
            turtas.Turtas.DataSource = bll.GautiDuomenis();
        }

        public void GautiDuomenis()
        {
            Duomenys = bll.GautiDuomenis();
            turtas.Turtas.DataSource = Duomenys;
            turtas.Saskaitos.DataSource = bll.GautiSaskaitas();
            turtas.Padaliniai.DataSource = bll.GautiPadalinius();
            turtas.MatoVnt.DataSource = bll.GautiMatoVnt();

            turtas.PadalinysDisplayMember = "Pavadinimas";
            turtas.SaskaitosKodasDisplayMember = "Kodas";
            turtas.SaskaitosPavadinimasDisplayMember = "Pavadinimas";
            turtas.MatoVntDisplayMember = "Pavad";

            turtas.MatoVntValueMember = turtas.SaskaitosPavadinimasValueMember = turtas.SaskaitosKodasValueMember = turtas.PadalinysValueMember = "Id";
        }
    }
}