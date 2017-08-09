using UnityEngine;
using System.Collections;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField]
#pragma warning disable CS0649 // Field 'IgnoreCollision.other' is never assigned to, and will always have its default value null
    private Collider2D other;
#pragma warning restore CS0649 // Field 'IgnoreCollision.other' is never assigned to, and will always have its default value null
    //simple function to detect collision between a box collider and a set collider of choice
	private void Awake()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, true);
    }
}
