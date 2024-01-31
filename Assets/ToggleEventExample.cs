using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;


public class ToggleEventExample : MonoBehaviour
{
    public Toggle toggle;
    public FlexibleColorPicker fcp;
    public Material material;
    private Coroutine colorCoroutine;


private void Start()
    {
        // Подписываемся на событие нажатия на чекбокс
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            // Запускаем корутину обновления цвета 
            colorCoroutine = StartCoroutine(UpdateColor());
            Debug.Log("Чекбокс нажат");
        }
        else
        {
            // Останавливаем корутину обновления цвета 
            if (colorCoroutine != null)
            {
                StopCoroutine(colorCoroutine);
            }
            Debug.Log("Чекбокс отпущен");
        }
    }

    private IEnumerator UpdateColor()
    {
        while (true)
        {
            // Обновляем цвет материала
            material.color = fcp.color;
            yield return null;
        }
    }
}


//public Toggle[] allToggles;

//private void Start()
//{
//    foreach (Toggle toggle in allToggles)
//    {
//        toggle.onValueChanged.AddListener((bool isOn) => { OnToggleValueChanged(toggle, isOn); });
//    }
//}

//private void OnToggleValueChanged(Toggle currentToggle, bool isOn)
//{
//    if (isOn)
//    {
//        foreach (Toggle toggle in allToggles)
//        {
//            if (toggle != currentToggle)
//            {
//                toggle.isOn = false;
//            }
//        }
//        material.color = fcp.color;
//    }
//}
