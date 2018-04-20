using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CrearCasillas : MonoBehaviour {

    public GameObject CasillaPrefab;
    public int ancho, alto;
    public Material Blanco, Negro;
    private int cont = 0;
    
	public void Crear() {
        for (int i = 0; i <= ancho; i++)
        {
            for (int k = 0; k <= alto; k++)
            {
                if ((i + k) % 2 == 0)
                {
                    CasillaPrefab.GetComponent<Casilla>().PonerColor(Blanco);
                }
                else
                {
                    CasillaPrefab.GetComponent<Casilla>().PonerColor(Negro);
                }
                CasillaPrefab.GetComponent<Casilla>().numCasilla = cont++;

                GameObject casillaTemp = Instantiate(CasillaPrefab, new Vector3(i, k, 0),new Quaternion(0, -90, 90, 0)) as GameObject;
               }
        }
    }
}
