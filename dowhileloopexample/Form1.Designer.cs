namespace dowhileloopexample
{
    partial class FrmNewton
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtBuiltIn = new System.Windows.Forms.TextBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblbuiltin = new System.Windows.Forms.Label();
            this.lblNumberIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(133, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtBuiltIn
            // 
            this.txtBuiltIn.Location = new System.Drawing.Point(343, 36);
            this.txtBuiltIn.Name = "txtBuiltIn";
            this.txtBuiltIn.ReadOnly = true;
            this.txtBuiltIn.Size = new System.Drawing.Size(100, 20);
            this.txtBuiltIn.TabIndex = 1;
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(512, 35);
            this.txtActual.Name = "txtActual";
            this.txtActual.ReadOnly = true;
            this.txtActual.Size = new System.Drawing.Size(100, 20);
            this.txtActual.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(385, 149);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(343, 13);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(37, 13);
            this.lblActual.TabIndex = 4;
            this.lblActual.Text = "Actual";
            // 
            // lblbuiltin
            // 
            this.lblbuiltin.AutoSize = true;
            this.lblbuiltin.Location = new System.Drawing.Point(512, 12);
            this.lblbuiltin.Name = "lblbuiltin";
            this.lblbuiltin.Size = new System.Drawing.Size(73, 13);
            this.lblbuiltin.TabIndex = 5;
            this.lblbuiltin.Text = "Approzimation";
            // 
            // lblNumberIn
            // 
            this.lblNumberIn.AutoSize = true;
            this.lblNumberIn.Location = new System.Drawing.Point(133, 11);
            this.lblNumberIn.Name = "lblNumberIn";
            this.lblNumberIn.Size = new System.Drawing.Size(56, 13);
            this.lblNumberIn.TabIndex = 6;
            this.lblNumberIn.Text = "Number In";
            // 
            // FrmNewton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 538);
            this.Controls.Add(this.lblNumberIn);
            this.Controls.Add(this.lblbuiltin);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtBuiltIn);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmNewton";
            this.Text = "Square Root approximation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtBuiltIn;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblbuiltin;
        private System.Windows.Forms.Label lblNumberIn;
    }
}

