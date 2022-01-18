using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Submit : MonoBehaviour
{
    public Text result;
    public Text key;
    public Text message;
    public Text encryptedMessage;
    public InputField inputField;
    public SceneSwitcher SceneSwitcher;
    public Button submit;

    public void SubmitPuzzle() {
        bool correct = Correct();

        if (correct) {
            //result.color = Color.green;
            SceneSwitcher.Load(8);
        } else {
            //TODO flicker red screeen
            result.text = "Incorrect. Try again.";
        }
    }

    public bool Correct() {
        return message.text == inputField.text;
    }
}
