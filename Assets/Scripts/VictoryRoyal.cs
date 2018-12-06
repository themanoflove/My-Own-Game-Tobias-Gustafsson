using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Det gör som man kan ladda barnor
using UnityEngine.SceneManagement;

public class VictoryRoyal : MonoBehaviour
{

    public int score = 1;
    public string LevelToLoad = "Level.2";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Player" && totalScore = 2)

        SceneManager.LoadScene(LevelToLoad);

        print("yo good man");


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


    }
}
