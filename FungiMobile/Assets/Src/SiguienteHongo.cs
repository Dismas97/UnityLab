using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteHongo : MonoBehaviour
{
    private Queue<GameObject> hijos = new Queue<GameObject>();
    public GameObject target;

    void Start()
    {
        int cant = target.transform.childCount;
        GameObject auxiliar = null;
        for (int i = 0; i < cant; i++){
            auxiliar = target.transform.GetChild(i).gameObject;
            hijos.Enqueue(auxiliar);
            if(i > 0){
                auxiliar.SetActive(false);
            }
        }
    }

    public void Siguiente(){
        GameObject auxiliar = null;
        auxiliar = hijos.Dequeue();
        auxiliar.SetActive(false);
        hijos.Enqueue(auxiliar);
        auxiliar = hijos.Peek();
        auxiliar.SetActive(true);
    }
}
