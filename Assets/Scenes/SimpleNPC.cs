using UnityEngine;

public class SimpleNPC : MonoBehaviour
{
    public Transform player;
    public float chaseDistance = 6f;
    public float moveSpeed = 2f;
    public bool enableDebug = false;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (enableDebug)
            Debug.Log(distance);

        if (distance <= chaseDistance)
        {
            Vector3 lookPos = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(lookPos);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}