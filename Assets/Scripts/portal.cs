using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    //skapar så att man kan byta vart man vill teleportera sig någonstans i unity
    public Transform target;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om något object som har tagen Player rör något object som har detta script transformeras player till en ny posiotion som du har valt i unity
        if (collision.tag == "Player")

            collision.transform.position = target.position;
    }

}
