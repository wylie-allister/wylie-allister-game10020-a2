using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI brazierCount;
    public GameObject doorUnlock;
    public GameObject cloudUI;

    public LevelManager sm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateBrazierCount(Brazier b)
    {
        //updates brazier text
        brazierCount.text = $"Braziers Out: {sm.brazierUnlitCount}";
    }

    public void UpdateDoorUI(Door door)
    {
        //enables door unlock ui
        doorUnlock.SetActive(true);
    }

    public void UpdateCloudUI(Fan f)
    {
        //enables cloud active ui
        cloudUI.SetActive(true);
    }
}
