﻿namespace Ejercicio_4___Tema_8
{
    partial class FormRectangulo
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ancho";
            // 
            // txtAncho
            // 
            this.txtAncho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAncho.Location = new System.Drawing.Point(110, 177);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Location = new System.Drawing.Point(110, 131);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Posición Y";
            // 
            // txtPosY
            // 
            this.txtPosY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosY.Location = new System.Drawing.Point(110, 81);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Posición X";
            // 
            // txtPosX
            // 
            this.txtPosX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosX.Location = new System.Drawing.Point(110, 35);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 20);
            this.txtPosX.TabIndex = 37;
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnyadir.Location = new System.Drawing.Point(69, 273);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(111, 44);
            this.btnAnyadir.TabIndex = 36;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = false;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Largo";
            // 
            // txtLargo
            // 
            this.txtLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLargo.Location = new System.Drawing.Point(110, 222);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 45;
            // 
            // FormRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.btnAnyadir);
            this.Name = "FormRectangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLargo;
    }
}