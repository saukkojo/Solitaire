using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public List<Card> startdeck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] emptyCardSlots;

    public List<Card> playdeck = new List<Card>();
    public int topcard = 0;
    private Card drawcard1;
    private Card drawcard2;
    private Card drawcard3;

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
                randCard.transform.localPosition = new Vector3(0, -20 * a, 0);
                
                //removes used card from the deck
                startdeck.Remove(randCard);
           }
            cardSlots[i].GetComponent<cardrenderer>().OrderCards();
        }

        for (int i = 0; i < 24; i++)
        {
            Card randCard = startdeck[Random.Range(0, startdeck.Count)];
            playdeck.Add(randCard);
            startdeck.Remove(randCard);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawCard()
    {
        if (topcard > 0)
        {
            drawcard1.gameObject.SetActive(false);
            drawcard2.gameObject.SetActive(false);
            drawcard3.gameObject.SetActive(false);
        }

        if (topcard < 24)
        {
            drawcard1 = playdeck[topcard];
            drawcard2 = playdeck[topcard + 1];
            drawcard3 = playdeck[topcard + 2];
        }

        if (topcard == 24)
        {
            drawcard1.gameObject.SetActive(false);
            drawcard2.gameObject.SetActive(false);
            drawcard3.gameObject.SetActive(false);
            topcard = 0;     
        }
        else if(topcard == 23)
        {
            drawcard1.gameObject.SetActive(true);
            drawcard2.gameObject.SetActive(false);
            drawcard3.gameObject.SetActive(false);
            topcard++;
        }
        else if (topcard == 22)
        {
            drawcard1.gameObject.SetActive(true);
            drawcard2.gameObject.SetActive(true);
            drawcard3.gameObject.SetActive(false);
            topcard += 2;
        }
        else if (topcard > 0 && topcard < 22)
        {
            drawcard1.gameObject.SetActive(true);
            drawcard2.gameObject.SetActive(true);
            drawcard3.gameObject.SetActive(true);
            topcard += 3;
        }
        else if (topcard == 0)
        {
            drawcard1.gameObject.SetActive(true);
            drawcard2.gameObject.SetActive(true);
            drawcard3.gameObject.SetActive(true);
            topcard += 3;
        }
        else
        {
            Debug.Log("Draw deck error");
        }

        drawcard1.transform.parent = GameObject.Find("deck").transform;
        drawcard1.transform.localPosition = new Vector3(0, 0, 0);
        drawcard2.transform.parent = GameObject.Find("deck").transform;
        drawcard2.transform.localPosition = new Vector3(30, 0, 0);
        drawcard3.transform.parent = GameObject.Find("deck").transform;
        drawcard3.transform.localPosition = new Vector3(60, 0, 0);

    }
}
