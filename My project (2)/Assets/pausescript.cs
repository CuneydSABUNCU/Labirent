using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI; // Pause men�s� UI ��esi
    private bool oyunDurdu = false;

    void Update()
    {
        // Escape tu�una bas�ld���nda oyunu durdur
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
        // Oyunu durdur ve pause men�s�n� aktif et
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Oyun zaman�n� durdur
        Cursor.lockState = CursorLockMode.None; // Farenin imlecini serbest b�rak
        Cursor.visible = true; // Farenin imlecini g�r�n�r yap
    }

    void Resume()
    {
        // Oyunu devam ettir ve pause men�s�n� devre d��� b�rak
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Oyun zaman�n� normal hale getir
        Cursor.lockState = CursorLockMode.Locked; // Farenin imlecini kilitle
        Cursor.visible = false; // Farenin imlecini gizle
    }
}
