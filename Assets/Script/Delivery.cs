using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [Header("Collision")]
    [Tooltip("Destroy delay time")] [SerializeField] private float m_destroyDelay = 0.2f;
    [Tooltip("Color code when vehicle has witness")] [SerializeField] private Color32 m_hasWitnessColor = new Color32(217, 38, 38, 255);
    [Tooltip("Color code when vehicle doesn't have witness")] [SerializeField] private Color32 m_noWitnessColor = new Color32(255, 255, 255, 255);

    private bool _hasWitness;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("oh My God! What have done!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Witness" && !_hasWitness)
        {
            Debug.Log("Witness is picked up");
            _hasWitness = true;
            _spriteRenderer.color = m_hasWitnessColor;
            Destroy(other.gameObject, m_destroyDelay);
        }
        if(other.tag == "SafePlace" && _hasWitness)
        {
            Debug.Log("Witness is deliveried to safe house");
            _hasWitness = false;
            _spriteRenderer.color = m_noWitnessColor;
        }
    }

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    Debug.Log("What is that!");
    //}
}
