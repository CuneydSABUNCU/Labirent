using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sorupaneli : MonoBehaviour
{
    public GameObject soruPaneli;
    public GameObject kaybetmepaneli; // Kaybetme paneli referansý
    private void Start()
    {
        kaybetmepaneli.SetActive(false);
    }

    public void DogruCevap()
    {
        soruPaneli.SetActive(false); // Soru panelini kapat
        Cursor.lockState = CursorLockMode.Locked; // Farenin imlecini kilitle
        Cursor.visible = false; // Farenin imlecini gizle
        Time.timeScale = 1f; // Oyunu devam ettir
    }

    public void YanlisCevap()
    {
        soruPaneli.SetActive(false); // Soru panelini kapat
        kaybetmepaneli.SetActive(true); // Kaybetme panelini aktif et
        Cursor.lockState = CursorLockMode.None; // Farenin imlecini serbest býrak
        Cursor.visible = true; // Farenin imlecini görünür yap
        Time.timeScale = 0f; // Oyunu durdur
    }
}
