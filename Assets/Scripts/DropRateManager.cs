using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using static DropRateManager;

public class DropRateManager : MonoBehaviour
{
    [System.Serializable]
    public class Drops
    {
        public string name;
        public GameObject itemPrefab;
        public float dropRate;

    }
    public List<Drops> drops;

    void OnDestroy()
    {
        float randomNum = UnityEngine.Random.Range(0f, 100f);
        List<Drops> possibleDrops = new List<Drops>();

        foreach (Drops rate in drops)
        {
            if (randomNum <= rate.dropRate)
            {
                possibleDrops.Add(rate);
            }
        }

        if(possibleDrops.Count > 0)
        {
            Drops drop = possibleDrops[UnityEngine.Random.Range(0, possibleDrops.Count)];
            Instantiate(drop.itemPrefab, transform.position, Quaternion.identity);
        }
    }
}
