using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public KeyCode teclaD = KeyCode.D;
    public KeyCode teclaA = KeyCode.A;
    float movimientos = 1f;
    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown(teclaD))
        {
            this.transform.Translate(new Vector3(0, movimientos* 7, 0));
        }
        
    }
        if (Input. ) 
}
