using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Submit : MonoBehaviour
{
    public Text result;
    public Text key;
    public Text encryptedMessage;
    public InputField inputField;

    public void SubmitPuzzle() {
        result.text = "Input: " + inputField.text + ", key: " + key.text + " encrypted: " + encryptedMessage.text + " solution: " + Solution();
    }

    public string Solution() {
        int shift = int.Parse(key.text);
        string result = CaesarShiftString(encryptedMessage.text, -shift);
        return result;
    }

    // Shifts a string using the caesar cipher
    public string CaesarShiftString(string value, int shift)
    {
        char[] buffer = value.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            // Letter.
            char letter = buffer[i];
            // Add shift to all.
            letter = (char)(letter + shift);
            // Subtract 26 on overflow.
            // Add 26 on underflow.
            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }
            // Store.
            buffer[i] = letter;
        }
        return new string(buffer);
    }
}
