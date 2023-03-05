using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAndar : MonoBehaviour
{
    public float cameraSpeed = 5.0f; // velocidade do movimento da câmera

    private void Update()
    {
        // movimentar a câmera para o lado direito
        transform.Translate(Vector3.right * cameraSpeed * Time.deltaTime);
    }
}
