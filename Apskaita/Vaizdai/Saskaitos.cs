using System;
using System.Windows.Forms;
using Apskaita.Prezenteriai;

namespace Apskaita.Vaizdai
{
    public partial class Saskaitos : Form, ISaskaitos
    {
        private SaskaitosFormPresenter presenter;

        public BindingSource SaskaitosBindingSource => saskaitosBindingSource;

        public Saskaitos()
        {
            InitializeComponent();
            presenter = new SaskaitosFormPresenter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.IkeltiDuomenis();
        }
    }

    public interface ISaskaitos
    {
        BindingSource SaskaitosBindingSource { get; }
    }
}
