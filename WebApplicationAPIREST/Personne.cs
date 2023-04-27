namespace WebApplicationAPIREST
{
    public class Personne
    {

        private string nom;
        private string prenom;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Personne(string nom, string prenom) 
        {
            this.nom = nom;
            this.prenom = prenom;
        }
    }

}
