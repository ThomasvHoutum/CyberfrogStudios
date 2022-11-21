using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonController : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject lights;
    [SerializeField] GameObject text;

    [SerializeField] GameObject spawnDoor;
    [SerializeField] GameObject arena1Door1;
    [SerializeField] GameObject arena1Door2;

    [SerializeField] Transform enemyRotation;

    [SerializeField] Vector3 playerPosArena1;
    [SerializeField] Vector3 playerPosArena2;
    [SerializeField] Vector3 playerPosVault;

    [SerializeField] Vector3 camPosArena1;
    [SerializeField] Vector3 camPosVault;

    Vector3 enemySpawnPos1 = new Vector3(-77.91f, 1.61f, 19.7f);
    Vector3 enemySpawnPos2 = new Vector3(-86.7f, 1.61f, 11.3f);

    public int killCounter;

    public int waveNumber;
    
    void Update()
    {
        if (killCounter == 4 && waveNumber == 1)
        {
            StartCoroutine("WaveOver");
            killCounter = 0;
        }
        if (killCounter == 8 && waveNumber == 2)
        {
            StartCoroutine("WaveOver");
            killCounter = 0;
        }
    }

    public void NextRoom(int roomID)
    {
        // First Arena
        if (roomID == 1)
        {
            Player.transform.position = playerPosArena1;

            mainCamera.transform.position = camPosArena1;

            if(mainCamera.transform.position == camPosArena1)
            {
                StartCoroutine("StartWave");
            }
        }
        if (roomID == 2)
        {
            Player.transform.position = playerPosArena2;

            StartCoroutine("StartWave");
        }

        // Vault
        if(roomID == 5)
        {
            Player.transform.position = playerPosVault;

            mainCamera.transform.position = camPosVault;

            text.GetComponent<VictoryBlink>().StartCoroutine("Blink");
        }
    }
    IEnumerator StartWave()
    {
        arena1Door1.transform.position = new Vector3(arena1Door1.transform.position.x, 2.58f, arena1Door1.transform.position.z);
        arena1Door2.transform.position = new Vector3(arena1Door2.transform.position.x, 2.58f, arena1Door2.transform.position.z);
        arena1Door1.GetComponent<DoorMovingController>().doorGoUp = true;
        arena1Door2.GetComponent<DoorMovingController>().doorGoUp = true;
        lights.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        print("WAVE STARTED");
        waveNumber += 1;
        if(waveNumber == 1)
        {
            Instantiate(enemyPrefab, enemySpawnPos1, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos2, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos1, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos2, enemyRotation.rotation);
        }
        if(waveNumber == 2)
        {
            Instantiate(enemyPrefab, enemySpawnPos1, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos2, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos1, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos2, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos1, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos2, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos1, enemyRotation.rotation);
            yield return new WaitForSeconds(1f);
            Instantiate(enemyPrefab, enemySpawnPos2, enemyRotation.rotation);
        }
        arena1Door1.GetComponent<DoorMovingController>().doorGoDown = true;
        arena1Door2.GetComponent<DoorMovingController>().doorGoDown = true;
    }

    IEnumerator WaveOver()
    {
        yield return new WaitForSeconds(2f);
        if(waveNumber == 1)
        {
            arena1Door1.GetComponent<DoorMovingController>().doorGoUp = true;
            lights.SetActive(false);
        }
        else
        {
            arena1Door2.GetComponent<DoorMovingController>().doorGoUp = true;
            lights.SetActive(false);
        }
    }

    private void Start()
    {
        StartCoroutine("StartGame");
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(3f);
        spawnDoor.GetComponent<DoorMovingController>().doorGoUp = true;
    }
}
