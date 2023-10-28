namespace C__SDF
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
            this.circle = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.circle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle.Location = new System.Drawing.Point(12, 22);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(139, 41);
            this.circle.TabIndex = 0;
            this.circle.Text = "Circle";
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.White;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.square.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(12, 135);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(139, 41);
            this.square.TabIndex = 1;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rectangle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangle.Location = new System.Drawing.Point(12, 78);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(139, 41);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 31);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.MinimumSize = new System.Drawing.Size(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter requirements:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.square);
            this.Controls.Add(this.circle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

