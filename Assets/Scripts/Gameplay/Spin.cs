using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	// Update is called once per frame
    // This will cause the pickup to spin in place
	void Update ()
    {   //Rotates around Z axis and at the frame rate so it is * by delta time
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
