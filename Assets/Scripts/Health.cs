//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Health : MonoBehaviour
//{   
//    public int health;
//    public void Start()
//    {
//        health = 5;
//    }
//// När den nuddar något med tagen Enemy så minskar helath med´-1
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
   
//        if (collision.tag=="Enemy")
//        {
//            health -=1;
//        }
//    }
//    public void Update()
//    {    om health är 0 laddas scenen om
//        if (health == 0)
//        {
//            Scene active = SceneManager.GetActiveScene();
//            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//        }


            //JAG FICK DET INTE ATT FUNKA





//    }
//}

