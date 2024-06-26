using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Shooting : MonoBehaviour
{
    public SerialPort port = new SerialPort("COM4", 9600);
    //public AmmoController AmmoCtrl; 

    // Start is called before the first frame update
    void Start()
    {
        port.ReadTimeout = 3;//puerto serial a usar
        port.Open();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gatillo() 
    {
        if (Input.GetKey("Fire"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (port.IsOpen) 
        {
            port.Write("1");
        }
    }
}
