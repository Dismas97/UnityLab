using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject target;
    private GameObject[] hijos;
	public static int libres = -1;

	void Start()
    {
        hijos = new GameObject[gameObject.transform.childCount];
		if (libres == -1){
			libres = 0;
		}
        libres += hijos.Length;
        for (int i = 0; i < hijos.Length; i++){
            hijos[i] = gameObject.transform.GetChild(i).gameObject;
            SelectorEspecie aux = hijos[i].AddComponent<SelectorEspecie>();
            aux.target = target.transform.GetChild(i).gameObject.transform;
        }
    }
}
