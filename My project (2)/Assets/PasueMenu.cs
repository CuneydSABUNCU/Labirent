using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasueMenu : MonoBehaviour
{
    public GameObject pauseButton; // Pause butonunu temsil eden UI ��esi.
    public GameObject pauseMenuUI; // Durdurma men�s�n� temsil eden UI ��esi.

   

    void Start()
    {
        // Ba�lang��ta pause butonu aktif, durdurma men�s� inaktif.
        pauseButton.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f; // Oyun h�z�n� durdur.
        
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f; // Oyun h�z�n� normale d�nd�r.
        
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Oyun h�z�n� normale d�nd�r.
        SceneManager.LoadScene(0); // Ana men� sahnesini y�kle.
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Oyun h�z�n� normale d�nd�r.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Mevcut sahneyi yeniden y�kle.
    }
}
