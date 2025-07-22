using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int depth = 20; //depth of the terrain
    public int width = 256; //width of the terrain
    public int height = 256; //height of the terrain
    public float scale = 20f; //the noise scale 

    void Start()
    {
        Terrain terrain = GetComponent<Terrain>(); //get the terrain component  
        terrain.terrainData = GenerateTerrain(terrain.terrainData); //generate terrain
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);
        terrainData.SetHeights(0, 0, GenerateHeights());
        return terrainData;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                heights[x, y] = CalculateHeight(x, y);
            }
        }
        return heights;
    }

    float CalculateHeight(int x, int y)
    {
        float xCoord = (float)x / width * scale;
        float yCoord = (float)y / height * scale;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
