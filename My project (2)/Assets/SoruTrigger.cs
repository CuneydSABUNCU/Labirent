using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoruTrigger : MonoBehaviour
{
    public GameObject soruPaneli;

    private void Start()
    {
        soruPaneli.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tetikleyiciye bir þey girdi."+ other.name);
        if (other.CompareTag("Player"))
        {
            
            soruPaneli.SetActive(true); // Soru panelini aktif et
            Cursor.lockState = CursorLockMode.None; // Farenin imlecini serbest býrak
            Cursor.visible = true; // Farenin imlecini görünür yap
            Time.timeScale = 0f; // Oyunu durdur
        }
    }
}
