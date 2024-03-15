using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {
        Debug.Log("Emoji");
    }

    public void ButtonActionB()
    {
        Debug.Log("Agacharse");
    }
}
