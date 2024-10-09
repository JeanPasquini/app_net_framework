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
    public partial class frmVisaoBotaoSeguranca : Form
    {
        public frmVisaoBotaoSeguranca()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroBotaoSeguranca frm = new frmCadastroBotaoSeguranca(null, false);
            frm.ShowDialog();
            atualizaGrid();
        }
        private void atualizaGrid()
        {
            try
            {
                showWaitForm.Open();
                string sql = $@"SELECT * FROM BUTTON";
                DataTable table = FunctionsSql.getTable(sql);

                if (table != null)
                {
                    kryptonDataGridView1.DataSource = table;
                }
                else
                {
                    Console.WriteLine("Error filling the DataGridView");
                }
                showWaitForm.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("An error occurred: " + er.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizaGrid_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void frmVisaoProduto_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonDataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = kryptonDataGridView1.SelectedRows[0];

                    string id = selectedRow.Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show($@"Do you want to delete the ID: {id}?", "System Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string sql = string.Format($@"DELETE BUTTON WHERE ID = '{id}'");
                        FunctionsSql.startQuery(sql);

                        MessageBox.Show("ID successfully deleted!");
                        atualizaGrid();
                    }
                }
                else
                {
                    MessageBox.Show("You must select a row to continue.", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("An error occurred: " + er.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = kryptonDataGridView1.SelectedRows[0];

                string id = selectedRow.Cells[0].Value.ToString();

                frmCadastroBotaoSeguranca frm = new frmCadastroBotaoSeguranca(id, true);
                frm.ShowDialog();
                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
    }
}
