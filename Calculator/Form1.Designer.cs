namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.First_box = new System.Windows.Forms.TextBox();
            this.Third_box = new System.Windows.Forms.TextBox();
            this.Result_box = new System.Windows.Forms.TextBox();
            this.Result_button = new System.Windows.Forms.Button();
            this.Second_box = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.Info_Box = new System.Windows.Forms.TextBox();
            this.What_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First_box
            // 
            this.First_box.Location = new System.Drawing.Point(70, 83);
            this.First_box.Name = "First_box";
            this.First_box.Size = new System.Drawing.Size(147, 27);
            this.First_box.TabIndex = 0;
            this.First_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.First_Box_KeyPress);
            // 
            // Third_box
            // 
            this.Third_box.Location = new System.Drawing.Point(70, 182);
            this.Third_box.Name = "Third_box";
            this.Third_box.Size = new System.Drawing.Size(147, 27);
            this.Third_box.TabIndex = 0;
            this.Third_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Third_Box_KeyPress);
            // 
            // Result_box
            // 
            this.Result_box.BackColor = System.Drawing.Color.LavenderBlush;
            this.Result_box.Cursor = System.Windows.Forms.Cursors.No;
            this.Result_box.Location = new System.Drawing.Point(22, 34);
            this.Result_box.Name = "Result_box";
            this.Result_box.ReadOnly = true;
            this.Result_box.Size = new System.Drawing.Size(408, 27);
            this.Result_box.TabIndex = 0;
            // 
            // Result_button
            // 
            this.Result_button.BackColor = System.Drawing.Color.MistyRose;
            this.Result_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Result_button.BackgroundImage")));
            this.Result_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Result_button.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result_button.Image = ((System.Drawing.Image)(resources.GetObject("Result_button.Image")));
            this.Result_button.Location = new System.Drawing.Point(264, 107);
            this.Result_button.Name = "Result_button";
            this.Result_button.Size = new System.Drawing.Size(87, 87);
            this.Result_button.TabIndex = 1;
            this.Result_button.Text = "OK";
            this.Result_button.UseVisualStyleBackColor = false;
            this.Result_button.Click += new System.EventHandler(this.Result_button_Click);
            // 
            // Second_box
            // 
            this.Second_box.Location = new System.Drawing.Point(70, 135);
            this.Second_box.MaxLength = 1;
            this.Second_box.Name = "Second_box";
            this.Second_box.Size = new System.Drawing.Size(147, 27);
            this.Second_box.TabIndex = 0;
            this.Second_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Second_Box_KeyPress);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_1.ForeColor = System.Drawing.Color.Black;
            this.label_1.Location = new System.Drawing.Point(22, 83);
            this.label_1.MinimumSize = new System.Drawing.Size(27, 27);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(27, 27);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "1";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_2.ForeColor = System.Drawing.Color.Black;
            this.label_2.Location = new System.Drawing.Point(22, 135);
            this.label_2.MinimumSize = new System.Drawing.Size(27, 27);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(27, 27);
            this.label_2.TabIndex = 2;
            this.label_2.Text = "2";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_3.ForeColor = System.Drawing.Color.Black;
            this.label_3.Location = new System.Drawing.Point(22, 182);
            this.label_3.MinimumSize = new System.Drawing.Size(27, 27);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(27, 27);
            this.label_3.TabIndex = 2;
            this.label_3.Text = "3";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info_Box
            // 
            this.Info_Box.BackColor = System.Drawing.Color.LavenderBlush;
            this.Info_Box.Cursor = System.Windows.Forms.Cursors.No;
            this.Info_Box.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Info_Box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Info_Box.Location = new System.Drawing.Point(22, 235);
            this.Info_Box.Multiline = true;
            this.Info_Box.Name = "Info_Box";
            this.Info_Box.ReadOnly = true;
            this.Info_Box.Size = new System.Drawing.Size(240, 151);
            this.Info_Box.TabIndex = 3;
            // 
            // What_Button
            // 
            this.What_Button.Cursor = System.Windows.Forms.Cursors.Help;
            this.What_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.What_Button.Location = new System.Drawing.Point(291, 348);
            this.What_Button.Name = "What_Button";
            this.What_Button.Size = new System.Drawing.Size(59, 37);
            this.What_Button.TabIndex = 4;
            this.What_Button.Text = "?";
            this.What_Button.UseVisualStyleBackColor = true;
            this.What_Button.Click += new System.EventHandler(this.What_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.What_Button);
            this.Controls.Add(this.Info_Box);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.Second_box);
            this.Controls.Add(this.Result_button);
            this.Controls.Add(this.Result_box);
            this.Controls.Add(this.Third_box);
            this.Controls.Add(this.First_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kawaii Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_box;
        private System.Windows.Forms.TextBox Third_box;
        private System.Windows.Forms.TextBox Result_box;
        private System.Windows.Forms.Button Result_button;
        private System.Windows.Forms.TextBox Second_box;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.TextBox Info_Box;
        private System.Windows.Forms.Button What_Button;
    }
}

