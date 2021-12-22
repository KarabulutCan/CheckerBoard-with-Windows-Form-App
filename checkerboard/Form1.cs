using System;
namespace checkerboard
{
    public partial class Form1 : Form
    {
        int leftSlide = 0;
        int topSlide = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] btn = new Button[8,8];
            MessageBox.Show(btn.GetUpperBound(1).ToString());

            for (int i = 0; i < btn.GetUpperBound(0); i++)
            {
                for (int j = 0; j < btn.GetUpperBound(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Width = 100;
                    btn[i, j].Height = 100;
                    btn[i,j].Top = topSlide;
                    btn[i,j].Left = leftSlide;
                    leftSlide += btn[i, j].Width;

                    if ((i + j) % 2 != 0)
                    {
                        btn[i,j].BackColor = Color.White;   
                    }
                    else
                    {
                        btn[i, j].BackColor = Color.Black;
                    }
                    Controls.Add(btn[i, j]);
                }
                topSlide += 100;
                leftSlide = 0;
                

            }
            

        }
    }
}