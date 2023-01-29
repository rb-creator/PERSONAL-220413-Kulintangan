using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableFloor : MonoBehaviour
{
    [SerializeField] private GameObject _grid;
    [SerializeField] private bool _gridActive = true;

    public void ToggleGrid()
    {
        if (_gridActive)
        {
            _grid.SetActive(false);
            _gridActive= false;
        }
        else
        {
            _grid.SetActive(true);
            _gridActive = true;
        }
    }
}
