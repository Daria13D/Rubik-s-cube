using UnityEngine;
using UnityEngine.UI;

public class OpenLocalHTML : MonoBehaviour
{
    public string filePath; // Путь к HTML файлу

    private Button button;

    public void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenFile);
    }

    public void OpenFile()
    {
        Application.OpenURL(filePath);
    }
}
