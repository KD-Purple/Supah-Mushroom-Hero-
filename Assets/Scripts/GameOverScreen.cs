using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text puntos;

    public void Setup(float score){
        gameObject.SetActive(true);
        puntos.SetText("Puntaje: " + score.ToString());
    }
}
