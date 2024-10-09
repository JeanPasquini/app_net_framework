using ControleOP;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_NET
{
    public partial class frmCadastroUsuario : Form
    {
        private string id;
        private bool editar;

        public frmCadastroUsuario(string id, bool editar)
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
                    if (!String.IsNullOrEmpty(txtNomeCompleto.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtEmailComplemento.Text) && !String.IsNullOrEmpty(txtCodigoSetor.Text) && !String.IsNullOrEmpty(txtSenha.Text) && !String.IsNullOrEmpty(txtUsuario.Text))
                    {

                        string sql = string.Format(@"UPDATE USERS SET USERNAME = '{0}', PASSWORD = '{1}', FULLNAME = '{2}', EMAIL = '{3}' WHERE ID = '{4}'",
                                                 /*{0}*/ txtUsuario.Text,
                                                 /*{1}*/ txtSenha.Text,
                                                 /*{2}*/ txtNomeCompleto.Text,
                                                 /*{3}*/ txtEmail.Text + txtEmailComplemento.Text,
                                                 /*{4}*/ id);

                        string sql2 = string.Format(@"UPDATE DEPARTMENTRELATION SET IDDEPARTMENT = '{0}' WHERE IDUSER = '{1}'",
                                                 /*{0}*/ txtCodigoSetor.Text,
                                                 /*{1}*/ id);

                        FunctionsSql.startQuery(sql);
                        FunctionsSql.startQuery(sql2);
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

                    if (!String.IsNullOrEmpty(txtNomeCompleto.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtEmailComplemento.Text) && !String.IsNullOrEmpty(txtCodigoSetor.Text) && !String.IsNullOrEmpty(txtSenha.Text) && !String.IsNullOrEmpty(txtUsuario.Text))
                    {

                        string sql = string.Format(@"INSERT INTO USERS (USERNAME, PASSWORD, FULLNAME, EMAIL) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                                 /*{0}*/ txtUsuario.Text,
                                                 /*{1}*/ txtSenha.Text,
                                                 /*{2}*/ txtNomeCompleto.Text,
                                                 /*{3}*/ txtEmail.Text + txtEmailComplemento.Text);

                        FunctionsSql.startQuery(sql);

                        string sqlLastID = $@"SELECT MAX(ID) AS ID FROM USERS";
                        txtID.Text = id = FunctionsSql.getData(sqlLastID, "ID");

                        string sql2 = string.Format(@"INSERT INTO DEPARTMENTRELATION (IDUSER, IDDEPARTMENT) VALUES ('{0}', '{1}')",
                                                     /*{0}*/ txtID.Text,
                                                     /*{1}*/ txtCodigoSetor.Text);

                        FunctionsSql.startQuery(sql2);

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

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                string sql = $@"SELECT US.*, DT.ID AS IDDEPARTMENT, DT.DEPARTMENTNAME FROM USERS US 
                                INNER JOIN DEPARTMENTRELATION DR ON DR.IDUSER = US.ID 
                                INNER JOIN DEPARTMENT DT ON DT.ID = DR.IDDEPARTMENT
                                WHERE US.ID = {id}";
                DataTable table = FunctionsSql.getTable(sql);

                if (table != null)
                {
                    string EMAIL = FunctionsSql.getData(sql, "EMAIL");
                    string[] emailParts = EMAIL.Split('@');
                    string emailLocalPart = emailParts.Length > 0 ? emailParts[0] : string.Empty;
                    string emailDomainPart = emailParts.Length > 1 ? "@" + emailParts[1] : string.Empty;

                    txtID.Text = FunctionsSql.getData(sql, "ID");
                    txtCodigoSetor.Text = FunctionsSql.getData(sql, "IDDEPARTMENT");
                    txtUsuario.Text = FunctionsSql.getData(sql, "USERNAME");
                    txtSenha.Text = FunctionsSql.getData(sql, "PASSWORD");
                    txtNomeCompleto.Text = FunctionsSql.getData(sql, "FULLNAME");
                    txtEmail.Text = emailLocalPart;
                    txtEmailComplemento.Text = emailDomainPart;
                    txtDescricaoSetor.Text = FunctionsSql.getData(sql, "DEPARTMENTNAME");
                }
            }
        }

        private void btnSelecionarSetor_Click(object sender, EventArgs e)
        {
            frmSelecionaSetor frm = new frmSelecionaSetor();
            frm.ShowDialog();
            txtCodigoSetor.Text = frm.id;
            txtDescricaoSetor.Text = frm.descricao;
        }

        private void btnRevelarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}