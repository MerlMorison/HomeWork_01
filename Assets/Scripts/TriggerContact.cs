using UnityEngine;

public class TriggerContact : MonoBehaviour
{
    [SerializeField] private GameObject ChoseEnemy;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ChoseEnemy)
        {
            Debug.Log("Triggered!");
        }
    }
}
