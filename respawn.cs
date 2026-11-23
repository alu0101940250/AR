using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class respawn : MonoBehaviour
{
    public DrivingSurfaceManager DrivingSurfaceManager;
    public GameObject SpiderPrefab;
    private GameObject currentSpider;

    private void Update()
    {
        ARPlane lockedPlane = DrivingSurfaceManager.LockedPlane;

        if (lockedPlane != null && currentSpider == null)
        {
            SpawnSpider(lockedPlane);
        }
    }

    private void SpawnSpider(ARPlane plane)
    {
        currentSpider = Instantiate(SpiderPrefab);

        currentSpider.transform.position =
            PackageSpawner.FindRandomLocation(plane);
    }

    public void SpiderDestroyed()
    {
        currentSpider = null;
    }
}
