using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Выход из игры"); // Опционально, можно использовать для отладки
        Application.Quit(); // Для выхода из игры во время проигрывания
    }
}
