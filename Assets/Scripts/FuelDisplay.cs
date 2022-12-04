
using UnityEngine;
using UnityEngine.UI;
using System;

public class FuelDisplay : MonoBehaviour
{
    public Image fuel;
    public static FuelDisplay instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        fuel.fillAmount -= Math.Abs(Input.GetAxis("Horizontal") / 3500f);
    }

    public void AddFuel()
    {
        fuel.fillAmount = 1;

        //fuel.fillAmount += 0.1f;
    }

    public float getFuel()
    {
        return fuel.fillAmount;
    }
}
