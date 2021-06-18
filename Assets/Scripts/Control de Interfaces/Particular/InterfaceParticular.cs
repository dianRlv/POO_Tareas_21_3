using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Tener acceso a la Interfaz de Usuario

public class InterfaceParticular : MonoBehaviour
{
public Text nombreTxT;
public Text vidaTxT;

public Text dañoAtTxT;

//JUGADOR INTERFAZ
Player playerData;

//ENEMIGO INTERFAZ
Enemy enemyData;

    // Start is called before the first frame update
    void Start()
    {
        //El "playerdata" va a leerme el componente incrustado en el padre, vinculado a "player"
        //GETCOMPONENTINPARENT= Limita la busqueda a elementos emparentados.
        playerData=GetComponentInParent<Player>();

        //ARRANCAR LA CORRUTINA
        StartCoroutine(AsignarDatosP(0.1f));


        //EnemIGO
        enemyData=GetComponentInParent<Enemy>();

        //ARRANCAR LA CORRUTINA
        StartCoroutine(AsignarDatosE(0.1f));
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AsignarDatosP (float waitTime){
        //Campo, regresame una nueva espera en segundos, donde... (Tiempo de espera)
        yield return new WaitForSeconds(waitTime); //Oh segundos (1.5f)
         //Los valores text se alimentan de cadenas de texto
        nombreTxT.text=playerData.Nombre;
        vidaTxT.text=playerData.Vida.ToString();
        dañoAtTxT.text=playerData.Ataque.ToString();
        /*Condicion 
        yield return new WaitUntil(); */

    }

    IEnumerator AsignarDatosE(float waitTime){
        yield return new WaitForSeconds(waitTime); //Oh segundos (1.5f)
        nombreTxT.text=enemyData.Nombre;
        vidaTxT.text=enemyData.Vida.ToString();
        dañoAtTxT.text=enemyData.Daño.ToString();
    }
}
