using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    Text txt;
    string story;
    public void CallText(Text t)
    {
        txt = t;
        story = txt.text;
        txt.text = "";
        StartCoroutine(TypeOut());

    }

    public IEnumerator TypeOut()
    {
        foreach (char c in story)
        {
            txt.text += c;
            if (c.Equals('.') || c.Equals(','))
            {
                yield return new WaitForSeconds(.1f);
            }
            else
            {
                yield return new WaitForSeconds(.05f);
            }
        }
    }
}
