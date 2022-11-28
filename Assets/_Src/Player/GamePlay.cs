using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public Material[] materials;
    Renderer renderers;

    GameManager gameManager;

    private void Start()
    {
        this.renderers = GetComponentInParent<Renderer>();
        this.renderers.enabled = true;
        this.renderers.sharedMaterial = materials[Random.Range(0,3)];
        this.gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("EmemyRed") && this.renderers.sharedMaterial == this.materials[0])
        {
            this.renderers.sharedMaterial = this.materials[Random.Range(0, 3)];
            gameManager.IncrementScore();
            //Debug.Log("True");
            this.CheckWin();
        }
        else if (other.gameObject.CompareTag("EmemyGreen") && this.renderers.sharedMaterial == this.materials[1])
        {
            this.renderers.sharedMaterial = this.materials[Random.Range(0, 3)];
            gameManager.IncrementScore();
            //Debug.Log("True");
            this.CheckWin();
        }
        else if (other.gameObject.CompareTag("EmemyBlue") && this.renderers.sharedMaterial == this.materials[2])
        {
            this.renderers.sharedMaterial = this.materials[Random.Range(0, 3)];
            gameManager.IncrementScore();
            //Debug.Log("True");
            this.CheckWin();
        }

        else if (other.gameObject.CompareTag("Terrain"))
        {
            //Debug.Log("Nem");
        }

        else if (other.gameObject.CompareTag("Trigger"))
        {
            //Debug.Log("Nem");
        }

        else
        {
            UIManager.instance.ShowGameOver(true);
            //Debug.Log(other.gameObject.ToString());
        }      
    }

    protected virtual void CheckWin()
    {
        if (gameManager.Score == 10)
        {
            UIManager.instance.ShowWinGame(true);
            Debug.Log("Win");
        }
    }
}
