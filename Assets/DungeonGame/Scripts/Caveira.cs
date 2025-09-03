using UnityEngine;


/*
 POOS(Herança) -> ":Enemy", vai herdar todas as variáveis do script Enemy, especificando apenas algumas características sem a necessidade de fazer novamente os mesmos 
                    códigos.
 
 */
public class Caveira:Enemy
{
    protected override void Introduction()
    {
        base.Introduction();
        Debug.Log("Outra fase");
    }
}
