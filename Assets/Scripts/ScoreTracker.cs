using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Vill använda textmeshpro
using TMPro;
//Using Unityengine.UI
public class ScoreTracker : MonoBehaviour
{
    //Referarar till en slags text
    public TextMeshProUGUI scoreText;
    public int totalScore=4;

    private void Update()
    {
        //En text på skärmer där det står Score och sen en siffra
        scoreText.text = string.Format("Score {0}", totalScore);
    }
}
