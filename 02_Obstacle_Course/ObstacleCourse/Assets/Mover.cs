using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    // these variables change our movement speed
    // [SerializeField] float xValue = 0;
    // [SerializeField] float yValue = 0.02f;
    // [SerializeField] float zValue = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float moveSpeed = 8f;
    void Start()
    {
        // transform.Translate(0.01f, 0, 0); --> Di chuyển một lần lúc ban đầu
    }

    // Update is called once per frame
    void Update()
    {
        // += 0.01
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")   * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
