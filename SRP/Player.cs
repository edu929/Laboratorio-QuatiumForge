using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string nombre;
    public float speedMovement;

    public Player(string nombre, float speedMovement)
    {
        this.nombre = nombre;
        this.speedMovement = speedMovement;
    }
}
