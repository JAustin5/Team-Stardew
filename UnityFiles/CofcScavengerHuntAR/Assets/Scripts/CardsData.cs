using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// !!! NOTE: this is possiblity of own class creation for card, currently have card details in AdminMainManage.cs !!!

[System.Serializable]
public class CardsData : MonoBehaviour
{
    public string name;
    public string address;
    public string description;
    public string hint1;
    public string hint2;
    public string hint3;

    public bool isUnlocked;

    public CardsData(string name, string address, string description, string hint1, string hint2, string hint3)
    {
        this.name = name;
        this.address = address;
        this.description = description;
        this.hint1 = hint1;
        this.hint2 = hint2;
        this.hint3 = hint3;
        this.isUnlocked = false; // Initial state for player
    }
}
