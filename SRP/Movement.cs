using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void OnMovement(Player player)
    {
        player.transform.position = new Vector2(5, 0) * player.speedMovement * Time.deltaTime;
    }
}
