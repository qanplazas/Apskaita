using System;
using System.Data;
using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;

namespace Apskaita.BussinesLogicLayer
{
    public class TiekejaiBLL
    {
        private readonly tiekejasTableAdapter tableAdapter = new tiekejasTableAdapter();
        private DataTable tiekejai;

        public event EventHandler ReikiaAtnaujintiDuomenis;

        public TiekejaiBLL()
        {
        }

        public DataTable GautiDuomenis()
        {
            tiekejai = tableAdapter.GautiTiekejus();
            tiekejai.RowChanged += Tiekejai_RowChanged;
            tiekejai.RowDeleted += Tiekejai_RowChanged;
            return tiekejai;
        }

        private void Tiekejai_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            tableAdapter.Update(e.Row);
            if(e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiDuomenis(this, EventArgs.Empty);
            }
        }
    }
}