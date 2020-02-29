using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroProgramacion2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //------------------------ARREGLOS------------------------- Almacenamiento de armas
            int[] listaDeArmas = { 1, 5, 7, 9, 145, -10 };
            Debug.Log("El arma en la posición 1 de la lista es: " + listaDeArmas[1]);
            Debug.Log("El arma en la posición 4 de la lista es: " + listaDeArmas[4]);

            foreach (int arma in listaDeArmas)
            {
                Debug.Log("El arma en la posición 1 de la lista es: " + arma);
            }

            //------------------------LISTAS------------------------- Almacenamiento de armas 

            List<int> idEnemigos = new List<int>();

            idEnemigos.Add(19);
            idEnemigos.Add(6);
            idEnemigos.Add(12);

            Debug.Log(idEnemigos.Count);
        }

        moverPlayerLados();
        moverPlayerArribaAbajo();
    }

    //------------------------METODOS-------------------------------

    public float velocidad = 10f;

    public void moverPlayerLados()
    {
        float moverLados = Input.GetAxis("Horizontal") * velocidad;
        this.transform.position = new Vector3(moverLados, this.transform.position.y, this.transform.position.z);
    }

    public void moverPlayerArribaAbajo()
    {
        float moverArribaAbajo = Input.GetAxis("Vertical") * velocidad;
        this.transform.position = new Vector3(this.transform.position.x, moverArribaAbajo, this.transform.position.z);
    }
}
