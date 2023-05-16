using CubeLiabry;

namespace Rubik
{
    public partial class Form1 : Form
    {
        Cube rubikCube = new();
        Panel[,] cubePanels;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cubePanels = new Panel[,]{
                { t1, t2, t3, t4, t5, t6, t7, t8, t9 },
                { l1, l2, l3, l4, l5, l6, l7, l8, l9 },
                { f1, f2, f3, f4, f5, f6, f7, f8, f9 },
                { r1, r2, r3, r4, r5, r6, r7, r8, r9 },
                { b1, b2, b3, b4, b5, b6, b7, b8, b9 },
                { d1, d2, d3, d4, d5, d6, d7, d8, d9 }
            };

            PaintCube();
        }

        void PaintCube()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cubePanels[i, j].BackColor = rubikCube.colors[rubikCube.cube[i, j] / 9];
                }
            }
        }

        

        private void t5_Click(object sender, EventArgs e)
        {
            rubikCube.RotateFace(0);
            PaintCube();
        }

        private void l5_Click(object sender, EventArgs e)
        {
            rubikCube.RotateFace(1);
            PaintCube();
        }
        private void f5_Click(object sender, EventArgs e)
        {
            rubikCube.RotateFace(2);
            PaintCube();
        }

        private void r5_Click(object sender, EventArgs e)
        {
            rubikCube.RotateFace(3);
            PaintCube();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            rubikCube.RotateFace(4);
            PaintCube();
        }

        private void d5_Click(object sender, EventArgs e)
        {
            rubikCube.RotateFace(5);
            PaintCube();
        }
    }
}