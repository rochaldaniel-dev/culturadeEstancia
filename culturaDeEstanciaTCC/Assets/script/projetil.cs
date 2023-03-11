using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{

    public float velocidade;
    

    //para destruir o inimigo
    public int dano;
    public float tempoDeMunicao;
    public float distancia;
    public LayerMask layerInimigo;



     void Start()

    {
        Invoke("destruirProjetil", tempoDeMunicao);
    }

    private void Update()
    {

         transform.Translate(new Vector2(1, 0) * Time.deltaTime * velocidade);
       
        RaycastHit2D hitInf = Physics2D.Raycast(transform.position, transform.forward, distancia, layerInimigo);
        
        if(hitInf.collider != null)
        {
           if(hitInf.collider.CompareTag("Inimigo"))
           {
                hitInf.collider.GetComponent<inimigos>().takeDamage(dano);
           } 

            destruirProjetil();
        }
    }

    void destruirProjetil()
    {
        Destroy(gameObject);
    }

}




