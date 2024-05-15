using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject modeloCano;

    [SerializeField]
    private float tempoParaSpawnar = 3;
    private float cronometro;


    private void Awake()
    {
        this.cronometro = this.tempoParaSpawnar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloCano, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaSpawnar;
        }
    }
}
