using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public static int DeathCount { get; private set; }

    private Vector3 spawnPosition;
    private Rigidbody2D rb;

    private void Awake()
    {
        spawnPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Respawn()
    {
        DeathCount++;

        transform.position = spawnPosition;
        rb.linearVelocity = Vector2.zero;
    }

    public static void ResetDeathCount()
    {
        DeathCount = 0;
    }
}