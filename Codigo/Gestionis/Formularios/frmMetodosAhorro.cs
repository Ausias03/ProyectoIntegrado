﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionis.Clases;
using Gestionis;
using MySqlX.XDevAPI;
using Gestionis.Herramientas;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace Gestionis
{
    public partial class frmMetodosAhorro : FrmBarraPrincipal
    {
        private readonly Usuario usuario;
        private readonly Cuenta cuentaUsuario;

        const double porcentajeNece = 50;
        const double porcentajePrescin = 30;
        const double porcentajeAhorro = 20;

        public frmMetodosAhorro()
        {
            InitializeComponent();
            ModificarBotones();
            usuario = Usuario.BuscaUsuario(Sesion.Instance.ApodoUsuario);
            cuentaUsuario = usuario.GetCuenta();
        }

        private void MetodosAhorro_Load(object sender, EventArgs e)
        {
            #region Iconos flechas / puntos

            pbDot.Image = Properties.Resources.check.ToBitmap();
            pbDot.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow2.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbDot2.Image = Properties.Resources.check.ToBitmap();
            pbDot2.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow4.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow4.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow5.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow5.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow6.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow6.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow7.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow7.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow8.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow8.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow9.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow9.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow10.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow10.SizeMode = PictureBoxSizeMode.StretchImage;

            pbArrow11.Image = Properties.Resources.Arrow.ToBitmap();
            pbArrow11.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            lblIngresoMesCont.Text = cuentaUsuario.TotalIngresos().ToString("0.00") + " €";

            if (Sesion.Instance.Espanyol) Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            else Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            AplicarIdioma();

            barraSecundaria1.Load();
            barraLateral2.Load();

            try
            {
                dgvGastosFijos.DataSource = Gasto.VisualizarDatosFijo();
                dgvGastosVariables.DataSource = Gasto.VisualizarDatosVariable();

                double? gastoFij = Gasto.TotalFijos();
                lblTotalValorFijo.Text = gastoFij.HasValue ? gastoFij.Value.ToString("0.00") + " €" : "0" + " €";

                double? gastoVari = Gasto.TotalVariable();
                lblTotalValorVariables.Text = gastoVari.HasValue ? gastoVari.Value.ToString("0.00") + " €" : "0" + " €";
                //lblTotalGastosVariables.Text = Gasto.TotalVariable() + " €";
                //lblTotalValorFijo.Text = Gasto.TotalFijos() + " €";

                lblDineroRest.Text = Gasto.DineroRestante(cuentaUsuario.TotalIngresos()).Value.ToString("0.00") + " €";

                lblPorcentajeVariable.Text = Gasto.PorcentajeTotalVariable().ToString("0") + " %";

                lblPorcentajeFijo.Text = Gasto.PorcentajeTotalFijo().ToString("0") + " %";

                double? porcenRest = Gasto.PorcentajeRestante(cuentaUsuario.TotalIngresos());
                lblPorcentajeRest.Text = porcenRest.HasValue ? porcenRest.Value.ToString("0") + " %" : "0" + " %";
                M503020Porcentajes();


            }
            catch (Exception) { }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void ModificarBotones()
        {
            barraSecundaria1.BtnLanguage.Click += BtnLanguage_Click;
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            AplicarIdioma();
            barraLateral2.AplicarIdiomas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void M503020Porcentajes()
        {
            double? ingresoMensual = cuentaUsuario.TotalIngresos();

            // Dinero a gastar según el % del metodo 50/30/20
            double? basicaValor = Gasto.M503020Necesidades(ingresoMensual);
            lblNecBasicasValor.Text =  basicaValor.HasValue ? basicaValor.Value.ToString("0.00") + " €" : "0" + " %";
            //double? presValor = Gasto.M503020Presindibles(ingresoMensual);
            //lblNecPresValor.Text = presValor.HasValue ? presValor.Value.ToString("0.00") + " €" : "N/A";
            lblNecPresValor.Text = Gasto.M503020Presindibles(ingresoMensual).Value.ToString("0.00") + " €";
            lblAhoValor.Text = Gasto.M503020Ahorro(ingresoMensual).Value.ToString("0.00") + " €";

            // Totales
            lblGMNecValor.Text = Gasto.TotalNecesidades() + " €";
            lblGPresValor.Text = Gasto.TotalPrescindibles() + " €";
            lblAhorroDinValor.Text = Gasto.DineroRestante(ingresoMensual).Value.ToString("0.00") + " €";

            // Colores
            lblGMNecPorDin.ForeColor = Gasto.PorcentajeNec(ingresoMensual) > porcentajeNece? Color.Red : Color.Green;
            lblGPPorDin.ForeColor = Gasto.PorcentajePrescin(ingresoMensual) > porcentajePrescin ? Color.Red : Color.Green;
            lblAhorroPorDin.ForeColor = Gasto.PorcentajeRestante(ingresoMensual) > porcentajeAhorro ? Color.Green : Color.Red;

            // Porcentajes
            double? porcentajeNec = Gasto.PorcentajeNec(ingresoMensual);
            lblGMNecPorDin.Text = porcentajeNec.HasValue ? porcentajeNec.Value.ToString("0") + " %" : "0" + " %";

            double? porcentajePres = Gasto.PorcentajePrescin(ingresoMensual);
            lblGPPorDin.Text = porcentajePres.HasValue ? porcentajePres.Value.ToString("0") + " %" : "0" + " %";
            
            lblAhorroPorDin.Text = (Gasto.PorcentajeRestante(ingresoMensual) ?? 0).ToString("0") + " %";

        }

        private void AplicarIdioma()
        {
            lblIngresosMes.Text = Resources.Idiomas.StringRecursosAhorros.lblIngresosMes;
            lblGastosFijos.Text = Resources.Idiomas.StringRecursosAhorros.lblGastosFijos;
            lblGastosVariables.Text = Resources.Idiomas.StringRecursosAhorros.lblGastosVariables;
            lblDineroRestante.Text = Resources.Idiomas.StringRecursosAhorros.lblDineroRestante;
            btnPersonalizado.Text = Resources.Idiomas.StringRecursosAhorros.btnPersonalizado;
            btnSalir.Text = Resources.Idiomas.StringRecursosAhorros.btnSalir;
            lblPorcentajes.Text = Resources.Idiomas.StringRecursosAhorros.lblPorcentajes;
            lbl20PorCiento.Text = Resources.Idiomas.StringRecursosAhorros.lbl20PorCiento;
            lbl50PorCiento.Text = Resources.Idiomas.StringRecursosAhorros.lbl50PorCiento;
            lbl30PorCiento.Text = Resources.Idiomas.StringRecursosAhorros.lbl30PorCiento;
            lblGastadoMes.Text = Resources.Idiomas.StringRecursosAhorros.lblGastadoMes;
            lblGastadoMes2.Text = Resources.Idiomas.StringRecursosAhorros.lblGastadoMes2;
            lblDineroAhorrar.Text = Resources.Idiomas.StringRecursosAhorros.lblDineroAhorrar;
            lblInfo.Text = Resources.Idiomas.StringRecursosAhorros.lblInfo;
            lblInfo2.Text = Resources.Idiomas.StringRecursosAhorros.lblInfo2;
        }
    }
}
