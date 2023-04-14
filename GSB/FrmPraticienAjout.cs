﻿using lesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmPraticienAjout : FrmBase {
        public FrmPraticienAjout() {
            InitializeComponent();
        }

        private void FrmPraticienAjout_Load(object sender, EventArgs e) {
            // On réinitialise les données
            nomChamp.Text = "";
            prenomChamp.Text = "";
            rueChamp.Text = "";
            villeChamp.Text = "";
            telChamp.Text = "";
            mailChamp.Text = "";
            lesTypesBox.Items.Clear();
            lesSpecialitesBox.Items.Clear();

            // Auto completion pour les villes
            AutoCompleteStringCollection villeAutoComplete = new AutoCompleteStringCollection();
            villeAutoComplete.AddRange(Globale.mesVilles.Select(ville => ville.Nom).ToArray());
            villeChamp.AutoCompleteCustomSource = villeAutoComplete;
            villeChamp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            villeChamp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            villeChamp.Visible = true;

            // On ajoute les données à partir de la classe Globale
            Globale.lesTypes.ForEach(praticien => lesTypesBox.Items.Add(praticien));
            Globale.lesSpecialites.ForEach(specialite => lesSpecialitesBox.Items.Add(specialite));
        }

        private void parametrerComposant() {
            this.lblTitre.Text = "Ajouter un nouveau praticien";

        }

        private void btnAjouter_Click(object sender, EventArgs e) {
            // On contrôle la sélection
            if (!Globale.mesVilles.Exists(x => x.Nom.Equals(villeChamp.Text, StringComparison.OrdinalIgnoreCase))) {
                MessageBox.Show(this, "Cette ville n'est pas valide !");
                return;
            }

            // L'utilisateur n'a pas sélectionné de type praticien
            if (lesTypesBox.SelectedItem == null) {
                MessageBox.Show(this, "Vous devez sélectionner un type de praticien !");
                return;
            }

            // Vérifier la validité du numéro de telephone
            string tel = telChamp.Text;
            if (!CheckUtils.isValidNumber(tel)) {
                MessageBox.Show(this, "Format de numéro de téléphone invalide !");
                return;
            }


            // Vérifier la validité de l'adresse email
            string email = mailChamp.Text;
            if (!CheckUtils.isValidEmail(email)) {
                MessageBox.Show(this, "Format d'adresse email invalide !");
                return;
            }

            string nom = nomChamp.Text;
            string prenom = prenomChamp.Text;
            string rue = rueChamp.Text;

            Ville ville = Globale.mesVilles.Find(x => x.Nom.Equals(villeChamp.Text, StringComparison.OrdinalIgnoreCase));
            TypePraticien type = (TypePraticien)lesTypesBox.SelectedItem;
            Specialite specialite = (Specialite)lesSpecialitesBox.SelectedItem;

            int idPraticien = Passerelle.ajouterPraticien(nom, prenom, rue, ville.Code, ville.Nom, tel, email, type.Id, specialite?.Id, out string message);

            // Le message est vide il n'y a donc pas eu d'erreur lors de l'ajout du praticien
            if (message.Length == 0) {
                // On crée un objet Praticien à partir de l'id renvoyé par la procédure
                Praticien praticien = new Praticien(idPraticien, nom, prenom, rue, ville.Code, ville.Nom, email, tel, type, specialite);

                // On ajoute l'objet à la liste globale
                Globale.mesPraticiens.Add(praticien);

                FrmPraticienAjout_Load(sender, e);

                MessageBox.Show("Praticien ajouté !");
                return;
            }

            MessageBox.Show("Une erreur est survenue lors de l'ajout du praticien ! " + message);
        }
    }
}

