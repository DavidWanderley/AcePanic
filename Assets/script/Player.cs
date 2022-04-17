using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    private     Rigidbody2D     PlayerRb;
    private     SpriteRenderer  PlayerSprite;
    public      float           velocidade;
    public      bool            flipX;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        PlayerSprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            velocidade *= -1;
            flipX = !flipX;
            PlayerSprite.flipX = flipX;
        }

        PlayerRb.velocity = new Vector2(velocidade, PlayerRb.velocity.y);

    }

    void OnCollisionEnter2D(Collision2D colisao){
        if(colisao.gameObject.tag == "espinho"){
            SceneManager.LoadScene("gameover");
        }
    } 

    void OnTriggerEnter2D(Collider2D colisao){
        if(colisao.gameObject.tag == "espinho"){
            SceneManager.LoadScene("gameover");
        }
    }
}
