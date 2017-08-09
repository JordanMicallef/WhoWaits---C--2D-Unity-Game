using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;


public class MenuControl : MonoBehaviour
{
#if UNITY_EDITOR
    //variables to set the players hunger, thirst, and weapon durability
    public int hungerStat;
    public int thirstStat;
    public int axeDura;
    //function loads the set scene in unity as well as setting the 3 variables above
    public void LoadScene(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
        PlayerPrefs.SetInt("PlayerHunger", hungerStat);
        PlayerPrefs.SetInt("PlayerThirst", thirstStat);
        PlayerPrefs.SetInt("AxeDurability", axeDura);
    }
#endif
}

