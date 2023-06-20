using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> startdeck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] emptyCardSlots;
    // Start is called before the first frame update
    public void Start()
    {
        Card randCard = startdeck[Random.Range(0, startdeck.Count)];

        for (int i = 1; i <= emptyCardSlots.Length; i++)
        {
            if (emptyCardSlots[i] == true)
            {
                for (int a = 0; a < i; a++)
                {
                    randCard.gameObject.SetActive(true);

                    if (a == 0) {
                        randCard.transform.position = cardSlots[i].position;
                        return;

                    }
                    else
                    {
                        randCard.transform.position = cardSlots[i].position + new Vector3(0,a * -10,0);
                        return;
                    }
                    emptyCardSlots[i] = false;
                    startdeck.Remove(randCard);
                    return;
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
