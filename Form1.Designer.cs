namespace LotteryApp
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
            lblBall1 = new Label();
            lblBall2 = new Label();
            lblBall3 = new Label();
            lblBall4 = new Label();
            lblBall5 = new Label();
            lblExtraBall = new Label();
            btnDraw = new Button();
            btnReset = new Button();
            lblStatus = new Label();
            lblTitile = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblBall1
            // 
            lblBall1.BackColor = Color.WhiteSmoke;
            lblBall1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBall1.Location = new Point(253, 230);
            lblBall1.Name = "lblBall1";
            lblBall1.Size = new Size(60, 60);
            lblBall1.TabIndex = 0;
            lblBall1.Text = "-";
            lblBall1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall2
            // 
            lblBall2.BackColor = Color.WhiteSmoke;
            lblBall2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBall2.Location = new Point(319, 230);
            lblBall2.Name = "lblBall2";
            lblBall2.Size = new Size(60, 60);
            lblBall2.TabIndex = 5;
            lblBall2.Text = "-";
            lblBall2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall3
            // 
            lblBall3.BackColor = Color.WhiteSmoke;
            lblBall3.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBall3.Location = new Point(385, 230);
            lblBall3.Name = "lblBall3";
            lblBall3.Size = new Size(60, 60);
            lblBall3.TabIndex = 6;
            lblBall3.Text = "-";
            lblBall3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall4
            // 
            lblBall4.BackColor = Color.WhiteSmoke;
            lblBall4.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBall4.Location = new Point(451, 230);
            lblBall4.Name = "lblBall4";
            lblBall4.Size = new Size(60, 60);
            lblBall4.TabIndex = 7;
            lblBall4.Text = "-";
            lblBall4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall5
            // 
            lblBall5.BackColor = Color.WhiteSmoke;
            lblBall5.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBall5.Location = new Point(517, 230);
            lblBall5.Name = "lblBall5";
            lblBall5.Size = new Size(60, 60);
            lblBall5.TabIndex = 8;
            lblBall5.Text = "-";
            lblBall5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExtraBall
            // 
            lblExtraBall.BackColor = Color.WhiteSmoke;
            lblExtraBall.BorderStyle = BorderStyle.Fixed3D;
            lblExtraBall.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExtraBall.ForeColor = Color.FromArgb(192, 0, 0);
            lblExtraBall.Location = new Point(637, 230);
            lblExtraBall.Name = "lblExtraBall";
            lblExtraBall.Size = new Size(60, 60);
            lblExtraBall.TabIndex = 9;
            lblExtraBall.Text = "+";
            lblExtraBall.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDraw
            // 
            btnDraw.BackColor = Color.DarkGoldenrod;
            btnDraw.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDraw.ForeColor = SystemColors.ControlText;
            btnDraw.Location = new Point(457, 338);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(120, 40);
            btnDraw.TabIndex = 10;
            btnDraw.Text = "Draw Ball";
            btnDraw.UseVisualStyleBackColor = false;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Firebrick;
            btnReset.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ControlLight;
            btnReset.Location = new Point(577, 338);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 40);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(253, 195);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 22);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Draw 0 of 6";
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.Font = new Font("Broadway", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitile.ForeColor = Color.Red;
            lblTitile.Location = new Point(385, 69);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(257, 50);
            lblTitile.TabIndex = 13;
            lblTitile.Text = "Lotto 6/36";
            lblTitile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.WhiteSmoke;
            lblResult.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(253, 460);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(261, 33);
            lblResult.TabIndex = 14;
            lblResult.Text = "Final combination:";
            lblResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 673);
            Controls.Add(lblResult);
            Controls.Add(lblTitile);
            Controls.Add(lblStatus);
            Controls.Add(btnReset);
            Controls.Add(btnDraw);
            Controls.Add(lblExtraBall);
            Controls.Add(lblBall5);
            Controls.Add(lblBall4);
            Controls.Add(lblBall3);
            Controls.Add(lblBall2);
            Controls.Add(lblBall1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lottery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBall1;
        private Label lblBall2;
        private Label lblBall3;
        private Label lblBall4;
        private Label lblBall5;
        private Label lblExtraBall;
        private Button btnDraw;
        private Button btnReset;
        private Label lblStatus;
        private Label lblTitile;
        private Label lblResult;
    }
}
