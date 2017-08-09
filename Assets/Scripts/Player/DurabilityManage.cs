using UnityEngine;
using System.Collections;

public class DurabilityManage : MonoBehaviour
{
    private int maxDurability = 100;
    public int minDurability;
    public static int axeDurability;

    //start gets the variable value set from title menu
    void Start ()
    {
        //axeDurability = maxDurability;
        axeDurability = PlayerPrefs.GetInt("AxeDurability");
    }

    //used by pickup to fix the player weapon
    public static void FixAxe(int axe)
    {
        axeDurability += 100;
        PlayerPrefs.SetInt("AxeDurability", axeDurability);
    }

    //used by weapon attack to reduce durability
    public static void Broken(int axe)
    {
        axeDurability -= 10;
        PlayerPrefs.SetInt("AxeDurability", axeDurability);
    }

    //provides checks to durability value and setting use of the flash animation
    void Update ()
    {
        if (axeDurability > maxDurability)
        {
            axeDurability = maxDurability;
            PlayerPrefs.SetInt("AxeDurability", maxDurability);
        }

        if (axeDurability < minDurability)
        {
            axeDurability = minDurability;
            PlayerPrefs.SetInt("AxeDurability", minDurability);
        }

        if (axeDurability == minDurability)
        {
            gameObject.GetComponent<Animation>().Play("Red_Flash");
        }
        else if (axeDurability > minDurability)
        {
            gameObject.GetComponent<Animation>().Stop("Red_Flash");
        }
    }

}
