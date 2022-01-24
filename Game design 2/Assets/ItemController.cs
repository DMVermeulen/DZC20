using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    [Tooltip("The colour to use when highlighting this object.")]
    [SerializeField] private Color colourHighlight = new Color(1, 1, 0, .8f);

    [Tooltip("The base colour of this object.")]
    [SerializeField] private Color colourBase = Color.clear;

    public void OnPointerClick(PointerEventData eventData)
    {
        FindObjectOfType<Inventory>().AddReward();
        Destroy(gameObject);
        Debug.Log("Clicked on " + name + " GameObject");
    }

    // Change colour to yellow-ish when hovering over object
    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().color = colourHighlight;
        Debug.Log("Cursor entering " + name + " GameObject");
    }

    // Return colour to basic state
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().color = colourBase;
        Debug.Log("Cursor exiting " + name + " GameObject");
    }
}
