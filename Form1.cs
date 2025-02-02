namespace MAC.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Item item = new Item(0, 0, 0, 0, 1000, 1000, 1000, 1000);
        private int blackCoffeeStock; // Initialize with a default value
        private int moccaStock; // Initialize with a default value
        private int latteStock; // Initialize with a default value
        private int chocolateStock; // Initialize with a default value

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyMoccaCoffee(amountToBuy);
            MessageBox.Show(result ? $"Purchase successful: {amountToBuy} Cup(s)" : "Out of stock, please try again later");
            moccaStock = item.GetBlackCoffeeStock();
            tbtextBox2.Text = moccaStock.ToString();
            MessageBox.Show(item.GetStockInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyLatteCoffee(amountToBuy);
            MessageBox.Show(result ? $"Purchase successful: {amountToBuy} Cup(s)" : "Out of stock, please try again later");
            latteStock = item.GetBlackCoffeeStock();
            tbtextBox3.Text = latteStock.ToString();
            MessageBox.Show(item.GetStockInfo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyChocolate(amountToBuy);
            MessageBox.Show(result ? $"Purchase successful: {amountToBuy} Cup(s)" : "Out of stock, please try again later");
            chocolateStock = item.GetBlackCoffeeStock();
            tbtextBox4.Text = chocolateStock.ToString();
            MessageBox.Show(item.GetStockInfo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyBlackCoffee(amountToBuy);
            MessageBox.Show(result ? $"Purchase successful: {amountToBuy} Cup(s)" : "Out of stock, please try again later");
            blackCoffeeStock = item.GetBlackCoffeeStock();
            tbtextBox1.Text = blackCoffeeStock.ToString();
            MessageBox.Show(item.GetStockInfo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            item.IncreaseStock(10, 10, 10, 10, 1000, 1000, 1000, 1000);
            MessageBox.Show("Stock replenished");

            MessageBox.Show(item.GetStockInfo());
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
