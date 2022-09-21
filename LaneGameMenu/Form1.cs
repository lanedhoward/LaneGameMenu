
namespace LaneGameMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 500;
            Height = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*
Worth 10 points. Create a game Menu with the following components:

1- Rectangle \/

2- Ellipses\/

3-Square \/

4- Circle \/

5- Pie \/

6- Arc \/

7- Triangle \/

8- Hexagon \/

9- All text must be a drawn string \/

10- Mix the use of Pen and Brus \/
             */

            Graphics g = e.Graphics;

            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White);

            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush whiteBrush = new SolidBrush(Color.White);
            Brush greenBrush = new SolidBrush(Color.Green);
            Brush orangeBrush = new SolidBrush(Color.Orange);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Brush pinkBrush = new SolidBrush(Color.Pink);
            Brush purpleBrush = new SolidBrush(Color.Purple);

            Font arial = new Font("Arial", 32);

            g.FillRectangle(greenBrush, 235, 125, 75, 75);

            g.FillEllipse(orangeBrush, 60, 200, 125, 125);

            g.FillPie(yellowBrush, 300, 325, 100, 100, 32, 283);

            g.DrawArc(blackPen, 250, 250, 200, 200, 180, 180);

            //triangle
            List<Point> tri = new List<Point>();
            tri.Add(new Point(120, 290));
            tri.Add(new Point(230, 150));
            tri.Add(new Point(300, 265));

            g.FillPolygon(pinkBrush, tri.ToArray());

            //hexagon
            List<Point> hex = new List<Point>();
            hex.Add(new Point(400, 125));
            hex.Add(new Point(450, 190));
            hex.Add(new Point(425, 250));
            hex.Add(new Point(350, 220));
            hex.Add(new Point(325, 180));
            hex.Add(new Point(375, 100));

            g.FillPolygon(purpleBrush, hex.ToArray());

            Rectangle titleBox = new Rectangle(100, 10, 300, 90);

            g.FillRectangle(blueBrush, titleBox);
            g.DrawRectangle(blackPen, titleBox);

            g.DrawString("Trouble Keep", arial, whiteBrush, titleBox);

            Rectangle startButton = new Rectangle(100, 300, 125, 50);

            g.FillEllipse(blueBrush, startButton);
            g.DrawEllipse(blackPen, startButton);

            g.DrawString("Start", arial, whiteBrush, startButton);



        }
    }
}