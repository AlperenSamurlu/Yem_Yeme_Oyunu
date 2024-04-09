namespace Yem_Yeme_Oyunu
{
    partial class Form_Game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.EngelUst = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.Yem = new System.Windows.Forms.Label();
            this.EngelOrta = new System.Windows.Forms.Label();
            this.EngelSol = new System.Windows.Forms.Label();
            this.Avci = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_Disco = new System.Windows.Forms.Timer(this.components);
            this.EngelAlt = new System.Windows.Forms.Label();
            this.EngelSag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Avci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(449, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Siyah Yerlere Dokunmayınız";
            // 
            // EngelUst
            // 
            this.EngelUst.BackColor = System.Drawing.Color.Black;
            this.EngelUst.Location = new System.Drawing.Point(30, 9);
            this.EngelUst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EngelUst.Name = "EngelUst";
            this.EngelUst.Size = new System.Drawing.Size(1877, 13);
            this.EngelUst.TabIndex = 24;
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.BackColor = System.Drawing.Color.Black;
            this.labelSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSure.ForeColor = System.Drawing.Color.White;
            this.labelSure.Location = new System.Drawing.Point(507, 236);
            this.labelSure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(42, 17);
            this.labelSure.TabIndex = 23;
            this.labelSure.Text = "Süre:";
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.BackColor = System.Drawing.Color.Black;
            this.labelPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPuan.ForeColor = System.Drawing.Color.White;
            this.labelPuan.Location = new System.Drawing.Point(507, 211);
            this.labelPuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(57, 17);
            this.labelPuan.TabIndex = 22;
            this.labelPuan.Text = "Puan=0";
            // 
            // Yem
            // 
            this.Yem.BackColor = System.Drawing.Color.Blue;
            this.Yem.Location = new System.Drawing.Point(380, 90);
            this.Yem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Yem.Name = "Yem";
            this.Yem.Size = new System.Drawing.Size(12, 13);
            this.Yem.TabIndex = 21;
            // 
            // EngelOrta
            // 
            this.EngelOrta.BackColor = System.Drawing.Color.Black;
            this.EngelOrta.Location = new System.Drawing.Point(446, 194);
            this.EngelOrta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EngelOrta.Name = "EngelOrta";
            this.EngelOrta.Size = new System.Drawing.Size(188, 89);
            this.EngelOrta.TabIndex = 20;
            // 
            // EngelSol
            // 
            this.EngelSol.BackColor = System.Drawing.Color.Black;
            this.EngelSol.Location = new System.Drawing.Point(18, 9);
            this.EngelSol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EngelSol.Name = "EngelSol";
            this.EngelSol.Size = new System.Drawing.Size(18, 1043);
            this.EngelSol.TabIndex = 19;
            // 
            // Avci
            // 
            this.Avci.BackColor = System.Drawing.Color.Red;
            this.Avci.Location = new System.Drawing.Point(372, 80);
            this.Avci.Margin = new System.Windows.Forms.Padding(2);
            this.Avci.Name = "Avci";
            this.Avci.Size = new System.Drawing.Size(20, 23);
            this.Avci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avci.TabIndex = 18;
            this.Avci.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_Disco
            // 
            this.timer_Disco.Tick += new System.EventHandler(this.timer_Disco_Tick);
            // 
            // EngelAlt
            // 
            this.EngelAlt.BackColor = System.Drawing.Color.Black;
            this.EngelAlt.Location = new System.Drawing.Point(18, 1039);
            this.EngelAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EngelAlt.Name = "EngelAlt";
            this.EngelAlt.Size = new System.Drawing.Size(1877, 13);
            this.EngelAlt.TabIndex = 26;
            // 
            // EngelSag
            // 
            this.EngelSag.BackColor = System.Drawing.Color.Black;
            this.EngelSag.Location = new System.Drawing.Point(1889, 9);
            this.EngelSag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EngelSag.Name = "EngelSag";
            this.EngelSag.Size = new System.Drawing.Size(18, 1043);
            this.EngelSag.TabIndex = 27;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.EngelSag);
            this.Controls.Add(this.EngelAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EngelUst);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.labelPuan);
            this.Controls.Add(this.Yem);
            this.Controls.Add(this.EngelOrta);
            this.Controls.Add(this.EngelSol);
            this.Controls.Add(this.Avci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Game";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Avci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EngelUst;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Label Yem;
        private System.Windows.Forms.Label EngelOrta;
        private System.Windows.Forms.Label EngelSol;
        private System.Windows.Forms.PictureBox Avci;
      
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_Disco;
        private System.Windows.Forms.Label EngelAlt;
        private System.Windows.Forms.Label EngelSag;
    }
}

