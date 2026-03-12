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
        brazierCount.text = $"Braziers Out: {b.brazierUnlitCount}";
    }

    public void UpdateDoorUI(Door door)
    {
        doorUnlock.SetActive(true);
    }

    public void UpdateCloudUI(Fan f)
    {
        cloudUI.SetActive(true);
    }
}
