using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextManagement : MonoBehaviour
{
    static TMP_Text requirement;
    public static List<string> requierements = new List<string>();
    private void Start()
    {
        requierements.Add(" За целый год вы накопили 1000$. Вы решили купить курс про финансовую грамотность и инвестиции...");
        requierements.Add(" 1-Урок. \nКуда не нужно инвестеривоть ? ");
        requierements.Add(" 2-Урок.\n Прибыли и риски инвестирования.");
        requierements.Add("...Звонок от друга...  \n Ваш азартный друг попросил вас деньги в долг.Но вы \n очень хотели купить акции \n APPLE...");
        requierements.Add("К вам пришли молодые ребята с хорошим проектом.Вы можете финансировать в старт - ап или отказать...");
        requirement = GetComponent<TMP_Text>();
        requirement.text = requierements[0];
    }

    public static void changeText()
    {
        requirement.text = requierements[Manager.currentCard];
    }
}
