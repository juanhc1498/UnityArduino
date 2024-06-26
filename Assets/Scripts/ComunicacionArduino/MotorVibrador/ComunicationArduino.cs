using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ComunicationArduino : MonoBehaviour
{
    public SerialPort port = new SerialPort("COM4", 9600);

    // Start is called before the first frame update
    void Start()
    {
        port.ReadTimeout = 30;
        port.Open();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            //Debug.Log("Entre");

            if (port.IsOpen)
            {
                //other.gameObject.tag == "Player";
                Debug.Log("Entre");
                port.Write("1");
            }
        }
        
    }
}
