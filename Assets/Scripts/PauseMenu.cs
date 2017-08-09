using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class PauseMenu : MonoBehaviour
{
//#if UNITY_EDITOR
    public bool isPaused;
    public GameObject pauseMenuCanvas;
    //constant checks if the game is paused
    void Update()
    {
        //game time changes depending on pause menu active
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        //key down press of escape key enables a pause boolean or sets it to false
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }
    //continue button function, sets pausing boolean to false
    public void Continue()
    {
        isPaused = false;
    }
    //quit button function loads in a set scene
    public void Quit(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
//#endif
}
