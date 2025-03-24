namespace apListaLigada_1_a_4
{
    partial class FrmListaLigada
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.udNota = new System.Windows.Forms.NumericUpDown();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLerArquivo1 = new System.Windows.Forms.Button();
            this.lsbUm = new System.Windows.Forms.ListBox();
            this.lsbDois = new System.Windows.Forms.ListBox();
            this.lsbTres = new System.Windows.Forms.ListBox();
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnLerArquivo2 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbQuantosNos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.A.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota:";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(84, 7);
            this.txtRA.MaxLength = 5;
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(58, 22);
            this.txtRA.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 36);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 22);
            this.txtNome.TabIndex = 4;
            // 
            // udNota
            // 
            this.udNota.DecimalPlaces = 1;
            this.udNota.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udNota.Location = new System.Drawing.Point(84, 66);
            this.udNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udNota.Name = "udNota";
            this.udNota.Size = new System.Drawing.Size(58, 22);
            this.udNota.TabIndex = 5;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            this.dlgAbrir.Title = "Selecione um arquivo de alunos para ler";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(196, 7);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(85, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(300, 7);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(87, 23);
            this.btnProcurar.TabIndex = 7;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(406, 7);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLerArquivo1
            // 
            this.btnLerArquivo1.Location = new System.Drawing.Point(512, 7);
            this.btnLerArquivo1.Name = "btnLerArquivo1";
            this.btnLerArquivo1.Size = new System.Drawing.Size(100, 23);
            this.btnLerArquivo1.TabIndex = 9;
            this.btnLerArquivo1.Text = "Arquivo 1";
            this.btnLerArquivo1.UseVisualStyleBackColor = true;
            this.btnLerArquivo1.Click += new System.EventHandler(this.btnLerArquivo1_Click);
            // 
            // lsbUm
            // 
            this.lsbUm.FormattingEnabled = true;
            this.lsbUm.ItemHeight = 15;
            this.lsbUm.Location = new System.Drawing.Point(13, 94);
            this.lsbUm.Name = "lsbUm";
            this.lsbUm.Size = new System.Drawing.Size(430, 94);
            this.lsbUm.TabIndex = 10;
            // 
            // lsbDois
            // 
            this.lsbDois.FormattingEnabled = true;
            this.lsbDois.ItemHeight = 15;
            this.lsbDois.Location = new System.Drawing.Point(13, 194);
            this.lsbDois.Name = "lsbDois";
            this.lsbDois.Size = new System.Drawing.Size(430, 94);
            this.lsbDois.TabIndex = 11;
            // 
            // lsbTres
            // 
            this.lsbTres.FormattingEnabled = true;
            this.lsbTres.ItemHeight = 15;
            this.lsbTres.Location = new System.Drawing.Point(12, 294);
            this.lsbTres.Name = "lsbTres";
            this.lsbTres.Size = new System.Drawing.Size(430, 94);
            this.lsbTres.TabIndex = 12;
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.Location = new System.Drawing.Point(450, 94);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(117, 40);
            this.btnExercicio1.TabIndex = 13;
            this.btnExercicio1.Text = "1. Contar";
            this.btnExercicio1.UseVisualStyleBackColor = true;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Location = new System.Drawing.Point(450, 172);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(117, 40);
            this.btnExercicio2.TabIndex = 14;
            this.btnExercicio2.Text = "2. Separar";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            // 
            // btnLerArquivo2
            // 
            this.btnLerArquivo2.Location = new System.Drawing.Point(450, 240);
            this.btnLerArquivo2.Name = "btnLerArquivo2";
            this.btnLerArquivo2.Size = new System.Drawing.Size(115, 40);
            this.btnLerArquivo2.TabIndex = 15;
            this.btnLerArquivo2.Text = "Arquivo 2";
            this.btnLerArquivo2.UseVisualStyleBackColor = true;
            this.btnLerArquivo2.Click += new System.EventHandler(this.btnLerArquivo2_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.Location = new System.Drawing.Point(571, 240);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(85, 40);
            this.btnExercicio3.TabIndex = 16;
            this.btnExercicio3.Text = "Juntar";
            this.btnExercicio3.UseVisualStyleBackColor = true;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.Location = new System.Drawing.Point(450, 294);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(117, 40);
            this.btnExercicio4.TabIndex = 17;
            this.btnExercicio4.Text = "4. Inverter";
            this.btnExercicio4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Exercício 3";
            // 
            // lbQuantosNos
            // 
            this.lbQuantosNos.AutoSize = true;
            this.lbQuantosNos.Location = new System.Drawing.Point(452, 141);
            this.lbQuantosNos.Name = "lbQuantosNos";
            this.lbQuantosNos.Size = new System.Drawing.Size(115, 15);
            this.lbQuantosNos.TabIndex = 19;
            this.lbQuantosNos.Text = "Quantos nós:";
            // 
            // FrmListaLigada
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(661, 393);
            this.Controls.Add(this.lbQuantosNos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnLerArquivo2);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Controls.Add(this.lsbTres);
            this.Controls.Add(this.lsbDois);
            this.Controls.Add(this.lsbUm);
            this.Controls.Add(this.btnLerArquivo1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.udNota);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListaLigada";
            this.Text = "Exercícios 1 a 4 - Listas Ligadas";
            this.Load += new System.EventHandler(this.FrmListaLigada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown udNota;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLerArquivo1;
        private System.Windows.Forms.ListBox lsbUm;
        private System.Windows.Forms.ListBox lsbDois;
        private System.Windows.Forms.ListBox lsbTres;
        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.Button btnLerArquivo2;
        private System.Windows.Forms.Button btnExercicio3;
        private System.Windows.Forms.Button btnExercicio4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbQuantosNos;
    }
}

