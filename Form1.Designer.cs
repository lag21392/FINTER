﻿namespace FINTER
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
            this.groupBox_Polinomio_De = new System.Windows.Forms.GroupBox();
            this.radioButton_NG_Regresivo = new System.Windows.Forms.RadioButton();
            this.radioButton_NG_Progresivo = new System.Windows.Forms.RadioButton();
            this.radioButton_Lagrange = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_Pasos_Calculo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_PolinomioPdeX = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_Lote_Datos_Y = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Lote_Datos_X = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_P_de_K = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Valor_K = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Resolver = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_Polinomio_De.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Polinomio_De
            // 
            this.groupBox_Polinomio_De.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Polinomio_De.AutoSize = true;
            this.groupBox_Polinomio_De.Controls.Add(this.richTextBox_Pasos_Calculo);
            this.groupBox_Polinomio_De.Controls.Add(this.button1);
            this.groupBox_Polinomio_De.Controls.Add(this.label2);
            this.groupBox_Polinomio_De.Controls.Add(this.richTextBox_PolinomioPdeX);
            this.groupBox_Polinomio_De.Controls.Add(this.label5);
            this.groupBox_Polinomio_De.Controls.Add(this.radioButton_NG_Regresivo);
            this.groupBox_Polinomio_De.Controls.Add(this.radioButton_NG_Progresivo);
            this.groupBox_Polinomio_De.Controls.Add(this.radioButton_Lagrange);
            this.groupBox_Polinomio_De.Location = new System.Drawing.Point(11, 128);
            this.groupBox_Polinomio_De.Name = "groupBox_Polinomio_De";
            this.groupBox_Polinomio_De.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_Polinomio_De.Size = new System.Drawing.Size(793, 471);
            this.groupBox_Polinomio_De.TabIndex = 2;
            this.groupBox_Polinomio_De.TabStop = false;
            this.groupBox_Polinomio_De.Text = "Calculo de polinomio P(x):";
            // 
            // radioButton_NG_Regresivo
            // 
            this.radioButton_NG_Regresivo.AutoSize = true;
            this.radioButton_NG_Regresivo.Location = new System.Drawing.Point(239, 19);
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
            this.radioButton_NG_Progresivo.Location = new System.Drawing.Point(78, 20);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Hallar Polinomio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_HallarPolinomio_Click);
            // 
            // richTextBox_Pasos_Calculo
            // 
            this.richTextBox_Pasos_Calculo.Location = new System.Drawing.Point(4, 56);
            this.richTextBox_Pasos_Calculo.Name = "richTextBox_Pasos_Calculo";
            this.richTextBox_Pasos_Calculo.ReadOnly = true;
            this.richTextBox_Pasos_Calculo.Size = new System.Drawing.Size(774, 323);
            this.richTextBox_Pasos_Calculo.TabIndex = 11;
            this.richTextBox_Pasos_Calculo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pasos de calculo:";
            // 
            // richTextBox_PolinomioPdeX
            // 
            this.richTextBox_PolinomioPdeX.Location = new System.Drawing.Point(4, 398);
            this.richTextBox_PolinomioPdeX.Name = "richTextBox_PolinomioPdeX";
            this.richTextBox_PolinomioPdeX.ReadOnly = true;
            this.richTextBox_PolinomioPdeX.Size = new System.Drawing.Size(773, 54);
            this.richTextBox_PolinomioPdeX.TabIndex = 13;
            this.richTextBox_PolinomioPdeX.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Polinomio P(x):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBox_Lote_Datos_Y);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox_Lote_Datos_X);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lote de datos Y (Formato: \"(f(x1),f(x2),...,f(xn)\"):";
            // 
            // richTextBox_Lote_Datos_Y
            // 
            this.richTextBox_Lote_Datos_Y.Location = new System.Drawing.Point(7, 79);
            this.richTextBox_Lote_Datos_Y.Name = "richTextBox_Lote_Datos_Y";
            this.richTextBox_Lote_Datos_Y.Size = new System.Drawing.Size(773, 24);
            this.richTextBox_Lote_Datos_Y.TabIndex = 11;
            this.richTextBox_Lote_Datos_Y.Text = "";
            this.richTextBox_Lote_Datos_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_Lote_Datos_Y_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lote de datos X (Formato: \"(x1,x2,...,xn)\"):";
            // 
            // richTextBox_Lote_Datos_X
            // 
            this.richTextBox_Lote_Datos_X.Location = new System.Drawing.Point(7, 36);
            this.richTextBox_Lote_Datos_X.Name = "richTextBox_Lote_Datos_X";
            this.richTextBox_Lote_Datos_X.Size = new System.Drawing.Size(773, 24);
            this.richTextBox_Lote_Datos_X.TabIndex = 9;
            this.richTextBox_Lote_Datos_X.Text = "";
            this.richTextBox_Lote_Datos_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_Lote_Datos_X_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_P_de_K);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_Valor_K);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_Resolver);
            this.groupBox2.Location = new System.Drawing.Point(11, 605);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 64);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especializacion del polinomio en K:";
            // 
            // textBox_P_de_K
            // 
            this.textBox_P_de_K.Location = new System.Drawing.Point(45, 39);
            this.textBox_P_de_K.Name = "textBox_P_de_K";
            this.textBox_P_de_K.ReadOnly = true;
            this.textBox_P_de_K.Size = new System.Drawing.Size(159, 20);
            this.textBox_P_de_K.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "K =";
            // 
            // textBox_Valor_K
            // 
            this.textBox_Valor_K.Location = new System.Drawing.Point(45, 16);
            this.textBox_Valor_K.Name = "textBox_Valor_K";
            this.textBox_Valor_K.Size = new System.Drawing.Size(159, 20);
            this.textBox_Valor_K.TabIndex = 20;
            this.textBox_Valor_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Valor_K_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "P(K) =";
            // 
            // button_Resolver
            // 
            this.button_Resolver.Location = new System.Drawing.Point(654, 32);
            this.button_Resolver.Name = "button_Resolver";
            this.button_Resolver.Size = new System.Drawing.Size(126, 23);
            this.button_Resolver.TabIndex = 17;
            this.button_Resolver.Text = "Calcular P(K)";
            this.button_Resolver.UseVisualStyleBackColor = true;
            this.button_Resolver.Click += new System.EventHandler(this.Button_Resolver_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(816, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Polinomio_De);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "FINTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Polinomio_De.ResumeLayout(false);
            this.groupBox_Polinomio_De.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Polinomio_De;
        private System.Windows.Forms.RadioButton radioButton_NG_Regresivo;
        private System.Windows.Forms.RadioButton radioButton_NG_Progresivo;
        private System.Windows.Forms.RadioButton radioButton_Lagrange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox_Pasos_Calculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_PolinomioPdeX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_Lote_Datos_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Lote_Datos_X;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_P_de_K;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Valor_K;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Resolver;
        private System.Windows.Forms.Button button2;
    }
}

