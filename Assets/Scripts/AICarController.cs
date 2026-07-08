using UnityEngine;

public class AICarController : MonoBehaviour
{
    [SerializeField]
    float aispeed = 30f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * aispeed * Time.deltaTime);
    }
}
