using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorEspecie : MonoBehaviour
{
    public Transform target;
    private GameObject[] hijos;

    void Start()
    {

		hijos = new GameObject[gameObject.transform.childCount];
		int rInt = Random.Range(0, hijos.Length);
		
        for (int i = 0; i < hijos.Length; i++){
			hijos[i] = gameObject.transform.GetChild(i).gameObject;
			hijos[i].SetActive(false);
	    }
		hijos[rInt].SetActive(true);
		hijos[rInt].AddComponent<BoxCollider2D>();
		Especie aux = hijos[rInt].AddComponent<Especie>();
		aux.target = target;
    }
}
