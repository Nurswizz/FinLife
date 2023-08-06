using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool isDragged = false;
    private float Z_POS = -1;
    private Vector3 startPos = new Vector3(-.15f, -.41f, -1f);
    private void Start()
    {
        Debug.Log(Manager.education + " " + Manager.happiness + " " + Manager.health + " " + Manager.money);
    }
    private void Update()
    {
        if (isDragged)
        {
            Vector3 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(temp.x, temp.y, Z_POS);
        }


    }

    private void OnMouseDown()
    {
        isDragged = true;
    }

    private void OnMouseUp()
    {
        isDragged = false;
        if (transform.position.x < -1f)
        {
            Manager.firstWay();
            GameObject.Destroy(gameObject);
            
        }
        else if (transform.position.x > 1f)
        {
            Manager.secondtWay();
            GameObject.Destroy(gameObject);
        }
        transform.position = startPos;
        Debug.Log(Manager.education + " " + Manager.happiness + " " + Manager.health + " " + Manager.money);
    }
}
