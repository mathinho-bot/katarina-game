using UnityEngine;

public class Dagger : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] private float speed;
    private void FixedUpdate() {
        transform.position += new Vector3(-speed, 0, 0);
        if(transform.position.x <= -5f) Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            other.gameObject.GetComponent<PlayerController>().points++;
            Destroy(gameObject);
            Debug.Log(other.gameObject.GetComponent<PlayerController>().points);
        }
    }
}
