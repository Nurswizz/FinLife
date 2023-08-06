using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static List<Card> firstWay = new List<Card>();
    public static List<Card> secondWay = new List<Card>();
    public List<GameObject> gameObjects;
    private void Start()
    {
        firstWay.Add(new Card(0, 0, 0, 0, -500));
        firstWay.Add(new Card());
        firstWay.Add(new Card());
        firstWay.Add(new Card(-10f, 10f, 0, 0, -100));
        firstWay.Add(new Card());
        secondWay.Add(new Card(0, 0, 0, 0, -500));
        secondWay.Add(new Card());
        secondWay.Add(new Card());
        secondWay.Add(new Card(-10f, -10f, 0, 0, 0));
        secondWay.Add(new Card(10f, -10f, 0, 0, -100));
    }
}
