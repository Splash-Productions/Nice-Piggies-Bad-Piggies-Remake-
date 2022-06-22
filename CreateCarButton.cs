using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCarButton : MonoBehaviour
{
    public bool isUsed;
    public GameObject objInComponent;
    public Sprite square;
    public GameObject PIGcomponent;
    public bool TheresPig;
    public GameObject pigButton;

    private void Start()
    {
        TheresPig = false;
        isUsed = false;
    }
    private void Update()
    {
        if (isUsed)
        {
            GetComponent<Image>().sprite = objInComponent.GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            GetComponent<Image>().sprite = square;
        }
        if (!GetComponentInParent<CarBuilding>().TheresPig)
        {
            pigButton.SetActive(true);
            PIGcomponent.SetActive(false);
        }
        else if(TheresPig)
        {
            pigButton.SetActive(false);
            PIGcomponent.SetActive(true);
        }
    }
    public void pressbutton()
    {
        if (GetComponentInParent<CarBuilding>().chosenComponent != null)
        {
            if (GetComponentInParent<CarBuilding>().chosenComponent.name != "pig")
            {
                
                    isUsed = true;
                    objInComponent = GetComponentInParent<CarBuilding>().chosenComponent;
                
            }
            else
            {
                TheresPig = true;
                GetComponentInParent<CarBuilding>().TheresPig = true;
            }
        }
        else
        {
            isUsed = false;
            objInComponent = null;
        }
        GetComponentInParent<CarBuilding>().chosenComponent = null;


    }
}
