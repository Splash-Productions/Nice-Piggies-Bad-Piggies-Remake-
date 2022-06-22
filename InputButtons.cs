using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputButtons : MonoBehaviour
{
    public CreateCarButton[] carComps;
    public GameObject car;
    public PhysicsMaterial2D cars;
    public GameObject pig;
    public GameObject canvas;
    public void cancel()
    {
        for(int i = 0; i < carComps.Length; i++)
        {
            carComps[i].objInComponent = null;
            GetComponentInParent<CarBuilding>().TheresPig = false;
            carComps[i].TheresPig = false;
            carComps[i].isUsed = false;
        }
    }
    public void createCar()
    {
        
        GameObject c = Instantiate(car, Vector3.zero, Quaternion.identity);
        for (int i = 0; i < carComps.Length; i++)
        {
            if (carComps[i].GetComponent<CreateCarButton>().objInComponent != null)
            {
                GameObject z = Instantiate(carComps[i].GetComponent<CreateCarButton>().objInComponent, c.GetComponent<Car>().comps[i].transform.position, Quaternion.identity);
                z.transform.parent = c.transform;
            }
            if (carComps[i].GetComponent<CreateCarButton>().TheresPig)
            {
                GameObject z = Instantiate(pig, c.GetComponent<Car>().comps[i].transform.position, Quaternion.identity);
                Camera.main.transform.parent = z.transform;
                Camera.main.transform.localPosition = new Vector3(0, 0, -10);

            }
        }

        canvas.SetActive(false);
    }
}
