using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public GameObject textBox;
    public Text textSpeech;
    public bool textActive;
    public string[] lines;
    public int line;

    void Update()
    {
        if (textActive && Input.GetKeyDown(KeyCode.Space))
        {
            line++;
        }

        if(line >= lines.Length)
        {
            textBox.SetActive(false);
            textActive = false;

            line = 0;
        }
        textSpeech.text = lines[line];
    }

    public void ShowText()
    {
        textActive = true;
        textBox.SetActive(true);
    }
}
