
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform plr;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = plr.position+ offset;
    }
}
