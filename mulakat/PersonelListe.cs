using Business.Service;
using DataAccess.Entity;
using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mulakat
{
    public partial class PersonelListe : DevExpress.XtraEditors.XtraForm
    {

        private readonly PersonelService _personelService = new PersonelService();

        public PersonelListe()
        {
            InitializeComponent();
        }

        private async void PersonelListe_Load(object sender, EventArgs e)
        {
            await Listele();

        }

        public async Task Listele()
        {
            gridcontPersonel.DataSource = await _personelService.GetAllAsync();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            var secili = gridPersonel.GetFocusedRow() as Personel;

            if (XtraMessageBox.Show($" Personel silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await _personelService.DeleteAsync(secili.Id);
                await Listele();
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }

        private async void btnSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                var seciliPersonel = gridPersonel.GetFocusedRow() as Personel;

                if (seciliPersonel == null)
                {
                    XtraMessageBox.Show("silinecek personeli seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (XtraMessageBox.Show($" personeli silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    await _personelService.DeleteAsync(seciliPersonel.Id);
                    await Listele();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}