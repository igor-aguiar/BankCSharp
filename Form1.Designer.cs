
namespace Bank
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
            this.owner = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.depositValue = new System.Windows.Forms.TextBox();
            this.Deposit = new System.Windows.Forms.Button();
            this.withdrawValue = new System.Windows.Forms.TextBox();
            this.Withdraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // owner
            // 
            this.owner.Location = new System.Drawing.Point(84, 50);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(100, 20);
            this.owner.TabIndex = 0;
            this.owner.TextChanged += new System.EventHandler(this.owner_TextChanged);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(84, 89);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 1;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(84, 129);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 20);
            this.balance.TabIndex = 2;
            // 
            // depositValue
            // 
            this.depositValue.Location = new System.Drawing.Point(71, 293);
            this.depositValue.Name = "depositValue";
            this.depositValue.Size = new System.Drawing.Size(100, 20);
            this.depositValue.TabIndex = 4;
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(71, 320);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(75, 23);
            this.Deposit.TabIndex = 5;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // withdrawValue
            // 
            this.withdrawValue.Location = new System.Drawing.Point(204, 292);
            this.withdrawValue.Name = "withdrawValue";
            this.withdrawValue.Size = new System.Drawing.Size(100, 20);
            this.withdrawValue.TabIndex = 6;
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(204, 319);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(75, 23);
            this.Withdraw.TabIndex = 7;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.owner);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.balance);
            this.groupBox1.Location = new System.Drawing.Point(177, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 238);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.withdrawValue);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.depositValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox owner;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox depositValue;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.TextBox withdrawValue;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

