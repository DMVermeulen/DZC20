using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Solution : MonoBehaviour
{
    public Text key;
    public Text message;
    public Text solution;

    // Start is called before the first frame update
    void Start()
    {
        print("hallo???");
        solution.text = string.Format("solution: {0} (key:{1})", message.text, key.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
