using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Estadisticas")]
    public float JumpForce = 10;
    public float walkspeed = 10;
    private float currentspeed = 0;

    [Header("Score")]
    private float topScore = 0.0f;
    public TMP_Text ScoreText;

    public GameOverScreen GameOverScreen;
    [SerializeField] private GameObject botonPausa;

    public void GameOver(){
        float result = Mathf.Round(topScore);
        GameOverScreen.Setup(result);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {        
         rb.velocity = new Vector2(currentspeed, rb.velocity.y);

         if(rb.velocity.y > 0 && transform.position.y > topScore){
            topScore = transform.position.y;
         }

         ScoreText.SetText("Score: " + Mathf.Round(topScore).ToString());
    }

    private void OnMove(InputValue inputValue){
        float moveValue = inputValue.Get<float>();
        Debug.Log("Move! " + moveValue);
        // Definimos la velocidad a la que debería estarse moviendo nuestro personaje
        currentspeed = moveValue * walkspeed;
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.tag == "End"){
            Time.timeScale = 0;
            GameOver();
            botonPausa.SetActive(false);
        }
    }

}
