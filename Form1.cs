namespace MAC.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Item item = new Item(10, 10, 10, 10, 1000, 1000, 1000, 1000);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyMoccaCoffee(amountToBuy);
            MessageBox.Show(result ? $"�ӡ�ë�������� �ӹǹ : {amountToBuy} Cup" : "�ͧ�����ҫ����������");
            MessageBox.Show(item.GetStockInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyLatteCoffee(amountToBuy);
            MessageBox.Show(result ? $"�ӡ�ë�������� �ӹǹ : {amountToBuy} Cup" : "�ͧ�����ҫ����������");
            MessageBox.Show(item.GetStockInfo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyChocolate(amountToBuy);
            MessageBox.Show(result ? $"�ӡ�ë�������� �ӹǹ : {amountToBuy} Cup" : "�ͧ�����ҫ����������");
            MessageBox.Show(item.GetStockInfo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amountToBuy = 1;
            bool result = item.BuyBlackCoffee(amountToBuy);
            MessageBox.Show(result ? $"�ӡ�ë�������� �ӹǹ : {amountToBuy} Cup" : "�ͧ�����ҫ����������");
            MessageBox.Show(item.GetStockInfo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            item.IncreaseStock(10, 10, 10, 10, 1000, 1000, 1000, 1000);
            MessageBox.Show("����ͧ�ѧ�����");
            MessageBox.Show(item.GetStockInfo());
        }
    }
}
