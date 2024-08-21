using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI; // Pause menüsü UI öðesi
    private bool oyunDurdu = false;

    void Update()
    {
        // Escape tuþuna basýldýðýnda oyunu durdur
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    // Durdurma butonuna atanan fonksiyon
    public void TogglePause()
    {
        oyunDurdu = !oyunDurdu;

        if (oyunDurdu)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    void Pause()
    {
        // Oyunu durdur ve pause menüsünü aktif et
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Oyun zamanýný durdur
        Cursor.lockState = CursorLockMode.None; // Farenin imlecini serbest býrak
        Cursor.visible = true; // Farenin imlecini görünür yap
    }

    void Resume()
    {
        // Oyunu devam ettir ve pause menüsünü devre dýþý býrak
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Oyun zamanýný normal hale getir
        Cursor.lockState = CursorLockMode.Locked; // Farenin imlecini kilitle
        Cursor.visible = false; // Farenin imlecini gizle
    }
}
