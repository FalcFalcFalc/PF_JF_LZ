using UnityEngine;
using System.Collections;

public class Casilla : MonoBehaviour {

    public Material colorCasilla;
    public int numCasilla;
    void OnMouseDown()
    {
        print(numCasilla.ToString());
    }

   public void PonerColor(Material color)
    {
        GetComponent<MeshRenderer>().material = color;
    }
}
