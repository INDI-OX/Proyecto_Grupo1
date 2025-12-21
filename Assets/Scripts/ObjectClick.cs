using UnityEngine;

public class OneClickPlatform : MonoBehaviour
{
    public GameObject newObjectPrefab;
    public Vector2 spawnPosition;
    public Transform parentGroup;
    AudioSource audioSource;
    public AudioClip cajon;

    private bool isOpened = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if (isOpened) return;
        if (audioSource != null && cajon != null)
        {
            audioSource.PlayOneShot(cajon);
        }
        Invoke(nameof(Open), 0.3f);

        //Open();
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
