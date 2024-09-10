using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpriteMask : MonoBehaviour
{
    public GameObject lupa;
    
    void Start(){
        lupa.transform.position = new Vector3(0,0,0);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 t_pos = touch.position;
            Vector3 final_pos = Camera.main.ScreenToWorldPoint(t_pos);
            final_pos.z = 0;
            final_pos.x -= 0.3f;
            
            final_pos.y += 0.25f;
            lupa.transform.position = final_pos;
            Debug.Log(lupa.transform.position);
        }
    }
}
