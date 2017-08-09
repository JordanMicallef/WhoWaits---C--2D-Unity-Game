using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThirstManage : MonoBehaviour
{ 
    private int maxPlayerThirst = 100;
    public static int playerThirst;
    public Slider thirstBar;

    //start gets the variable value set from title menu which is then used to set the slider
    //invoke repeating begins the decrease in variable value
    void Start()
    {
        InvokeRepeating("dehydrated", 1, 20.0f);
        thirstBar = GetComponent<Slider>();
        //playerThirst = maxPlayerThirst;
        playerThirst = PlayerPrefs.GetInt("PlayerThirst");
    }
    //removes from the player thirst variables
    void dehydrated()
    {
        playerThirst -= 5;
        PlayerPrefs.SetInt("PlayerThirst", playerThirst);
        Debug.Log(playerThirst);
    }

    //used to hurt the player through enemy attacks
    public static void HurtPlayer()
    {
        playerThirst -= 10;
        PlayerPrefs.SetInt("PlayerThirst", playerThirst);
    }

    //checks constantly made to the variable values to correct the gui bar
    void Update()
    {
        if (playerThirst > maxPlayerThirst)
        {
            playerThirst = maxPlayerThirst;
            PlayerPrefs.SetInt("PlayerThirst", playerThirst);
        }
        thirstBar.value = playerThirst;
    }

    //increase players thirst
    public static void DrinkPlayer()
    {
        playerThirst += 10;
        PlayerPrefs.SetInt("PlayerThirst", playerThirst);
    }

    //sets players thirst to full and sets the value
    public void FullThirst()
    {
        playerThirst = maxPlayerThirst;
        PlayerPrefs.SetInt("PlayerThirst", playerThirst);
    }
}
