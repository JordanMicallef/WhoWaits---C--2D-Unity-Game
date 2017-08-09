using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour
{
    public Transform target;
    Camera gameCamera;
    //sets the gameCamera object
	void Start ()
    {
        gameCamera = GetComponent<Camera>();
	}
	
	//checks player movement and moves gameCamera according
	void Update ()
    {
        gameCamera.orthographicSize = (Screen.height / 100f) / 4f;

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0, 0, -10);
        }
	}
}
