using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Implementacion : MonoBehaviour
{


    private void Start()
    {
        Botones boton = new Botones();
        Jugador jugador = new Jugador();
        Vehiculo vehiculo = new Vehiculo();


        boton.SetAction(jugador);
        boton.ButtonA();
        boton.ButtonB();

        boton.SetAction(vehiculo);
        boton.ButtonA();
        boton.ButtonB();
    }


}
