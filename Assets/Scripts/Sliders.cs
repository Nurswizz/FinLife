using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Sliders : MonoBehaviour
{
    public Slider education;
    public Slider money;
    public Slider happiness;
    public Slider health;
    public TMP_Text moneyText;

    private void Update()
    {
        education.value = Manager.education;
        money.value = Manager.money;
        happiness.value = Manager.happiness;
        health.value = Manager.health;
        moneyText.text = Manager.realMoney.ToString();
    }


}
