namespace CalculatorTwoNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(190, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(211, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(364, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add.Location = new System.Drawing.Point(214, 204);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(41, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sub.Location = new System.Drawing.Point(276, 204);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(43, 23);
            this.Sub.TabIndex = 5;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mul.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Mul.Location = new System.Drawing.Point(334, 204);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(45, 23);
            this.Mul.TabIndex = 6;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = false;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Div.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Div.Location = new System.Drawing.Point(397, 204);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(44, 23);
            this.Div.TabIndex = 7;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resultBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.resultBox.Location = new System.Drawing.Point(149, 249);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 22);
            this.resultBox.TabIndex = 8;
            this.resultBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label3;
    }
}

