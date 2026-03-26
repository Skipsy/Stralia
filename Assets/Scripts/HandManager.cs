using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class HandManager : MonoBehaviour
{

    public List<CardDisplay> deck = new List<CardDisplay>();
    public List<CardDisplay> discardPile = new List<CardDisplay>();
    public Transform[] cardSlots;
    public bool [] avilableCardSlots;

    

    public void DrawCard()
    {
        if(deck.Count >= 1)
        {
   
            CardDisplay randomCard = deck[Random.Range(0,deck.Count)];

            // this will subject to change when we make a better hand system
            for (int i = 0; i < avilableCardSlots.Length; i++)
            {
                if (avilableCardSlots[i] == true)
                {
                    randomCard.gameObject.SetActive(true);
                    randomCard.transform.position = cardSlots[i].transform.position;
                    avilableCardSlots[i] = false;
                    deck.Remove(randomCard);
                    return;
                }           
            }
        }
        
    } 


    public void ReshuffleDeck()
    {
        


    }
}
