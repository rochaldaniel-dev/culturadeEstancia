using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarDeCena : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelDeOpcoes;

    void Start()
    {
        SceneManager.LoadScene("jogo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
