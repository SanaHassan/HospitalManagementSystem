namespace HospitalManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginPatientButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.loginAdminButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPatientButton
            // 
            this.loginPatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPatientButton.AutoSize = true;
            this.loginPatientButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.loginPatientButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPatientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPatientButton.Location = new System.Drawing.Point(42, 704);
            this.loginPatientButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginPatientButton.Name = "loginPatientButton";
            this.loginPatientButton.Size = new System.Drawing.Size(262, 77);
            this.loginPatientButton.TabIndex = 0;
            this.loginPatientButton.Text = "Patient";
            this.loginPatientButton.UseVisualStyleBackColor = false;
            this.loginPatientButton.Click += new System.EventHandler(this.loginPatientButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupButton.AutoSize = true;
            this.signupButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.signupButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signupButton.Location = new System.Drawing.Point(990, 700);
            this.signupButton.Margin = new System.Windows.Forms.Padding(6);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(340, 77);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Admin\'s Sign up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // loginAdminButton
            // 
            this.loginAdminButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginAdminButton.AutoSize = true;
            this.loginAdminButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.loginAdminButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginAdminButton.Location = new System.Drawing.Point(374, 704);
            this.loginAdminButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginAdminButton.Name = "loginAdminButton";
            this.loginAdminButton.Size = new System.Drawing.Size(262, 77);
            this.loginAdminButton.TabIndex = 2;
            this.loginAdminButton.Text = "Admin";
            this.loginAdminButton.UseVisualStyleBackColor = false;
            this.loginAdminButton.Click += new System.EventHandler(this.loginAdminButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(938, 789);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Doctor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 31.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(268, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1289, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1777, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::HospitalManagementSystem.Properties.Resources._1920x0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1774, 929);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginAdminButton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginPatientButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginPatientButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button loginAdminButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

