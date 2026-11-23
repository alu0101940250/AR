using UnityEngine;
using UnityEngine.SceneManagement;

public class spiderBehav : MonoBehaviour
{
    private bool hit = false;
    private void OnTriggerEnter(Collider other)
    {
        if (hit) return;

        if (other.CompareTag("Player"))
        {
            hit = true;

            score.Instance.AddPoints(-1);

            respawn spawner = FindAnyObjectByType<respawn>();
            if (spawner != null)
            {
                spawner.SpiderDestroyed();
            }

            Destroy(gameObject);
        }
    }
}
