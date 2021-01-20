using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notaciones
{
    public partial  class Form1 : Form
    {
        Not_Polaca notacion;
        Pila<int> pileishon;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string cadena = expresionTxt.Text;
            expresionIngresada.Text = cadena;

            if (expresionTxt.Text.Equals("")) {
                resultadoPostfija.Text = "Resultado postfija";
                resultadoPrefija.Text = "Resultado prefija";
                expresionIngresada.Text = "Expresión";
            }

            borrar();
        }

 

 
        public void borrar() {
            expresionTxt.Text = "";
        }


    }


     
}




