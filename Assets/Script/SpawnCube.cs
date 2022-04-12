using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject _prefabsCube;
    public bool _isSpawn;
    public Camera _camera;
    private void Update()
    {
        if (!_isSpawn) return;
        Spawn();
    }
    void Spawn()
    {
        Instantiate(_prefabsCube, RandomPos(), Quaternion.identity);
    }
    public Vector3 RandomPos()
    {
        float camWidth = _camera.pixelWidth;
        float camHeight = _camera.pixelHeight;
        float camX = _camera.WorldToScreenPoint(_camera.transform.position).x;
        float camY = _camera.WorldToScreenPoint(_camera.transform.position).y;

        float x = Random.Range(camX - (camWidth / 2), camX + (camWidth / 2));
        float y = Random.Range(camY - (camHeight / 2), camX + (camWidth / 2));

        return new Vector3(x, y);
    }
}
