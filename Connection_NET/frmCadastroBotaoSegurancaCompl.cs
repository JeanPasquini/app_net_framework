using ControleOP;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_NET
{
    public partial class frmCadastroBotaoSegurancaCompl : Form
    {
        private string id;

        public frmCadastroBotaoSegurancaCompl(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtNomeBotao.Text))
                {

                    string sql = string.Format(@"INSERT INTO BUTTONRELATION (IDUSER, IDBUTTON) VALUES ('{0}', '{1}')",
                                             /*{0}*/ id,
                                             /*{1}*/ txtCodigo.Text);

                    FunctionsSql.startQuery(sql);

                MessageBox.Show("Added successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                }
                else
                {
                MessageBox.Show("Fill in all fields to register", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("An error occurred: " + er.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnSelecionarBotao_Click(object sender, EventArgs e)
        {
            frmSelecionaBotaoSegurancaCompl frm = new frmSelecionaBotaoSegurancaCompl();
            frm.ShowDialog();

            txtCodigo.Text = frm.id;
            txtNomeBotao.Text = frm.descricao;
        }
    }
}