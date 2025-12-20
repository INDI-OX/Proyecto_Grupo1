using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public Image uiItemImage;
    public Sprite itemSprite;
    private Animator animator;

    int brillo = 0;
    public float tiempo = 0f;
    private bool picked = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        tiempo = Time.time;
        if (tiempo >= 1f)
        {
            brillo = 1 - brillo;
            tiempo = 0f;
        }
    }
    private void Reset()
    {
        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
            col.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (picked) return;

        if (collision.CompareTag("Player"))
        {
            picked = true;

            if (uiItemImage != null && itemSprite != null)
            {
                uiItemImage.sprite = itemSprite;
                uiItemImage.enabled = true;
            }

            Destroy(gameObject);
        }
    }
}
