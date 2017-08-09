using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        

    }

    // This is called every time the player collides with a collider and deactivates the object it touches
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
