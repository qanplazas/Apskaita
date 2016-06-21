using System.Data;
using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;
using System;

namespace Apskaita.BussinesLogicLayer
{
    public class NurasymasBLL : PajamavimasBLL
    {
        public new event EventHandler ReikiaAtnaujintiAktus;
        public new event EventHandler ReikiaAtnaujintiOperacijas;

        private nurasymo_aktasTableAdapter nurasymoAktasTableAdapter;
        private nurasymo_operacijaTableAdapter nurasymoOperacijaTableAdapter;

        private DataTable nurasymoAktai;
        private DataTable nurasymoOperacijos;

        public NurasymasBLL()
        {
            nurasymoOperacijaTableAdapter = new nurasymo_operacijaTableAdapter();
            nurasymoAktasTableAdapter = new nurasymo_aktasTableAdapter();
        }

        public override DataSet GautiOperacijasPagalAkta()
        {
            DataSet ds = new DataSet();
            nurasymoAktai = nurasymoAktasTableAdapter.GautiNurasymoAktus();
            nurasymoOperacijos = nurasymoOperacijaTableAdapter.GautiNurasymoOperacijas();

            nurasymoAktai.RowChanged += NurasymoAktai_RowChanged;
            nurasymoOperacijos.RowChanged += NurasymoOperacijos_RowChanged;

            nurasymoAktai.RowDeleted += NurasymoAktai_RowChanged;
            nurasymoOperacijos.RowDeleted += NurasymoOperacijos_RowChanged;

            ds.Tables.Add(nurasymoAktai);
            ds.Tables.Add(nurasymoOperacijos);

            ds.Relations.Add("nurasymo_operacija_ibfk_2", ds.Tables[0].Columns["Id"], ds.Tables[1].Columns["AktasId"]);
            return ds;
        }

        private void NurasymoOperacijos_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            nurasymoOperacijaTableAdapter.Update(e.Row);
            if (e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiOperacijas?.Invoke(this, EventArgs.Empty);
            }
        }

        private void NurasymoAktai_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            nurasymoAktasTableAdapter.Update(e.Row);
            if (e.Action == DataRowAction.Add)
            {
                ReikiaAtnaujintiAktus?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}