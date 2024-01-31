using System;
using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public GameObject window;

    void Awake()
    {
        window.SetActive(false); // Закрываем окно при запуске сцены
    }

    public void ShowWindow()
    {
        window.SetActive(true);
    }

    public void HideWindow()
    {
        window.SetActive(false);
    }
}