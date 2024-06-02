using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo2 : MonoBehaviour
{
    private GameObject giocatore;

    // Start is called before the first frame update
    void Start()
    {
        giocatore = GameObject.FindGameObjectWithTag("Giocatore");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Confini")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Giocatore")
        {
            Destroy(giocatore.gameObject);
        }
    }
}
