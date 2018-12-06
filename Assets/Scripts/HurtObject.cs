using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{

    //När någonting som nuddar den, som heter Player  laddar scenen om 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Skapar en temponär variabel som endast finns här, den kollar och vilken barna som spelaren är på och laddar om barnan
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
