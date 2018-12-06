using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordIsTouthing : MonoBehaviour
{

    //När den nuddar något kollar den om det är spelaren
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Den kollar om den den saken som nuddar har tagen player
        if (collision.gameObject.tag == "Sword")
        {

            //Tar bort sig själv
            Destroy(gameObject);
        }


    }
}


