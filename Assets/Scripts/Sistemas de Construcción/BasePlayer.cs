using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    //INSTANCIAR UN OBJ = CONSTRUIR UNA BASE
    //Objetos dentro de la Base:
    //Declaraciones independientes e individuales

    // Start is called before the first frame update

    public ConstructorPlayer[]nuevoJugador;

    void Awake() 
    //AWAKE:Funciona un seg. antes que start
    {
        //Instanciacion = Inicialización
        nuevoJugador=new ConstructorPlayer[1];
        nuevoJugador[0]= new ConstructorPlayer (1,"Drake",40,12,8);
        



    }

    


}

