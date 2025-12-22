using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public Image uiItemImage;
    public Sprite itemSprite;
    AudioSource audioSource;
    public AudioClip papel;
    //private Animator animator;

    //int brillo = 0;
    //public float tiempo = 0f;
    private bool picked = false;
    public static int papeles_obt = 0;
    public static int interaccion = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //animator = GetComponent<Animator>();
    }
    /*private void Update()
    {
        tiempo = Time.time;
        if (tiempo >= 1f)
        {
            animator.SetInteger("Brillo", 1);
            brillo = 1 - brillo;
            tiempo = 0f;
        }
        else
        {
            animator.SetInteger("Brillo", 0);
        }
    }*/
    private void Reset()
    {
        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
            col.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (picked) return;

        if (audioSource != null && papel != null)
        {
            audioSource.PlayOneShot(papel);
        }

        if (collision.CompareTag("Player"))
        {
            interaccion++;
            papeles_obt++;
            picked = true;

            if (uiItemImage != null && itemSprite != null)
            {
                uiItemImage.sprite = itemSprite;
                uiItemImage.enabled = true;
            }

            Destroy(gameObject,0.3f);
        }
    }
}
