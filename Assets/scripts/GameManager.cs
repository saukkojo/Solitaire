using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] filledCardSlots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawCard()
    {
        switch(deck.Count)
        {
            case == 0:
                
            case = 1:
                Card drawCard = deck[];
            case = 2:
                Card drawCard = deck[];
            case >= 3:
                Card drawCard = deck[];
            case = 0:
                Card drawCard = deck[];
        }
    }
}
