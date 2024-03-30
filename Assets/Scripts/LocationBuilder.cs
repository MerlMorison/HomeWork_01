using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    [SerializeField] private Material playerMaterial;
    [SerializeField] private Material enemyMaterial;


    void Awake()
    {
        PlayerData();
        EnemyData();

    }
    private void PlayerData()
    {
        player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        player.transform.position = new Vector3(-1f, 4f, 0f);
        player.name = "Player";
        player.AddComponent<BoxCollider>();
        player.AddComponent<Rigidbody>();
        player.AddComponent<PlayerMovement>();
        player.AddComponent<TriggerContact>();

        Renderer playerRenderer = player.GetComponent<Renderer>();
        playerRenderer.material = playerMaterial;
    }
    private void EnemyData()
    {
        enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
        enemy.transform.position = new Vector3(1f, 4f, 0f);
        enemy.name = "Enemy";
        enemy.AddComponent<BoxCollider>();

        enemy.AddComponent<Rigidbody>();
        Rigidbody enemyRb = enemy.GetComponent<Rigidbody>();
        enemyRb.drag = 5f;

        Renderer enemyRenderer = enemy.GetComponent<Renderer>();
        enemyRenderer.material = enemyMaterial;
    }
}


