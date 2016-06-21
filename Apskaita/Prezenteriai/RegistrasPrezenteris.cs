using System;
using System.Windows.Forms;
using Apskaita.BussinesLogicLayer;

namespace Apskaita.Prezenteriai
{
    class RegistrasPrezenteris
    {
        private readonly IRegistroVaizdas _vaizdas;
        RegistrasBLL bll = new RegistrasBLL();

        public RegistrasPrezenteris(IRegistroVaizdas vaizdas)
        {
            _vaizdas = vaizdas;
        }

        public void IkeltiDuomenis()
        {
            _vaizdas.Saskaitos.DataSource = bll.GautiBuhSaskaitas();
            _vaizdas.SudarytasRegistras.DataSource = bll.GautiEinamojoLaikotarpioRegistra();
            _vaizdas.Padalinys.DataSource = bll.GautiPadalinius();
            

            _vaizdas.SaskaitosKodasDisplayMember = "Kodas";
            _vaizdas.SaskaitosPavadinimasDisplayMember = "Pavadinimas";
            _vaizdas.PadalinysDisplayMember = "Pavadinimas";
            _vaizdas.PadalinysValueMember = _vaizdas.SaskaitosKodasValueMember = _vaizdas.SaskaitosPavadinimasValueMember = "Id";
        }

        public void PerkeltiDuomenisIRegistra(DateTime t1, DateTime t2)
        {
            bll.PerkeltiDuomenisIRegistra(t1,t2);
            _vaizdas.SudarytasRegistras.DataSource = bll.GautiEinamojoLaikotarpioRegistra();
            MessageBox.Show("Duomenys sėkmingai perkelti į registrą.");
        }
    }

    internal interface IRegistroVaizdas
    {
        BindingSource Saskaitos { get; }
        BindingSource SudarytasRegistras { get; }
        BindingSource Padalinys { get; }

        string SaskaitosKodasValueMember { get; set; }
        string SaskaitosKodasDisplayMember { get; set; }

        string SaskaitosPavadinimasValueMember { get; set; }
        string SaskaitosPavadinimasDisplayMember { get; set; }

        string PadalinysDisplayMember { get; set; }
        string PadalinysValueMember { get; set; }
    }
}
