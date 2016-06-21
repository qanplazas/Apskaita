using System.Windows.Forms;
using Apskaita.Prezenteriai;

namespace Apskaita.Vaizdai
{
    public partial class Tiekejai : Form, ITiekejaiForm
    {
        public Tiekejai()
        {
            InitializeComponent();
            prezenteris = new TiekejaiFormPresenter(this);
        }

        public BindingSource TiekejaiBindingSource => tiekejaiBindingSource;
        private TiekejaiFormPresenter prezenteris;
        private void Tiekejai_Load(object sender, System.EventArgs e)
        {
            prezenteris.GautiDuomenis();
        }
    }

    public interface ITiekejaiForm
    {
        BindingSource TiekejaiBindingSource { get; }
    }
}
