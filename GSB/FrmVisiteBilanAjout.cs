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
    public partial class FrmVisiteBilanAjout : FrmBase {
        public FrmVisiteBilanAjout() {
            InitializeComponent();
        }

        private void FrmVisiteBilanAjout_Load(object sender, EventArgs e) {

            // Parametrage du datagridview
            dgvEchantillonsDistribues.AllowUserToResizeColumns = false;
            dgvEchantillonsDistribues.AllowUserToResizeRows = false;
            dgvEchantillonsDistribues.AllowUserToAddRows = false;
            dgvEchantillonsDistribues.AllowUserToDeleteRows = false;
            dgvEchantillonsDistribues.MultiSelect = false;

            dgvEchantillonsDistribues.RowHeadersVisible = false;
            dgvEchantillonsDistribues.ColumnCount = 5;

            dgvEchantillonsDistribues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEchantillonsDistribues.Columns[0].Name = "Médicaments";
            dgvEchantillonsDistribues.Columns[0].Width = 110;
            dgvEchantillonsDistribues.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEchantillonsDistribues.Columns[1].Name = "Quantité";
            dgvEchantillonsDistribues.Columns[1].Width = 90;
            dgvEchantillonsDistribues.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEchantillonsDistribues.Columns[2].Name = "+";
            dgvEchantillonsDistribues.Columns[2].Width = 50;
            dgvEchantillonsDistribues.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEchantillonsDistribues.Columns[3].Name = "-";
            dgvEchantillonsDistribues.Columns[3].Width = 50;
            dgvEchantillonsDistribues.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEchantillonsDistribues.Columns[4].Name = "x";
            dgvEchantillonsDistribues.Columns[4].Width = 50;
            dgvEchantillonsDistribues.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
