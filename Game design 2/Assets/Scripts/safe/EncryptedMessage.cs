using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncryptedMessage : MonoBehaviour
{
    public Text key;
    public Text message;
    public Text encryptedMessage;

    // Start is called before the first frame update
    void Start()
    {
        //print("started encrypted message");
        //print(key.text);
        //print(message.text);
        //print(CaesarShiftString(message.text, int.Parse(key.text)));
        encryptedMessage.text = CaesarShiftString(message.text, int.Parse(key.text));
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
