using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float yValue = 0f;
    [SerializeField] float moveSpeed = 1f;


    void Start()
    {
        PrintInstructions();
    }
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * moveSpeed * Time.deltaTime, yValue, zValue * moveSpeed * Time.deltaTime);
    }
}
