using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;

namespace EquinalDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Tb_Pass.Text != "" && Tb_Usuario.Text != "")
            {
                
                Database db = DatabaseFactory.CreateDatabase("DB_Equinal");
                DataTable dt = db.ExecuteDataSet("USP_Iniciarsesion", Tb_Usuario.Text).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string hash = dt.Rows[0]["contrasena"].ToString();
                    bool pwc = PasswordStorage.VerifyPassword(Tb_Pass.Text, hash);
                    if (pwc == true)
                    {
                        //MessageBox.Show("Bienvenido ");
                        VentanaPrincipal vp = new VentanaPrincipal();    
                        vp.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no existe");
                }


            }
            else
            {
                MessageBox.Show("llena todos los campos");
            }
            
        }

        private void Tb_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
