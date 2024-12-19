using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollisionSc : MonoBehaviour
{
    public int n = 10;
    public Text txt;
    public void OnCollisionEnter(Collision collision)
    {
        n--;
        txt.text = n.ToString();
    }
}
