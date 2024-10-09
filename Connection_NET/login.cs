using ControleOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_NET
{
    public partial class login : Form
    {
        public bool logado { get; set; }


        public login()
        {
            InitializeComponent();
            txtVersao.Text = Version.versao;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void logar()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string sql = String.Format(@"SELECT US.*, DT.ID AS IDDEPARTMENT, DT.DEPARTMENTNAME FROM USERS US 
                                            INNER JOIN DEPARTMENTRELATION DR ON DR.IDUSER = US.ID 
                                            INNER JOIN DEPARTMENT DT ON DT.ID = DR.IDDEPARTMENT
                                            WHERE US.USERNAME = '{0}' AND US.PASSWORD = '{1}'", usuario, senha);
            DataTable table = FunctionsSql.getTable(sql);

            if (table.Rows.Count > 0)
            {
                logado = true; 
                session.idusuario = FunctionsSql.getData(sql, "ID");
                session.account = FunctionsSql.getData(sql, "USERNAME");
                session.username = FunctionsSql.getData(sql, "FULLNAME");
                session.password = FunctionsSql.getData(sql, "PASSWORD");
                session.email = FunctionsSql.getData(sql, "EMAIL");
                session.departmentID = FunctionsSql.getData(sql, "IDDEPARTMENT");
                session.departmentDESC = FunctionsSql.getData(sql, "DEPARTMENTNAME");
                this.Close();
            }
            else
            {
                MessageBox.Show($"User not registered! \n\nPlease consult an ADM to register - system {Version.versao}", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            logado = false;
            this.Close();
        }

        private void btnLogar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logar();
            }
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            frmAppConfiguration frm = new frmAppConfiguration();
            frm.ShowDialog();
        }
    }
}
