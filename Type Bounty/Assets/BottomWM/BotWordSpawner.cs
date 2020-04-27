using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotWordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public BotWordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-.5f, 2.5f), Random.Range(-1f, 5f));

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        BotWordDisplay wordDisplay = wordObj.GetComponent<BotWordDisplay>();

        return wordDisplay;
    }
}
