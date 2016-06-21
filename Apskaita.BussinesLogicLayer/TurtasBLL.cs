using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;
using System.Data;
using System;

namespace Apskaita.BussinesLogicLayer
{
    public class TurtasBLL 
    {
        private readonly mat_vertTableAdapter turtasTableAdapter = new mat_vertTableAdapter();
        private readonly saskaitaTableAdapter saskaitaTableAdapter = new saskaitaTableAdapter();
        private readonly padalinysTableAdapter padalinysTableAdapter = new padalinysTableAdapter();
        private readonly matovntTableAdapter matoVntTableAdapter = new matovntTableAdapter();

        private DataTable turtas;

        public event EventHandler ReikiaAtnaujintiDuomenis;

        public DataTable GautiDuomenis()
        {
            turtas = turtasTableAdapter.GautiMaterialinesVertybes();
            turtas.RowChanged += Turtas_RowChanged;
            turtas.RowDeleted += Turtas_RowChanged;
            return turtas;
        }

        private void Turtas_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            turtasTableAdapter.Update(e.Row);
            if (e.Action == DataRowAction.Add)
                ReikiaAtnaujintiDuomenis?.Invoke(this, EventArgs.Empty);
        }

        public DataTable GautiMatoVnt()
        {
            return matoVntTableAdapter.GautiMatoVienetus();
        }

        public DataTable GautiSaskaitas()
        {
            return saskaitaTableAdapter.GautiSaskaitas();
        }

        public DataTable GautiPadalinius()
        {
            return padalinysTableAdapter.GautiPadalinius();
        }
    }

}
