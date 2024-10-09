
namespace Connection_NET
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAbaCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolAbaAdministracao = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnConfiguracao = new System.Windows.Forms.ToolStripButton();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.btnDeslogar = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizarSoftware = new System.Windows.Forms.ToolStripButton();
            this.btnTicket = new System.Windows.Forms.ToolStripButton();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.btnCadastroBotaoSeguranca = new System.Windows.Forms.ToolStripButton();
            this.btnCadastroSetor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCadastroUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnPermitirUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrarProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnMinimizarExpandir = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip6.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolAbaCadastro,
            this.toolAbaAdministracao});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(179, 719);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripLabel1.Image = global::Connection_NET.Properties.Resources.cube_32x32;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(177, 53);
            this.toolStripLabel1.Text = "Connection .NET";
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolAbaCadastro
            // 
            this.toolAbaCadastro.Image = global::Connection_NET.Properties.Resources.bosale_32x32;
            this.toolAbaCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAbaCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbaCadastro.Name = "toolAbaCadastro";
            this.toolAbaCadastro.Size = new System.Drawing.Size(177, 56);
            this.toolAbaCadastro.Text = "Register";
            this.toolAbaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAbaCadastro.Click += new System.EventHandler(this.toolAbaRegistrarProduto_Click);
            // 
            // toolAbaAdministracao
            // 
            this.toolAbaAdministracao.AutoSize = false;
            this.toolAbaAdministracao.Image = global::Connection_NET.Properties.Resources.show_32x321;
            this.toolAbaAdministracao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAbaAdministracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbaAdministracao.Name = "toolAbaAdministracao";
            this.toolAbaAdministracao.Size = new System.Drawing.Size(132, 51);
            this.toolAbaAdministracao.Text = "Administration";
            this.toolAbaAdministracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolAbaAdministracao.Click += new System.EventHandler(this.toolAbaAdministracao_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNomeUsuario,
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(179, 724);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1177, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtNomeUsuario.Image = global::Connection_NET.Properties.Resources.user2;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(180, 20);
            this.txtNomeUsuario.Text = "username - deparment";
            this.txtNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersion.Size = new System.Drawing.Size(938, 20);
            this.lblVersion.Spring = true;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracao,
            this.btnInfo,
            this.btnDeslogar,
            this.btnAtualizarSoftware,
            this.btnTicket});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip4.Size = new System.Drawing.Size(1356, 31);
            this.toolStrip4.TabIndex = 8;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfiguracao.Image = global::Connection_NET.Properties.Resources.gears;
            this.btnConfiguracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(29, 28);
            this.btnConfiguracao.Text = "Configuration";
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = global::Connection_NET.Properties.Resources.information_p16;
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(29, 28);
            this.btnInfo.Text = "Information";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeslogar.Image = global::Connection_NET.Properties.Resources.changeview_32x32;
            this.btnDeslogar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(29, 28);
            this.btnDeslogar.Text = "Logout";
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // btnAtualizarSoftware
            // 
            this.btnAtualizarSoftware.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizarSoftware.Image = global::Connection_NET.Properties.Resources.update;
            this.btnAtualizarSoftware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizarSoftware.Name = "btnAtualizarSoftware";
            this.btnAtualizarSoftware.Size = new System.Drawing.Size(29, 28);
            this.btnAtualizarSoftware.Text = "Update";
            this.btnAtualizarSoftware.Click += new System.EventHandler(this.btnAtualizarSoftware_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTicket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTicket.Image = global::Connection_NET.Properties.Resources.mailmerge_32x32;
            this.btnTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(29, 28);
            this.btnTicket.Text = "Ticket";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ContentPanel.Size = new System.Drawing.Size(883, 54);
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStrip6);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStrip5);
            this.toolStripContainer2.ContentPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolStripContainer2.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer2.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(1177, 67);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(179, 31);
            this.toolStripContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(1177, 67);
            this.toolStripContainer2.TabIndex = 8;
            this.toolStripContainer2.Text = "toolStripContainer2";
            this.toolStripContainer2.TopToolStripPanelVisible = false;
            // 
            // toolStrip6
            // 
            this.toolStrip6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastroBotaoSeguranca,
            this.btnCadastroSetor,
            this.toolStripSeparator7,
            this.btnCadastroUsuario,
            this.btnPermitirUsuario});
            this.toolStrip6.Location = new System.Drawing.Point(0, 0);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(1177, 59);
            this.toolStrip6.TabIndex = 9;
            this.toolStrip6.Text = "toolStrip6";
            this.toolStrip6.Visible = false;
            // 
            // btnCadastroBotaoSeguranca
            // 
            this.btnCadastroBotaoSeguranca.Image = global::Connection_NET.Properties.Resources.add_32x324;
            this.btnCadastroBotaoSeguranca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastroBotaoSeguranca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastroBotaoSeguranca.Name = "btnCadastroBotaoSeguranca";
            this.btnCadastroBotaoSeguranca.Size = new System.Drawing.Size(111, 56);
            this.btnCadastroBotaoSeguranca.Text = "Button register";
            this.btnCadastroBotaoSeguranca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastroBotaoSeguranca.Click += new System.EventHandler(this.btnCadastroBotaoSeguranca_Click);
            // 
            // btnCadastroSetor
            // 
            this.btnCadastroSetor.Image = global::Connection_NET.Properties.Resources.usergroup_32x32;
            this.btnCadastroSetor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastroSetor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastroSetor.Name = "btnCadastroSetor";
            this.btnCadastroSetor.Size = new System.Drawing.Size(147, 56);
            this.btnCadastroSetor.Text = "Department register";
            this.btnCadastroSetor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastroSetor.Click += new System.EventHandler(this.btnCadastroSetor_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 59);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Image = global::Connection_NET.Properties.Resources.bocontact2_32x32;
            this.btnCadastroUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastroUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(96, 56);
            this.btnCadastroUsuario.Text = "User register";
            this.btnCadastroUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // btnPermitirUsuario
            // 
            this.btnPermitirUsuario.Image = global::Connection_NET.Properties.Resources.bouser_32x32;
            this.btnPermitirUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPermitirUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPermitirUsuario.Name = "btnPermitirUsuario";
            this.btnPermitirUsuario.Size = new System.Drawing.Size(81, 56);
            this.btnPermitirUsuario.Text = "User acess";
            this.btnPermitirUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPermitirUsuario.Click += new System.EventHandler(this.btnPermitirUsuario_Click);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarProduto,
            this.toolStripSeparator5});
            this.toolStrip5.Location = new System.Drawing.Point(0, 0);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(1177, 59);
            this.toolStrip5.TabIndex = 8;
            this.toolStrip5.Text = "toolStrip5";
            this.toolStrip5.Visible = false;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Image = global::Connection_NET.Properties.Resources.tag_32x32;
            this.btnCadastrarProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastrarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(64, 56);
            this.btnCadastrarProduto.Text = "Product";
            this.btnCadastrarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 59);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(179, 98);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 626);
            this.tabControl1.TabIndex = 12;
            // 
            // btnMinimizarExpandir
            // 
            this.btnMinimizarExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimizarExpandir.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarExpandir.FlatAppearance.BorderSize = 0;
            this.btnMinimizarExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarExpandir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizarExpandir.Image = global::Connection_NET.Properties.Resources.prev_16x16;
            this.btnMinimizarExpandir.Location = new System.Drawing.Point(0, 722);
            this.btnMinimizarExpandir.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizarExpandir.Name = "btnMinimizarExpandir";
            this.btnMinimizarExpandir.Size = new System.Drawing.Size(179, 27);
            this.btnMinimizarExpandir.TabIndex = 11;
            this.btnMinimizarExpandir.UseVisualStyleBackColor = true;
            this.btnMinimizarExpandir.Click += new System.EventHandler(this.minimizeToolStripButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnMinimizarExpandir);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection .NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtNomeUsuario;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btnConfiguracao;
        private System.Windows.Forms.ToolStripButton btnAtualizarSoftware;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.Button btnMinimizarExpandir;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton btnCadastrarProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolAbaAdministracao;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripButton btnCadastroBotaoSeguranca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnCadastroUsuario;
        private System.Windows.Forms.ToolStripButton btnPermitirUsuario;
        private System.Windows.Forms.ToolStripButton btnCadastroSetor;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripButton btnTicket;
        private System.Windows.Forms.ToolStripButton toolAbaCadastro;
        private System.Windows.Forms.ToolStripButton btnDeslogar;
    }
}