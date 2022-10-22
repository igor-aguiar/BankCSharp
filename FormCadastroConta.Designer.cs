
namespace Bank
{
    partial class FormCadastroConta
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
            this.registerAccountBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerAccountBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.owner);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // registerAccountBtn
            // 
            this.registerAccountBtn.Location = new System.Drawing.Point(84, 156);
            this.registerAccountBtn.Name = "registerAccountBtn";
            this.registerAccountBtn.Size = new System.Drawing.Size(221, 23);
            this.registerAccountBtn.TabIndex = 9;
            this.registerAccountBtn.Text = "Register Account";
            this.registerAccountBtn.UseVisualStyleBackColor = true;
            this.registerAccountBtn.Click += new System.EventHandler(this.registerAccountBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Owner";
            // 
            // owner
            // 
            this.owner.Location = new System.Drawing.Point(84, 47);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(221, 20);
            this.owner.TabIndex = 0;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(84, 89);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(221, 20);
            this.number.TabIndex = 1;
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 226);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registerAccountBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox owner;
        private System.Windows.Forms.TextBox number;
    }
}