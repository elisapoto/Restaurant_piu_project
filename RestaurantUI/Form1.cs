using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NivelStocareDate;
using NvlModele;

namespace RestaurantUI
{
    public partial class Form1 : Form
    {
        private AdministrareComenzi_Fisier adminComenzi;
        private Comanda comandaCurenta;
        private const string NUME_FISIER = "comenzi.txt";

        public Form1()
        {
            InitializeComponent();
            ConfigureUI();
            adminComenzi = new AdministrareComenzi_Fisier(NUME_FISIER);
            IncarcaCategorii();
            AfiseazaComenzi();
        }

        private void ConfigureUI()
        {
            // Modern styling
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9);
            this.Text = "Restaurant Management System";

            // Configure controls styling
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.BackColor = Color.FromArgb(65, 105, 225);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
                btn.Padding = new Padding(5);
            }

            lstComenzi.BackColor = Color.White;
            lstComenzi.Font = new Font("Consolas", 9);
            lstComenzi.HorizontalScrollbar = true;

            // Configure group boxes
            grpNouaComanda.ForeColor = Color.FromArgb(65, 105, 225);
            grpCautare.ForeColor = Color.FromArgb(65, 105, 225);
            grpListaComenzi.ForeColor = Color.FromArgb(65, 105, 225);
        }

        private void IncarcaCategorii()
        {
            cmbCategorie.DataSource = Enum.GetValues(typeof(CategorieProdus));
        }

        private void AfiseazaComenzi()
        {
            lstComenzi.Items.Clear();
            var comenzi = adminComenzi.GetComenzi();

            if (comenzi.Count == 0)
            {
                lstComenzi.Items.Add("Nu există comenzi în sistem.");
                return;
            }

            foreach (var comanda in comenzi)
            {
                lstComenzi.Items.Add(comanda.ToString());
                lstComenzi.Items.Add("--------------------------------------------------");
            }
        }

        private void btnCautaId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCautaId.Text, out int id) && id > 0)
            {
                Comanda comandaGasita = adminComenzi.GetComandaById(id);

                if (comandaGasita != null)
                {
                    lstComenzi.Items.Clear();
                    lstComenzi.Items.Add(comandaGasita.ToString());
                }
                else
                {
                    MessageBox.Show($"Comanda cu ID-ul {id} nu a fost găsită.", "Căutare",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Introduceți un ID valid (număr întreg pozitiv).", "Eroare",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCautaMasa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCautaMasa.Text, out int masa) && masa > 0)
            {
                var comenziMasa = adminComenzi.GetComenziByMasa(masa);

                lstComenzi.Items.Clear();
                if (comenziMasa.Count > 0)
                {
                    foreach (var comanda in comenziMasa)
                    {
                        lstComenzi.Items.Add(comanda.ToString());
                        lstComenzi.Items.Add("--------------------------------------------------");
                    }
                }
                else
                {
                    lstComenzi.Items.Add($"Nu există comenzi pentru masa {masa}.");
                }
            }
            else
            {
                MessageBox.Show("Introduceți un număr de masă valid (număr întreg pozitiv).", "Eroare",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            if (!ValideazaProdus())
                return;

            if (comandaCurenta == null)
            {
                if (!int.TryParse(txtMasa.Text, out int masa) || masa <= 0)
                {
                    MessageBox.Show("Introduceți un număr de masă valid!", "Eroare",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                comandaCurenta = new Comanda(adminComenzi.GetNextComandaId(), masa);
            }

            Produs produs = new Produs(
                txtNumeProdus.Text,
                double.Parse(txtPretProdus.Text),
                (CategorieProdus)cmbCategorie.SelectedItem
            );

            comandaCurenta.AdaugaProdus(produs);
            lstProduseComanda.Items.Add(produs.ToString());
            lblTotalComanda.Text = $"Total: {comandaCurenta.Total} RON";

            txtNumeProdus.Clear();
            txtPretProdus.Clear();
            txtNumeProdus.Focus();
        }

        private void btnFinalizareComanda_Click(object sender, EventArgs e)
        {
            if (comandaCurenta != null && comandaCurenta.Produse.Count > 0)
            {
                adminComenzi.AddComanda(comandaCurenta);
                comandaCurenta = null;
                lstProduseComanda.Items.Clear();
                lblTotalComanda.Text = "Total: 0 RON";
                txtMasa.Clear();
                AfiseazaComenzi();
                MessageBox.Show("Comanda a fost finalizată și salvată!", "Succes",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu ați adăugat niciun produs la comandă!", "Eroare",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStergeComanda_Click(object sender, EventArgs e)
        {
            if (lstComenzi.SelectedIndex != -1 && lstComenzi.SelectedItem.ToString().Contains("Comanda #"))
            {
                string selected = lstComenzi.SelectedItem.ToString();
                int start = selected.IndexOf('#') + 1;
                int end = selected.IndexOf(']');
                if (int.TryParse(selected.Substring(start, end - start), out int id))
                {
                    if (MessageBox.Show($"Sigur doriți să ștergeți comanda #{id}?", "Confirmare",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (adminComenzi.StergeComanda(id))
                        {
                            AfiseazaComenzi();
                            MessageBox.Show($"Comanda #{id} a fost ștearsă.", "Succes",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Comanda #{id} nu a putut fi găsită.", "Eroare",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectați o comandă validă pentru ștergere.", "Eroare",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCautaId.Clear();
            txtCautaMasa.Clear();
            AfiseazaComenzi();
        }

        private bool ValideazaProdus()
        {
            if (string.IsNullOrWhiteSpace(txtNumeProdus.Text))
            {
                MessageBox.Show("Numele produsului nu poate fi gol!", "Eroare",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(txtPretProdus.Text, out double pret) || pret <= 0)
            {
                MessageBox.Show("Preț invalid! Introduceți o valoare pozitivă.", "Eroare",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            if (comandaCurenta != null && lstProduseComanda.SelectedIndex != -1)
            {
                string produsInfo = lstProduseComanda.SelectedItem.ToString();
                var produs = comandaCurenta.Produse.FirstOrDefault(p => p.ToString() == produsInfo);

                if (produs != null)
                {
                    comandaCurenta.StergeProdus(produs);
                    lstProduseComanda.Items.RemoveAt(lstProduseComanda.SelectedIndex);
                    lblTotalComanda.Text = $"Total: {comandaCurenta.Total} RON";
                }
            }
        }
    }
}