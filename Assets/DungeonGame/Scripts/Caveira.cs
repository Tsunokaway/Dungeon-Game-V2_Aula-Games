using UnityEngine;


/*
 POOS(Heran�a) -> ":Enemy", vai herdar todas as vari�veis do script Enemy, especificando apenas algumas caracter�sticas sem a necessidade de fazer novamente os mesmos 
                    c�digos.
 
 */
public class Caveira:Enemy
{
    protected override void Introduction()
    {
        base.Introduction();
        Debug.Log("Outra fase");
    }
}
