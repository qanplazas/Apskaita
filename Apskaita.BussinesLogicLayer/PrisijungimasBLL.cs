using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Apskaita.DataAccessLayer.ApskaitaDataSetTableAdapters;
using static Apskaita.DataAccessLayer.ApskaitaDataSet;

namespace Apskaita.BussinesLogicLayer
{
    public class PrisijungimasBLL
    {
        private readonly prisijungimasTableAdapter tableAdapter = new prisijungimasTableAdapter();
        private prisijungimasDataTable prisijungimasDT = new prisijungimasDataTable();

        public bool TikrintiPrisijungimoDuomenis(string prisijungimo_vardas, string md5)
        {
            if (this.prisijungimasDT.Count == 0) //jei duomenys i lentele dar neikelti
            {
                IkeltiDuomenis();
            }
            var prisijungimas = prisijungimasDT.FirstOrDefault(x => x.prisij_vardas == prisijungimo_vardas);
            if(prisijungimas != null)
            {
                if(prisijungimas.slaptaz == md5)
                {
                    return true;
                }
            }
            return false;
        }

        private void IkeltiDuomenis()
        {
            prisijungimasDT = tableAdapter.GautiPrisijungimus();
        }

        public string GautiMD5(string input)
        {
            return createMD5(MD5.Create(), input);
        }

        private string createMD5(MD5 md5, string input)
        {
            var sifroBaitai = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            StringBuilder b = new StringBuilder();

            for (int i = 0; i < sifroBaitai.Length; i++)
            {
                b.Append(sifroBaitai[i].ToString("x2"));
            }

            return b.ToString();
        }
    }
}