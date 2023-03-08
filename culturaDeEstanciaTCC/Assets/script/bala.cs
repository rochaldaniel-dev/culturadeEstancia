using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atirar : MonoBehaviour
{
    public int dano;
    public float tempoDevida;
    public float distancia;
    public LayerMask layerInimig;
   

    void start()
    {
        Invoke("DestruirProjetil", tempoDevida);
    }

    private void Update()
    {
        

    }
    
    void DestruirProjetil()
    {
        Destroy(gameObject);
    }
}
