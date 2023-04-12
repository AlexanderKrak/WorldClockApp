namespace WorldClockApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        int hour;
        int minute;
        int second;
        
        public Form()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            lblTimeNow.Text = myDateTime.ToString("HH:mm:ss");
            lblTokyoTime.Text = myDateTime.AddHours(7).ToString("HH:mm:ss");
            lblNewYorkTime.Text = myDateTime.AddHours(-6).ToString("HH:mm:ss");
            lblLondonTime.Text = myDateTime.AddHours(-1).ToString("HH:mm:ss");
            lblMoscowTime.Text = myDateTime.AddHours(1).ToString("HH:mm:ss");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Start();

            
            
            
        }
    }
}