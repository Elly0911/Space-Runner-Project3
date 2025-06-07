using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;
    
    [Header("Choose Display Type")]
    public bool useUI = true; // Toggle this based on your needs
    
    [Header("UI Display (for menus)")]
    public Image artworkImage; // For UI display
    
    [Header("World Display (for in-game)")]
    public SpriteRenderer artworkSprite; // For world display
    
    private int selectedOption = 0;
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("SelectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        
        if (useUI && artworkImage != null)
        {
            artworkImage.sprite = character.characterSprite;
        }
        else if (!useUI && artworkSprite != null)
        {
            artworkSprite.sprite = character.characterSprite;
        }
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("SelectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("SelectedOption", selectedOption);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}