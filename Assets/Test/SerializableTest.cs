using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializableTest : MonoBehaviour
{
    public serializableClass serializableTest;
    void Start()
    {
        this.serializableTest = new serializableClass("xiba");
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "Serializable"))
        {
            string filename = Application.dataPath + "/Resources/serializable.dat";
            Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);

            //创建二进制序列化器
            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fStream, this.serializableTest);
            fStream.Close();

            this.serializableTest.name = "猪皮骚";
            Debug.Log("the class name is :" + this.serializableTest.name);
        }

        if (GUI.Button(new Rect(300, 10, 150, 100), "Deserialize"))
        {
            string filename = Application.dataPath + "/Resources/serializable.dat";
            Stream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            this.serializableTest = binaryFormatter.Deserialize(fStream) as serializableClass;

            fStream.Close();
            Debug.Log("after Deserilizable the class name is :" + this.serializableTest.name);
        }
    }
}