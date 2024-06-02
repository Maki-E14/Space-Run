using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Giocatore") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Riavvia()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
