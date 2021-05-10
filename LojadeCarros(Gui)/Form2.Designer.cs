
namespace LojadeCarros_Gui_
{
    partial class Form2
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
            this.gp_invent = new System.Windows.Forms.GroupBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.lbl_portas = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.txt_portas = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gp_invent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_invent
            // 
            this.gp_invent.Controls.Add(this.btn_atualizar);
            this.gp_invent.Controls.Add(this.lbl_codigo);
            this.gp_invent.Controls.Add(this.lbl_qtd);
            this.gp_invent.Controls.Add(this.lbl_portas);
            this.gp_invent.Controls.Add(this.lbl_estado);
            this.gp_invent.Controls.Add(this.lbl_ano);
            this.gp_invent.Controls.Add(this.txt_codigo);
            this.gp_invent.Controls.Add(this.txt_qtd);
            this.gp_invent.Controls.Add(this.txt_portas);
            this.gp_invent.Controls.Add(this.txt_estado);
            this.gp_invent.Controls.Add(this.txt_ano);
            this.gp_invent.Controls.Add(this.btn_sair);
            this.gp_invent.Controls.Add(this.btn_remover);
            this.gp_invent.Controls.Add(this.btn_limpar);
            this.gp_invent.Controls.Add(this.btn_salvar);
            this.gp_invent.Controls.Add(this.btn_carregar);
            this.gp_invent.Controls.Add(this.btn_add);
            this.gp_invent.Controls.Add(this.label3);
            this.gp_invent.Controls.Add(this.label2);
            this.gp_invent.Controls.Add(this.label1);
            this.gp_invent.Controls.Add(this.txt_preco);
            this.gp_invent.Controls.Add(this.txt_modelo);
            this.gp_invent.Controls.Add(this.txt_Marca);
            this.gp_invent.Location = new System.Drawing.Point(12, 21);
            this.gp_invent.Name = "gp_invent";
            this.gp_invent.Size = new System.Drawing.Size(230, 488);
            this.gp_invent.TabIndex = 1;
            this.gp_invent.TabStop = false;
            this.gp_invent.Text = "Adicionar Carro";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(2, 301);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(110, 25);
            this.btn_atualizar.TabIndex = 22;
            this.btn_atualizar.Text = "Atualizar Item";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(6, 240);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 21;
            this.lbl_codigo.Text = "Código";
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(6, 211);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(27, 15);
            this.lbl_qtd.TabIndex = 20;
            this.lbl_qtd.Text = "Qtd";
            // 
            // lbl_portas
            // 
            this.lbl_portas.AutoSize = true;
            this.lbl_portas.Location = new System.Drawing.Point(6, 182);
            this.lbl_portas.Name = "lbl_portas";
            this.lbl_portas.Size = new System.Drawing.Size(40, 15);
            this.lbl_portas.TabIndex = 19;
            this.lbl_portas.Text = "Portas";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(6, 153);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(42, 15);
            this.lbl_estado.TabIndex = 18;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(6, 124);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(29, 15);
            this.lbl_ano.TabIndex = 17;
            this.lbl_ano.Text = "Ano";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(114, 237);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(110, 23);
            this.txt_codigo.TabIndex = 16;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(114, 208);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(110, 23);
            this.txt_qtd.TabIndex = 15;
            // 
            // txt_portas
            // 
            this.txt_portas.Location = new System.Drawing.Point(114, 179);
            this.txt_portas.Name = "txt_portas";
            this.txt_portas.Size = new System.Drawing.Size(110, 23);
            this.txt_portas.TabIndex = 14;
            this.txt_portas.TextChanged += new System.EventHandler(this.txt_portas_TextChanged);
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(114, 150);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(110, 23);
            this.txt_estado.TabIndex = 13;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(114, 121);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(110, 23);
            this.txt_ano.TabIndex = 12;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(114, 456);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(110, 25);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(114, 270);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(110, 25);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover Carro";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(114, 421);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(110, 25);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar Lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(114, 301);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(110, 25);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(2, 421);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(110, 25);
            this.btn_carregar.TabIndex = 7;
            this.btn_carregar.Text = "Carregar Lista";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(2, 270);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 25);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add Carro";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(114, 92);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(110, 23);
            this.txt_preco.TabIndex = 2;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(114, 63);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(110, 23);
            this.txt_modelo.TabIndex = 1;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(114, 34);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(110, 23);
            this.txt_Marca.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(248, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 507);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 514);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gp_invent);
            this.Name = "Form2";
            this.Text = "Gerenciar banco de dados";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gp_invent.ResumeLayout(false);
            this.gp_invent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_invent;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Label lbl_portas;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_ano;
        //private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.TextBox txt_portas;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_atualizar;
    }
}