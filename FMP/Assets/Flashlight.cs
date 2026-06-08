using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private Image Batterybarsprite;
    public int charge = 0;
    void Start()
    {
        
    }

    public void UpdateHealthBar(int maxCharge, int currentCharge)
    {
        Batterybarsprite.fillAmount = currentCharge / maxCharge;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(charge == 100)
            {
                charge = 0;
            }
            else
            {
                charge = charge + 25;
            }
        }
    }
}
