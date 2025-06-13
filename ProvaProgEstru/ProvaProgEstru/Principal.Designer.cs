namespace ProvaProgEstru
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadPedido = new System.Windows.Forms.Button();
            this.btnCadUsuario = new System.Windows.Forms.Button();
            this.btnConsultPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma das 5 Opções";
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(37, 66);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(121, 23);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.Location = new System.Drawing.Point(37, 109);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(121, 23);
            this.btnCadProduto.TabIndex = 2;
            this.btnCadProduto.Text = "Cadastrar Produtos";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadPedido
            // 
            this.btnCadPedido.Location = new System.Drawing.Point(37, 149);
            this.btnCadPedido.Name = "btnCadPedido";
            this.btnCadPedido.Size = new System.Drawing.Size(121, 23);
            this.btnCadPedido.TabIndex = 3;
            this.btnCadPedido.Text = "Cadastrar Pedido";
            this.btnCadPedido.UseVisualStyleBackColor = true;
            this.btnCadPedido.Click += new System.EventHandler(this.btnCadPedido_Click);
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.Location = new System.Drawing.Point(37, 187);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(121, 23);
            this.btnCadUsuario.TabIndex = 4;
            this.btnCadUsuario.Text = "Cadastrar Usuário";
            this.btnCadUsuario.UseVisualStyleBackColor = true;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // btnConsultPedido
            // 
            this.btnConsultPedido.Location = new System.Drawing.Point(37, 225);
            this.btnConsultPedido.Name = "btnConsultPedido";
            this.btnConsultPedido.Size = new System.Drawing.Size(121, 23);
            this.btnConsultPedido.TabIndex = 5;
            this.btnConsultPedido.Text = "Consultar Pedido";
            this.btnConsultPedido.UseVisualStyleBackColor = true;
            this.btnConsultPedido.Click += new System.EventHandler(this.btnConsultPedido_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 288);
            this.Controls.Add(this.btnConsultPedido);
            this.Controls.Add(this.btnCadUsuario);
            this.Controls.Add(this.btnCadPedido);
            this.Controls.Add(this.btnCadProduto);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadPedido;
        private System.Windows.Forms.Button btnCadUsuario;
        private System.Windows.Forms.Button btnConsultPedido;
    }
}