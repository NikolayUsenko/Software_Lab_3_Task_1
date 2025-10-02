namespace Software_Lab_3_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format($"Координаты: {e.X}, {e.Y}");
            textBox1.Text = (e.X + e.Y).ToString();
        }
    }
}
