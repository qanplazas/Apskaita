using System.Windows.Forms;

namespace Apskaita.Valdikliai
{
    public class DuomenuSarasas : DataGridView
    {
        public DuomenuSarasas()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DuomenuSarasas
            // 
            this.AllowUserToAddRows = false;
            this.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DuomenuSarasas_DataError);
            this.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.OnEditCtrlShowing);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void OnEditCtrlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var ctrl = e.Control as ComboBox;
            if(ctrl != null)
            {
                ctrl.DropDownStyle = ComboBoxStyle.DropDown;
                ctrl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ctrl.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void DuomenuSarasas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
