
namespace ConvertApp
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnEUR2VND = new System.Windows.Forms.Button();
            this.btnUSD2VND = new System.Windows.Forms.Button();
            this.btnVND2EUR = new System.Windows.Forms.Button();
            this.btnVND2USD = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblQuyDoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Red;
            this.txtResult.Location = new System.Drawing.Point(173, 180);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(255, 35);
            this.txtResult.TabIndex = 11;
            // 
            // btnEUR2VND
            // 
            this.btnEUR2VND.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEUR2VND.Location = new System.Drawing.Point(481, 253);
            this.btnEUR2VND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEUR2VND.Name = "btnEUR2VND";
            this.btnEUR2VND.Size = new System.Drawing.Size(159, 42);
            this.btnEUR2VND.TabIndex = 7;
            this.btnEUR2VND.Text = "EUR to VND";
            this.btnEUR2VND.UseVisualStyleBackColor = true;
            this.btnEUR2VND.Click += new System.EventHandler(this.btnEUR2VND_Click);
            // 
            // btnUSD2VND
            // 
            this.btnUSD2VND.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSD2VND.Location = new System.Drawing.Point(481, 148);
            this.btnUSD2VND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUSD2VND.Name = "btnUSD2VND";
            this.btnUSD2VND.Size = new System.Drawing.Size(159, 45);
            this.btnUSD2VND.TabIndex = 8;
            this.btnUSD2VND.Text = "USD to VND";
            this.btnUSD2VND.UseVisualStyleBackColor = true;
            this.btnUSD2VND.Click += new System.EventHandler(this.btnUSD2VND_Click);
            // 
            // btnVND2EUR
            // 
            this.btnVND2EUR.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVND2EUR.Location = new System.Drawing.Point(481, 203);
            this.btnVND2EUR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVND2EUR.Name = "btnVND2EUR";
            this.btnVND2EUR.Size = new System.Drawing.Size(159, 43);
            this.btnVND2EUR.TabIndex = 9;
            this.btnVND2EUR.Text = "VND to EUR";
            this.btnVND2EUR.UseVisualStyleBackColor = true;
            this.btnVND2EUR.Click += new System.EventHandler(this.btnVND2EUR_Click);
            // 
            // btnVND2USD
            // 
            this.btnVND2USD.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVND2USD.Location = new System.Drawing.Point(481, 94);
            this.btnVND2USD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVND2USD.Name = "btnVND2USD";
            this.btnVND2USD.Size = new System.Drawing.Size(159, 44);
            this.btnVND2USD.TabIndex = 10;
            this.btnVND2USD.Text = "VND to USD";
            this.btnVND2USD.UseVisualStyleBackColor = true;
            this.btnVND2USD.Click += new System.EventHandler(this.btnVND2USD_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.Color.Blue;
            this.txtMoney.Location = new System.Drawing.Point(173, 105);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(255, 35);
            this.txtMoney.TabIndex = 6;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(61, 180);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(95, 30);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả";
            // 
            // lblQuyDoi
            // 
            this.lblQuyDoi.AutoSize = true;
            this.lblQuyDoi.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyDoi.Location = new System.Drawing.Point(61, 108);
            this.lblQuyDoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuyDoi.Name = "lblQuyDoi";
            this.lblQuyDoi.Size = new System.Drawing.Size(91, 30);
            this.lblQuyDoi.TabIndex = 5;
            this.lblQuyDoi.Text = "Quy đổi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "CURRENCY CONVERSION APP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 334);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEUR2VND);
            this.Controls.Add(this.btnUSD2VND);
            this.Controls.Add(this.btnVND2EUR);
            this.Controls.Add(this.btnVND2USD);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuyDoi);
            this.Name = "Form1";
            this.Text = "Currency Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnEUR2VND;
        private System.Windows.Forms.Button btnUSD2VND;
        private System.Windows.Forms.Button btnVND2EUR;
        private System.Windows.Forms.Button btnVND2USD;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblQuyDoi;
        private System.Windows.Forms.Label label1;
    }
}

