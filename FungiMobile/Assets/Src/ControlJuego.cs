using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    [SerializeField]
	private GameObject texto;

    void Start()
    {
        texto.SetActive(false);
    }

    // Update is called once per frame
    
    void Update()
    {
        if(Puzzle.libres == 0){
			texto.SetActive(true);
		}
    }
}
