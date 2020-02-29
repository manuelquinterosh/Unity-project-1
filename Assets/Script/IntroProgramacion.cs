using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroProgramacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //Este If se encarga de cambiar el color del material del objeto al oprimir la tecla Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }



        //---------------------SINTAXIS----------------------------

        //----------------PRIMERO: COMENTARIOS----------------------

        //

        /*
         * 
         * 
         * */

        //----------------SEGUNDO: LOS PUNTOS-------------------------

        Debug.Log(this.transform.position.x);

        //-----------------TERCERO: PUNTO Y COMA------------------------

        //---------------------SINTAXIS----------------------------




        //---------------------VARIABLES-----------------------

        bool personajeMuerto = true;

        int CuarentaMillones = 40000000;

        float CuarentaMillonesComa32pesos = 40000000.32f;

        string FraseBrujaCabal = "EstudienVagos";

        string MiNombre = "Santiago";

        //---------------------VARIABLES EJEMPLOS-----------------------

        CuarentaMillones = CuarentaMillones + 1000000;

        Debug.Log(FraseBrujaCabal); //Hacer ejemplo de concatenar

        //---------------------VARIABLES-----------------------




        //---------------------OPERADORES UNITARIOS-----------------------

        /*

           ++
           --
           +=
           -=
           /=
           *=

        */

        //---------------------OPERADORES UNITARIOS-----------------------





        //---------------------OPERADORES lOGICOS Y RELACIONALES-----------------------

        //lOGICOS
        /*

          ||
          &&

        */

        //RELACIONALES
        /*

           <
           >
           ==
           <=
           >=
           !=

        */

        //---------------------OPERADORES lOGICOS Y RELACIONALES-----------------------




        //-----------------------ESTRUCTURAS DE CONDICIONES-------------------------

        //----------IF - ELSE IF - WHILE - FOR - FOREACH - SWITCH-------------------

        //-----------------------------IF---------------------------------- MARIO BROSS

        int vidaEnemigo = 100;
        bool estrellaDeMario = true;

        //El jugador golpea el enemigo y baja su vida a 10

        vidaEnemigo = 10;

        if (vidaEnemigo <= 0)
        {
            Debug.Log("El enemigo ha muerto");
        }

        //El jugador atrapa la estrella




        //-----------------------------WHILE - DO WHILE---------------------------------- ZELDA BOTW

        bool escudoActivo = true;

        while (escudoActivo)
        {
            Debug.Log("Oh has usado el escudo y no pierdes vida, ahora el escudo debe recuperarse");
            escudoActivo = false;
        }

        do
        {
            Debug.Log("Tienes el escudo activado");
        }
        while (escudoActivo);






        //-----------------------------FOR---------------------------------- CTR Nitro...

        int wumpasObtenidos = 0;

        for (wumpasObtenidos = 0; wumpasObtenidos < 10; wumpasObtenidos++)
        {
            Debug.Log("Acumulando Wumpas");
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Ejecutando FOR");
        }





        //-----------------------------FOREACH---------------------------------- Issac

        string nombrePersonaje = "Isaac";

        foreach(char letra in nombrePersonaje)
        {
            Debug.Log(letra);
        }




        //-----------------------------SWITCH---------------------------------- Resident Evil

        int numeroDeLlaves = 0;

        switch (numeroDeLlaves)
        {
            case 0:
                Debug.Log("Necesitas más llaves");
                break;

            case 1:
                Debug.Log("Puedes entrar por esta puerta");
                break;

            case 2:
                Debug.Log("Solo necesitas una llave, ¿quieres usar una de ellas para entrar?");
                break;
        }
    }
}

