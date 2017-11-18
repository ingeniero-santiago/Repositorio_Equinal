using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EquinalDesktop
{
    public partial class Agregar_Equino : Form
    {
        public Agregar_Equino()
        {
            InitializeComponent();
        }
        string ruta_img;
        string ruta_video;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    Pb_ImagenPregunta.Load(this.openFileDialog1.FileName);
                    Lb_Tituloimg.Text = openFileDialog1.SafeFileName;
                    ruta_img = Path.GetDirectoryName(openFileDialog1.FileName)+openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void Agregar_Equino_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog2.FileName;
            Lb_Video.Text = openFileDialog2.SafeFileName;
            ruta_video = Path.GetDirectoryName(openFileDialog2.FileName)+openFileDialog2.FileName;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal vp = new VentanaPrincipal();
            this.Close();
            vp.Show();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!=string.Empty&& txtRaza.Text != string.Empty && txtPadre.Text != string.Empty && txtMadre.Text != string.Empty && txtColor.Text != string.Empty && Cb_sexo.SelectedValue.ToString() != string.Empty &&
                txtEdad.Text != string.Empty && txtPeso.Text != string.Empty && Txt_Desc.Text != string.Empty && Txt_Empresa.Text != string.Empty && ruta_img != string.Empty && ruta_video!= string.Empty )
            {
                Database db = DatabaseFactory.CreateDatabase("DB_Equinal");
                db.ExecuteDataSet("usp_agregarequino", txtNombre.Text,txtRaza.Text,txtPadre.Text,txtMadre.Text,txtColor.Text,Cb_sexo.SelectedText.ToString()
                              ,txtEdad.Text,txtPeso.Text,Txt_Desc.Text,Txt_Empresa.Text,ruta_img,ruta_video);
                MessageBox.Show("El equino "+txtNombre.Text+" fue registrado exitosamente");

            }
            else
            {
                MessageBox.Show("Debes completar todos los campos");
            }


        }
    }
}
