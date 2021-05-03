
namespace Difficulty_settings
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
            this.heronameOutput = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.begin = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.welcomeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heronameOutput
            // 
            this.heronameOutput.Location = new System.Drawing.Point(222, 35);
            this.heronameOutput.Name = "heronameOutput";
            this.heronameOutput.Size = new System.Drawing.Size(166, 20);
            this.heronameOutput.TabIndex = 0;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(12, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(204, 23);
            this.label.TabIndex = 1;
            this.label.Text = "Enter Your Hero Name:";
            // 
            // select
            // 
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select.Location = new System.Drawing.Point(93, 142);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(231, 23);
            this.select.TabIndex = 2;
            this.select.Text = "Select Your Diffculty Level:";
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.easyButton.Location = new System.Drawing.Point(16, 168);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(100, 35);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumButton.Location = new System.Drawing.Point(162, 168);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(100, 35);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.hardButton.Location = new System.Drawing.Point(298, 168);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(100, 35);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // begin
            // 
            this.begin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin.ForeColor = System.Drawing.SystemColors.Control;
            this.begin.Location = new System.Drawing.Point(134, 271);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(150, 35);
            this.begin.TabIndex = 6;
            this.begin.Text = "Begin";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputLabel.Location = new System.Drawing.Point(28, 353);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(360, 30);
            this.outputLabel.TabIndex = 7;
            // 
            // welcomeOutput
            // 
            this.welcomeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.welcomeOutput.Location = new System.Drawing.Point(97, 326);
            this.welcomeOutput.Name = "welcomeOutput";
            this.welcomeOutput.Size = new System.Drawing.Size(227, 27);
            this.welcomeOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(410, 410);
            this.Controls.Add(this.welcomeOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label);
            this.Controls.Add(this.heronameOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hero Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heronameOutput;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label select;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label welcomeOutput;
    }
}

