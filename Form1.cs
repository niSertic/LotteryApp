namespace LotteryApp
{
    public partial class Form1 : Form
    {
        private Random random;
        private List<int> availableNumbers;
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

            lblExtraBall.Text = "+";
            btnDraw.Enabled = true;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (drawCount >= 6) {
                btnDraw.Enabled = false;
                return; 
            }
            

            int index = random.Next(availableNumbers.Count);
            int number = availableNumbers[index];
            availableNumbers.RemoveAt(index);

            if (drawCount < 5)
            {
                mainBallLabels[drawCount].Text = number.ToString();
            }
            else
            {
                lblExtraBall.Text = number.ToString();
                btnDraw.Enabled = false;
            }

            drawCount++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetLottery();
        }
    }
}
