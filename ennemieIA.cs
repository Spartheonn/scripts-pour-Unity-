using UnityEngine;

public class ennemieIA : MonoBehaviour
{
    public Transform joueur;
    public VieBarre viebarre;
    public float vitesseDeDeplacement = 5f;
    public float distanceDeDetection = 5f;
    public float degatsAuContact = 10f;
    
    void Update()
    {
        // Vérifier la distance entre l'ennemi et le joueur
        float distanceAuJoueur = Vector2.Distance(transform.position, joueur.position);

        // Si le joueur est à portée de détection, déplacer l'ennemi vers le joueur
        if (distanceAuJoueur <= distanceDeDetection)
        {
            Vector2 directionVersJoueur = joueur.position - transform.position;
            directionVersJoueur.Normalize();
            transform.Translate(directionVersJoueur * vitesseDeDeplacement * Time.deltaTime, Space.World);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("toucher");
            viebarre.Degats(degatsAuContact);
        }
        print("oui je suis raciste oui");
    }


}
