using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;
    //När den nuddar något kollar den om det är spelaren
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Den kollar om den den saken som nuddar har tagen player
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel "controller" och sätt den till 
            //resultatet av sökningen efter object med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //skapa en tamporär variabel "tracker" och sätt den till 
                //resultatet av sökningen efter komponenten "ScoreTracker
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)

                {
                    tracker.totalScore += score;

                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");

                }
            }
            else
            {
                Debug.LogError("GameController finns inte");
            }

            //Tar bort sig själv
            Destroy(gameObject);
        }


    }
}
