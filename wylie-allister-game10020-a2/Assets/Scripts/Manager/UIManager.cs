using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI brazierCount;

    public SceneManager sm;
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
}
