using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private string playerName = "Undefined";

    void Start()
    {
        Debug.Log($"I'm alive! Nice to meet you! My name is {playerName}.");
    }
}
