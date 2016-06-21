using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;
using System;
using System.Data;

namespace Apskaita.BussinesLogicLayer
{
    public class MatoVntBLL
    {

        matovntTableAdapter matoVntTableAdapter = new matovntTableAdapter();
        DataTable matoVntDT;

        public event EventHandler ReikiaAtnaujintiDuomenis;

        public DataTable GautiDuomenis()
        {
            matoVntDT = matoVntTableAdapter.GautiMatoVienetus();
            matoVntDT.RowChanged += MatoVntDT_RowChanged;
            matoVntDT.RowDeleted += MatoVntDT_RowChanged;
            return matoVntDT;
        }

        private void MatoVntDT_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            matoVntTableAdapter.Update(e.Row);
            if(e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiDuomenis?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
