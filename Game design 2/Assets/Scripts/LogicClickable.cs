using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LogicClickable : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [Tooltip("The colour to use when highlighting this object.")]
    [SerializeField] private Color colourHighlight = new Color(1, 1, 0, 1);

    [Tooltip("The base colour of this object.")]
    [SerializeField] private Color colourBase = Color.white;

    private TextMesh text;
    private int state = -1;

    // Called once at startup 
    public void Start()
    {
        // Retrieve text child
        text = GetComponentInChildren<TextMesh>();

        // Set text to initial state
        text.text = "?";
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Loop through the possible states
            state++;

            // Wraparound
            if (state > 1) state = -1;
        } 
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            // Loop through the possible states
            state--;

            // Wraparound
            if (state < -1) state = 1;
        } 
        else
        {
            // Middle mouse button, ignore that shit
            return;
        }

        // Set text to new state
        text.text = (state >= 0) ? $"{state}" : "?";

        Debug.Log("Clicked on " + name + " GameObject");
    }

    // Change colour to yellow-ish when hovering over object
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = colourHighlight;
        Debug.Log("Cursor entering " + name + " GameObject");
    }

    // Return colour to basic state
    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = colourBase;
        Debug.Log("Cursor exiting " + name + " GameObject");
    }
}
