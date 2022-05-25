namespace Hw7csh
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelUserNumber = new System.Windows.Forms.Label();
            this.labelCountOfTry = new System.Windows.Forms.Label();
            this.labelMenuTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(312, 52);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(107, 62);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset game";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Visible = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlusOne.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusOne.Location = new System.Drawing.Point(312, 254);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(107, 62);
            this.buttonPlusOne.TabIndex = 1;
            this.buttonPlusOne.Text = "X2";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Visible = false;
            this.buttonPlusOne.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiply.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(312, 154);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(107, 62);
            this.buttonMultiply.TabIndex = 2;
            this.buttonMultiply.Text = "Plus 1";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Visible = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonPLusOne_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerNumber.Location = new System.Drawing.Point(65, 71);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(135, 24);
            this.labelComputerNumber.TabIndex = 3;
            this.labelComputerNumber.Text = "Find  number:";
            this.labelComputerNumber.Visible = false;
            // 
            // labelUserNumber
            // 
            this.labelUserNumber.AutoSize = true;
            this.labelUserNumber.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNumber.Location = new System.Drawing.Point(65, 173);
            this.labelUserNumber.Name = "labelUserNumber";
            this.labelUserNumber.Size = new System.Drawing.Size(131, 24);
            this.labelUserNumber.TabIndex = 4;
            this.labelUserNumber.Text = "Your number:";
            this.labelUserNumber.Visible = false;
            // 
            // labelCountOfTry
            // 
            this.labelCountOfTry.AutoSize = true;
            this.labelCountOfTry.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfTry.Location = new System.Drawing.Point(65, 273);
            this.labelCountOfTry.Name = "labelCountOfTry";
            this.labelCountOfTry.Size = new System.Drawing.Size(143, 24);
            this.labelCountOfTry.TabIndex = 5;
            this.labelCountOfTry.Text = "Number of try:";
            this.labelCountOfTry.Visible = false;
            // 
            // labelMenuTitle
            // 
            this.labelMenuTitle.AutoSize = true;
            this.labelMenuTitle.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuTitle.Location = new System.Drawing.Point(147, 81);
            this.labelMenuTitle.Name = "labelMenuTitle";
            this.labelMenuTitle.Size = new System.Drawing.Size(182, 33);
            this.labelMenuTitle.TabIndex = 6;
            this.labelMenuTitle.Text = "Doubler Game";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(153, 154);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(176, 38);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(153, 232);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 38);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 345);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMenuTitle);
            this.Controls.Add(this.labelCountOfTry);
            this.Controls.Add(this.labelUserNumber);
            this.Controls.Add(this.labelComputerNumber);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonPlusOne);
            this.Controls.Add(this.buttonReset);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonPlusOne;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelUserNumber;
        private System.Windows.Forms.Label labelCountOfTry;
        private System.Windows.Forms.Label labelMenuTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
    }
}

