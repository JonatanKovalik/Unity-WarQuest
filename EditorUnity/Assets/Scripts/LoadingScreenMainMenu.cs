using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class LoadingScreenMainMenu : MonoBehaviour
{
    public RawImage BackGroundImage;
    public Text TitleLoading;
    public Text DataNumbers;
    public GameObject LoadingFrame;
    public GameObject MainMenuFrame;

    private List<string> TitleDataText = new List<string>()
    {
        "Loading core systems...",
        "Initializing audio engine...",
        "Preparing user interface...",
        "Connecting to game server...",
        "Syncing player data...",
        "Loading main menu assets...",
        "Finalizing setup..."
    };

    private List<string> DataNumbersText = new List<string>()
    {
        "2/215",
        "1/342",
        "94/327",
        "77/192",
        "59/483",
        "173/256",
        "12/158"
    };


    // This function randomly changes the background image of the loading screen!!!
    private void FunctionChangingBackGroundImage()
    {
        int numberrand = UnityEngine.Random.Range(0, 2);
        if (numberrand == 0)
        {
            BackGroundImage.GetComponent<RawImage>().texture = Resources.Load<Texture>("Textures/LoadingScreenImage1");
        }
        else
        {
            BackGroundImage.GetComponent<RawImage>().texture = Resources.Load<Texture>("Textures/LoadingScreenImage2");
        }
        Debug.LogWarning($"Number Random = {numberrand}");
    }
    void Start()
    {
        LoadingFrame.SetActive(true);
        MainMenuFrame.SetActive(false);
        FunctionChangingBackGroundImage();
        TitleLoading.text = TitleDataText[0];
        DataNumbers.text = DataNumbersText[0];
        StartCoroutine(DataTextChange());
    }

    IEnumerator DataTextChange()
    {
        int index = 0;
        if (index == 0)
        {
            int numberdata = 215;
            int currentdata = 2;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];
            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= 215)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if (index == 1)
        {
            int numberdata = 342;
            int currentdata = 1;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];

            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= numberdata)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if (index == 2)
        {
            int numberdata = 327;
            int currentdata = 94;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];
            FunctionChangingBackGroundImage();
            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= numberdata)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if (index == 3)
        {
            int numberdata = 192;
            int currentdata = 77;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];
            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= numberdata)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if (index == 4)
        {
            int numberdata = 483;
            int currentdata = 59;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];
            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= numberdata)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if (index == 5)
        {
            int numberdata = 256;
            int currentdata = 173;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];
            FunctionChangingBackGroundImage();
            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= numberdata)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if (index == 6)
        {
            int numberdata = 158;
            int currentdata = 12;
            TitleLoading.text = TitleDataText[index];
            DataNumbers.text = DataNumbersText[index];
            while (currentdata <= numberdata)
            {
                currentdata += UnityEngine.Random.Range(12, 17);
                DataNumbers.text = currentdata.ToString() + '/' + numberdata.ToString();
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.3f, 0.52f));
                if (currentdata >= numberdata)
                {
                    index += 1;
                    Debug.LogWarning($"{index} successfully end!");
                    break;
                }
            }
        }
        if(index == 7)
        {
            int alpha = 255;
            int r = 255;
            int g = 255;
            int b = 255;
            TitleLoading.text = "Main menu loaded successfully!";
            DataNumbers.text = "All systems operational.";
            Debug.LogWarning("All loading processes completed successfully!");
            while(alpha != 0)
            {
                BackGroundImage.color = new Color32((byte)r, (byte)g, (byte)b, 255);
                TitleLoading.color = new Color32(255, 255, 255, (byte)alpha);
                DataNumbers.color = new Color32(255, 255, 255, (byte)alpha);
                alpha -= 5;
                r -= 5;
                g -= 5;
                b -= 5;
                if(alpha <= 0)
                {
                    Debug.Log("Alpha is 0, break the loop!");
                    BackGroundImage.color = new Color32(0, 0, 0, 255);
                    TitleLoading.color = new Color32(255, 255, 255, 0);
                    DataNumbers.color = new Color32(255, 255, 255, 0);
                    break;
                }
                yield return new WaitForSeconds(0.05f);
            }
            BackGroundImage.GetComponent<RawImage>().texture = Resources.Load<Texture>("Textures/MainMenuImage");
            r = 0; 
            g = 0;
            b = 0;
            BackGroundImage.rectTransform.offsetMin = new Vector2(0, -91);
            BackGroundImage.rectTransform.offsetMax = new Vector2(0, 11);
            while (r != 255) // this enugh to make the background color white
            {
                r += 5;
                g += 5;
                b += 5;
                BackGroundImage.color = new Color32((byte)r, (byte)g, (byte)b, 255);
                if(BackGroundImage.color.r >= 255 && BackGroundImage.color.g >= 255 && BackGroundImage.color.b >= 255)
                {
                    Debug.Log("Background color is white, break the loop!");
                    BackGroundImage.color = new Color32(255, 255, 255, 255);
                    break;
                }
                yield return new WaitForSeconds(0.05f);
            }
        }
        LoadingFrame.SetActive(false);
        MainMenuFrame.SetActive(true);
    }
}
