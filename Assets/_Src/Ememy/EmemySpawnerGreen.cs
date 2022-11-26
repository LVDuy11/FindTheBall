using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmemySpawnerGreen : MonoBehaviour
{
    protected GameObject ememy;
    protected List<GameObject> emenySpawn;

    float timer = 0;
    float delay = 1f;
    private void Awake()
    {
        this.ememy = GameObject.Find("EmemyGreen");
        this.ememy.SetActive(false);
        this.emenySpawn = new List<GameObject>();
    }

    private void Update()
    {
        this.Spawn();
        this.EmemyDead();
    }

    public virtual void Spawn()
    {
        if (this.emenySpawn.Count > 0) return;

        this.timer += Time.deltaTime;
        if (this.timer < this.delay) return;
        this.timer = 0;

        Vector3 spanwPos = new Vector3(Random.Range(0,501), 30, Random.Range(0,501));
        GameObject emenySpawner = Instantiate(this.ememy, spanwPos, Quaternion.identity);
        emenySpawner.SetActive(true);
        emenySpawn.Add(emenySpawner);
    }

    public virtual void EmemyDead()
    {
        GameObject ememyCheck;
        for (int i = 0; i < emenySpawn.Count; i++)
        {
            ememyCheck = this.emenySpawn[i];
            if(ememyCheck == null) this.emenySpawn.RemoveAt(i);
        }
    }
}
