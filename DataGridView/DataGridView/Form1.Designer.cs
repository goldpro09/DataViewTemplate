namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbInfos = new System.Windows.Forms.GroupBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFone = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.txbAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.gpbInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfos
            // 
            this.gpbInfos.BackColor = System.Drawing.Color.Silver;
            this.gpbInfos.Controls.Add(this.txbCPF);
            this.gpbInfos.Controls.Add(this.label2);
            this.gpbInfos.Controls.Add(this.txbData);
            this.gpbInfos.Controls.Add(this.label1);
            this.gpbInfos.Controls.Add(this.txbFone);
            this.gpbInfos.Controls.Add(this.lblFone);
            this.gpbInfos.Controls.Add(this.txbAdress);
            this.gpbInfos.Controls.Add(this.lblAdress);
            this.gpbInfos.Controls.Add(this.txbEmail);
            this.gpbInfos.Controls.Add(this.lblEmail);
            this.gpbInfos.Controls.Add(this.txbAge);
            this.gpbInfos.Controls.Add(this.lblAge);
            this.gpbInfos.Controls.Add(this.txbName);
            this.gpbInfos.Controls.Add(this.lblName);
            this.gpbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbInfos.Location = new System.Drawing.Point(23, 63);
            this.gpbInfos.Name = "gpbInfos";
            this.gpbInfos.Size = new System.Drawing.Size(595, 144);
            this.gpbInfos.TabIndex = 0;
            this.gpbInfos.TabStop = false;
            this.gpbInfos.Text = "Informações";
            this.gpbInfos.Enter += new System.EventHandler(this.gpbInfos_Enter);
            // 
            // txbCPF
            // 
            this.txbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCPF.Location = new System.Drawing.Point(321, 109);
            this.txbCPF.MaxLength = 14;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(117, 24);
            this.txbCPF.TabIndex = 13;
            this.txbCPF.TextChanged += new System.EventHandler(this.txbCPF_TextChanged);
            this.txbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPresssCPF);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF:";
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(485, 108);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(86, 24);
            this.txbData.TabIndex = 11;
            this.txbData.TextChanged += new System.EventHandler(this.txbData_TextChanged);
            this.txbData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data:";
            // 
            // txbFone
            // 
            this.txbFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFone.Location = new System.Drawing.Point(358, 68);
            this.txbFone.Name = "txbFone";
            this.txbFone.Size = new System.Drawing.Size(213, 24);
            this.txbFone.TabIndex = 9;
            this.txbFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.Location = new System.Drawing.Point(271, 67);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(90, 24);
            this.lblFone.TabIndex = 8;
            this.lblFone.Text = "Telefone:";
            // 
            // txbAdress
            // 
            this.txbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdress.Location = new System.Drawing.Point(371, 26);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(200, 24);
            this.txbAdress.TabIndex = 7;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(271, 26);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(99, 24);
            this.lblAdress.TabIndex = 6;
            this.lblAdress.Text = "Endereço:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(70, 109);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(195, 24);
            this.txbEmail.TabIndex = 5;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            this.txbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txbAge
            // 
            this.txbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAge.Location = new System.Drawing.Point(70, 67);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(195, 24);
            this.txbAge.TabIndex = 3;
            this.txbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(6, 67);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(62, 24);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Idade:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(70, 27);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(195, 24);
            this.txbName.TabIndex = 1;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            this.txbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 197);
            this.dataGridView1.TabIndex = 14;
            // 
            // gpbOptions
            // 
            this.gpbOptions.Controls.Add(this.btnView);
            this.gpbOptions.Controls.Add(this.btnExcluir);
            this.gpbOptions.Controls.Add(this.btnSalvar);
            this.gpbOptions.Controls.Add(this.btnUpdate);
            this.gpbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOptions.Location = new System.Drawing.Point(23, 213);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(595, 67);
            this.gpbOptions.TabIndex = 15;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Opções";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Silver;
            this.btnView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnView.Location = new System.Drawing.Point(312, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 42);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Visualizar";
            this.btnView.UseCustomBackColor = true;
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExcluir.Location = new System.Drawing.Point(162, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 42);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseCustomBackColor = true;
            this.btnExcluir.UseSelectable = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSalvar.Location = new System.Drawing.Point(10, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 42);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseCustomBackColor = true;
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.Location = new System.Drawing.Point(465, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 506);
            this.Controls.Add(this.gpbOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbInfos);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Registrador";
            this.gpbInfos.ResumeLayout(false);
            this.gpbInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfos;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFone;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.TextBox txbAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbOptions;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}

