using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Vector3  offset = new Vector3(0f, 0f, -10f);
    private float smoothtime = .25f;
    private Vector3 velocity = Vector3.zero;
    
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothtime);
    }
}
