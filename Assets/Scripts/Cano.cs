using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Cano : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    }
}
