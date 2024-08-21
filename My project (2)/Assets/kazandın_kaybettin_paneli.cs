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
        Time.timeScale = 1f; // Oyun hýzýný normale döndür.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Mevcut sahneyi yeniden yükle.
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Oyun hýzýný normale döndür.
        SceneManager.LoadScene(0); // Ana menü sahnesini yükle.
    }
    public void SeviyeGec()
    {
        Time.timeScale = 1f; // Oyun hýzýný normale döndür.
        SceneManager.LoadScene(2); // Ana menü sahnesini yükle.
    }
}
