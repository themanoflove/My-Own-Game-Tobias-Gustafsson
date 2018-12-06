using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounfCheck : MonoBehaviour
{
    // variabel som är ett heltal och ökar med ett
    public int touches;
    //När den träffar saker ökar den touches
    private void OnTriggerEnter2D(Collider2D other)
    {
        touches++;
    }
    //när man lämnar subtraherar touches
    private void OnTriggerExit2D(Collider2D other)
    {
        touches--;
    }
    //Den ligger på player så när den kan se om vi rör marken
}
