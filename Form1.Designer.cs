namespace Formulario {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.certo1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.certo2 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.certo3 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.caixa1 = new System.Windows.Forms.Panel();
            this.caixa2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pontuacao = new System.Windows.Forms.Label();
            this.caixa1.SuspendLayout();
            this.caixa2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) 10 + 10 = ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2) 20 + 20 = ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3) 30 + 30 = ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(581, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar resposta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // certo1
            // 
            this.certo1.AutoSize = true;
            this.certo1.Location = new System.Drawing.Point(28, 16);
            this.certo1.Name = "certo1";
            this.certo1.Size = new System.Drawing.Size(37, 17);
            this.certo1.TabIndex = 4;
            this.certo1.TabStop = true;
            this.certo1.Text = "20";
            this.certo1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(155, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(277, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "40";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(26, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "60";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(153, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "50";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // certo2
            // 
            this.certo2.AutoSize = true;
            this.certo2.Location = new System.Drawing.Point(275, 20);
            this.certo2.Name = "certo2";
            this.certo2.Size = new System.Drawing.Size(37, 17);
            this.certo2.TabIndex = 9;
            this.certo2.TabStop = true;
            this.certo2.Text = "40";
            this.certo2.UseVisualStyleBackColor = true;
            this.certo2.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(23, 18);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(37, 17);
            this.radioButton7.TabIndex = 10;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "80";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // certo3
            // 
            this.certo3.AutoSize = true;
            this.certo3.Location = new System.Drawing.Point(150, 18);
            this.certo3.Name = "certo3";
            this.certo3.Size = new System.Drawing.Size(37, 17);
            this.certo3.TabIndex = 11;
            this.certo3.TabStop = true;
            this.certo3.Text = "60";
            this.certo3.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(272, 18);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(37, 17);
            this.radioButton9.TabIndex = 12;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "70";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // caixa1
            // 
            this.caixa1.Controls.Add(this.radioButton3);
            this.caixa1.Controls.Add(this.radioButton2);
            this.caixa1.Controls.Add(this.certo1);
            this.caixa1.Location = new System.Drawing.Point(149, 83);
            this.caixa1.Name = "caixa1";
            this.caixa1.Size = new System.Drawing.Size(352, 54);
            this.caixa1.TabIndex = 13;
            // 
            // caixa2
            // 
            this.caixa2.Controls.Add(this.certo2);
            this.caixa2.Controls.Add(this.radioButton5);
            this.caixa2.Controls.Add(this.radioButton4);
            this.caixa2.Location = new System.Drawing.Point(151, 179);
            this.caixa2.Name = "caixa2";
            this.caixa2.Size = new System.Drawing.Size(349, 56);
            this.caixa2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.certo3);
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Location = new System.Drawing.Point(154, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 61);
            this.panel3.TabIndex = 15;
            // 
            // pontuacao
            // 
            this.pontuacao.AutoSize = true;
            this.pontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pontuacao.Location = new System.Drawing.Point(589, 323);
            this.pontuacao.Name = "pontuacao";
            this.pontuacao.Size = new System.Drawing.Size(140, 17);
            this.pontuacao.TabIndex = 16;
            this.pontuacao.Text = "SUA PONTUAÇÃO";
            this.pontuacao.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pontuacao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.caixa2);
            this.Controls.Add(this.caixa1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.caixa1.ResumeLayout(false);
            this.caixa1.PerformLayout();
            this.caixa2.ResumeLayout(false);
            this.caixa2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton certo1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton certo2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton certo3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Panel caixa1;
        private System.Windows.Forms.Panel caixa2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pontuacao;
    }
}

