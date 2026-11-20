using Business.Service;
using DataAccess.Entity;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using static DataAccess.Enum.Enum;

namespace mulakat
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        private readonly PersonelService _personelService = new PersonelService();

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGorevi.Properties.DataSource = System.Enum.GetValues(typeof(Departman));
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var personel = new Personel
                {
                    Aktif = toggleSwitch1.IsOn,
                    Ad = txtPersonel.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Adres = txtAdres.Text.Trim(),
                    Maas = Convert.ToDecimal(calcMaas.EditValue ?? 0),
                    Aciklama = txtAciklama.Text.Trim(),
                    Departman = (Departman)cmbGorevi.EditValue
                };

                await _personelService.AddAsync(personel);
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

