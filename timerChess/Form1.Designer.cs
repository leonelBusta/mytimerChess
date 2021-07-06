
namespace timerChess
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutos = new System.Windows.Forms.ComboBox();
            this.comboBoxSegundos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTiempo1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btncambio = new System.Windows.Forms.Button();
            this.labelTiempo2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBlancas = new System.Windows.Forms.TextBox();
            this.txtNegras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.BackColor = System.Drawing.Color.White;
            this.comboBoxHora.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(287, 61);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(71, 37);
            this.comboBoxHora.TabIndex = 0;
            // 
            // comboBoxMinutos
            // 
            this.comboBoxMinutos.BackColor = System.Drawing.Color.White;
            this.comboBoxMinutos.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMinutos.FormattingEnabled = true;
            this.comboBoxMinutos.Location = new System.Drawing.Point(472, 61);
            this.comboBoxMinutos.Name = "comboBoxMinutos";
            this.comboBoxMinutos.Size = new System.Drawing.Size(77, 37);
            this.comboBoxMinutos.TabIndex = 1;
            // 
            // comboBoxSegundos
            // 
            this.comboBoxSegundos.FormattingEnabled = true;
            this.comboBoxSegundos.Location = new System.Drawing.Point(742, 494);
            this.comboBoxSegundos.Name = "comboBoxSegundos";
            this.comboBoxSegundos.Size = new System.Drawing.Size(80, 23);
            this.comboBoxSegundos.TabIndex = 2;
            this.comboBoxSegundos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "HORAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "MINUTOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Segundos:";
            this.label3.Visible = false;
            // 
            // labelTiempo1
            // 
            this.labelTiempo1.AutoSize = true;
            this.labelTiempo1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelTiempo1.Font = new System.Drawing.Font("Stencil", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTiempo1.Location = new System.Drawing.Point(40, 222);
            this.labelTiempo1.Name = "labelTiempo1";
            this.labelTiempo1.Size = new System.Drawing.Size(360, 93);
            this.labelTiempo1.TabIndex = 6;
            this.labelTiempo1.Text = "00:00:00";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(323, 138);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(187, 56);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btncambio
            // 
            this.btncambio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncambio.FlatAppearance.BorderSize = 0;
            this.btncambio.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncambio.Location = new System.Drawing.Point(297, 367);
            this.btncambio.Name = "btncambio";
            this.btncambio.Size = new System.Drawing.Size(235, 93);
            this.btncambio.TabIndex = 8;
            this.btncambio.Text = "Turnos";
            this.btncambio.UseVisualStyleBackColor = false;
            this.btncambio.Click += new System.EventHandler(this.btncambio_Click);
            // 
            // labelTiempo2
            // 
            this.labelTiempo2.AutoSize = true;
            this.labelTiempo2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelTiempo2.Font = new System.Drawing.Font("Stencil", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTiempo2.Location = new System.Drawing.Point(434, 222);
            this.labelTiempo2.Name = "labelTiempo2";
            this.labelTiempo2.Size = new System.Drawing.Size(360, 93);
            this.labelTiempo2.TabIndex = 9;
            this.labelTiempo2.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::timerChess.Properties.Resources.giphy__2_;
            this.pictureBox2.Location = new System.Drawing.Point(40, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 315);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::timerChess.Properties.Resources.giphy__1_;
            this.pictureBox3.Location = new System.Drawing.Point(485, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(309, 315);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // txtBlancas
            // 
            this.txtBlancas.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBlancas.Location = new System.Drawing.Point(28, 150);
            this.txtBlancas.Name = "txtBlancas";
            this.txtBlancas.Size = new System.Drawing.Size(230, 41);
            this.txtBlancas.TabIndex = 14;
            this.txtBlancas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNegras
            // 
            this.txtNegras.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNegras.Location = new System.Drawing.Point(568, 150);
            this.txtNegras.Name = "txtNegras";
            this.txtNegras.Size = new System.Drawing.Size(234, 41);
            this.txtNegras.TabIndex = 15;
            this.txtNegras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(817, 522);
            this.Controls.Add(this.txtNegras);
            this.Controls.Add(this.txtBlancas);
            this.Controls.Add(this.labelTiempo2);
            this.Controls.Add(this.labelTiempo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncambio);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSegundos);
            this.Controls.Add(this.comboBoxMinutos);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.ComboBox comboBoxMinutos;
        private System.Windows.Forms.ComboBox comboBoxSegundos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTiempo1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btncambio;
        private System.Windows.Forms.Label labelTiempo2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBlancas;
        private System.Windows.Forms.TextBox txtNegras;
    }
}

