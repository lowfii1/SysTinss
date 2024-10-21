using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //var cmd = Banco.Abrir();
            //cmd.CommandText = "Select * from niveis where id = 1";
            //var dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    MessageBox.Show($"olá{dr.GetString(1)}");
            //}
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new();
            frmUsuarios.MdiParent = this;//isso faz com que deixe ele dentro do conteiner na parte cinza e não abra duas telas a partir do momento em que você clicar no icone ou botão
            frmUsuarios.Show();//Se coloca show Dialog ele abre duas telinhas quando clicar no botão mas tem um porem ele so fecha se voce terminar o processo
        }
    }
}
