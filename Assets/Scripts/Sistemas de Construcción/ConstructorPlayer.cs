using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ConstructorPlayer
//Al momento de quitarle la herencia "monobehaviour" se convierte en una clase tradicional de C#
{
    //Los contructores no requieren "Start" ni "Update"
    //Atributos o Propiedades
    // + = Público 
    // - = Privado

    // [SerializeField], se ve en el inspector sin ser público.

    //Características y Atributos del Player
    public int PlayerId;
    public string Nombre;
    public float Vida;
    public float Ataque;
    public float Sigilo;


    //Métodos y Comportamientos

    //MÉTODO CONSTRUCTOR
    public ConstructorPlayer (int id, string n, float vida, float ata, float sig){
        //Al constructor se le darán parámetros para poder asignar argumentos ()
        //PARÁMETROS:Elementos que me van a pedir los métodos para poder hacer funcionar su acción / evento

        this.PlayerId=id;
        this.Nombre=n;
        this.Vida=vida;
        this.Ataque=ata;
        this.Sigilo=sig;


    }

}