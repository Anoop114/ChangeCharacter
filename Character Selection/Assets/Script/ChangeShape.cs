using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape : MonoBehaviour
{
    public GameObject[] Shapes;
    public float speed;
    private GameObject currentActiveGameObject = null;
    Vector3 rot = Vector3.zero;
    Quaternion rotate = new Quaternion();
    public void ChangeShapeBtnClick(int _index)
    {
        Shapes[_index].SetActive(true);
        currentActiveGameObject = Shapes[_index];
        for (int i = 0; i < Shapes.Length; i++)
        {
            if (i == _index)continue;
            Shapes[i].SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        if(currentActiveGameObject != null)
        {
            rot = currentActiveGameObject.transform.eulerAngles;
            rot.y += speed * Time.deltaTime;
            rotate.eulerAngles = rot;
            currentActiveGameObject.transform.rotation = rotate;
        }
    }
}
