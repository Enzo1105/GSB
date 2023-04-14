using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmVisiteConsultation : FrmBase {
        public FrmVisiteConsultation() {
            InitializeComponent();
        }

        private void FrmVisiteConsultaton_Load(object sender, EventArgs e) {

            // Parametrage du datagridview
            dgvVisites.AllowUserToResizeColumns = false;
            dgvVisites.AllowUserToResizeRows = false;
            dgvVisites.AllowUserToAddRows = false;
            dgvVisites.AllowUserToDeleteRows = false;
            dgvVisites.MultiSelect = false;

            dgvVisites.RowHeadersVisible = false;
            dgvVisites.ColumnCount = 3;

            dgvVisites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvVisites.Columns[0].Name = "Programmé le";
            dgvVisites.Columns[0].Width = 80;
            dgvVisites.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[1].Name = "à";
            dgvVisites.Columns[1].Width = 30;
            dgvVisites.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVisites.Columns[2].Name = "sur";
            dgvVisites.Columns[2].Width = 60;
            dgvVisites.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
