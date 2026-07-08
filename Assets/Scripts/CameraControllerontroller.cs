using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 offset;

    void Start()
    {
        if (player == null)
        {
            var playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj == null)
            {
                Debug.LogWarning("CameraController: No GameObject with tag 'Player' found.");
                return;
            }
            player = playerObj.transform;
        }

        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        if (player == null) return;
        transform.position = player.position + offset;
    }
}
