using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> startdeck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] emptyCardSlots;
    // Start is called before the first frame update
    void Start()
    {
        Card randCard = startdeck[Random.Range(0, startdeck.Count)];
        Card previousCard;
        for (int i = 1; i <= emptyCardSlots.Length; i++)
        {
            if (emptyCardSlots[i] == true)
            {
                for (int a = 0; a < i; a++)
                {
                    randCard.gameObject.SetActive(true);

                    if (a == 0) {
                        randCard.transform.position = cardSlots[i].position;
                        randCard = previousCard;
                    }
                    else
                    {
                        randCard.transform.parent = previousCard.transform;
                        randCard = previousCard;
                    }
                }
            }
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
