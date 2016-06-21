using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;
using Apskaita.DataAccessLayer.AtaskaitosDataSetTableAdapters;
using System;
using System.Data;

namespace Apskaita.BussinesLogicLayer.Ataskaita
{
    public class LikuciaiBLL
    {
        public DataTable GautiAtaskaitosDuomenis(DateTime pradzia, DateTime pabaiga, int padalinysId)
        {
            likuciaiTableAdapter ad = new likuciaiTableAdapter();
            ad.ClearBeforeFill = true;
            DataTable duom = new DataTable();
            duom = ad.GautiDuomenis(pradzia, pabaiga, padalinysId);
            return duom;
        }

        public DataTable GautiPadalinius()
        {
            return new padalinysTableAdapter().GautiPadalinius();
        }

        public DataTable GautiBuhSaskaitas()
        {
            return new saskaitaTableAdapter().GautiSaskaitas();
        }
    }
}
