using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    public void AbrirLink(string url)
    {
        Application.OpenURL(url);
    }
}
