using System.Data;
using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;
using System;

namespace Apskaita.BussinesLogicLayer
{
    public class PajamavimasBLL
    {
        private readonly pajamavimo_aktasTableAdapter pajamavimoAktasTableAdapter;
        private readonly pajamavimo_operacijaTableAdapter pajamavimoOperacijaTableAdapter;
        private readonly mat_vertTableAdapter turtasTableAdapter;
        private readonly tiekejasTableAdapter tiekejasTableAdapter;
        private readonly padalinysTableAdapter padaliniaiTableAdapter;

        private DataTable pajamavimoAktaiDT;
        private DataTable pajamavimoOperacijosDT;

        public event EventHandler ReikiaAtnaujintiAktus;
        public event EventHandler ReikiaAtnaujintiOperacijas;

        public PajamavimasBLL()
        {
            turtasTableAdapter = new mat_vertTableAdapter();
            pajamavimoAktasTableAdapter = new pajamavimo_aktasTableAdapter();
            pajamavimoOperacijaTableAdapter = new pajamavimo_operacijaTableAdapter();
            tiekejasTableAdapter = new tiekejasTableAdapter();
            padaliniaiTableAdapter = new padalinysTableAdapter();
        }

        public DataTable GautiPadalinius()
        {
            return padaliniaiTableAdapter.GautiPadalinius();
        }

        public DataTable GautiTurta()
        {
            return turtasTableAdapter.GautiMaterialinesVertybes();
        }

        public DataTable GautiTiekejus()
        {
            return tiekejasTableAdapter.GautiTiekejus();
        }

        public virtual DataSet GautiOperacijasPagalAkta()
        {
            DataSet ds = new DataSet();
            pajamavimoAktaiDT = pajamavimoAktasTableAdapter.GautiPajamavimoAktus();
            pajamavimoOperacijosDT = pajamavimoOperacijaTableAdapter.GautiPajamavimoOperacijas();

            pajamavimoAktaiDT.RowChanged += PajamavimoAktaiDT_RowChanged;
            pajamavimoOperacijosDT.RowChanged += PajamavimoOperacijosDT_RowChanged;

            pajamavimoAktaiDT.RowDeleted += PajamavimoAktaiDT_RowChanged;
            pajamavimoOperacijosDT.RowDeleted += PajamavimoOperacijosDT_RowChanged;

            ds.Tables.Add(pajamavimoAktaiDT);
            ds.Tables.Add(pajamavimoOperacijosDT);

            //ryšio pavadinimas pasirenkamas laisvai, bet dėl patogumo naudojamas numatytas pavadinimas
            ds.Relations.Add("pajamavimo_operacija_ibfk_2", ds.Tables[0].Columns["Id"], ds.Tables[1].Columns["AktasId"]);
            return ds;
        }

        private void PajamavimoOperacijosDT_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            pajamavimoOperacijaTableAdapter.Update(e.Row);

            if(e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiOperacijas?.Invoke(this, EventArgs.Empty);
            }
        }

        private void PajamavimoAktaiDT_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            pajamavimoAktasTableAdapter.Update(e.Row);
            if(e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiAktus?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}