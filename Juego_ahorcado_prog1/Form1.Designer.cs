namespace Juego_ahorcado_prog1
{
	partial class Form1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.imgCuerpo = new System.Windows.Forms.PictureBox();
			this.imgPieRight = new System.Windows.Forms.PictureBox();
			this.imgPieLeft = new System.Windows.Forms.PictureBox();
			this.imgBrazoLeft = new System.Windows.Forms.PictureBox();
			this.imgBrazoRight = new System.Windows.Forms.PictureBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnContainer1 = new System.Windows.Forms.FlowLayoutPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgCuerpo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPieRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPieLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBrazoLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBrazoRight)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0001s_0000_Horca_2_copy;
			this.pictureBox1.Location = new System.Drawing.Point(58, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(167, 365);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0000s_0000_Cabeza;
			this.pictureBox2.Location = new System.Drawing.Point(187, 58);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(69, 67);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// imgCuerpo
			// 
			this.imgCuerpo.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0000s_0005_Cuerpo;
			this.imgCuerpo.Location = new System.Drawing.Point(215, 80);
			this.imgCuerpo.Name = "imgCuerpo";
			this.imgCuerpo.Size = new System.Drawing.Size(14, 242);
			this.imgCuerpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgCuerpo.TabIndex = 3;
			this.imgCuerpo.TabStop = false;
			this.imgCuerpo.Visible = false;
			// 
			// imgPieRight
			// 
			this.imgPieRight.BackColor = System.Drawing.Color.Transparent;
			this.imgPieRight.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0000s_0004_Pierna_izquierda;
			this.imgPieRight.Location = new System.Drawing.Point(177, 305);
			this.imgPieRight.Name = "imgPieRight";
			this.imgPieRight.Size = new System.Drawing.Size(48, 72);
			this.imgPieRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgPieRight.TabIndex = 4;
			this.imgPieRight.TabStop = false;
			this.imgPieRight.Visible = false;
			// 
			// imgPieLeft
			// 
			this.imgPieLeft.BackColor = System.Drawing.Color.Transparent;
			this.imgPieLeft.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0000s_0003_Pierna_derecha;
			this.imgPieLeft.Location = new System.Drawing.Point(219, 304);
			this.imgPieLeft.Name = "imgPieLeft";
			this.imgPieLeft.Size = new System.Drawing.Size(48, 72);
			this.imgPieLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgPieLeft.TabIndex = 5;
			this.imgPieLeft.TabStop = false;
			this.imgPieLeft.Visible = false;
			// 
			// imgBrazoLeft
			// 
			this.imgBrazoLeft.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.imgBrazoLeft.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0000s_0001_Brazo_derecho;
			this.imgBrazoLeft.Location = new System.Drawing.Point(219, 142);
			this.imgBrazoLeft.Name = "imgBrazoLeft";
			this.imgBrazoLeft.Size = new System.Drawing.Size(70, 68);
			this.imgBrazoLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBrazoLeft.TabIndex = 6;
			this.imgBrazoLeft.TabStop = false;
			this.imgBrazoLeft.Visible = false;
			// 
			// imgBrazoRight
			// 
			this.imgBrazoRight.Image = global::Juego_ahorcado_prog1.Properties.Resources.Ahorcado_0000s_0002_Brazo_izquierdo;
			this.imgBrazoRight.Location = new System.Drawing.Point(155, 143);
			this.imgBrazoRight.Name = "imgBrazoRight";
			this.imgBrazoRight.Size = new System.Drawing.Size(70, 68);
			this.imgBrazoRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBrazoRight.TabIndex = 7;
			this.imgBrazoRight.TabStop = false;
			this.imgBrazoRight.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(458, 58);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(173, 21);
			this.comboBox1.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(586, 156);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "Agregar Boton";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnContainer1
			// 
			this.btnContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnContainer1.Location = new System.Drawing.Point(527, 185);
			this.btnContainer1.Name = "btnContainer1";
			this.btnContainer1.Size = new System.Drawing.Size(251, 137);
			this.btnContainer1.TabIndex = 18;
			// 
			// timer1
			// 
			this.timer1.Interval = 300;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnContainer1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.imgCuerpo);
			this.Controls.Add(this.imgPieRight);
			this.Controls.Add(this.imgPieLeft);
			this.Controls.Add(this.imgBrazoLeft);
			this.Controls.Add(this.imgBrazoRight);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgCuerpo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPieRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPieLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBrazoLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgBrazoRight)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox imgCuerpo;
		private System.Windows.Forms.PictureBox imgPieRight;
		private System.Windows.Forms.PictureBox imgPieLeft;
		private System.Windows.Forms.PictureBox imgBrazoLeft;
		private System.Windows.Forms.PictureBox imgBrazoRight;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FlowLayoutPanel btnContainer1;
		private System.Windows.Forms.Timer timer1;
	}
}

