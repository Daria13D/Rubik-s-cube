using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOnClick : MonoBehaviour
{
    public Button button; public Material[] materials; public Color[] targetColors;


    private bool isMaterial1 = true;

    void Start()
    {
        button.onClick.AddListener(ChangeMaterialColors);
    }

    void ChangeMaterialColors()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = targetColors[i];
        }
        isMaterial1 = !isMaterial1;
    }
}
