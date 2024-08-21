using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasueMenu : MonoBehaviour
{
    public GameObject pauseButton; // Pause butonunu temsil eden UI öðesi.
    public GameObject pauseMenuUI; // Durdurma menüsünü temsil eden UI öðesi.

   

    void Start()
    {
        // Baþlangýçta pause butonu aktif, durdurma menüsü inaktif.
        pauseButton.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f; // Oyun hýzýný durdur.
        
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f; // Oyun hýzýný normale döndür.
        
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Oyun hýzýný normale döndür.
        SceneManager.LoadScene(0); // Ana menü sahnesini yükle.
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Oyun hýzýný normale döndür.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Mevcut sahneyi yeniden yükle.
    }
}
