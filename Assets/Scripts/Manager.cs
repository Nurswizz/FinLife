using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Manager : MonoBehaviour
{
    public static float happiness;
    public static float money;
    public static float education;
    public static float health;
    public static int realMoney;
    public static int currentCard;
    public static List<GameObject> gameObjects;
    private static Data data;
   
    private void Start()
    {
        happiness = 50f;
        money = 50f;
        education = 50f;
        health = 50f;
        realMoney = 1000;
        currentCard = 0;
        data = GetComponent<Data>();
        Instantiate(data.gameObjects[currentCard], new Vector3(-0.15f, -0.41f, -1), Quaternion.identity);
    }


    public static void firstWay()
    {
        happiness += Data.firstWay[currentCard].getHappiness();
        money += Data.firstWay[currentCard].getMoney();
        health += Data.firstWay[currentCard].getHealth();
        education +=  Data.firstWay[currentCard].getEducation();
        realMoney += Data.firstWay[currentCard].getRealMoney();
        if (currentCard < Data.secondWay.Count)
            currentCard++;
        Instantiate(data.gameObjects[currentCard], new Vector3(-0.15f, -0.41f, -1), Quaternion.identity);
        TextManagement.changeText();
    }

    public static void secondtWay()
    {
        happiness = happiness + Data.secondWay[currentCard].getHappiness();
        money += Data.secondWay[currentCard].getMoney();
        health += Data.secondWay[currentCard].getHealth();
        education += Data.secondWay[currentCard].getEducation();
        realMoney += Data.secondWay[currentCard].getRealMoney();
        if (currentCard < Data.secondWay.Count)
            currentCard++;
        Instantiate(data.gameObjects[currentCard], new Vector3(-0.15f, -0.41f, -1), Quaternion.identity);
        TextManagement.changeText();
    }

   
}
