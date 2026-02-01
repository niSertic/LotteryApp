namespace LotteryApp
{
    public partial class Form1 : Form
    {
        private Random random;
        private List<int> availableNumbers;
        private List<int> drawnNumbers;
        private int drawCount;
        private Label[] mainBallLabels;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
            mainBallLabels = new Label[]
            {
                lblBall1,
                lblBall2,
                lblBall3,
                lblBall4,
                lblBall5
            };

            ResetLottery();
        }

        private void ResetLottery()
        {
            drawnNumbers = new List<int>();
            availableNumbers = new List<int>();
            for (int i = 1; i <= 36; i++)
            {
                availableNumbers.Add(i);
            }

            drawCount = 0;

            foreach (Label lbl in mainBallLabels)
            {
                lbl.Text = "-";
            }

            lblStatus.Text = "Draw 0 of 6";
            lblExtraBall.Text = "+";
            btnDraw.Enabled = true;
            lblResult.Visible = false;
            lblResult.Text = "Final combination:";
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (drawCount >= 6) {
                btnDraw.Enabled = false;
                return;
            }

            int index = random.Next(availableNumbers.Count);
            int number = availableNumbers[index];
            drawnNumbers.Add(number);
            availableNumbers.RemoveAt(index);

            if (drawCount < 5)
            {
                mainBallLabels[drawCount].Text = number.ToString();
            }
            else
            {
                lblExtraBall.Text = number.ToString();
                btnDraw.Enabled = false;

                var mainBalls = drawnNumbers.Take(5).OrderBy(n => n).ToList();
                int extraBall = drawnNumbers[5];
                lblResult.Text = "Final combination: " + string.Join(", ", mainBalls) + " + " + extraBall;

                lblResult.Visible = true;
            }

            drawCount++;
            lblStatus.Text = $"Draw {drawCount} of 6";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetLottery();
        }
    }
}
