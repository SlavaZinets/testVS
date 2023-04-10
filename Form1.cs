namespace _2003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x;
        int y;
        int h = 60;
     
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);
            gr.FillRectangle(brush,  100, 100, h, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Refresh(); 
            y = e.Y;
            x = e.X;

            
            

            Graphics gr = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);
            gr.FillRectangle(brush, x - h/2, y - h / 2, h, h); 
        }
    }
}