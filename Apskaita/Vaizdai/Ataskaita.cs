using Apskaita.Prezenteriai.Ataskaitos;
using System.Windows.Forms;

namespace Apskaita.Vaizdai
{
    public partial class Ataskaita : Form, ILikuciaiAtaskaitaView
    {
        LikuciaiAtaskaitaPrezenteris p;

        public BindingSource AtaskaitaBindingSuorce
        {
            get
            {
                return AtaskaitosDataSetBindingSource;
            }
        }

        public BindingSource Padaliniai
        {
            get
            {
                return padalinysBindingSource;
            }
        }

        public BindingSource Saskaitos
        {
            get
            {
                return saskaitosBindingSource;
            }
        }

        public Ataskaita()
        {
            InitializeComponent();
            p = new LikuciaiAtaskaitaPrezenteris(this);
        }

        private void NupirktaPagalTiekeja_Load(object sender, System.EventArgs e)
        {
            p.ikelti();
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var pdlId = int.Parse(tiekejasComboBox.SelectedValue.ToString());
            p.IkeltiDuomenis(nuoDateTimePicker.Value, ikiDateTimePicker.Value, pdlId);
            reportViewer1.RefreshReport();
        }
    }

    internal interface ILikuciaiView
    {
        BindingSource Padaliniai { get; }
        BindingSource Saskaitos { get; }
    }

    interface IAtaskaitaView : ILikuciaiView
    {
        BindingSource AtaskaitaBindingSuorce { get; }
    }


    internal interface ILikuciaiAtaskaitaView : IAtaskaitaView
    {
    }
}
