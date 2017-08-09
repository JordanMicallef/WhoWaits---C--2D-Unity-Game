using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HungerManage : MonoBehaviour
{
    private int maxPlayerHunger = 100;
    public static int playerHunger;
    public Slider hungerBar;

    //start gets the variable value set from title menu which is then used to set the slider
    //invoke repeating begins the decrease in variable value
    void Start()
    {
        InvokeRepeating("hunger", 1, 30.0f);
        hungerBar = GetComponent<Slider>();
        //playerHunger = maxPlayerHunger;
        playerHunger = PlayerPrefs.GetInt("PlayerHunger");
    }
    //removes from the player hunger variables
    void hunger()
    {
        playerHunger -= 5;
        PlayerPrefs.SetInt("PlayerHunger", playerHunger);
        Debug.Log(playerHunger);
    }

    //checks constantly made to the variable values to correct the gui bar
    void Update()
    {
        if(playerHunger > maxPlayerHunger)
        {
            playerHunger = maxPlayerHunger;
            PlayerPrefs.SetInt("PlayerHunger", playerHunger);
        }
        
        hungerBar.value = playerHunger;
    }

    //used to hurt the player through enemy attacks
    public static void HurtPlayer()
    {
        playerHunger -= 10;
        PlayerPrefs.SetInt("PlayerHunger", playerHunger);
    }

    //increase players hunger
    public static void FeedPlayer()
    {
        playerHunger += 10;
        PlayerPrefs.SetInt("PlayerHunger", playerHunger);
    }

    //sets players hunger to full and sets the value
    public void FullHunger()
    {
        playerHunger = maxPlayerHunger;
        PlayerPrefs.SetInt("PlayerHunger", playerHunger);
    }
}
