using System;
using System.Data;
using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;

namespace Apskaita.BussinesLogicLayer
{
    public class SaskaitosBLL 
    {
        private saskaitaTableAdapter tableAdapter;
        private DataTable saskaitosDT;

        public event EventHandler ReikiaAtnaujintiDuomenis;

        public SaskaitosBLL()
        {
            tableAdapter = new saskaitaTableAdapter();
        }

        public DataTable GautiSaskaitas()
        {
            saskaitosDT = tableAdapter.GautiSaskaitas();
            saskaitosDT.RowChanged += SaskaitosDT_RowChanged;
            saskaitosDT.RowDeleted += SaskaitosDT_RowChanged;
            return saskaitosDT;
        }

        private void SaskaitosDT_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            tableAdapter.Update(e.Row);
            if (e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiDuomenis?.Invoke(this, EventArgs.Empty);
            }

        }
    }
}
