using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public int charge = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(charge == 100)
            {
                charge = 100;
            }
            else
            {
                charge = charge + 25;
            }
        }
    }
}
