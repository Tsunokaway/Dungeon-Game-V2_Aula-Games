using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

/*
 Herança -> ":MonoBeahviour" da própria Unity, porém é possivel
 
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
         No método Start(), deve ser definido a vida no começo do jogo.
         */
        life = maxLife;
        Introduction();

    }

    /*
     Para poder acesar esse método em outro script, é necessário o "protected virtual"
     */
    protected virtual void Introduction()
    {
        Debug.Log("Meu nome é *" + name + "*, tenho *" + life + "* de vida");
    }

    protected virtual void Move()
    {
        //MoveTowards(posição inicial, seguir Player, velocidade) -> função para se mover em direção a algo
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
        //Time.deltaTime -> Identifica os fps e de acordo com essa informção equilibra a velocidade do inimigo
    }
    private void Update()
    {
        Move();
    }
}
