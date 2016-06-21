using System.Windows.Forms;
using Apskaita.Prezenteriai;

namespace Apskaita.Vaizdai
{
    public partial class RegistroPerziura : Form, IRegistroVaizdas
    {
        public RegistroPerziura()
        {
            InitializeComponent();
            prezenteris = new RegistrasPrezenteris(this);
        }

        public BindingSource Saskaitos { get {return buhSaskBindingSource;} }
        public BindingSource SudarytasRegistras { get { return einamLaikotarpRegistrasBindingSource; } }
        public string SaskaitosKodasValueMember { get { return SaskaitaKodasColumn.ValueMember; } set
        {
            SaskaitaKodasColumn.ValueMember = value;
        } }
        public string SaskaitosKodasDisplayMember { get { return SaskaitaKodasColumn.DisplayMember; } set
        {
            SaskaitaKodasColumn.DisplayMember = value;
        } }
        public string SaskaitosPavadinimasValueMember { get { return SaskaitosPavadinimasColumn.ValueMember; } set
        {
            SaskaitosPavadinimasColumn.ValueMember = value;
        } }
        public string SaskaitosPavadinimasDisplayMember { get { return SaskaitosPavadinimasColumn.DisplayMember; } set
        {
            SaskaitosPavadinimasColumn.DisplayMember = value;
        } }

        public BindingSource Padalinys
        {
            get
            {
                return padalinysBindingSource;
            }
        }

        public string PadalinysDisplayMember
        {
            get
            {
                return padalinysColumn.DisplayMember;
            }

            set
            {
                padalinysColumn.DisplayMember = value;
            }
        }

        public string PadalinysValueMember
        {
            get
            {
                return padalinysColumn.ValueMember;
            }

            set
            {
                padalinysColumn.ValueMember = value;
            }
        }

        private RegistrasPrezenteris prezenteris;

        private void RegistroPerziura_Load(object sender, System.EventArgs e)
        {
            prezenteris.IkeltiDuomenis();
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            NuoIki nk = new NuoIki();
            if (nk.ShowDialog() == DialogResult.OK)
                prezenteris.PerkeltiDuomenisIRegistra(nk.Nuo, nk.Iki);
        }
    }
}
