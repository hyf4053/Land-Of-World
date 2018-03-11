using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GetHexInfo : MonoBehaviour {

    // HexMesh hexMesh;
   // HexCell cell;

    public HexGrid hexGrid;
    public HexMapEditor hexMapEditor;
    public HexCoordinates currentHexCoordinates;
    public HexCell currentHexCell;
    public string color;
    public int elevation;


    private void Awake()
    {
        hexGrid = hexGrid.GetComponent<HexGrid>();
        hexMapEditor = hexMapEditor.GetComponent<HexMapEditor>();
    }

    private void Update()
    {
        //hexMapEditor = hexMapEditor.GetComponent<HexMapEditor>();
        if (
        Input.GetMouseButton(0) &&
        !EventSystem.current.IsPointerOverGameObject()
    )
        {
            currentHexCoordinates =  hexMapEditor.HandleInput(1);
            Debug.Log(currentHexCoordinates.ToString());
            GetHexGridInfo();
        }
    }

    public void GetHexGridInfo()
    {
        currentHexCell = hexGrid.GetCell(currentHexCoordinates);
       color = currentHexCell.color.ToString();
    }

}
