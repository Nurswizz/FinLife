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
        requierements.Add(" �� ����� ��� �� �������� 1000$. �� ������ ������ ���� ��� ���������� ����������� � ����������...");
        requierements.Add(" 1-����. \n���� �� ����� ������������� ? ");
        requierements.Add(" 2-����.\n ������� � ����� ��������������.");
        requierements.Add("...������ �� �����...  \n ��� �������� ���� �������� ��� ������ � ����.�� �� \n ����� ������ ������ ����� \n APPLE...");
        requierements.Add("� ��� ������ ������� ������ � ������� ��������.�� ������ ������������� � ����� - �� ��� ��������...");
        requirement = GetComponent<TMP_Text>();
        requirement.text = requierements[0];
    }

    public static void changeText()
    {
        requirement.text = requierements[Manager.currentCard];
    }
}
