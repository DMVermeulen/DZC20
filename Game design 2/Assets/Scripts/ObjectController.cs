using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [Tooltip("The object responsible for switching scenes.")]
    [SerializeField] private SceneSwitcher sceneSwitcher;

    [Tooltip("The build index of the scene to load when clicked, use 0 to ignore switch.")]
    [SerializeField] private int sceneNumber = 0;

    [Tooltip("The colour to use when highlighting this object.")]
    [SerializeField] private Color colourHighlight = new Color(1, 1, 0, .8f);

    [Tooltip("The base colour of this object.")]
    [SerializeField] private Color colourBase = Color.clear;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Switch to next scene, if defined
        if (sceneNumber != 0)
        {
            sceneSwitcher.Load(sceneNumber);
        }
        
        Debug.Log("Clicked on " + name + " GameObject");
    }

    // Change colour to yellow-ish when hovering over object
    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Renderer>().material.color = colourHighlight;
        Debug.Log("Cursor entering " + name + " GameObject");
    }

    // Return colour to basic state
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Renderer>().material.color = colourBase;
        Debug.Log("Cursor exiting " + name + " GameObject");
    }
}
