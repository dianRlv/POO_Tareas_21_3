using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorEnemy
{
    public int EnemyId;
    public string Nombre;
    public float Vida;
    public float Daño;

    //Métodos y Comportamientos
        public ConstructorEnemy (int id, string n, float vida, float da){
        //El Constructor se le darán parámetros-----> asignar argumentos ()
        this.EnemyId=id;
        this.Nombre=n;
        this.Vida=vida;
        this.Daño=da;
    
    }
}
