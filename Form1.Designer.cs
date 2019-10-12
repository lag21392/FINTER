namespace FINTER
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Resolver = new System.Windows.Forms.Button();
            this.richTextBox_Lote_Datos = new System.Windows.Forms.RichTextBox();
            this.groupBox_Polinomio_De = new System.Windows.Forms.GroupBox();
            this.radioButton_NG_Regresivo = new System.Windows.Forms.RadioButton();
            this.radioButton_NG_Progresivo = new System.Windows.Forms.RadioButton();
            this.radioButton_Lagrange = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Valor_K = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Valor_K = new System.Windows.Forms.TextBox();
            this.groupBox_Polinomio_De.SuspendLayout();
            this.groupBox_Valor_K.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Resolver
            // 
            this.button_Resolver.Location = new System.Drawing.Point(688, 150);
            this.button_Resolver.Name = "button_Resolver";
            this.button_Resolver.Size = new System.Drawing.Size(75, 23);
            this.button_Resolver.TabIndex = 0;
            this.button_Resolver.Text = "Resolver";
            this.button_Resolver.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Lote_Datos
            // 
            this.richTextBox_Lote_Datos.Location = new System.Drawing.Point(15, 39);
            this.richTextBox_Lote_Datos.Name = "richTextBox_Lote_Datos";
            this.richTextBox_Lote_Datos.Size = new System.Drawing.Size(773, 69);
            this.richTextBox_Lote_Datos.TabIndex = 1;
            this.richTextBox_Lote_Datos.Text = "";
            this.richTextBox_Lote_Datos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox_KeyPress_Lote_Datos);
            // 
            // groupBox_Polinomio_De
            // 
            this.groupBox_Polinomio_De.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Polinomio_De.Controls.Add(this.radioButton_NG_Regresivo);
            this.groupBox_Polinomio_De.Controls.Add(this.radioButton_NG_Progresivo);
            this.groupBox_Polinomio_De.Controls.Add(this.radioButton_Lagrange);
            this.groupBox_Polinomio_De.Location = new System.Drawing.Point(15, 114);
            this.groupBox_Polinomio_De.Name = "groupBox_Polinomio_De";
            this.groupBox_Polinomio_De.Size = new System.Drawing.Size(175, 100);
            this.groupBox_Polinomio_De.TabIndex = 2;
            this.groupBox_Polinomio_De.TabStop = false;
            this.groupBox_Polinomio_De.Text = "Polinomio de:";
            // 
            // radioButton_NG_Regresivo
            // 
            this.radioButton_NG_Regresivo.AutoSize = true;
            this.radioButton_NG_Regresivo.Location = new System.Drawing.Point(7, 65);
            this.radioButton_NG_Regresivo.Name = "radioButton_NG_Regresivo";
            this.radioButton_NG_Regresivo.Size = new System.Drawing.Size(153, 17);
            this.radioButton_NG_Regresivo.TabIndex = 2;
            this.radioButton_NG_Regresivo.TabStop = true;
            this.radioButton_NG_Regresivo.Text = "Newton Gregory Regresivo";
            this.radioButton_NG_Regresivo.UseVisualStyleBackColor = true;
            // 
            // radioButton_NG_Progresivo
            // 
            this.radioButton_NG_Progresivo.AutoSize = true;
            this.radioButton_NG_Progresivo.Location = new System.Drawing.Point(7, 42);
            this.radioButton_NG_Progresivo.Name = "radioButton_NG_Progresivo";
            this.radioButton_NG_Progresivo.Size = new System.Drawing.Size(155, 17);
            this.radioButton_NG_Progresivo.TabIndex = 1;
            this.radioButton_NG_Progresivo.TabStop = true;
            this.radioButton_NG_Progresivo.Text = "Newton Gregory Progresivo";
            this.radioButton_NG_Progresivo.UseVisualStyleBackColor = true;
            // 
            // radioButton_Lagrange
            // 
            this.radioButton_Lagrange.AutoSize = true;
            this.radioButton_Lagrange.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Lagrange.Name = "radioButton_Lagrange";
            this.radioButton_Lagrange.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Lagrange.TabIndex = 0;
            this.radioButton_Lagrange.TabStop = true;
            this.radioButton_Lagrange.Text = "Lagrange";
            this.radioButton_Lagrange.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(15, 233);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(773, 210);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lote de datos (Formato: \"(x1,x2,...,xn)\"):";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proceso de resolucion:";
            // 
            // groupBox_Valor_K
            // 
            this.groupBox_Valor_K.Controls.Add(this.label3);
            this.groupBox_Valor_K.Controls.Add(this.textBox_Valor_K);
            this.groupBox_Valor_K.Location = new System.Drawing.Point(197, 115);
            this.groupBox_Valor_K.Name = "groupBox_Valor_K";
            this.groupBox_Valor_K.Size = new System.Drawing.Size(200, 100);
            this.groupBox_Valor_K.TabIndex = 6;
            this.groupBox_Valor_K.TabStop = false;
            this.groupBox_Valor_K.Text = "Valor K:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "K =";
            // 
            // textBox_Valor_K
            // 
            this.textBox_Valor_K.Location = new System.Drawing.Point(35, 40);
            this.textBox_Valor_K.Name = "textBox_Valor_K";
            this.textBox_Valor_K.Size = new System.Drawing.Size(159, 20);
            this.textBox_Valor_K.TabIndex = 0;
            this.textBox_Valor_K.TextChanged += new System.EventHandler(this.TextBox_Valor_K_TextChanged);
            this.textBox_Valor_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Valor_K_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Valor_K);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox_Polinomio_De);
            this.Controls.Add(this.richTextBox_Lote_Datos);
            this.Controls.Add(this.button_Resolver);
            this.Name = "Form1";
            this.Text = "FINTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Polinomio_De.ResumeLayout(false);
            this.groupBox_Polinomio_De.PerformLayout();
            this.groupBox_Valor_K.ResumeLayout(false);
            this.groupBox_Valor_K.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Resolver;
        private System.Windows.Forms.RichTextBox richTextBox_Lote_Datos;
        private System.Windows.Forms.GroupBox groupBox_Polinomio_De;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_NG_Regresivo;
        private System.Windows.Forms.RadioButton radioButton_NG_Progresivo;
        private System.Windows.Forms.RadioButton radioButton_Lagrange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_Valor_K;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Valor_K;
    }
}

