using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        Time.timeScale = 1f; // Oyun h�z�n� normale d�nd�r.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Mevcut sahneyi yeniden y�kle.
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Oyun h�z�n� normale d�nd�r.
        SceneManager.LoadScene(0); // Ana men� sahnesini y�kle.
    }
    public void SeviyeGec()
    {
        Time.timeScale = 1f; // Oyun h�z�n� normale d�nd�r.
        SceneManager.LoadScene(2); // Ana men� sahnesini y�kle.
    }
}
