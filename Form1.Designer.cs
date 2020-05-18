namespace ProjetoAtleta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(236, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(236, 158);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 6;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(236, 96);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 7;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(236, 223);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 9;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(225, 276);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(111, 40);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(50, 276);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(116, 40);
            this.btn_enviar.TabIndex = 11;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ProjetoAtelta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_enviar;
    }
}

