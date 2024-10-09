using ControleOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_NET
{
    public partial class frmMain : Form
    {
        private NotifyIcon notifyIcon;
        private ToolStrip tool;

        private bool toolStripMinimized = false;
        private int toolStripOriginalWidth;

        public frmMain()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Text = "Connection .NET";
            notifyIcon.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Abrir", NotifyIcon_Open);
            contextMenu.MenuItems.Add("Fechar", NotifyIcon_Close);
            notifyIcon.ContextMenu = contextMenu;
            Login();
            lblVersion.Text += Version.versao;
        }

        private void Login()
        {
            login frm = new login();
            frm.ShowDialog();
            if (frm.logado)
            {
                InitializeComponent();
                toolStripOriginalWidth = toolStrip1.Width;
                txtNomeUsuario.Text = $"{session.username} - {session.departmentDESC}";
                if (session.departmentID != "1")
                {
                    toolAbaAdministracao.Visible = false;
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        //Methods
        #region

        //Abrir form
        public void ajusteForm(Form frm)
        {
            TabPage newTabPage = new TabPage(frm.Text);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            newTabPage.Controls.Add(frm);
            tabControl1.TabPages.Add(newTabPage);

            frm.Show();
            tabControl1.SelectedTab = newTabPage;
        }

        #endregion

        //LoadForm
        #region


        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void NotifyIcon_Open(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void NotifyIcon_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        #endregion

        private void mudarTool(ToolStrip aba)
        {
            if (tool != null && tool != aba)
            {
                tool.Visible = false;
                aba.Visible = true;
                tool = aba;
            }
            else if (tool == null)
            {
                tool = aba;
                aba.Visible = true;
            }
            else
            {
                
            }
            
        }

        private void minimizeToolStripButton_Click(object sender, EventArgs e)
        {
            if (!toolStripMinimized)
            {
                toolStrip1.Width = 50;
                toolStripMinimized = true;
                btnMinimizarExpandir.Width = toolStrip1.Width;
                foreach (ToolStripItem item in toolStrip1.Items)
                {
                    if (item is ToolStripButton)
                    {
                        ((ToolStripButton)item).DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                }
                toolStripLabel1.Text = "CN";
                btnMinimizarExpandir.Image = Properties.Resources.next_16x16;
            }
            else
            {
                toolStrip1.Width = toolStripOriginalWidth;
                toolStripMinimized = false;
                btnMinimizarExpandir.Width = toolStrip1.Width;
                foreach (ToolStripItem item in toolStrip1.Items)
                {
                    if (item is ToolStripButton)
                    {
                        ((ToolStripButton)item).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    }
                }
                toolStripLabel1.Text = "Connection .NET";
                btnMinimizarExpandir.Image = Properties.Resources.prev_16x16;
            }
        }

        private bool permissao(string idBOTAO)
        {
            if (session.departmentID != "1")
            {

                string sql = String.Format(@"SELECT * FROM BUTTONRELATION WHERE IDUSER = '{0}' AND IDBUTTON = '{1}'", session.idusuario, idBOTAO);

                DataTable table = FunctionsSql.getTable(sql);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"You can't acess this area, need the Button permission ({idBOTAO}). \n\nContact an ADM.", "System message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Current version: {Version.versao}", "System message",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmAppConfiguration frm = new frmAppConfiguration();
            frm.Show();
        }

        private void btnAtualizarSoftware_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project is only a demonstration!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnCadastroBotaoSeguranca_Click(object sender, EventArgs e)
        {
            frmVisaoBotaoSeguranca frm = new frmVisaoBotaoSeguranca();
            ajusteForm(frm);
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmVisaoUsuario frm = new frmVisaoUsuario();
            ajusteForm(frm);
        }

        private void toolAbaAdministracao_Click(object sender, EventArgs e)
        {
            mudarTool(toolStrip6);
        }

        private void btnPermitirUsuario_Click(object sender, EventArgs e)
        {
            frmVisaoBotaoSegurancaUsuario frm = new frmVisaoBotaoSegurancaUsuario();
            ajusteForm(frm);
        }

        private void btnCadastroSetor_Click(object sender, EventArgs e)
        {
            frmVisaoSetor frm = new frmVisaoSetor();
            ajusteForm(frm);
        }

        private void toolAbaRegistrarProduto_Click(object sender, EventArgs e)
        {
            if (permissao("1"))
            {
                mudarTool(toolStrip5);
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            //None
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                session.email = null;
                session.password = null;
                session.account = null;
                session.username = null;
                session.departmentDESC = null;
                session.departmentID = null;
                session.idusuario = null;

                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();

                frm.FormClosed += (s, args) => this.Close();
            }
        }
    }
}
