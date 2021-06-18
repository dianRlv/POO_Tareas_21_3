using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //ABSTRACCION ENEMIGO: DATOS
    public int EnemyId;
    public string Nombre;
    public float Vida;
    public float Daño;
   
    BaseEnemy bdEnemy;

    private void Start() {

        // INICIALIZAR OBJETOS
        bdEnemy = GameObject.FindObjectOfType<BaseEnemy>();

        CargarDatos(EnemyId);
        //La variable ("") será la que asigne datos a "cargar datos"
        }

        //ALGORITMO DE BUSQUEDA (Enemigo)
        void CargarDatos(int id){
            for (int i = 0; i < bdEnemy.nuevoEnemy.Length; i++) 
            {   
                if (bdEnemy.nuevoEnemy[i].EnemyId==id)
                {
                    //Este algoritmo de busqueda me asignará los valore de nombre, vida y velocidad.
                    this.Nombre=bdEnemy.nuevoEnemy[i].Nombre;
                    this.Vida=bdEnemy.nuevoEnemy[i].Vida;
                    this.Daño=bdEnemy.nuevoEnemy[i].Daño;
    
                }
                
            }
        }
    }
