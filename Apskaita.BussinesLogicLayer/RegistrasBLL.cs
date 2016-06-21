using System;
using System.Data;
using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;

namespace Apskaita.BussinesLogicLayer
{
    public class RegistrasBLL
    {
        einamasisLaikotarpisTableAdapter einamasisLaikotarpisTableAdapter;
        private mat_vertTableAdapter turtasTableAdapter;
        padalinysTableAdapter padalinysTableAdapter;

        public RegistrasBLL()
        {
            einamasisLaikotarpisTableAdapter = new einamasisLaikotarpisTableAdapter();
            turtasTableAdapter = new mat_vertTableAdapter();
            padalinysTableAdapter = new padalinysTableAdapter();
        }

        public DataTable GautiEinamojoLaikotarpioRegistra()
        {
            return einamasisLaikotarpisTableAdapter.FormuotiRegistroIrasus();
        }

        public DataTable GautiPadalinius()
        {
            return padalinysTableAdapter.GautiPadalinius();
        }

        public void PerkeltiDuomenisIRegistra(DateTime pradziosData, DateTime pabaigosData)
        {
            var tmpDuomenys = einamasisLaikotarpisTableAdapter.FormuotiRegistroIrasus();
            einamasisLaikotarpisTableAdapter.IterptiIRegistraDuomenis(pradziosData.ToShortDateString(),
                pabaigosData.ToShortDateString());

            var turtas = turtasTableAdapter.GautiMaterialinesVertybes();

            for (int i = 0; i < turtas.Count; i++)
            {
                turtas[i].KiekioLikutis = tmpDuomenys[i].KiekioLikutisPab;
                turtas[i].SumosLikutis = tmpDuomenys[i].SumosLikutisPab;
            }

            turtasTableAdapter.Update(turtas);

            einamasisLaikotarpisTableAdapter.IssaugotiNurasymoAktus();
            einamasisLaikotarpisTableAdapter.IssaugotiPajamavimoAktus();
        }

        public DataTable GautiBuhSaskaitas()
        {
            return new saskaitaTableAdapter().GautiSaskaitas();
        }
    }
}
