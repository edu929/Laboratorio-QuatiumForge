using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {
        Debug.Log("Estación siguiente");
    }

    public void ButtonActionB()
    {
        Debug.Log("Estación anterior");
    }
}
