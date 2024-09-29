using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Animator characterAnimator;
    private int buttonPressCount = 0;

    // Checks for animation triggers
    public string[] animationTriggers;
    //checks for a specific trigger press count
    public int[] pressCounts;

    // Method to be called when the button is pressed
    public void OnButtonPressed()
    {
        buttonPressCount++;

        // Loop through triggers and press count
        for (int i = 0; i < animationTriggers.Length; i++)
        {
            if (buttonPressCount == pressCounts[i])
            {
                characterAnimator.SetTrigger(animationTriggers[i]);
            }
        }
    }
}
