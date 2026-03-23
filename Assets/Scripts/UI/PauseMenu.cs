using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public CanvasGroup gameHUDGroup;
    private bool isPaused = false;

    void Awake()
    {
        if (gameHUDGroup == null)
        {
            GameObject hud = GameObject.Find("Summon Units");
            if (hud != null) gameHUDGroup = hud.GetComponent<CanvasGroup>();
        }
    }

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.pKey.wasPressedThisFrame)
        {
            if (isPaused) Resume();
            else Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        if (gameHUDGroup != null)
        {
            gameHUDGroup.blocksRaycasts = true;
            gameHUDGroup.interactable = true;
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        if (gameHUDGroup != null)
        {
            gameHUDGroup.blocksRaycasts = false;
            gameHUDGroup.interactable = false;
        }
    }

    public void LoadOptions()
    {
        Debug.Log("Settings Menu open");
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}