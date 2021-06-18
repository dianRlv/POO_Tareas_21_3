using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    // Start is called before the first frame update

    public ConstructorEnemy[]nuevoEnemy;

    void Awake() 
    //AWAKE:Funciona un seg. antes que start
    {
        //Instanciacion = Inicialización
        nuevoEnemy=new ConstructorEnemy[1];
        nuevoEnemy[0]= new ConstructorEnemy (1,"Ghost",60,10);
        



    }

    


}
