namespace kütüpOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void formAc(Form gelenForm)
        {
            foreach (Form mdiForm in MdiChildren)
            {
                if (mdiForm.Text == gelenForm.Text)
                {
                    mdiForm.BringToFront();
                    return;
                }
            }

            gelenForm.MdiParent = this;
            gelenForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aranankitapcs aranankitap = new aranankitapcs();
            formAc(aranankitap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tumkitaplar tumkitaplar = new tumkitaplar();

            formAc(tumkitaplar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitapcesid kitapcesid = new kitapcesid();

            formAc(kitapcesid);
        }
    }
}
