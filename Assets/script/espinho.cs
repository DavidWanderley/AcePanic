using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinho : MonoBehaviour{

    private     Rigidbody2D espinhoRB;

    private     int         atrito;
    public      int         atritoMaximo, atritoMinimo;
    public      Vector3     posicao;
    public      GameObject  espinhoPrefab;

    void Start()
    {
        espinhoRB = GetComponent<Rigidbody2D>();
        atrito = Random.Range(atritoMinimo, atritoMaximo);
        espinhoRB.drag = atrito;

        posicao = transform.position;

    }

    void OnBecameInvisible(){
        Instantiate(espinhoPrefab, posicao, transform.localRotation);
        pontuacao.pontos += 1;
        Destroy(this.gameObject);
    }
}
