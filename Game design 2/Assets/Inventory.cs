using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Material rewardMat;
    public Image slot1;
    bool hasReward = false;

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void AddReward()
    {
        slot1.material = rewardMat;
        slot1.gameObject.SetActive(true);
        hasReward = true;
    }

    public bool HasReward()
    {
        return hasReward;
    }
}
