namespace window_app_apowb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            int basevalue, expo, i;
            int result = 1;
            basevalue = Convert.ToInt32(textBox1.Text);
            expo = Convert.ToInt32(textBox2.Text);

            for (i = 1; i <= expo; i++)
            {
                result = result * basevalue;
            }
            textBox3.Text = result.ToString();  
            
        }

       
    }
}