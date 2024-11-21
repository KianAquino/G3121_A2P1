using UnityEngine;

public class Bounce : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerControllerX player = collision.gameObject.GetComponent<PlayerControllerX>();
            player.Fly();
            collision.gameObject.GetComponent<AudioSource>().PlayOneShot(player.bounceSound);
        }
    }
}
