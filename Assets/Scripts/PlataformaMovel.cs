using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovel : MonoBehaviour
{
    public Transform pontoA;  // O primeiro ponto de movimento
    public Transform pontoB;  // O segundo ponto de movimento
    public float velocidade = 3f;  // Velocidade de movimento
    private Vector3 proximoDestino;

    void Start()
    {
        // Definir o primeiro destino
        proximoDestino = pontoA.position;
    }

    void Update()
    {
        // Movimenta a plataforma em direção ao destino
        transform.position = Vector3.MoveTowards(transform.position, proximoDestino, velocidade * Time.deltaTime);

        // Se a plataforma chegou ao destino, alterna o ponto de movimento
        if (Vector3.Distance(transform.position, proximoDestino) < 0.1f)
        {
            proximoDestino = proximoDestino == pontoA.position ? pontoB.position : pontoA.position;
        }
    }
}
