using Apskaita.Prezenteriai;
using System;
using System.Windows.Forms;

namespace Apskaita.Vaizdai
{
    public partial class MatoVnt : Form, IMatoVnt
    {
        MatoVntPrezenteris presenter;

        public MatoVnt()
        {
            InitializeComponent();
            presenter = new MatoVntPrezenteris(this);
        }

        BindingSource IMatoVnt.MatoVnt => matoVntBindingSource;
        

        private void MatoVnt_Load(object sender, EventArgs e)
        {
            presenter.GautiDuomenis();
        }
    }

    internal interface IMatoVnt
    {
        BindingSource MatoVnt { get; }
    }
}
