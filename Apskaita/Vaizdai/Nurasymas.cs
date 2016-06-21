using System;
using System.Windows.Forms;
using Apskaita.Prezenteriai;
using System.Data;

namespace Apskaita.Vaizdai
{
    public partial class Nurasymas : Form, IAktaiForma
    {
        public Nurasymas()
        {
            InitializeComponent();
            prezenteris = new NurasymoAktaiFormPresenter(this);
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

        public BindingSource Padaliniai
        {
            get
            {
                return padaliniaiBindingSource;
            }
        }

        private NurasymoAktaiFormPresenter prezenteris;
        private void Nurasymas_Load(object sender, EventArgs e)
        {
            prezenteris.GautiDuomenis();
        }
    }
}
