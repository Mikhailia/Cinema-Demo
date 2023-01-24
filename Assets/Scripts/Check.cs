using System;
using System.IO.MemoryMappedFiles;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    public string Name;
    public string Rad;
    public string PointVRad;
    public Text mName;
    public Text RAd;
    public Text PinRad;

    public void SpawnWhatiNeed(GameObject objPrefab)
    {
        Instantiate(objPrefab);
    }

    public void NameChange(string movieName)
    {
        Name = movieName;
    }

    public void RadChange(string BB)
    {
        Rad = BB;
    }

    public void PointVRadChange(string BC)
    {
        PointVRad = BC;
    }

    void Update()
    {
        mName.text = Name;
        RAd.text = Rad;
        PinRad.text = PointVRad;
    }
}
