using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 3f;
    [SerializeField] private float heightrange = 3f;
    [SerializeField] private GameObject _pipe;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            PipeSpawn();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void PipeSpawn()
    {
        Vector3 spawnPosition = transform.position + new Vector3 (15, Random.Range(-heightrange, heightrange), -9);
        GameObject pipe = Instantiate(_pipe, spawnPosition, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
