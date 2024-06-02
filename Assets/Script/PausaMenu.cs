using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaMenu : MonoBehaviour
{
    [SerializeField] GameObject pausaMenu;

    public void Pausa()
    {
        pausaMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pausaMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
