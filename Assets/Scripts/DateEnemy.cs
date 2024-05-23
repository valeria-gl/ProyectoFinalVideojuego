using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateEnemy : MonoBehaviour
{
    public int ReduceVida;
    public GameObject Jugador;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Jugador.GetComponent<DatePlayer>().VidaPlayer -= ReduceVida;
        }
    }
}
