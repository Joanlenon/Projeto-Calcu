namespace Projeto_Calcu
{
    partial class Aritimetico
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
            this.txt_pri = new System.Windows.Forms.TextBox();
            this.txt_seg = new System.Windows.Forms.TextBox();
            this.txt_ter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_media = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_pri
            // 
            this.txt_pri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pri.ForeColor = System.Drawing.Color.Black;
            this.txt_pri.Location = new System.Drawing.Point(49, 43);
            this.txt_pri.Name = "txt_pri";
            this.txt_pri.Size = new System.Drawing.Size(151, 26);
            this.txt_pri.TabIndex = 0;
            this.txt_pri.TextChanged += new System.EventHandler(this.txt_pri_TextChanged);
            // 
            // txt_seg
            // 
            this.txt_seg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seg.Location = new System.Drawing.Point(51, 113);
            this.txt_seg.Name = "txt_seg";
            this.txt_seg.Size = new System.Drawing.Size(151, 26);
            this.txt_seg.TabIndex = 1;
            this.txt_seg.TextChanged += new System.EventHandler(this.txt_seg_TextChanged);
            // 
            // txt_ter
            // 
            this.txt_ter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ter.Location = new System.Drawing.Point(51, 182);
            this.txt_ter.Name = "txt_ter";
            this.txt_ter.Size = new System.Drawing.Size(151, 26);
            this.txt_ter.TabIndex = 2;
            this.txt_ter.TextChanged += new System.EventHandler(this.txt_ter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Primeiro Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Terceiro Valor";
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(382, 113);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(151, 26);
            this.txt_resultado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Média Aritimética";
            // 
            // btn_media
            // 
            this.btn_media.Location = new System.Drawing.Point(262, 116);
            this.btn_media.Name = "btn_media";
            this.btn_media.Size = new System.Drawing.Size(75, 23);
            this.btn_media.TabIndex = 8;
            this.btn_media.Text = "Media";
            this.btn_media.UseVisualStyleBackColor = true;
            this.btn_media.Click += new System.EventHandler(this.btn_media_Click);
            // 
            // Aritimetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_media);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ter);
            this.Controls.Add(this.txt_seg);
            this.Controls.Add(this.txt_pri);
            this.Name = "Aritimetico";
            this.Text = "Aritimetico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pri;
        private System.Windows.Forms.TextBox txt_seg;
        private System.Windows.Forms.TextBox txt_ter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_media;
    }
}