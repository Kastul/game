using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject DogmaNoktasi;
    public GameObject VarisNoktasi;
    public int AnlikKarakterSayisi = 1;
    public List<GameObject> Karakterler;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))

            foreach (var item in Karakterler)
            {
                //  object pooling

                if (!item.activeInHierarchy)
                {
                    item.transform.position = DogmaNoktasi.transform.position;
                    item.SetActive(true);
                    AnlikKarakterSayisi++;
                    break;
                }
            }
    }
}

