using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoPlayer : MonoBehaviour
{
public float speed = 5.0f; // velocidade do movimento do jogador

private Camera mainCamera; // referência à câmera na cena

private void Start()
{
// buscar a referência à câmera na cena
mainCamera = Camera.main;
}

private void Update()
{
// movimentar o jogador nas direções permitidas
float moveHorizontal = Input.GetAxis("Horizontal");
float moveVertical = Input.GetAxis("Vertical");
Vector2 movement = new Vector2(moveHorizontal, moveVertical);

// mover o jogador em relação à câmera
Vector3 cameraForward = mainCamera.transform.forward;
cameraForward.y = 0;
cameraForward = cameraForward.normalized;
Vector3 cameraRight = mainCamera.transform.right;
cameraRight.y = 0;
cameraRight = cameraRight.normalized;
Vector3 moveDirection = cameraForward * movement.y + cameraRight * movement.x;
moveDirection.y = movement.y;
transform.position += moveDirection.normalized * speed * Time.deltaTime;
}
}






