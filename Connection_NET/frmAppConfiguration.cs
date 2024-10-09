using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_NET
{
    public partial class frmAppConfiguration : Form
    {
        public frmAppConfiguration()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarBase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja abrir o arquivo SQL?",
                                                    "Abrir Arquivo",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string fileName = "main.sql"; 

                string filePath = Path.Combine(appDirectory, fileName);

                try
                {
                    if (File.Exists(filePath))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não encontrado: " + filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
