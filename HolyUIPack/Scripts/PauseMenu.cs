using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;

    [SerializeField] CanvasGroup PauseMenuCanvas;
    void Start()
    {
        InputManager.Instance.OnUnPressESC += UnPauseGame;
        UnPauseGame();
    }

    public void PauseGame()
    {
        InputManager.Instance.OnUnPressESC -= PauseGame;
        InputManager.Instance.OnUnPressESC += UnPauseGame;
        isPaused = true;

        Time.timeScale = 0f;
        PauseMenuCanvas.alpha = 1f;
        PauseMenuCanvas.interactable = true;
    }

    public void UnPauseGame()
    {
        InputManager.Instance.OnUnPressESC += PauseGame;
        InputManager.Instance.OnUnPressESC -= UnPauseGame;
        isPaused = false;

        Time.timeScale = 1f;
        PauseMenuCanvas.alpha = 0f;
        PauseMenuCanvas.interactable = false;
    }
}
