using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public Text obj_text;
    public InputField display;

    // Start is called before the first frame update
    void Start()
    {
        //obj_text.text = "testtest";
       // obj_text = new Text("hello");
        print(obj_text.text);   
        print(display.text);
    }

    // Update is called once per frame
    void Update()
    {
        //print(display.text);
    }
}
