using UnityEngine;

public class TestTriggerEnter : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ASDA");

        if (other.gameObject.tag == "Player")
            AudioManager.instance.PlayOneShot(FModEvents.instance.test, transform.position);
    }
}
