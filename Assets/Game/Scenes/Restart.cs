using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{
    [SerializeField] private int _scene;
    public void RestartScene()
    {
        SceneManager.LoadScene(_scene);
    }
}
