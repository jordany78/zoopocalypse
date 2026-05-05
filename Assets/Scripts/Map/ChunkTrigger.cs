using UnityEngine;

public class ChunkTrigger : MonoBehaviour
{
    MapController mc;
    public GameObject targetMap;

    void Start()
    {
        mc = FindFirstObjectByType<MapController>();
    }

    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            mc.currentChunk = targetMap;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(mc.currentChunk = targetMap)
            {
                mc.currentChunk = null;
            }
        }
    }
}
