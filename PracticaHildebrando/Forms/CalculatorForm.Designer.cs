namespace PracticaHildebrando.Forms
{
    partial class CalculatorForm
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
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.btnIncr = new System.Windows.Forms.Button();
            this.btnDecre = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(53, 56);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(100, 22);
            this.tbNumber1.TabIndex = 0;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(53, 97);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(100, 22);
            this.tbNumber2.TabIndex = 1;
            // 
            // btnIncr
            // 
            this.btnIncr.Location = new System.Drawing.Point(53, 174);
            this.btnIncr.Name = "btnIncr";
            this.btnIncr.Size = new System.Drawing.Size(75, 23);
            this.btnIncr.TabIndex = 2;
            this.btnIncr.Text = "+";
            this.btnIncr.UseVisualStyleBackColor = true;
            this.btnIncr.Click += new System.EventHandler(this.btnIncr_Click);
            // 
            // btnDecre
            // 
            this.btnDecre.Location = new System.Drawing.Point(53, 236);
            this.btnDecre.Name = "btnDecre";
            this.btnDecre.Size = new System.Drawing.Size(75, 23);
            this.btnDecre.TabIndex = 3;
            this.btnDecre.Text = "-";
            this.btnDecre.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(183, 174);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(183, 236);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(213, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 6;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDecre);
            this.Controls.Add(this.btnIncr);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Button btnIncr;
        private System.Windows.Forms.Button btnDecre;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label lblResult;
    }
}