using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private bool inFloor;
    [SerializeField] private Animator animController;
     private const string jumpTrigger = "Jump";
     private bool isJumping;
     [SerializeField]private float jumpForce;
     [SerializeField] private Rigidbody rb;
     public int points = 0;
     [SerializeField] private TextMeshProUGUI scoreText;
     [SerializeField] private GameObject goCanvas;
     [SerializeField] private TextMeshProUGUI jumpText;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && inFloor && !isJumping) {
            animController.SetTrigger(jumpTrigger);
            isJumping = true;
            Jump();
            if(jumpText.text != "") jumpText.text = "";
        }

        scoreText.text = points.ToString();

        if(transform.position.y <= -3.5f) GameOver();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("floor")) {
            inFloor = true;
            isJumping = false;
        } 
    }

    private void Jump() {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void GameOver() {
        goCanvas.SetActive(true);
        
    }

}
