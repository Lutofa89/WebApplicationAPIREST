using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPIREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
        
    

        private readonly ILogger<PersonneController> _logger;

        public PersonneController(ILogger<PersonneController> logger)
        {
            _logger = logger;
        }

        // je veux lui passer des paramètres !

        [HttpGet("{nom}/{prenom}")] // avec cette syntaxe, il va comprendre que c'est des paramètres

        // le constructeur !
        public IEnumerable<Personne> Get(string nom, string prenom ) // Je mes les deux paramètres nom et prenom
        {

            Personne p1 = new Personne("Kerreman","Fabrice");
            Personne p2 = new Personne("Ajabli","Ahmed");
            Personne p3 = new Personne("Boumasour","Jamila");
            Personne p4 = new Personne(nom, prenom);

            // Je vais créer une liste de personne que je vais retourner.

            // créer un objet de type générique

            List<Personne> listePersonne = new List<Personne> { p1, p2 ,p3, p4 };

            _logger.LogInformation("Retourne" + listePersonne.Count + "élement ");


            return listePersonne;

        }
    }
}