using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Especie : MonoBehaviour
{
    public Transform target; 

    private bool bloqueado;
    
    private Vector2 origen;

    private float dX, dY;    

    void Start()
    {
        origen = transform.position;
    }

    public void Reset(){
		transform.position = origen;
		bloqueado = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.touchCount > 0 && !bloqueado){
			Touch touch = Input.GetTouch(0);
			Vector2 t_pos = Camera.main.ScreenToWorldPoint(touch.position);
			switch(touch.phase){
				case TouchPhase.Began:
					if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(t_pos)){
						dX = t_pos.x - transform.position.x;
						dY = t_pos.y - transform.position.y;						
					} break;
					
				case TouchPhase.Moved:
					if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(t_pos)){
						transform.position = new Vector2(t_pos.x - dX, t_pos.y - dY);
					} break;
					
				case TouchPhase.Ended:
					if (Mathf.Abs(transform.position.x - target.position.x)<= 0.5f &&
						Mathf.Abs(transform.position.y - target.position.y)<= 0.5   ){
						transform.position = new Vector2(target.position.x, target.position.y);
						bloqueado = true;
						Puzzle.libres -=1;
					}
					else{
						transform.position = new Vector2(origen.x,origen.y);
					} break;
			}
		}
    }
}
