using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminMainManage : MonoBehaviour
{
    // AdminScreens Canvases
    public GameObject adminMainScreenCanvas;
    public GameObject locationCreationForm;

    // Admin card fields
    public GameObject adminCardPrefab;
    public InputField locationName;
    public InputField locationAddress;
    public InputField coordinateLatitude;
    public InputField coordinateLongtitude;
    public InputField locationDescription;
    public InputField cardHint1;
    public InputField cardHint2;
    public InputField cardHint3;
    //public Image ; Getting image that is uploaded

    // accumlator to keep track of number of created cards to display on Player's screen found vs not found
    public int createdCardAcc = 0;

    // Store of cards
    public List<CardsData> cards = new List<CardsData>();

    [System.Serializable]
    public class CardsData
    {
        public string name;
        public string address;
        public string latitude;
        public string longitude;
        public string description;
        public string hint1;
        public string hint2;
        public string hint3;

        public bool isUnlocked;
    }

    // Card creation (ONLY ADMIN)
    public void CreateCard()
    {
        CardsData newCard = new CardsData
        {
            name = locationName.text,
            address = locationAddress.text,
            latitude = coordinateLatitude.text,
            longitude = coordinateLongtitude.text,
            description = locationDescription.text,
            hint1 = cardHint1.text,
            hint2 = cardHint2.text,
            hint3 = cardHint3.text,
            isUnlocked = false
        };

        cards.Add(newCard);
        createdCardAcc++;

        // TO-DO: Visual representation of card for both Admin and Player screens
        
    }

    // Editing an existing card
    public void EditCard(CardsData cardData)
    {
        locationName.text = cardData.name;
        locationAddress.text = cardData.address;
        coordinateLatitude.text = cardData.latitude;
        coordinateLongtitude.text = cardData.longitude;
        locationDescription.text = cardData.description;
        cardHint1.text = cardData.hint1;
        cardHint2.text = cardData.hint2;
        cardHint3.text = cardData.hint3;
    }

    // Delete an exsiting card
    public void DeleteCard(CardsData cardData)
    {
        cards.Remove(cardData);
        //TO-DO: create to destroy card itself from view
        //Destroy();
        createdCardAcc--;
    }
}
