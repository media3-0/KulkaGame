using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class UIManager : MonoBehaviour {

    public GameObject pausePanel;
    public bool isPaused;
    public Button resumeGame;
    public Button MainMenu;
    void Start ()
    {
        resumeGame = resumeGame.GetComponent<Button>();
        MainMenu = MainMenu.GetComponent<Button>();
        isPaused = false;
        Cursor.visible = false;
    }
    void Update()
    {
        PauseGame(isPaused);

        if (Input.GetButtonDown("Cancel"))
        {
            switchPause();
        }
    }
    public void ReturnToMainMenu()
    {
        Application.LoadLevel(0);
        switchPause();
    }
    void PauseGame(bool state)
    {
        if(state)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0.0f;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1.0f;
            pausePanel.SetActive(false);
            Cursor.visible = false;
        }
    }
    public void switchPause()
    {
        if (isPaused)
        {
            isPaused = false;
        }
        else
        {
            isPaused = true;
        }
    }
}
