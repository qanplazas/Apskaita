using System.Data;
using System.Windows.Forms;
using Apskaita.Prezenteriai;

namespace Apskaita.Vaizdai
{
    public partial class Pajamavimas : Form, IAktaiForma
    {
        public Pajamavimas()
        {
            InitializeComponent();
            prezenteris = new PajamavimoAktaiFormPresenter(this);
        }

        #region ypatybes
        public BindingSource Padaliniai
        {
            get
            {
                return padaliniaiBindingSource;
            }
        }
        public BindingSource Aktai { get { return aktaiBindingSource; } }
        public BindingSource Operacijos { get { return operacijosBindingSource; } }
        public BindingSource Turtas { get { return turtasBindingSource; } }
        public BindingSource Tiekejai { get { return tiekejaiBindingSource; } }
        public string TiekejasDisplayMember
        {
            get { return TiekejasColumn.DisplayMember; }
            set
            {
                TiekejasColumn.DisplayMember = value;
            }
        }
        public string TiekejasValueMember
        {
            get { return TiekejasColumn.ValueMember; }
            set
            {
                TiekejasColumn.ValueMember = value;
            }
        }

        public string TurtoKodasDisplayMember
        {
            get { return KodasColumn.DisplayMember; }
            set { KodasColumn.DisplayMember = value; }
        }

        public string TurtoKodasValueMember
        {
            get { return KodasColumn.ValueMember; }
            set { KodasColumn.ValueMember = value; }
        }

        public string TurtoPavadinimasDisplayMember
        {
            get { return PavadinimasColumn.DisplayMember; }
            set
            {
                PavadinimasColumn.DisplayMember = value;
            }
        }
        public string TurtoPavadinimasValueMember
        {
            get { return PavadinimasColumn.ValueMember; }
            set
            {
                PavadinimasColumn.ValueMember = value;
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
        #endregion

        private PajamavimoAktaiFormPresenter prezenteris;

        private void Pajamavimas_Load(object sender, System.EventArgs e)
        {
            prezenteris.GautiDuomenis();
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }

    public interface IAktaiForma
    {
        BindingSource Aktai { get; }
        BindingSource Operacijos { get; }
        BindingSource Turtas { get; }
        BindingSource Tiekejai { get; }
        BindingSource Padaliniai { get; }

        string TiekejasDisplayMember { get; set; }
        string TiekejasValueMember { get; set; }

        string PadalinysDisplayMember { get; set; }
        string PadalinysValueMember { get; set; }

        string TurtoKodasDisplayMember { get; set; }
        string TurtoKodasValueMember { get; set; }

        string TurtoPavadinimasDisplayMember { get; set; }
        string TurtoPavadinimasValueMember { get; set; }
    }
}
