namespace Spel_Adens
{
    public partial class Form1 : Form

       
        


    {
        int datornsTal;
        int antalGissningar;
        public Form1()
        {
            InitializeComponent();

            lbxSt�rstaTalet.Items.Add(10);
            lbxSt�rstaTalet.Items.Add(20);
            lbxSt�rstaTalet.SelectedItem = lbxSt�rstaTalet.Items[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string st�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);


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

        private void lbxSt�rstaTalet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}