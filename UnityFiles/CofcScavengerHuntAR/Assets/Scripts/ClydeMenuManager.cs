using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeMenuManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject clydePanel;

    // Start is called before the first frame update
    void Start()
    {
        clydePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayClydePanel()
    {
        clydePanel.SetActive(true);
    }

    public void HideClydePanel()
    {
        clydePanel.SetActive(false);
    }
}
