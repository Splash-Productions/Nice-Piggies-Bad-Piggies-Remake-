using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBuilding : MonoBehaviour
{
    public GameObject chosenComponent;
    public GameObject cursor;
    public bool TheresPig;
    private void Start()
    {
        TheresPig = false;
    }
    private void Update()
    {
        if (chosenComponent != null)
        {
            cursor.GetComponent<SpriteRenderer>().sprite = chosenComponent.GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            cursor.GetComponent<SpriteRenderer>().sprite = null;
        }
        cursor.transform.position = new Vector3( Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
    }
}
