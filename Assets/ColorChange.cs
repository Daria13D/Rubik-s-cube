//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEngine;
//using UnityEngine;
//using UnityEngine.UI;

//public class ColorChange : MonoBehaviour
//{

//    public Material[] faceMaterials; // Массив материалов для каждой грани кубика
//    public Toggle[] faceToggles; // Массив чекбоксов, представляющих каждую грань
//    public Button[] colorButtons; // Массив кнопок, представляющих каждый цвет в цветовой палитре

//    private MeshRenderer[] faceRenderers; // Массив компонентов MeshRenderer для каждой грани кубика

//    private void Awake()
//    {
//        // Получаем компонент MeshRenderer для каждой грани кубика
//        faceRenderers = GetComponentsInChildren<MeshRenderer>();
//    }

//    private void Start()
//    {
//        // Устанавливаем первоначальные значения цветов и связываем чекбоксы и кнопки с методами изменения цвета
//        for (int i = 1; i < faceRenderers.Length; i++)
//        {
//            // Устанавливаем первоначальный цвет для каждой грани
//            faceRenderers[i].material = faceMaterials[i];

//            // Связываем каждый чекбокс с методом изменения цвета
//            int index = i; // Фиксируем текущий индекс для передачи в лямбда-выражение
//            faceToggles[i].onValueChanged.AddListener((isSelected) =>
//            {
//                SetFaceColor(index, isSelected);
//            });
//        }

//        // Связываем каждую кнопку цветовой палитры с методом изменения активного цвета
//        for (int i = 0; i < colorButtons.Length; i++)
//        {
//            int index = i; // Фиксируем текущий индекс для передачи в лямбда-выражение
//            colorButtons[i].onClick.AddListener(() =>
//            {
//                SetActiveColor(index);
//            });
//        }
//    }

//    private void SetFaceColor(int index, bool isSelected)
//    {
//        // Если чекбокс выбран, устанавливаем материал с соответствующим индексом для грани
//        // Иначе устанавливаем основной материал (например, белый)

//        if (isSelected)
//        {
//            faceRenderers[index].material = faceMaterials[index];
//        }
//        //else
//        //{
//        //    // Замените "whiteMaterial" на ваш основной материал грани
//        //    faceRenderers[index].material = ;
//        //}
//    }

//    private void SetActiveColor(int index)
//    {
//        // Здесь вы можете реализовать изменение активного цвета, когда пользователь выбирает цвет из палитры
//        // Например, сохранить выбранный цвет в переменной для последующего использования при изменении цвета граней
//        // И затем использовать его в методе SetFaceColor()
//    }
//}