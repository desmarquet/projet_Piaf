using PDF;

Poulailler poulailler = new Poulailler();

poulailler.NbMaxP = 10;
// Ajouter des poules
poulailler.AjouterP("Germaine", "Sussex", 1.2, Taille.L);

poulailler.AjouterP("Ginger", "gauloise", 0.8, Taille.L);

// Ajouter des poules
poulailler.AjouterP("Roussette", "Marans", 0.9, Taille.M);


// Afficher les poules
poulailler.Affiche();

// Supprimer une poule
poulailler.SupprimerPoule("Germaine");

// Afficher à nouveau les poules après suppression
poulailler.Affiche();

Console.ReadLine();