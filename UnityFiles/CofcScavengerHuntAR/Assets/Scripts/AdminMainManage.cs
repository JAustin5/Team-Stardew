using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminMainManage : MonoBehaviour
{
    // AdminScreens Canvases
    public GameObject adminMainScreenCanvas;
    public Transform cardContainer;
    public GameObject locationCreationForm;

    // Admin card fields
    public GameObject cardPrefab;
    public InputField locationName;
    public InputField locationAddress;
    public InputField locationDescription;
    public InputField cardHint1;
    public InputField cardHint2;
    public InputField cardHint3;
    //public Image ; Getting image that is uploaded

    // accumlator to keep track of number of created cards to display on Player's screen found vs not found
    private int totalLocationCards = 0;
    private int foundLocationCards = 0;


    // Store of cards
    private  List<CardsData> cardList = new List<CardsData>();

    // Data of card --> NOTE: moved to separate Class CardData (has own script)

    // Card creation (ONLY ADMIN)
    public void CreateCard(string name, string address, string description, string hint1, string hint2, string hint3)
    {
        // Need to add converter of address to coordinates

        // Add 'lat' and 'long' to new CardsData
        CardsData newCard = new CardsData(name, address, description, hint1, hint2, hint3);
        cardList.Add(newCard);

        DisplayCard(newCard);

        


        totalLocationCards++;        
    }

    private void DisplayCard(CardsData card)
    {
        GameObject cardUI = Instantiate(cardPrefab, cardContainer);
        cardUI.transform.Find("LocationName").GetComponent<Text>().text = card.name;

        Button editButton = cardUI.transform.Find("EditButton").GetComponent<Button>();
        Button deleteButton = cardUI.transform.Find("DeleteButton").GetComponent<Button>();

        // Add listeners???
        //editButton.onClick.AddListener(() => EditCard(card, cardUI));
        //deleteButton.onClick.AddListener(() => DeleteCard(card, cardUI));
    }

    // Show the entire card informations
    //private void DisplayCardScreen(CardsData card)
    //{
        
    //}

    // Editing an existing card
    public void EditCard(CardsData card, GameObject cardUI)
    {
        card.name = "New Card Name";
        cardUI.transform.Find("NameInputField").GetComponent<Text>().text = card.name;

        card.address = "New Address";
        cardUI.transform.Find("AddressInputField").GetComponent<Text>().text = card.address;

        card.description = "New Description";
        cardUI.transform.Find("DetailsInputField").GetComponent<Text>().text = card.description;

        card.hint1 = "Hint 1";
        cardUI.transform.Find("Hint1InputField").GetComponent<Text>().text = card.hint1;

        card.hint2 = "Hint 2";
        cardUI.transform.Find("Hint2InputField").GetComponent<Text>().text = card.hint2;

        card.hint3 = "Hint 3";
        cardUI.transform.Find("Hint3InputField").GetComponent<Text>().text = card.hint3;
    }

    // Delete an exsiting card
    public void DeleteCard(CardsData card, GameObject cardUI)
    {

        cardList.Remove(card);
        Destroy(cardUI);
        totalLocationCards--;

        //cardList.Remove(cardData);
        //TO-DO: create to destroy card itself from view
        //Destroy();


    }
}
