namespace Gasolinera
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
            components = new System.ComponentModel.Container();
            btnRegular = new Button();
            btnPremium = new Button();
            btnSuperPremium = new Button();
            label1 = new Label();
            txtNumeroGalones = new TextBox();
            label2 = new Label();
            lblTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnRegular
            // 
            btnRegular.Location = new Point(23, 60);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(99, 90);
            btnRegular.TabIndex = 0;
            btnRegular.Text = "Regular";
            btnRegular.UseVisualStyleBackColor = true;
            btnRegular.Click += btnRegular_Click;
            // 
            // btnPremium
            // 
            btnPremium.Location = new Point(163, 60);
            btnPremium.Name = "btnPremium";
            btnPremium.Size = new Size(99, 90);
            btnPremium.TabIndex = 1;
            btnPremium.Text = "Premium";
            btnPremium.UseVisualStyleBackColor = true;
            btnPremium.Click += btnPremium_Click;
            // 
            // btnSuperPremium
            // 
            btnSuperPremium.Location = new Point(307, 60);
            btnSuperPremium.Name = "btnSuperPremium";
            btnSuperPremium.Size = new Size(99, 90);
            btnSuperPremium.TabIndex = 2;
            btnSuperPremium.Text = "Super Premium";
            btnSuperPremium.UseVisualStyleBackColor = true;
            btnSuperPremium.Click += btnSuperPremium_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "N de galones";
            // 
            // txtNumeroGalones
            // 
            txtNumeroGalones.Location = new Point(102, 21);
            txtNumeroGalones.Name = "txtNumeroGalones";
            txtNumeroGalones.Size = new Size(124, 23);
            txtNumeroGalones.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 24);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(306, 23);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "label3";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 193);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(txtNumeroGalones);
            Controls.Add(label1);
            Controls.Add(btnSuperPremium);
            Controls.Add(btnPremium);
            Controls.Add(btnRegular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegular;
        private Button btnPremium;
        private Button btnSuperPremium;
        private Label label1;
        private TextBox txtNumeroGalones;
        private Label label2;
        private Label lblTotal;
        private System.Windows.Forms.Timer timer1;
    }
}