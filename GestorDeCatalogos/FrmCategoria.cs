﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace GestorDeCatalogos
{
    public partial class FrmCategoria : Form
    {

        private List<Categoria> listaCategoria;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void dgv_categorias_SelectionChanged(object sender, EventArgs e)
        {
            Categoria seleccion = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;
          
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            cargarGrilla();

        }

        private void cargarGrilla()
        {

            LogicaCategoria logicaCategoria = new LogicaCategoria();

            listaCategoria = logicaCategoria.CategoriaList();

            dgv_categorias.DataSource = listaCategoria;

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
           FrmAgregarMarCat frmAgregarMarCat = new FrmAgregarMarCat();
            frmAgregarMarCat.ShowDialog();  
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            FrmAgregarMarCat frmAgregarMarCat = new FrmAgregarMarCat();
            frmAgregarMarCat.ShowDialog();
        }
    }
}
