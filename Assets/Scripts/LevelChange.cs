using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;


public class LevelChange : MonoBehaviour
{
//#if UNITY_EDITOR
    public string sceneName;
    //function on collision between object and box collider trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //checks for player tag
      if (other.gameObject.CompareTag("Player"))
        {
            //loads in level scene 
            Debug.Log("Enter next level");
            EditorSceneManager.LoadScene(sceneName);
        }
    }
//#endif
}
