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

    public void SubmitPuzzle() {
        bool correct = Correct();
        result.text = "Input: " + inputField.text + ", key: " + key.text + " encrypted: " + encryptedMessage.text + " solution: " + message.text + " correct:"+correct;
        if (correct) {
            result.color = Color.green;
        }
    }

    public bool Correct() {
        return message.text == inputField.text;
    }
}
