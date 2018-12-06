using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //datorn hittar kollar om den är av och om den är av så är objectet onsynligt
        GetComponent<SpriteRenderer>().enabled = false;

    }

}
