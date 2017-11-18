using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquinalDesktop
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            Database db = DatabaseFactory.CreateDatabase("DB_Equinal");
            dgv_Ejemplares.DataSource = db.ExecuteDataSet(CommandType.StoredProcedure, "usp_consultarequinos").Tables[0];
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Agregar_Equino ae = new Agregar_Equino();
            ae.Show();
            this.Hide();
        }

        private void dgv_Ejemplares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
