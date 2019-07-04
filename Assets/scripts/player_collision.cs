using UnityEngine;

public class player_collision : MonoBehaviour
{
    public Player_movement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            Debug.Log("We Hit something");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
 