using ControleOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Connection_NET
{
    public partial class frmCadastroBotaoSeguranca : Form
    {
        private string id;
        private bool editar;

        public frmCadastroBotaoSeguranca(string id, bool editar)
        {
            InitializeComponent();
            this.id = id;
            this.editar = editar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    if (!String.IsNullOrEmpty(txtNomeBotao.Text) && !String.IsNullOrEmpty(txtDescricaoBotao.Text))
                    {

                        string sql = string.Format(@"UPDATE BUTTON SET BUTTONNAME = '{0}', DESCRIPTION = '{1}' WHERE ID = '{2}'",
                                                 /*{0}*/ txtNomeBotao.Text,
                                                 /*{1}*/ txtDescricaoBotao.Text,
                                                 /*{2}*/ id);
                        FunctionsSql.startQuery(sql);
                        MessageBox.Show("Updated successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fill in all fields to register", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    if (!String.IsNullOrEmpty(txtNomeBotao.Text) && !String.IsNullOrEmpty(txtDescricaoBotao.Text))
                    {

                        string sql = string.Format(@"INSERT INTO BUTTON (BUTTONNAME, DESCRIPTION) VALUES ('{0}', '{1}')",
                                                 /*{0}*/ txtNomeBotao.Text,
                                                 /*{1}*/ txtDescricaoBotao.Text);
                        FunctionsSql.startQuery(sql);
                        MessageBox.Show("Added successfully!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fill in all fields to register", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("An error occurred: " + er.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (editar) {
                string sql = $@"SELECT * FROM BUTTON WHERE ID = {id}";
                DataTable table = FunctionsSql.getTable(sql);

                if (table != null)
                {
                    string ID = FunctionsSql.getData(sql, "ID");
                    string NOMEBOTAO = FunctionsSql.getData(sql, "BUTTONNAME");
                    string DESCRICAOBOTAO = FunctionsSql.getData(sql, "DESCRIPTION");

                    txtID.Text = ID;
                    txtNomeBotao.Text = NOMEBOTAO;
                    txtDescricaoBotao.Text = DESCRICAOBOTAO;
                }
            }
        }
    }
}