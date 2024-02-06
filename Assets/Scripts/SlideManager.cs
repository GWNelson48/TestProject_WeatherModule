using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlideManager : MonoBehaviour
{
    public List<GameObject> textSlides;
    public List<Image> imageSlides;
    [SerializeField] Button continueButton;

    void Start()
    {
        for (int i = 0; i < textSlides.Count; i++)
        {
            textSlides[i].SetActive(false);            
        }

        for (int i = 0; i < imageSlides.Count; i++)
        {
            imageSlides[i].enabled = false;
        }

        textSlides[0].SetActive(true);
        imageSlides[0].enabled = true;

        ActiveButtonCheck();
    }

    private int activeSlideIndex = 0;

    public void NextSlide()
    {
        if (activeSlideIndex >= (textSlides.Count - 1)) { return; }

        textSlides[activeSlideIndex].SetActive(false);
        imageSlides[activeSlideIndex].enabled = false;

        activeSlideIndex += 1;

        textSlides[activeSlideIndex].SetActive(true);
        imageSlides[activeSlideIndex].enabled = true;

        ActiveButtonCheck();
    }

    public void PreviousSlide()
    {
        if (activeSlideIndex <= 0) { return; }

        textSlides[activeSlideIndex].SetActive(false);
        imageSlides[activeSlideIndex].enabled = false;

        activeSlideIndex -= 1;

        textSlides[activeSlideIndex].SetActive(true);
        imageSlides[activeSlideIndex].enabled = true;

        ActiveButtonCheck();
    }

    public void Continue()
    {
        if (activeSlideIndex != (textSlides.Count - 1)) { return; }

        SceneManager.LoadScene("Scene2");
    }

    void ActiveButtonCheck()
    {
        if (activeSlideIndex != (textSlides.Count - 1))
        {
            continueButton.interactable = false;
        }
        else
        {
            continueButton.interactable = true;
        }
    }
}
