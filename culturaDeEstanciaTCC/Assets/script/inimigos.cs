using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigos : MonoBehaviour
{
    public int energia;
    
    

   
    void Update()
    {
        if(energia <= 0)
        {
            Invoke("DestroyEnemy", energia); 
        }
    }


    public void takeDamage(int damage)
    {
        energia -= damage;
    }

    private void DestroyEnemy()
    {
       Destroy(gameObject); 
    }

}
