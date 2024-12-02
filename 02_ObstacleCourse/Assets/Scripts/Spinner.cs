using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0.5f;
    [SerializeField] float zAngle = 0;
    void Start () {
        if (this.gameObject.tag == "360") {
            xAngle = 3;
            yAngle = 3;
            zAngle = 3;
        }
    }
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
