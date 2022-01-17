using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayKey : MonoBehaviour
{
    public Text key;
    public Text showKey;

    // Start is called before the first frame update
    void Start()
    {
        showKey.text = "Key: " + key.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
