using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> startdeck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] emptyCardSlots;

    public List<Card> playdeck = new List<Card>();
    // Start is called before the first frame update
    public void Start()
    {
        //goes through card slots in order
        for (int i = 0; i < cardSlots.Length; i++)
        {  
            //spawns the correct amount of cards for each slot
           for (int a = 0; a <= i; a++)
           {
                //activates a random card from the deck
                Card randCard = startdeck[Random.Range(0, startdeck.Count)];
                randCard.gameObject.SetActive(true);

                //moves the card to its position
                randCard.transform.SetParent(cardSlots[i]);
                randCard.transform.localPosition = new Vector3(0, -40 * a, 0);
                
                //removes used card from the deck
                startdeck.Remove(randCard);
           }
        }

        while (startdeck.Count > 0)
        {
            for()
            startdeck.Remove(randCard);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void DrawCard()
    {
        switch(deck.Count)
        {
            case == 0:
                
            case == 1:
                Card drawCard
            case == 2:
                Card drawCard
            case >= 3:
                Card drawCard
        }
    }*/
}
