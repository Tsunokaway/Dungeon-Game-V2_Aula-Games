using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    //moveH -> movimento horizontal
    //moveV -> movimento vertical
    private float moveH, moveV;
    public Animator animator;
    //necessariamente o "f" depois do número definido
    public float speed = 2f;

    private void Start()
    {
        //Ao iniciar o jogo, acessa o Rigidbody2D do personagem
        rb = GetComponent<Rigidbody2D>();


        //  INDICAÇÃO PARA POSIÇÃO INICIAL DO JOGADOR
        //transform  -> Para o personagem se mexer
        //position -> Posição do personagem na cena
        //transform.position = new Vector3(0, 0, 0);
    }

    /*
     
        Padrâo (opcional) -> "private"
        "void Update()" -> Função que atualiza o jogo
     
     */
    private void Update()
    {
        /*
         GetKeyDown() -> Quando a tecla for pressionada
         GetKey() -> Enquanto a tecla estiver pressionada
         GetKeyUp() -> Quando a tecla não estiver mais pressionada
         
         
         KeyCode.Space -> Tecla Espaço
         */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("O usuário clicou!");
            transform.position = new Vector3(0, 0, 0);
        }
    }


    private void FixedUpdate()
    {
        /*
         Devolve um valor de acordo com a movimentação (setas ou AWSD):
            -> -1 para esquerda e para baixo
            -> 1 para direita e para cima
         */
        moveH = Input.GetAxis("Horizontal")*speed;//multiplica o valor do moveH para 2(para direita) ou -2(para esquerda)
        moveV = Input.GetAxis("Vertical")*speed;//multiplica o valor do moveH para 2(para cima) ou -2(para baixo)

        /*
         rb.linearVelocity -> Aplica uma velocidade na direção em que o Player está sendo direcionado
         */
        rb.linearVelocity = new Vector2(moveH, moveV);

        // Responsável por ativar as animações
        animator.SetFloat("Horizontal", moveH);
        animator.SetFloat("Vertical", moveV);
        animator.SetFloat("Speed", rb.linearVelocity.magnitude);

        // Vira o personagem baseado no movimento
        transform.localScale = new Vector3(moveH < 0 ? -1 : 1, 1, 1);
    }


}
