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
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        // += 0.01
        MovePlayer();
    }

    void PrintInstructions() { 
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys!");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer() { 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
