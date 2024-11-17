namespace WinAsynchDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(textBox1.Text), null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
        bool Cancel;
        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 0; j <= seconds; j++)
            {
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(j * 100 / seconds));
                if (Cancel) { break; }
            }
            if (Cancel)
            {
                System.Windows.Forms.MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else { System.Windows.Forms.MessageBox.Show("Complete"); }

        }
        private delegate void TimeConsumingMethodDelegate(int seconds);

        public delegate void SetProgressDelegate(int val);
        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }
    }
}
