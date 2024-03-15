using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    private IButtonBehavior accion;

    public void SetAction(IButtonBehavior accion)
    {
        this.accion = accion;
    }

    public void ButtonA()
    {
        accion.ButtonActionA();
    }

    public void ButtonB()
    {
        accion.ButtonActionB();
    }
}
