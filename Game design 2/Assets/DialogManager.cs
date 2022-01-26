using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject dialog3;

    // Start is called before the first frame update
    void Start()
    {
        if(ProgressData.profProgress == 0)
        {
            dialog1.SetActive(true);
            ProgressData.profProgress = 1;
        }else if(ProgressData.profProgress == 1 && !FindObjectOfType<Inventory>().HasReward())
        {
            dialog2.SetActive(true);
        }
        else
        {
            dialog3.SetActive(true);
        }
    }
}
