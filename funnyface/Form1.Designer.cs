namespace funnyface
{
    partial class Form1
    {
        /// <summary>
        /// Povinná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Vyčištění použitých prostředků.
        /// </summary>
        /// <param name="disposing">true, pokud se mají uvolnit spravované prostředky; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda potřebná pro podporu návrháře - neupravovat  
        /// její obsah v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLength = new System.Windows.Forms.Label();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(503, 166);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(114, 25);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "počet znaků";
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numPasswordLength.Location = new System.Drawing.Point(626, 164);
            this.numPasswordLength.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.numPasswordLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPasswordLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(68, 32);
            this.numPasswordLength.TabIndex = 1;
            this.numPasswordLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(526, 221);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 52);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "🤑💲💯";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(463, 334);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(291, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 62);
            this.label1.TabIndex = 4;
            this.label1.Tag = "ff";
            this.label1.Text = "GENERÁTOR NUKLEÁRNÍCH HESEL";
            // 
            // timer1
            // 
            this.timer1.Tag = "ff";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::funnyface.Properties.Resources.cyber_hacker_attack_background_skull_vector__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.numPasswordLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Generátor Hesel";
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
