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
            SuspendLayout();
            // 
            // lblBall1
            // 
            lblBall1.BorderStyle = BorderStyle.FixedSingle;
            lblBall1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBall1.Location = new Point(139, 142);
            lblBall1.Name = "lblBall1";
            lblBall1.Size = new Size(60, 60);
            lblBall1.TabIndex = 0;
            lblBall1.Text = "-";
            lblBall1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall2
            // 
            lblBall2.BorderStyle = BorderStyle.FixedSingle;
            lblBall2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBall2.Location = new Point(205, 142);
            lblBall2.Name = "lblBall2";
            lblBall2.Size = new Size(60, 60);
            lblBall2.TabIndex = 5;
            lblBall2.Text = "-";
            lblBall2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall3
            // 
            lblBall3.BorderStyle = BorderStyle.FixedSingle;
            lblBall3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBall3.Location = new Point(271, 142);
            lblBall3.Name = "lblBall3";
            lblBall3.Size = new Size(60, 60);
            lblBall3.TabIndex = 6;
            lblBall3.Text = "-";
            lblBall3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall4
            // 
            lblBall4.BorderStyle = BorderStyle.FixedSingle;
            lblBall4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBall4.Location = new Point(337, 142);
            lblBall4.Name = "lblBall4";
            lblBall4.Size = new Size(60, 60);
            lblBall4.TabIndex = 7;
            lblBall4.Text = "-";
            lblBall4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBall5
            // 
            lblBall5.BorderStyle = BorderStyle.FixedSingle;
            lblBall5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBall5.Location = new Point(403, 142);
            lblBall5.Name = "lblBall5";
            lblBall5.Size = new Size(60, 60);
            lblBall5.TabIndex = 8;
            lblBall5.Text = "-";
            lblBall5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExtraBall
            // 
            lblExtraBall.BackColor = Color.FromArgb(255, 255, 128);
            lblExtraBall.BorderStyle = BorderStyle.FixedSingle;
            lblExtraBall.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtraBall.Location = new Point(529, 142);
            lblExtraBall.Name = "lblExtraBall";
            lblExtraBall.Size = new Size(60, 60);
            lblExtraBall.TabIndex = 9;
            lblExtraBall.Text = "+";
            lblExtraBall.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDraw
            // 
            btnDraw.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDraw.Location = new Point(369, 295);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(120, 40);
            btnDraw.TabIndex = 10;
            btnDraw.Text = "Draw Ball";
            btnDraw.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(495, 295);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 40);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnReset);
            Controls.Add(btnDraw);
            Controls.Add(lblExtraBall);
            Controls.Add(lblBall5);
            Controls.Add(lblBall4);
            Controls.Add(lblBall3);
            Controls.Add(lblBall2);
            Controls.Add(lblBall1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lottery";
            ResumeLayout(false);
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
    }
}
