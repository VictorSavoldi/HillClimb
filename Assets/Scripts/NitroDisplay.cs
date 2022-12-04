using UnityEngine;
using UnityEngine.UI;
using System;

public class NitroDisplay : MonoBehaviour
{
    public Image nitro;
    public static NitroDisplay instance;

    // Start is called before the first frame update
    void Start()
    {
        nitro.fillAmount = 0;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        nitro.fillAmount -= Math.Abs(Input.GetAxis("Horizontal") / 150f);
    }

    public void AddNitro()
    {
        nitro.fillAmount = 1;

        //nitro.fillAmount += 0.1f;
    }

    public float getNitro()
    {
        return nitro.fillAmount;
    }
}
