using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject daggerPrefab;


    private void FixedUpdate()
    {
        transform.position += new Vector3(-speed,0,0);

        if(transform.position.x <= -11f) {
            transform.position = new Vector3(9.5f, -2.6f, 0f);
            Instantiate(daggerPrefab, new Vector3(4.7f, -0.9f, 0f), Quaternion.identity);
        }
    }
}
