using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;
    private float tamanhoDaImagemNaCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagemReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaImagemNaCena = tamanhoDaImagemReal * escala;
    }

    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoDaImagemNaCena);
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
