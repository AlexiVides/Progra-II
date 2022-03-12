namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.textb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textb2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbRestar = new System.Windows.Forms.RadioButton();
            this.rdbSumar = new System.Windows.Forms.RadioButton();
            this.lbl = new System.Windows.Forms.GroupBox();
            this.lblResulatado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.lbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // textb1
            // 
            this.textb1.Location = new System.Drawing.Point(127, 37);
            this.textb1.Name = "textb1";
            this.textb1.Size = new System.Drawing.Size(100, 23);
            this.textb1.TabIndex = 0;
            this.textb1.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textb2
            // 
            this.textb2.Location = new System.Drawing.Point(127, 86);
            this.textb2.Name = "textb2";
            this.textb2.Size = new System.Drawing.Size(100, 23);
            this.textb2.TabIndex = 2;
            this.textb2.Text = "0.00";
            this.textb2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCalcular.Location = new System.Drawing.Point(257, 57);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rdbDividir);
            this.groupBox1.Controls.Add(this.rdbMultiplicar);
            this.groupBox1.Controls.Add(this.rdbRestar);
            this.groupBox1.Controls.Add(this.rdbSumar);
            this.groupBox1.Location = new System.Drawing.Point(38, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(173, 59);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(59, 19);
            this.rdbDividir.TabIndex = 3;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(173, 34);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(82, 19);
            this.rdbMultiplicar.TabIndex = 2;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbRestar
            // 
            this.rdbRestar.AutoSize = true;
            this.rdbRestar.Location = new System.Drawing.Point(74, 59);
            this.rdbRestar.Name = "rdbRestar";
            this.rdbRestar.Size = new System.Drawing.Size(57, 19);
            this.rdbRestar.TabIndex = 1;
            this.rdbRestar.TabStop = true;
            this.rdbRestar.Text = "Restar";
            this.rdbRestar.UseVisualStyleBackColor = true;
            // 
            // rdbSumar
            // 
            this.rdbSumar.AutoSize = true;
            this.rdbSumar.Location = new System.Drawing.Point(74, 34);
            this.rdbSumar.Name = "rdbSumar";
            this.rdbSumar.Size = new System.Drawing.Size(59, 19);
            this.rdbSumar.TabIndex = 0;
            this.rdbSumar.TabStop = true;
            this.rdbSumar.Text = "Sumar";
            this.rdbSumar.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.Controls.Add(this.lblResulatado);
            this.lbl.Location = new System.Drawing.Point(38, 227);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(295, 101);
            this.lbl.TabIndex = 6;
            this.lbl.TabStop = false;
            this.lbl.Text = "Resulatdo";
            this.lbl.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblResulatado
            // 
            this.lblResulatado.AutoSize = true;
            this.lblResulatado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResulatado.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResulatado.Location = new System.Drawing.Point(89, 19);
            this.lblResulatado.Name = "lblResulatado";
            this.lblResulatado.Size = new System.Drawing.Size(116, 65);
            this.lblResulatado.TabIndex = 0;
            this.lblResulatado.Text = "0.00";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textb1);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lbl.ResumeLayout(false);
            this.lbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textb1;
        private Label label1;
        private Label label2;
        private TextBox textb2;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private RadioButton rdbRestar;
        private RadioButton rdbSumar;
        private RadioButton rdbDividir;
        private RadioButton rdbMultiplicar;
        private GroupBox lbl;
        private Label lblResulatado;
    }
}