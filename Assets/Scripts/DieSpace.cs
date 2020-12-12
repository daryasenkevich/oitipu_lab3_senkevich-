using UnityEngine;

public class DieSpace : MonoBehaviour
{
    public GameObject respawm;
  void OnTriggerEnter2D(Collider2D other)
    {
if (other.tag == "Player")
        {
            other.transform.position = respawm.transform.position;
        }
    }
}
