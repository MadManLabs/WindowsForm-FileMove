namespace MoveFile
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
            this.sourcebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.destinationtextBox = new System.Windows.Forms.TextBox();
            this.destinationbutton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourcebutton
            // 
            this.sourcebutton.BackColor = System.Drawing.Color.Lavender;
            this.sourcebutton.Location = new System.Drawing.Point(391, 98);
            this.sourcebutton.Name = "sourcebutton";
            this.sourcebutton.Size = new System.Drawing.Size(109, 23);
            this.sourcebutton.TabIndex = 0;
            this.sourcebutton.Text = "Choose Source";
            this.sourcebutton.UseVisualStyleBackColor = false;
            this.sourcebutton.Click += new System.EventHandler(this.sourcebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(58, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(27, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Path";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sourceTextBox.Location = new System.Drawing.Point(177, 100);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(189, 20);
            this.sourceTextBox.TabIndex = 3;
            // 
            // destinationtextBox
            // 
            this.destinationtextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.destinationtextBox.Location = new System.Drawing.Point(177, 165);
            this.destinationtextBox.Name = "destinationtextBox";
            this.destinationtextBox.Size = new System.Drawing.Size(189, 20);
            this.destinationtextBox.TabIndex = 4;
            // 
            // destinationbutton
            // 
            this.destinationbutton.Location = new System.Drawing.Point(391, 163);
            this.destinationbutton.Name = "destinationbutton";
            this.destinationbutton.Size = new System.Drawing.Size(109, 23);
            this.destinationbutton.TabIndex = 5;
            this.destinationbutton.Text = "Choose Destination";
            this.destinationbutton.UseVisualStyleBackColor = true;
            this.destinationbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(207, 255);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(140, 23);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "Move Files";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(24, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Move files created in the last 24 hours ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(536, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.destinationbutton);
            this.Controls.Add(this.destinationtextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourcebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourcebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.TextBox destinationtextBox;
        private System.Windows.Forms.Button destinationbutton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label label3;
    }
}

