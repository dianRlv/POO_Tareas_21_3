using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Player : ConstructorPlayer (HERENCIA Y ENCAPSULAMIENTO)
public class Player : MonoBehaviour
{ 
    //ABSTRACCION JUGADOR: DATOS

    public int PlayerId;
    public string Nombre;
    public float Vida;
    public float Ataque;
    public float Sigilo;

    BasePlayer bdJugador;

    private void Start() {

        //FORMA INICIALIZAR OBJETOS UNICOS
        bdJugador = GameObject.FindObjectOfType<BasePlayer>();

        CargarDatos(PlayerId);
        //La variable ("") será la que asigne datos a "cargar datos"

        }


        //ALGORITMO DE BUSQUEDA
        void CargarDatos(int id){
            for (int i = 0; i < bdJugador.nuevoJugador.Length; i++) //Cuerpo de la lectura
            //Quiero que mientras i sea - a la cantidad de obj en base de jugador, leas la asignación de valores
            {
                //si bd.. en su base nuevo j, en el recorrido de i en playerid == al valor del parametro ...
                
                if (bdJugador.nuevoJugador[i].PlayerId==id)
                {
                    //Este algoritmo de busqueda me asignará los valore de nombre, vida y velocidad.
                   this.Nombre=bdJugador.nuevoJugador[i].Nombre;
                    this.Vida=bdJugador.nuevoJugador[i].Vida;
                    this.Ataque=bdJugador.nuevoJugador[i].Ataque;
                    this.Sigilo=bdJugador.nuevoJugador[i].Sigilo; 
                }
                
            }
        }
    }
