namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_thing1 = new System.Windows.Forms.TextBox();
            this.txt_thing2 = new System.Windows.Forms.TextBox();
            this.btn_thing1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "object_no_1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "object_no_2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_thing1
            // 
            this.txt_thing1.Location = new System.Drawing.Point(369, 265);
            this.txt_thing1.Name = "txt_thing1";
            this.txt_thing1.Size = new System.Drawing.Size(273, 20);
            this.txt_thing1.TabIndex = 2;
            this.txt_thing1.TextChanged += new System.EventHandler(this.txt_thing1_TextChanged);
            // 
            // txt_thing2
            // 
            this.txt_thing2.Location = new System.Drawing.Point(369, 318);
            this.txt_thing2.Name = "txt_thing2";
            this.txt_thing2.Size = new System.Drawing.Size(273, 20);
            this.txt_thing2.TabIndex = 3;
            // 
            // btn_thing1
            // 
            this.btn_thing1.Location = new System.Drawing.Point(369, 390);
            this.btn_thing1.Name = "btn_thing1";
            this.btn_thing1.Size = new System.Drawing.Size(248, 23);
            this.btn_thing1.TabIndex = 4;
            this.btn_thing1.Text = "button1";
            this.btn_thing1.UseVisualStyleBackColor = true;
            this.btn_thing1.Click += new System.EventHandler(this.btn_thing1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 625);
            this.Controls.Add(this.btn_thing1);
            this.Controls.Add(this.txt_thing2);
            this.Controls.Add(this.txt_thing1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_thing1;
        private System.Windows.Forms.TextBox txt_thing2;
        private System.Windows.Forms.Button btn_thing1;
    }
}

