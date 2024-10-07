using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchBarFunction : MonoBehaviour
{
    public Input searchInputField;
    public Input resultContainer;
    public List<GameObject> allItems;   // update to have GameObject be cards
    // Start is called before the first frame update
    
    //private void Start()
    //{
    //    searchInputField.onValueChanged.AddListener(OnSearchChanged);
    //}

    private void OnSearchChanged(string searchText)
    {
        foreach (GameObject item in allItems)
        {
            if (item.name.ToLower().Contains(searchText.ToLower()))
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
    }
    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
