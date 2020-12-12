using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Replay : MonoBehaviour
{
    public GameObject respawm;
    void ReplayLevel(Collider2D other)
    {

        other.tag = "Player";
        other.transform.position = respawm.transform.position;
    }
}
