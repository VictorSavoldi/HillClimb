using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D carRig;
    public float speed;
    private float movement;
    public Axle[] axles;
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (movement == -1)
            SetTorque(speed);

        else if (movement == 1)
            SetTorque(-speed);
    }

    void SetTorque(float speed)
    {
        if (FuelDisplay.instance.getFuel() > 0)
            foreach (Axle axle in axles)
            {
                if (NitroDisplay.instance.getNitro() > 0)
                {
                    axle.wheel.AddTorque(speed * axle.torque * 5 * Time.fixedDeltaTime);
                    carRig.AddTorque(-speed * axle.torque * 5 * Time.fixedDeltaTime);
                }
                else
                {
                    axle.wheel.AddTorque(speed * axle.torque * Time.fixedDeltaTime);
                    carRig.AddTorque(-speed * axle.torque * Time.fixedDeltaTime);
                }
            }

    }

    [System.Serializable]

    public class Axle
    {
        public Rigidbody2D wheel;
        public float torque;
    }

}
