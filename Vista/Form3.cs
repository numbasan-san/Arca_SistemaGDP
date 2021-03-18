using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_productos.Vista
{
    public partial class Form3 : Form
    {
        public string nombre;
        public Boolean estado;

        public Form3()
        {
            InitializeComponent();
        }

        private void TXT_Nombre_TextChanged(object sender, EventArgs e)
        {
            nombre = TXT_Nombre.Text;
            
        }
    }
}
