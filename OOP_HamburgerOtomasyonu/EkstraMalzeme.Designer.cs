
namespace OOP_HamburgerOtomasyonu
{
    partial class EkstraMalzeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkstraKaydet = new System.Windows.Forms.Button();
            this.nudEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkstraKaydet);
            this.groupBox1.Controls.Add(this.nudEkstraFiyat);
            this.groupBox1.Controls.Add(this.txtEkstra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Bilgileri";
            // 
            // btnEkstraKaydet
            // 
            this.btnEkstraKaydet.Location = new System.Drawing.Point(132, 130);
            this.btnEkstraKaydet.Name = "btnEkstraKaydet";
            this.btnEkstraKaydet.Size = new System.Drawing.Size(227, 34);
            this.btnEkstraKaydet.TabIndex = 3;
            this.btnEkstraKaydet.Text = "Kaydet";
            this.btnEkstraKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraKaydet.Click += new System.EventHandler(this.btnEkstraKaydet_Click);
            // 
            // nudEkstraFiyat
            // 
            this.nudEkstraFiyat.Location = new System.Drawing.Point(132, 97);
            this.nudEkstraFiyat.Name = "nudEkstraFiyat";
            this.nudEkstraFiyat.Size = new System.Drawing.Size(227, 26);
            this.nudEkstraFiyat.TabIndex = 2;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(132, 53);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(227, 26);
            this.txtEkstra.TabIndex = 1;
            this.txtEkstra.TextChanged += new System.EventHandler(this.txtEkstra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Adı:";
            // 
            // EkstraMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 346);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EkstraMalzeme";
            this.Text = "EkstraMalzeme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkstraKaydet;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyat;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}