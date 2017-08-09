using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
//#if UNITY_EDITOR
    public bool isDead; //
    public GameObject gameoverMenuCanvas;

    void Update()
    {
        //sets game time depending on game over menu use
        if (isDead)
        {
            gameoverMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            gameoverMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        //if statements used to determine use of the game over menu
        if (HungerManage.playerHunger <= 0)
        {
            isDead = true;
        }

        else if (ThirstManage.playerThirst <= 0)
        {
            isDead = true;
        }

    }

    //Function to restart the game to a set scene variable and with the set player variables
    public void Restart(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
        PlayerPrefs.SetInt("PlayerHunger", 100);
        PlayerPrefs.SetInt("PlayerThirst", 100);
        PlayerPrefs.SetInt("AxeDurability", 100);
    }
    //Quits the game to the set scene through unity
    public void Quit(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
//#endif
}
