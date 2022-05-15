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

            notificacionDescuento.Visible = false;

            //Generador automático de códigos de descuento (solo hay descuentos martes y jueves)
            DayOfWeek day = DateTime.Now.DayOfWeek;
            string dayToday = " " + day.ToString();
            if ((dayToday == DayOfWeek.Tuesday.ToString()) || (dayToday == DayOfWeek.Thursday.ToString()))
            {
                if (servicio.GetTipoEntidad(usuario.GetCorreo()) == "profesor")
                {
                    labelDescuento.Text = "DESCUENTO DE HOY: " + codDescuento;
                    labelDescuento.Visible = true;
                }
                else labelDescuento.Visible = false;
            }
            else labelDescuento.Visible = false;
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            /*
             * 1. Comprobar que el titular de la tarjeta es el profesor que ha logeado
             */
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bConfirmar.Enabled = false;
            aplicarDescuento.Enabled = false;
            string bonos = codSegBox.Text;
            if (bonos == "") bonosCorrecto = false;
            else {
                bonosCorrecto = true;
                switch (bonos)
                {
                    case "10":
                        precio = 50.0;
                        break;
                    case "50":
                        precio = 100.0;
                        break;
                    case "100":
                        precio = 150.0;
                        break;
                    default:
                        precio = 0.0;
                        break;
                }
            }

            if(bonosCorrecto && descuentoCorrecto) aplicarDescuento.Enabled = true;
            if (tarjetaCorrecto && titularCorrecto && seguridadCorrecto && bonosCorrecto)
                bConfirmar.Enabled = true;
        }

        private void descuentoBox_TextChanged(object sender, EventArgs e)
        {
            aplicarDescuento.Enabled = false;
            if (descuentoBox.Text == "") descuentoCorrecto = false;
            else descuentoCorrecto = true;
            if (descuentoCorrecto && bonosCorrecto) aplicarDescuento.Enabled = true;
        }

        private static Random random = new Random();
        private static string GeneradorDescuento(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void aplicarDescuento_Click(object sender, EventArgs e)
        {
            if (codDescuento == descuentoBox.Text) {
                precio = precio - (precio * 0.2);
                aplicarDescuento.Enabled = false;
                notificacionDescuento.Visible = true;
                notificacionDescuento.Text = "¡Descuento del 20% aplicado!";
            }
            else
            {
                DialogResult aviso = MessageBox.Show(this, "El código introducido es incorrecto. Introduzca de correctamente el código de descuento.", "Código descuento incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

