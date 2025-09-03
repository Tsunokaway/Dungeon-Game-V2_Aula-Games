using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

/*
 Heran�a -> ":MonoBeahviour" da pr�pria Unity, por�m � possivel
 
 */
public class Enemy: MonoBehaviour
{
    public string name;
    public float speed;
    public float life;
    public float maxLife;
    public Transform target;


    void Start()
    {
        /*
         No m�todo Start(), deve ser definido a vida no come�o do jogo.
         */
        life = maxLife;
        Introduction();

    }

    /*
     Para poder acesar esse m�todo em outro script, � necess�rio o "protected virtual"
     */
    protected virtual void Introduction()
    {
        Debug.Log("Meu nome � *" + name + "*, tenho *" + life + "* de vida");
    }

    protected virtual void Move()
    {
        //MoveTowards(posi��o inicial, seguir Player, velocidade) -> fun��o para se mover em dire��o a algo
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
        //Time.deltaTime -> Identifica os fps e de acordo com essa inform��o equilibra a velocidade do inimigo
    }
    private void Update()
    {
        Move();
    }
}
