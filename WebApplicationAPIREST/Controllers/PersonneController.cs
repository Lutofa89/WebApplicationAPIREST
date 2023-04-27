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

        // je veux lui passer des param�tres !

        [HttpGet("{nom}/{prenom}")] // avec cette syntaxe, il va comprendre que c'est des param�tres

        // le constructeur !
        public IEnumerable<Personne> Get(string nom, string prenom ) // Je mes les deux param�tres nom et prenom
        {

            Personne p1 = new Personne("Kerreman","Fabrice");
            Personne p2 = new Personne("Ajabli","Ahmed");
            Personne p3 = new Personne("Boumasour","Jamila");
            Personne p4 = new Personne(nom, prenom);

            // Je vais cr�er une liste de personne que je vais retourner.

            // cr�er un objet de type g�n�rique

            List<Personne> listePersonne = new List<Personne> { p1, p2 ,p3, p4 };

            _logger.LogInformation("Retourne" + listePersonne.Count + "�lement ");


            return listePersonne;

        }
    }
}