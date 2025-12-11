using UnityEngine;

public class OneClickPlatform : MonoBehaviour
{
    public GameObject newObjectPrefab;
    public Vector2 spawnPosition;
    public Transform parentGroup;

    private bool isOpened = false;

    void OnMouseDown()
    {
        if (isOpened) return;
        Open();
    }

    void Open()
    {
        isOpened = true;

        Vector3 worldPos = new Vector3(spawnPosition.x, spawnPosition.y, transform.position.z);

        Quaternion rotation = newObjectPrefab.transform.rotation;

        Instantiate(newObjectPrefab, worldPos, rotation, parentGroup);

        Destroy(gameObject);
    }
}
