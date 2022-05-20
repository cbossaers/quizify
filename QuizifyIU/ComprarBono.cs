using Quizify.Entities;
using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class ComprarBono : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;

        //Variables para habilitar/deshabilitar el botón "Crear"
        private Boolean tarjetaCorrecto = false;
        private Boolean titularCorrecto = false;
        private Boolean seguridadCorrecto = false;
        private Boolean bonosCorrecto = false;
        private Boolean descuentoCorrecto = false;
        private string codDescuento = GeneradorDescuento(6);
        private double precio = 0.0;

        public ComprarBono(NuevoServicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;

            baplicarDescuento.Enabled = false;
            bConfirmar.Enabled = false;
            notificacionDescuento.Visible = false;
            //labelDescuento.Visible = false;
            labelDescuento.Text = "DESCUENTO DE HOY: " + codDescuento;
            labelDescuento.Visible = true;
            //Generador automático de códigos de descuento (solo hay descuentos martes y viernes)
            /*DayOfWeek day = DateTime.Now.DayOfWeek;
            string dayToday = " " + day.ToString();
            if ((dayToday == DayOfWeek.Tuesday.ToString()) || (dayToday == DayOfWeek.Friday.ToString()))
            {
                if (servicio.GetTipoEntidad(usuario.GetCorreo()) == "profesor")
                {
                    labelDescuento.Text = "DESCUENTO DE HOY: " + codDescuento;
                    labelDescuento.Visible = true;
                }
                else labelDescuento.Visible = false;
            }*/
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show(this, "¿Desea finalizar la compra de " + numBonos.Text + " por el precio de " + precio + " €?", 
                "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(aviso == DialogResult.Yes)
            {
                Profesor profe = servicio.GetProfesor(usuario.correo);
                servicio.AlterarBonos(profe.correo, Int32.Parse(numBonos.Text));
                DialogResult confirmacion = MessageBox.Show(this, "¡Compra realizada con éxito!",
                "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(confirmacion == DialogResult.OK)
                {
                    hideAll();
                }
            }
        }

        private void tarjetaBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string tarjeta = tarjetaBox.Text;
            if (tarjeta == "") tarjetaCorrecto = false;
            else tarjetaCorrecto = true;
            if (tarjetaCorrecto && titularCorrecto && seguridadCorrecto && bonosCorrecto)
                bConfirmar.Enabled = true;
        }

        private void titularBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string titular = titularBox.Text;
            if (titular == "") titularCorrecto = false;
            else titularCorrecto = true;
            if (tarjetaCorrecto && titularCorrecto && seguridadCorrecto && bonosCorrecto)
                bConfirmar.Enabled = true;
        }

        
        private void codSegBox_TextChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            string seg = codSegBox.Text;
            if (seg == "") seguridadCorrecto = false;
            else seguridadCorrecto = true;
            if (tarjetaCorrecto && titularCorrecto && seguridadCorrecto && bonosCorrecto)
                bConfirmar.Enabled = true;
        }

        private void descuentoBox_TextChanged(object sender, EventArgs e)
        {
            if (descuentoBox.Text == "") descuentoCorrecto = false;
            else descuentoCorrecto = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            baplicarDescuento.Enabled = false;
            string bonos = numBonos.Text;
            if (bonos == "") bonosCorrecto = false;
            else
            {
                bonosCorrecto = true;
                switch (bonos)
                {
                    case "10":
                        precio = 50.0;
                        break;
                    case "50":
                        precio = 100.0;
                        break;
                    default:
                        //100 bonos
                        precio = 150.0;
                        break;
                }

                if (tarjetaCorrecto && titularCorrecto && seguridadCorrecto && bonosCorrecto)
                {
                    bConfirmar.Enabled = true;
                }
            }
        }

        
        private static readonly Random random = new Random();
        private static string GeneradorDescuento(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /*
        private static string GeneradorDescuento(int length)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letra;
            
            for(int i = 0; i<length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letra = Convert.ToChar(shift + 65);
                str_build.Append(letra);
            }
            return str_build.ToString();
        }*/

        private void aplicarDescuento_Click(object sender, EventArgs e)
        {
            if (codDescuento == descuentoBox.Text) {
                precio = precio - (precio * 0.2);
                baplicarDescuento.Enabled = false;
                notificacionDescuento.Visible = true;
                notificacionDescuento.Text = "¡Descuento del 20% aplicado!";
                descuentoBox.Enabled = false;
            }
            else
            {
                DialogResult aviso = MessageBox.Show(this, "El código introducido es incorrecto. Introduzca de correctamente el código de descuento.", "Código descuento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void hideAll()
        {
            tarjetaBox.Text = "";
            titularBox.Text = "";
            codSegBox.Text = "";
            numBonos.Text = "";
            descuentoBox.Text = "";
            labelDescuento.Visible = false;
            notificacionDescuento.Visible = false;
            bConfirmar.Enabled = false;
        }
    }
}

