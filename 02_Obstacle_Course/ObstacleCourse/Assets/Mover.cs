using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform.Translate(0.01f, 0, 0); --> Di chuyển một lần lúc ban đầu
    }

    // Update is called once per frame
    void Update()
    {
        // += 0.01
        transform.Translate(0.01f, 0, 0);
    }
}
