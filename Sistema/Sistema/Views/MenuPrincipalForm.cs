﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sistema.Views.Campeonato;
using Sistema.Views.Times;
using Sistema.Views.Jogadores;
using Sistema.Views.Grupos;
using Sistema.Views.Partidas;
using Sistema.Views.Transmissao;
using Sistema.Service;

namespace Sistema.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 70)
            {
                MenuVertical.Width = 220;
            }
            else
                MenuVertical.Width = 70;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxRestaurar.Visible = true;
            pictureBoxMinimizar.Visible = false;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            pictureBoxRestaurar.Visible = false;
            pictureBoxMinimizar.Visible = true;
        }

        private void pictureBoxMinimizador_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEmPainel(object FormFilho)
        {
            if (this.panelConteudo.Controls.Count > 0)
                this.panelConteudo.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteudo.Controls.Add(fh);
            this.panelConteudo.Tag = fh;
            fh.Show();
        }

        private void buttonCadastroCamp_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new CampeonatoCadastroForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new CampeonatoListagemForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new CadastroTimesForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new TimesListagemForm());
        }

        private void buttonCadastroGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new GrupoListagemForm());
        }

        private void buttonPartidas_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new PartidaListagemForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new TransmissaoCadastroEdicaoForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new CadastroJogadoresForm());
        }

    }
}