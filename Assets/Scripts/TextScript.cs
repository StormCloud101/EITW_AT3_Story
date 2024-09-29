using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI textBox; // for the UI text
    public Button nextButton; // for the UI button
    public string[] textLines; // array for lines of text
    public string nextScene; // next scene
    private int currentLine = 0; // track line of text


    // Start is called before the first frame update
    void Start()
    {

        textBox.text = textLines[currentLine];
        nextButton.onClick.AddListener(DisplayNextLine);
    }

    void DisplayNextLine()
    {
        currentLine++;

        if (currentLine < textLines.Length)
        {
            textBox.text = textLines[currentLine];
            }
        
        else
        {
            SceneManager.LoadScene(nextScene); // Load the next scene when done
        }
    }
}
