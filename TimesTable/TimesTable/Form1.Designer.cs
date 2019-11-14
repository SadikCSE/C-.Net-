namespace TimesTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.loopStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loopEnd = new System.Windows.Forms.TextBox();
            this.loopsubmit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loopStart
            // 
            this.loopStart.Location = new System.Drawing.Point(175, 46);
            this.loopStart.Name = "loopStart";
            this.loopStart.Size = new System.Drawing.Size(100, 20);
            this.loopStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // loopEnd
            // 
            this.loopEnd.Location = new System.Drawing.Point(175, 106);
            this.loopEnd.Name = "loopEnd";
            this.loopEnd.Size = new System.Drawing.Size(100, 20);
            this.loopEnd.TabIndex = 3;
            // 
            // loopsubmit
            // 
            this.loopsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopsubmit.Location = new System.Drawing.Point(354, 75);
            this.loopsubmit.Name = "loopsubmit";
            this.loopsubmit.Size = new System.Drawing.Size(75, 23);
            this.loopsubmit.TabIndex = 4;
            this.loopsubmit.Text = "For Loop";
            this.loopsubmit.UseVisualStyleBackColor = true;
            this.loopsubmit.Click += new System.EventHandler(this.loopsubmit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(175, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 160);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 356);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loopsubmit);
            this.Controls.Add(this.loopEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loopStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Times Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loopStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loopEnd;
        private System.Windows.Forms.Button loopsubmit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

