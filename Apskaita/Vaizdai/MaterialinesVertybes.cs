using System;
using System.Windows.Forms;

namespace Apskaita.Vaizdai
{
    public partial class MaterialinesVertybes : Form, ITurtasForma
    {
        private Prezenteriai.TurtasPrezenteris prezenteris;

        public MaterialinesVertybes()
        {
            InitializeComponent();
            prezenteris = new Prezenteriai.TurtasPrezenteris(this);
        }

        #region ITurtasForma
        public BindingSource Padaliniai
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

        public BindingSource Saskaitos
        {
            get
            {
                return saskaitosBindingSource;
            }
        }

        public string SaskaitosKodasDisplayMember
        {
            get
            {
                return buhSaskaita.DisplayMember;
            }

            set
            {
                buhSaskaita.DisplayMember = value;
            }
        }

        public string SaskaitosKodasValueMember
        {
            get
            {
                return buhSaskaita.ValueMember;
            }

            set
            {
                buhSaskaita.ValueMember = value;
            }
        }

        public string SaskaitosPavadinimasDisplayMember
        {
            get
            {
                return buhSaskaitaPavadinimas.DisplayMember;
            }

            set
            {
                buhSaskaitaPavadinimas.DisplayMember = value;
            }
        }

        public string SaskaitosPavadinimasValueMember
        {
            get
            {
                return buhSaskaitaPavadinimas.ValueMember;
            }

            set
            {
                buhSaskaitaPavadinimas.ValueMember = value;
            }
        }

        BindingSource ITurtasForma.Turtas
        {
            get
            {
                return turtasBindingSource;
            }
        }

        public BindingSource MatoVnt
        {
            get
            {
                return matoVntBindingSource;
            }
        }

        public string MatoVntDisplayMember
        {
            get
            {
                return matoVntColumn.DisplayMember;
            }

            set
            {
                matoVntColumn.DisplayMember = value;
            }
        }

        public string MatoVntValueMember
        {
            get
            {
                return matoVntColumn.ValueMember;
            }

            set
            {
                matoVntColumn.ValueMember = value;
            }
        }
        #endregion

        private void MaterialinesVertybes_Load(object sender, EventArgs e)
        {
            prezenteris.GautiDuomenis();
        }

        private void atnaujintiToolStripButton_Click(object sender, EventArgs e)
        {
            prezenteris.GautiDuomenis();
        }
    }

    public interface ITurtasForma
    {
        BindingSource Turtas { get; }
        BindingSource Saskaitos { get; }
        BindingSource Padaliniai { get; }
        BindingSource MatoVnt { get; }

        string PadalinysDisplayMember { get; set; }
        string PadalinysValueMember { get; set; }

        string SaskaitosKodasDisplayMember { get; set; }
        string SaskaitosKodasValueMember { get; set; }

        string SaskaitosPavadinimasDisplayMember { get; set; }
        string SaskaitosPavadinimasValueMember { get; set; }

        string MatoVntDisplayMember { get; set; }
        string MatoVntValueMember { get; set; }
    }
}
