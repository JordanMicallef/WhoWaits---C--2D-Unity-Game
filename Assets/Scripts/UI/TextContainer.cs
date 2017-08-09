using UnityEngine;
using System.Collections;

public class TextContainer : MonoBehaviour
{
    private TextManager textManager;

    public string[] textLines;

	void Start ()
    {
        textManager = FindObjectOfType<TextManager>();
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                //textManager.ShowText(speech);
                if (!textManager.textActive)
                {
                    textManager.lines = textLines;
                    textManager.line = 0;
                    textManager.ShowText();
                }
            }
        }
    }
}
