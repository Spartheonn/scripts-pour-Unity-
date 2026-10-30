using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private bool isattacked;
    private BoxCollider2D boxCollider2D;
    public float cd;
    void Start()
    {
        isattacked = false;
        boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.enabled = true;
        cd = 1f;
    }
    IEnumerator attackCouldown()
    {

        // Attente de quelques secondes
        yield return new WaitForSeconds(cd);

        // Code à exécuter après l'attente
        isattacked = false;
        boxCollider2D.enabled = true;
        Debug.Log("Fin de la coroutine.");

    }

    
    void FixedUpdate()
    {
        if (Input.GetButton("attack") && (isattacked == false))
        {
            boxCollider2D.enabled = false;
            print("attaque");
            isattacked = true;
            StartCoroutine(attackCouldown());

        }
    }
}
