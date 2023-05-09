using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextStyling : MonoBehaviour
{
    TextMeshProUGUI myTextMesh;

    public Color otherCharacterTextColor;

    // Start is called before the first frame update
    void Start()
    {
        myTextMesh = GetComponent<TextMeshProUGUI>();
    }

    public void SetTextIsDialogue(bool isDialogue)
    {
        myTextMesh.color = Color.white;
        if (isDialogue)
        {
            myTextMesh.fontStyle = FontStyles.Italic;
        }
        else
        {
            myTextMesh.fontStyle = FontStyles.Normal;
        }
    }

    public void SetOtherCharacterColor()
    {
        SetTextIsDialogue(true);
        myTextMesh.color = otherCharacterTextColor;
    }
}
