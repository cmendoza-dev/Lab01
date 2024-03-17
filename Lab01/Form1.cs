using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form

    {
        int nc = 0;

        void generarNumero()
        {
            nc++;
            //txtNumGuia.text = nc.ToString("0000");
        }


        public Form1()
        {
            InitializeComponent();
            generarNumero();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Instanciando la clase RegistrarTransporte
            RegistrarTransporte rt = new RegistrarTransporte();
            rt.NomCliente = txtNomCliente.Text;
            rt.Descrip = txtDescrip.Text;
            //rt.TnMetricas = txtTnM.Text;



        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
