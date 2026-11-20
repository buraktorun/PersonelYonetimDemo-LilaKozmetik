namespace mulakat
{
    partial class PersonelListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblBaslik = new DevExpress.XtraEditors.LabelControl();
            grpMenu = new DevExpress.XtraEditors.GroupControl();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            gridcontPersonel = new DevExpress.XtraGrid.GridControl();
            personelBindingSource = new System.Windows.Forms.BindingSource(components);
            gridPersonel = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colDepartman = new DevExpress.XtraGrid.Columns.GridColumn();
            colMaas = new DevExpress.XtraGrid.Columns.GridColumn();
            colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)grpMenu).BeginInit();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridcontPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblBaslik.Appearance.Options.UseFont = true;
            lblBaslik.Appearance.Options.UseTextOptions = true;
            lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            lblBaslik.Location = new System.Drawing.Point(0, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new System.Drawing.Size(1046, 55);
            lblBaslik.TabIndex = 3;
            lblBaslik.Text = "Personel Listesi";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(btnKapat);
            grpMenu.Controls.Add(btnSil);
            grpMenu.Controls.Add(btnEkle);
            grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpMenu.Location = new System.Drawing.Point(0, 590);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new System.Drawing.Size(1046, 71);
            grpMenu.TabIndex = 4;
            grpMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnKapat.ImageOptions.ImageIndex = 2;
            btnKapat.Location = new System.Drawing.Point(1944, -3);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new System.Drawing.Size(85, 38);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            // 
            // btnSil
            // 
            btnSil.ImageOptions.ImageIndex = 8;
            btnSil.Location = new System.Drawing.Point(956, 28);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(85, 38);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click_1;
            // 
            // btnEkle
            // 
            btnEkle.ImageOptions.ImageIndex = 6;
            btnEkle.Location = new System.Drawing.Point(865, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(85, 38);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // gridcontPersonel
            // 
            gridcontPersonel.DataSource = personelBindingSource;
            gridcontPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            gridcontPersonel.Location = new System.Drawing.Point(0, 55);
            gridcontPersonel.MainView = gridPersonel;
            gridcontPersonel.Name = "gridcontPersonel";
            gridcontPersonel.Size = new System.Drawing.Size(1046, 535);
            gridcontPersonel.TabIndex = 6;
            gridcontPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridPersonel });
            // 
            // personelBindingSource
            // 
            personelBindingSource.DataSource = typeof(DataAccess.Entity.Personel);
            // 
            // gridPersonel
            // 
            gridPersonel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colAktif, colAd, colDepartman, colMaas, colTelefon, colAdres, colAciklama });
            gridPersonel.GridControl = gridcontPersonel;
            gridPersonel.Name = "gridPersonel";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            // 
            // colAktif
            // 
            colAktif.FieldName = "Aktif";
            colAktif.Name = "colAktif";
            colAktif.Visible = true;
            colAktif.VisibleIndex = 0;
            // 
            // colAd
            // 
            colAd.FieldName = "Ad";
            colAd.Name = "colAd";
            colAd.Visible = true;
            colAd.VisibleIndex = 1;
            // 
            // colDepartman
            // 
            colDepartman.FieldName = "Departman";
            colDepartman.Name = "colDepartman";
            colDepartman.Visible = true;
            colDepartman.VisibleIndex = 6;
            // 
            // colMaas
            // 
            colMaas.FieldName = "Maas";
            colMaas.Name = "colMaas";
            colMaas.Visible = true;
            colMaas.VisibleIndex = 4;
            // 
            // colTelefon
            // 
            colTelefon.FieldName = "Telefon";
            colTelefon.Name = "colTelefon";
            colTelefon.Visible = true;
            colTelefon.VisibleIndex = 3;
            // 
            // colAdres
            // 
            colAdres.FieldName = "Adres";
            colAdres.Name = "colAdres";
            colAdres.Visible = true;
            colAdres.VisibleIndex = 2;
            // 
            // colAciklama
            // 
            colAciklama.FieldName = "Aciklama";
            colAciklama.Name = "colAciklama";
            colAciklama.Visible = true;
            colAciklama.VisibleIndex = 5;
            // 
            // PersonelListe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1046, 661);
            Controls.Add(gridcontPersonel);
            Controls.Add(grpMenu);
            Controls.Add(lblBaslik);
            Name = "PersonelListe";
            Text = "Personel Listesi";
            Load += PersonelListe_Load;
            ((System.ComponentModel.ISupportInitialize)grpMenu).EndInit();
            grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridcontPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)personelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridcontPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPersonel;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaas;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartman;
    }
}