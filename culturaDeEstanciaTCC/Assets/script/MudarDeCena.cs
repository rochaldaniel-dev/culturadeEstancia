using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarDeCena : MonoBehaviour
{
    
    [SerializeField] private string LevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelDeOpcoes;

    public void jogar()
   
    {
        SceneManager.LoadScene(LevelDeJogo);
        
    }

    public void AbriOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelDeOpcoes.SetActive(true);
    }

    public void FechaOpções()
    {
        painelDeOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void sairDoJogo()
    {
        Debug.Log("sair do jogo");
        Application.Quit();
    }
 

}
