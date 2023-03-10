using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{

    public float velocidade;
    public Rigidbody2D municao;
    public string tagInimigo;


    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(new Vector2(1, 0) * Time.deltaTime * velocidade);

    }

    
 

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag(tagInimigo))
        {
            Destroy(outro.gameObject);
            Destroy(municao.gameObject);
        }
    }

}




