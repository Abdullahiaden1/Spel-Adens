namespace Spel_Adens
{
    public partial class Form1 : Form

       
        


    {
        int datornsTal;
        int antalGissningar;
        public Form1()
        {
            InitializeComponent();

            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);


            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;
        }

        private void lblDatornsTal_Click(object sender, EventArgs e)
        {

        }

        private void btnGissa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbxStörstaTalet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}